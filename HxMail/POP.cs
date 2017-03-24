using System;
using System.Net.Sockets;
using System.IO;

public class POP
{
    //dsdsa
    //邮箱服务器
    private string POPServer;
    //用户账户
    private string user;
    //用户密码
    private string pwd;
    //通讯端口
    private int Port = 110;
    //空构造函数
    public POP() { }
    //初始化链接信息
    public POP(string server, string _user, string _pwd, int port)
    {
        POPServer = server;
        user = _user;
        pwd = _pwd;
        Port = port;
    }
    /// <summary>
    /// 获取登录成功的网络流
    /// </summary>
    /// <returns>返回登录成功的网络流</returns>
    public NetworkStream Connect()
    {
        Console.WriteLine(POPServer+"     "+Port);
        TcpClient tcpClient = new TcpClient(POPServer, Port);//创建TCP客户端对象
        Byte[] outbytes;//编码
        string input;//信息
        NetworkStream ns = null;//临时的网络流
        try
        {
            ns = tcpClient.GetStream();//网络流获取客户端对象传来的对象
            StreamReader sr = new StreamReader(ns);//创建一个基于ns读取流
            Console.WriteLine(sr.ReadLine());//输出信息
            input = "user " + user + "\r\n";//指定发送指令 账户
            outbytes = System.Text.Encoding.ASCII.GetBytes(input.ToCharArray());//编码处理
            ns.Write(outbytes, 0, outbytes.Length);//发送
            input = "pass " + pwd + "\r\n";//指定发送指令 密码
            outbytes = System.Text.Encoding.ASCII.GetBytes(input.ToCharArray());//编码处理
            ns.Write(outbytes, 0, outbytes.Length);//发送
            Console.WriteLine(sr.ReadLine());//输出信息
            return ns;//返回连接完成后的对象
        }
        catch (InvalidOperationException ioe)
        {
            Console.WriteLine(ioe.Message);
            return ns;
        }
    }

    /// <summary>
    /// 获取邮件的总数
    /// </summary>
    /// <returns>返回总数量</returns>
    /// 
    public string GetNumberOfNewMessages()
    {
        Byte[] outbytes;//字节流
        string input;//发送指令
        try
        {
            NetworkStream ns = Connect();//获取已经登录成功的网络流
            StreamReader sr = new StreamReader(ns);//读取流
            input = "stat" + "\r\n";//指令：获取邮箱邮件总数目
            outbytes = System.Text.Encoding.ASCII.GetBytes(input.ToCharArray());//编码处理
            ns.Write(outbytes, 0, outbytes.Length);//发送
            string resp = sr.ReadLine();//读取信息
            Console.WriteLine(resp);//输出信息
            string[] tokens = resp.Split(new Char[] { ' ' });//分出邮件数量和大小 1数量 2所有字节
            input = "quit" + "\r\n";//指令：关闭
            outbytes = System.Text.Encoding.ASCII.GetBytes(input.ToCharArray());//编码处理
            ns.Write(outbytes, 0, outbytes.Length);//发送
            Console.WriteLine(sr.ReadLine());//输出信息
            sr.Close();//关闭读取流
            ns.Close();//关闭网络流
            return tokens[1];//返回数量
        }
        catch (InvalidOperationException ioe)
        {
            Console.WriteLine("Could not connect to mail server" + ioe.Message);
            return "Unable";
        }
    }

    public void ddg()
    {
        POP pop = new POP("pop.126.com", "xujinzevip@126.com", "xujinze", 110);
        pop.readMailInfo(2);
    }

    /// <summary>
    /// 读取邮件的日期 发件人 收件人 和标题
    /// </summary>
    /// <param name="index">读取邮件的索引</param>
    /// <returns>返回数组 0日期 1发件人 2收件人 3标题</returns>
    public string[] readMailInfo(int index)
    {
        Byte[] outbytes;//字节流
        string input;//发送指令
        string szip = "";
        string[] arrTemp;//临时信息
        string[] mailInfo = new string[4];//邮箱内容信息  0 日期 1 来自 3 收件人 4 标题
        try
        {
            NetworkStream ns = Connect();//获取已经登录成功的网络流
            StreamReader sr = new StreamReader(ns);//读取流
            input = "retr " + GetNumberOfNewMessages() + "\r\n";//指令：获取邮箱邮件总数目
            outbytes = System.Text.Encoding.GetEncoding("GB2312").GetBytes(input.ToCharArray());//编码处理
            ns.Write(outbytes, 0, outbytes.Length);//发送
            szip = sr.ReadLine();
            if (szip[0] != '-')
            {
                while (szip != ".")
                {
                    arrTemp = szip.Split(":".ToCharArray());
                    if (arrTemp[0] == "Date")
                        mailInfo[0] = arrTemp[1];//获取日期
                    if (arrTemp[0] == "From")
                        mailInfo[1] = arrTemp[1].Substring(arrTemp[1].IndexOf('<'));//获取邮箱格式<邮箱地址>
                    if (arrTemp[0] == "To")
                        mailInfo[2] = arrTemp[1];//获取收件人
                    if (arrTemp[0] == "Subject")
                        mailInfo[3] = arrTemp[1];//获取标题
                    szip = sr.ReadLine();
                }
            }
            foreach (var item in mailInfo)
            {
                Console.WriteLine(item);
            }
            input = "quit" + "\r\n";//指令：关闭
            outbytes = System.Text.Encoding.GetEncoding("GB2312").GetBytes(input.ToCharArray());//编码处理
            ns.Write(outbytes, 0, outbytes.Length);//发送
            Console.WriteLine(sr.ReadLine());//输出信息
            sr.Close();//关闭读取流
            ns.Close();//关闭网络流
            return mailInfo;
        }
        catch (InvalidOperationException ioe)
        {
            return new string[] { ioe.Message };//返回错误信息
        }
    }
}


