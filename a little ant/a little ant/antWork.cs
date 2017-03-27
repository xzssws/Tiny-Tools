using Abot.Crawler;
using Abot.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace a_little_ant
{
    /// <summary>
    /// 工蚁
    /// </summary>
    public static class antWork
    {
        //开始抓取
        public static void Starting(object sender, PageCrawlStartingArgs e)
        {
            PageToCrawl pageToCrawl = e.PageToCrawl;
            Outputer.Output(string.Format("关于抓取页面 {0} 上找到的链接 {1}", pageToCrawl.Uri.AbsoluteUri, pageToCrawl.ParentUri.AbsoluteUri));
        }

        //抓取完成
        public static void Completed(object sender, PageCrawlCompletedArgs e)
        {
            CrawledPage crawledPage = e.CrawledPage;
            if (crawledPage.WebException != null || crawledPage.HttpWebResponse.StatusCode != HttpStatusCode.OK)
                Outputer.Output(string.Format("抓取页面失败: {0}", crawledPage.Uri.AbsoluteUri));
            else
            {
                Outputer.Output(string.Format("抓取页面成功 {0}", crawledPage.Uri.AbsoluteUri));
                string Text = HtmlHelper.GetMainContent(e.CrawledPage.Content.Text);
                Outputer.Output(Text);
            }
            if (string.IsNullOrEmpty(crawledPage.Content.Text))
                Outputer.Output(string.Format("抓取页面错误: 页面无内容 {0}", crawledPage.Uri.AbsoluteUri));

        }
        //抓取连接失败
        public static void Disallowed(object sender, PageLinksCrawlDisallowedArgs e)
        {
            CrawledPage crawledPage = e.CrawledPage;
            Outputer.Output(string.Format("没有抓取 {0} 页上的链接 {1} ", crawledPage.Uri.AbsoluteUri, e.DisallowedReason));
        }
        //抓取页面失败
        public static void Disallowed(object sender, PageCrawlDisallowedArgs e)
        {
            PageToCrawl pageToCrawl = e.PageToCrawl;
            Outputer.Output(string.Format("由于产生错误：{1} 无法抓取页面{0}", pageToCrawl.Uri.AbsoluteUri, e.DisallowedReason));
        }
    }
}
