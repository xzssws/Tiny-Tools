using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace a_little_ant
{
    class HtmlHelper
    {
        ///<summary>  
        /// 判断两段儿文本里哪个中文占的比例高  
        ///</summary>  
        ///<param name="x"></param>  
        ///<param name="y"></param>  
        ///<returns></returns>  
        public static int CompareDinosByChineseLength(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    Regex r = new Regex("[\u4e00-\u9fa5]");
                    float xCount = (float)(r.Matches(x).Count) / (float)x.Length;
                    float yCount = (float)(r.Matches(y).Count) / (float)y.Length;

                    int retval = xCount.CompareTo(yCount);

                    if (retval != 0)
                    {
                        return retval;
                    }
                    else
                    {
                        return x.CompareTo(y);
                    }
                }
            }
        }

        ///<summary>  
        /// 获取一个网页源码中的标签列表，支持嵌套，一般或去div，td等容器  
        ///</summary>  
        ///<param name="input"></param>  
        ///<param name="tag"></param>  
        ///<returns></returns>  
        public static List<string> GetTags(string input, string tag)
        {
            StringReader strReader = new StringReader(input);
            int lowerThanCharCounter = 0;
            int lowerThanCharPos = 0;
            Stack<int> tagPos = new Stack<int>();
            List<string> taglist = new List<string>();
            int i = 0;
            while (true)
            {
                try
                {
                    int intCharacter = strReader.Read();
                    if (intCharacter == -1) break;

                    char convertedCharacter = Convert.ToChar(intCharacter);

                    if (lowerThanCharCounter > 0)
                    {
                        if (convertedCharacter == '>')
                        {
                            lowerThanCharCounter--;

                            string biaoqian = input.Substring(lowerThanCharPos, i - lowerThanCharPos + 1);
                            if (biaoqian.StartsWith(string.Format("<{0}", tag)))
                            {
                                tagPos.Push(lowerThanCharPos);
                            }
                            if (biaoqian.StartsWith(string.Format("</{0}", tag)))
                            {
                                if (tagPos.Count < 1)
                                    continue;
                                int tempTagPos = tagPos.Pop();
                                string strdiv = input.Substring(tempTagPos, i - tempTagPos + 1);
                                taglist.Add(strdiv);
                            }
                        }
                    }

                    if (convertedCharacter == '<')
                    {
                        lowerThanCharCounter++;
                        lowerThanCharPos = i;
                    }
                }
                finally
                {
                    i++;
                }
            }
            return taglist;
        }

        ///<summary>  
        /// 从一段网页源码中获取正文  
        ///</summary>  
        ///<param name="input"></param>  
        ///<returns></returns>  
        public static string GetMainContent(string input)
        {
            string reg1 = @"<(p|br)[^<]*>";
            string reg2 =
                @"(
([^=]*)(=[^
]*)?\][\s\S]*?
/\1
)|(?<lj>(?=[^\u4E00-\u9FA5\uFE30-\uFFA0,."");])<a\s+[^>]*>[^<]{2,}</a>(?=[^\u4E00-\u9FA5\uFE30-\uFFA0,."");]))|(?<Style><style[\s\S]+?/style>)|(?<select><select[\s\S]+?/select>)|(?<Script><script[\s\S]*?/script>)|(?<Explein><\!\-\-[\s\S]*?\-\->)|(?<li><li(\s+[^>]+)?>[\s\S]*?/li>)|(?<Html></?\s*[^> ]+(\s*[^=>]+?=['""]?[^""']+?['""]?)*?[^\[<]*>)|(?<Other>&[a-zA-Z]+;)|(?<Other2>\#[a-z0-9]{6})|(?<Space>\s+)|(\&\#\d+\;)";

            //1、获取网页的所有div标签  
            List<string> list = GetTags(input, "div");

            //2、去除汉字少于200字的div  
            List<string> needToRemove = new List<string>();
            foreach (string s in list)
            {
                Regex r = new Regex("[\u4e00-\u9fa5]");
                if (r.Matches(s).Count < 300)
                {
                    needToRemove.Add(s);
                }
            }
            foreach (string s in needToRemove)
            {
                list.Remove(s);
            }

            //3、把剩下的div按汉字比例多少倒序排列,  
            list.Sort(CompareDinosByChineseLength);
            if (list.Count < 1)
            {
                return "";
            }
            input = list[list.Count - 1];

            //4、把p和br替换成特殊的占位符[p][br]  
            input = new Regex(reg1, RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "[$1]");

            //5、去掉HTML标签，保留汉字  
            input = new Regex(reg2, RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "");

            //6、把特殊占维护替换成回车和换行  
            input = new Regex("\\[p]", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "\r\n ");
            input = new Regex("\\[br]", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "\r\n");
            return input;
        }
    }
}

