using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
  public  class Program
    {
        static void Main(string[] args)
        {
            //定义一个随机数
            Random random = new Random();

            //运算符
            string[] sy = { "+", "-", "÷", "×" };
            string symbol = string.Empty;

            int left = 0;
            int right = 0;
            int i = 0;

            Console.Write("请输入题数：");
            int ti = Int32.Parse(Console.ReadLine());
            Console.Write("请输入范围：");
            int fan = Int32.Parse(Console.ReadLine());


            StreamWriter sw = new StreamWriter(@"E:\Exercise.txt");
            StreamWriter sw1 = new StreamWriter(@"E:\Answer.txt");
            for (int z = 0; z < ti; z++)
            {

                left = random.Next(1, fan);
                right = random.Next(1, fan);
             

                symbol = sy[random.Next(0, 4)];

                ////定义一个答案
                int da = 0;

                switch (symbol)
                {
                    case "-": da = left - right; break;
                    case "+": da = left + right; break;
                    case "÷": da = left / right; break;
                    case "×": da = left * right; break;
                }
                //Console.WriteLine("{0}{3}{2}{1}", left, right, i, symbol);

                Console.SetOut(sw);
                Console.WriteLine("{0}{2}{1}={3}", left, right, symbol, da);
                Console.SetOut(sw1);
               
                Console.WriteLine(da);


            }

            sw.Flush();
            sw.Close();
            sw1.Flush();
            sw1.Close();
            Console.ReadKey();
        }
    }
}
