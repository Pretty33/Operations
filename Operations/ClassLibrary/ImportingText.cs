using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public  class ImportingText
    {

        /// <summary>
        /// 导入文本
        /// </summary>
        /// <param name="title">题目</param>
        /// <param name="answer">答案</param>
        /// <returns></returns>
        public static string Importing(string[] title,string[] answer)
        {
            StreamWriter sw = new StreamWriter(@"E:\Operations\Exercise.txt", false, System.Text.Encoding.Default);
            foreach(var item in title)
            {
                sw.WriteLine(item);
            }
            sw.Close();

            StreamWriter sw1 = new StreamWriter(@"E:\Operations\Answer.txt", false, System.Text.Encoding.Default);
            foreach(var item in answer)
            {
                sw1.WriteLine(item);
            }
            sw1.Close();

            return "答案以及题目导入文本完成,在E盘";
        }
    }
}
