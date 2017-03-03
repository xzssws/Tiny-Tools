using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hi_WorkLog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserConfig config = null;

            //配置路径
            string configPath = Environment.CurrentDirectory + "\\user.config";
        //文件存在
        Info:
            if (File.Exists(configPath))
            {
                try
                {
                    config = SerializeHelper.FromBinaryPath<UserConfig>(configPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("您的配置文件已损坏，请重新告诉我你的基础数据。");
                    File.Delete(configPath);
                    goto Info;
                }
            }
            //询问获取信息
            else
            {
                Console.WriteLine("检测到您第一次使用，请告诉我你的一些信息。");
                Console.WriteLine("请您的TFS服务器是:\"http://192.168.1.252:8080/tfs/\"吗?  (Y/N)");
                string info = info = Console.ReadLine();
                string url = "";
                if (info.ToLower() == "y")
                {
                    url = "http://192.168.1.252:8080/tfs/DZ/";
                }
                else if (info.ToLower() == "n")
                {
                    Console.Clear();
                    Console.WriteLine("请手动输入TFS服务器地址：");
                    url = Console.ReadLine();
                }
                else
                {
                    return;
                }
                Console.Clear();
                Console.WriteLine("你的用户名？");
                string username = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("你的密码？");
                string password = Console.ReadLine();
                //连接
                Console.Clear();
                Console.WriteLine("你所在的项目？ 如：GH");
                string projectname = Console.ReadLine();
                //任务ID
                Console.Clear();
                Console.WriteLine("你所在的任务ID？ 如：243");
                int WorkID = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("即将生成配置文件，请勿删除");

                config = new UserConfig();
                config.ParentID = WorkID;
                config.ProjectName = projectname;
                config.Password = password;
                config.UserName = username;
                config.URL = url;
                SerializeHelper.ToBinaryPath(configPath, config);
            }

            Console.WriteLine("正在连接TFS服务器，请稍后....");
            TFSClient tfs = new TFSClient(config.URL, config.UserName, config.Password);
            tfs.Connection(config.ProjectName);
            Console.Clear();
            Console.WriteLine("TFS服务器连接成功，欢迎你...");
            //连接项目
            Console.WriteLine("你要提交哪天的工作日志？\n输入提示：0 今天 -1昨天 -2前天... +1 明天 +2 后天...  或者输入特定日周期 2017-2-9");
            string dateExpression = Console.ReadLine();
            DateTime dt = DateTime.Today;
            char flag = dateExpression.FirstOrDefault();
            switch (flag)
            {
                case '0':
                    dt = DateTime.Today;
                    break;
                case '+':
                    string dp = dateExpression.Substring(1);
                    dt = DateTime.Today.AddDays(int.Parse(dp));
                    break;
                case '-':
                    string ddp = dateExpression.Substring(1);
                    dt = DateTime.Today.AddDays(0 - int.Parse(ddp));
                    break;
                default:
                    dt = DateTime.Parse(dateExpression);
                    //正常日期
                    break;
            }
            Console.Clear();
            Console.WriteLine("您正在录入" + dt.ToString("yyyy年MM月dd日") + "的日志...");

            WorkItemCollection ddd = tfs.Query(@" Select  [ID],[标题]
                From WorkItems
                Where [工作项类型] = 'Bug'  and [解决者] = '" + tfs.Client.UserDisplayName + "' and 状态 in('已提交','已关闭')  and [解决日期] = '" + dt.ToString("yyyy/MM/dd") + "' order by [ID] ");
            Console.WriteLine("系统检测到您今天完成了 " + ddd.Count + "个Bug");
            foreach (WorkItem item in ddd)
            {
                Console.WriteLine(item.Id + ":" + item.Title);
            }
            //手动输入
            Write: Console.WriteLine("请输入日志内容。 输入提示：工作内容;工作时间;加班工时");
            string Expression = Console.ReadLine().TrimEnd(';');
            
            //获取数量
            var p = Expression.Split(';');
            string title = "";
            int gtime = 0, jtime = 0;
            if (p.Length > 1)
            {
                title = p[0];
                gtime = int.Parse(p[1]);
                jtime = 0;
            }
            else if (p.Length > 1)
            {
                title = p[0];
                gtime = int.Parse(p[1]);
                jtime = int.Parse(p[2]);
            }
            Regex ConnoteA = new Regex("&.*,");
            bool result = ConnoteA.IsMatch(Expression);
            List<string> LinkID = new List<string>();
            foreach (Match mch in ConnoteA.Matches(Expression))
            {
                string x = mch.Value.Trim().TrimEnd(',');
                var bugs = x.Split(',');
                foreach (var item in bugs)
                {
                    //删去&
                    LinkID.Add(item.TrimStart('&'));
                }
            }
            
            WorkItem workitem = tfs.CreateWorkItem("工作日志");
            workitem.Fields["指派给"].Value = tfs.Client.UserDisplayName;
            workitem.Fields["标题"].Value = title;
            workitem.Fields["总工时"].Value = gtime;
            workitem.Fields["工作日期"].Value = dt;
            workitem.Fields["加班工时"].Value = jtime;
            tfs.LinkWorkItem(workitem, config.ParentID, "父级");
            //添加相关工作项
            foreach (var item in LinkID)
            {
                tfs.LinkWorkItem(workitem, int.Parse(item), "相关");
            }
            //检查
            if (workitem.IsValid())
            {
                workitem.Save();
                Console.WriteLine("提交成功，是否继续（Y/N）");
            }
            Console.WriteLine("提交成功，是否继续（Y/N）");
            string Text = Console.ReadLine();
            if (Text.ToLower() == "y")
            {
                goto Write;
            }

            //记录日期
            //我检测到你完成了2个Bug没有记录需要记录吗？
            //TODO 检测今天完成的Bug 并提示是否输入
            //我检测到你完成了3个Bug 要记录吗？
            //y
            //BUG：233  标题：东疯狂三份狂森江苏了反动房东发动机房东开 
            //您用了多久解决完这个Bug(工时;加班工时)？
            //3;3
            //我将创建一个工作日志 内容为 解决Bug233 东疯狂三份狂森江苏了...可以吗？
            //y
            //提交成功,是否录入下一个Bug？(y/n)；
            //BUG：243  标题：东疯狂三份狂森江苏了反动房东发动机房东开 
            //您用了多久解决完这个Bug(工时;加班工时)？
            //3;3
            //我将创建一个工作日志 内容为 解决Bug233 东疯狂三份狂森江苏了...可以吗？
            //y
        }
    }
}
