using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Show

    {
        /// <summary>
        /// 显示题目
        /// </summary>
        /// <param name="scope">范围</param>
        /// <returns></returns>
        public static string ShowTopic(int scope)
        {
            string[] operatonal= { "+", "-", "÷", "×" };

            //保存右边的随机数
            string left = string.Empty;
            //保存左边的随机数
            string right = string.Empty;
            //保存符号
            string symbol = string.Empty;

            //定义随机数
            Random random = new Random();

            //保存题目
            string title = string.Empty;

            left = random.Next(0, scope).ToString();
            right = random.Next(0, scope).ToString();
            symbol =operatonal[random.Next(0, 4)].ToString();
            title = left + symbol + right + "=";

            return title;

        }
    }
}
