using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入一隻Pokemon:");
            Console.Write("請輸入名字:");
            string name = Console.ReadLine();
            Console.Write("請輸入國碼:");
            string nationalno = Console.ReadLine();

            float height = 0;
            float weight = 0;
            Console.Write("請輸入身高:");
            try
            {
                height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("身高輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入 Weight:");
            try
            {
                weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("體重輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入Gender:");
            string gender = Console.ReadLine();
            Console.Write("請輸入Abilities:");
            string abilities = Console.ReadLine();
            Console.Write("請輸入Category:");
            string category = Console.ReadLine();
            Console.WriteLine("{0} 的基本資料, 身高:{1},體重: {2}, 性別:{3} ,國碼:{4},能力:{5},屬性{6}", name, height, weight, gender, nationalno, abilities, category);
        }
    }
}