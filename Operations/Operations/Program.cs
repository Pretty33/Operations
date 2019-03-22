using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Operations
{
  public  class Program
    {
        static void Main(string[] args)
        {

            Console.Write("请输入出题数量：");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("请输入范围：");
            int scope = Int32.Parse(Console.ReadLine());

            //用于保存题目到数组然后方便导入文本
            string[] titlelist = new string[number];
            //用于保存答案到数组然后方便导入文本
            string[] answerlist = new string[number];

            for(int y = 0; y < number; y++)
            {
                string title = "";
                string answer = "";
                //把题目放到 title 传入参数
                title = Show.ShowTopic(scope);
                titlelist[y] = title;
                //把答案放入 answer 传入参数
                answer = Answer.AnswerText(title);
                answerlist[y] = answer;

                Thread.Sleep(100);
            }
            //把题目导入文本
            Console.WriteLine(ImportingText.Importing(titlelist, answerlist));
            Console.ReadKey();
        }
    }
}