/**
邮箱配置方法及介绍
Hotmail邮箱目前已全面支持pop功能，无需手动开启。
服务器配置方法如下：
类型：POP3
接收邮件服务器：pop3.live.com
接收端口：995    SSL 是
发送邮件服务器：smtp.live.com
发送端口：25    TLS/SSL 是

补充说明：Hotmail的邮箱用户名一定要填写地址全称，否则无法成功绑定。

邮箱配置方法及介绍
Gmail邮箱也需要手动配置pop或者imap功能。
配置方法如下：
登录Gmail邮箱后点击“设置”-“转发和pop
smtp”-“pop下载”下勾选“对从现在起所收到的邮件启用pop”或者“IMAP访问”中勾选“启用IMAP”然后“保存更改”，如下图所示：
POP3配置方法：
类型：POP3
接收邮件服务器：pop.gmail.com
接收端口：995    SSL 是
发送邮件服务器：smtp.gmail.com
发送端口：465或者587    SSL/TSL 是

配置方法：
类型：IMAP4
接收邮件服务器：imap.gmail.com
接收端口：993    SSL 是
发送邮件服务器：smtp.gmail.com
发送端口：465或者587    SSL/TSL 是

补充说明：由于Gmail邮箱服务器本身设置的原因，Gmail邮箱邮件只允许邮件客户端软件pop收取一次，因此POP取过的邮件，pc客户端如outlook将收不到，反之亦然。建议使用IMAP。另外，Gmail邮箱是将已发送邮件和收到的邮件存放在一起的，所以使用客户端软件收Gmail的邮件会将已发送的邮件一同收取下来。

邮箱配置方法及介绍
目前尚邮支持比较好的是雅虎中国邮箱：yahoo.com.cn和yahoo.cn。雅虎中国邮箱需要定制“来信提醒”的服务方可开通pop功能。
方法如下：
登陆雅虎邮箱后点击“pop+来信提醒”-“关联手机”-“定制”-“设置”完毕后即可开通pop，同时有新邮件时雅虎也会给你发送短信提醒，如图所示：

配置方法：
类型：POP3
接收邮件服务器：pop.mail.yahoo.com.cn
接收端口：995    SSL 是
发送邮件服务器：smtp.mail.yahoo.com
发送端口：465    SSL 是

网易(126\163\yeah.net)邮箱配置方法及介绍
网易免费邮箱对pop取信频率有严格的限制，因此相对取信速度比较慢。网易免费邮箱中126和163邮箱06年后注册的以及yeah.net邮箱07年后的注册用户不再支持pop功能，需要定制其“随身邮服务”方可开通，老用户本身就是支持pop功能的，无需定制。

邮箱配置方法：
类型：POP3
接收邮件服务器：pop.126.com
接收端口：110    SSL 否
发送邮件服务器：smtp.126.com
发送端口：25    SSL 否

特别说明：如果您确认您的126邮箱开通了POP功能，但还是不能绑定成功，可以尝试在邮箱用户名处填写126邮箱地址全称，再看是否能绑定成功。通常，126邮箱无论使用@符号前内容或者用邮箱全称来填写“邮箱用户名”都可以成功绑定。您可以多尝试下。


邮箱配置方法：

类型：POP3
接收邮件服务器：pop.163.com
接收端口：110    SSL 否
发送邮件服务器：smtp.163.com
发送端口：25    SSL 否
配置方法：
类型：POP3
接收邮件服务器pop.yeah.net
接收端口：110    SSL 否
发送邮件服务器：smtp. yeah.net
发送端口：25    SSL 否

邮箱配置方法及介绍
QQ邮箱需要通过手动的方式开启pop功能，方法如下：
登陆您的QQ邮箱页面后点击页面上方的“设置”-“账号”-“POP3/SMTP服务”勾选“开启POP3/SMTP服务”后“保存修改”，如图所示
服务器配置方法：
类型：POP3
接收邮件服务器：pop.qq.com
接收端口：110    SSL 否
发送邮件服务器：smtp.qq.com
发送端口：25    SSL 否

邮箱配置方法及介绍
新浪邮箱自08年6月分服务器被攻击后开始对pop取件频率进行了严格限制，同时新注册的用户需要手动才能开通pop功能（老用户不需要）。
手动开通pop的方法：
登录新浪邮箱后点击“邮箱设置”-“帐户”-“pop-smtp设置”勾选“开启”后“保存”，如图所示：
服务器配置方法：
类型：POP3
接收邮件服务器：pop.sina.com
接收端口：110    SSL 否
发送邮件服务器：smtp.sina.com
发送端口：25    SSL 否
*/
