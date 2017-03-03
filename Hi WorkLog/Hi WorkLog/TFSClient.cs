using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_WorkLog
{
    /// <summary>
    /// TFS 客户端帮助类
    /// </summary>
    public class TFSClient
    {
        /// <summary>
        /// 获取用户名
        /// </summary>
        public string UserName { get; private set; }
        /// <summary>
        /// 获取或设置密码
        /// </summary>
        private string PassWord { get; set; }
        /// <summary>
        /// 获取URL路径
        /// </summary>
        public string URL { get; private set; }
        /// <summary>
        /// 获取或设置 项目
        /// </summary>
        public Project Project { get; set; }
        /// <summary>
        /// 获取或设置 客户端
        /// </summary>
        public WorkItemStore Client { get; set; }

        /// <summary>
        /// 创建<see cref="TFSClient"/>的新实例
        /// </summary>
        /// <param name="url">URL路径</param>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        public TFSClient(string url, string userName, string passWord)
        {
            this.URL = url;
            this.UserName = UserName;
            this.PassWord = passWord;
        }

        /// <summary>
        /// 连接项目
        /// </summary>
        /// <param name="projectName">项目名称</param>
        public void Connection(string projectName)
        {
            Uri tfsUri = new Uri(URL);
            TfsTeamProjectCollection server = new TfsTeamProjectCollection(tfsUri);
            server.Credentials = new System.Net.NetworkCredential(UserName, PassWord, URL);
            this.Client = server.GetService<WorkItemStore>();
            this.Project = Client.Projects[projectName];
        }

        /// <summary>
        /// 链接工作项
        /// </summary>
        /// <param name="source">源工作项</param>
        /// <param name="targetID">目标工作项ID</param>
        /// <param name="type">连接类型</param>
        public void LinkWorkItem(WorkItem source, int targetID, string type)
        {
            WorkItemLinkTypeEnd linkTypeEnd = Client.WorkItemLinkTypes.LinkTypeEnds[type];
            source.Links.Add(new RelatedLink(linkTypeEnd, targetID));
        }

        /// <summary>
        /// 创建工作项
        /// </summary>
        /// <param name="type">工作项类型</param>
        /// <returns>工作项</returns>
        public WorkItem CreateWorkItem(string type)
        {
            WorkItemType itemtype = this.Project.WorkItemTypes[type];
            WorkItem workitem = new WorkItem(itemtype);
            return workitem;
        }

        /// <summary>
        /// 查询工作项
        /// </summary>
        /// <param name="querystr">查询工作项</param>
        /// <returns>工作项集合</returns>
        public WorkItemCollection Query(string querystr)
        {
            return this.Client.Query(querystr);
        }
    }
}
