using Abot.Crawler;
using Abot.Poco;
using System;

namespace a_little_ant
{
    public class Core
    {
        public void First_Configuration()
        {
            crawlConfig = new CrawlConfiguration();
            //超时时间 秒
            crawlConfig.CrawlTimeoutSeconds = 100;
            //最大线程数
            crawlConfig.MaxConcurrentThreads = 10;
            //查看
            crawlConfig.MaxPagesToCrawl = 1000;
            //插件爬虫
            crawler = new PoliteWebCrawler(crawlConfig, null, null, null, null, null, null, null, null);
        }

        public void Second_Ready()
        {
            crawler.PageCrawlStartingAsync += antWork.Starting;//单个页面爬取开始
            crawler.PageCrawlCompletedAsync += antWork.Completed;//单个页面爬取结束
            crawler.PageCrawlDisallowedAsync += antWork.Disallowed;//页面不允许爬取事件
            crawler.PageLinksCrawlDisallowedAsync += antWork.Disallowed;//页面链接不允许爬取事件
        }

        public void Third_Start()
        {
            CrawlResult result = crawler.Crawl(new Uri("http://www.cnblogs.com/xzssws"));

            if (result.ErrorOccurred)
                Console.WriteLine("抓取完成 {0} 错误: {1}", result.RootUri.AbsoluteUri, result.ErrorException.Message);
            else
                Console.WriteLine("抓取完成 {0} 并没发现错误", result.RootUri.AbsoluteUri);
        }

        /// <summary>
        /// 获取或设置 爬虫配置
        /// </summary>
        public CrawlConfiguration crawlConfig { get; set; }

        /// <summary>
        /// 获取或设置 爬虫
        /// </summary>
        public PoliteWebCrawler crawler { get; set; }
    }
}