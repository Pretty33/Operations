using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Answer
    {
        /// <summary>
        /// 运算答案
        /// </summary>
        /// <param name="title">题目</param>
        /// <returns></returns>
        public static string AnswerText(string title)
        {
            DataTable dt = new DataTable();
            //把数组里面的运算符变成计算机认识的运算符
            string answer = title.Replace("×", "*").Replace("÷", "/").Replace("=", "");

            //保存答案
            string result = dt.Compute(answer, "").ToString();
            return result;

        }
    }
}
