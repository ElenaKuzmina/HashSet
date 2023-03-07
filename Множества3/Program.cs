using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Множества3
{
    class Program
    {
        static void Main(string[] args)
        {//определение множества
            HashSet<int> a = new HashSet<int>();
            //создание множества 
            Create_mnozh(30, a);
            Console.WriteLine("Исходное множество:");
            //вывод множества
            Print_mnozh(a);
            
            HashSet<int> Simple = new HashSet<int>();
            HashSet<int> NoSimple = new HashSet<int>();
            Change_mnozh(a, Simple, NoSimple);
            Console.WriteLine("Простые числа");
            Print_mnozh(Simple);
            Console.WriteLine("НЕПростые числа");
            Print_mnozh(NoSimple);
            a.Contains(6);
            Simple.UnionWith(NoSimple);
            a.Remove(6);
            Console.ReadKey();
        }

        private static void Change_mnozh(HashSet<int> a,
            HashSet<int> Simple, HashSet<int> NoSimple)
        {
            foreach (int c in a)
            {
                if (Prostoe(c))
                    Simple.Add(c);
                else
                    NoSimple.Add(c);
            }
        }

        private static void Create_mnozh(int n, 
            HashSet<int> mn_ch)
        {
            Random R = new Random();
            for (int i = 0; i < n; i++)
            { mn_ch.Add(R.Next(1, 1000)); }
        }

        private static void Print_mnozh(HashSet<int> mn_ch)
        {
            foreach (int c in mn_ch)
                Console.Write($"{c}  ");
            Console.WriteLine();
        }

        static bool Prostoe(int k)
        { bool f = true;
            for(int d=2; d<=k/2;d++)
            { if (k % d == 0)
                {
                    f = false;
                    break;
                }
            }
            return f;
        }
    }

}
