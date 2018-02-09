using Delegate.Model;
using System;
using System.Collections.Generic;

namespace Delegate
{
    public delegate TOutput ConverterByMySelf<TInput, TOutput>(TInput from);

    class Program
    {
        public delegate int Comparision<T>(T lhs, T rhs);

        static void Main(string[] args)
        {
            List<FuckMe> fuckMeList = new List<FuckMe>();
            fuckMeList.Add(new FuckMe { Name = "A", Age = 1, Salary = 333 });
            fuckMeList.Add(new FuckMe { Name = "B", Age = 2, Salary = 222 });
            fuckMeList.Add(new FuckMe { Name = "C", Age = 3, Salary = 111 });


            foreach (FuckMe f in fuckMeList)
            {
                Console.WriteLine(f.Name);
                Console.WriteLine(f.Age);
                Console.WriteLine(f.Salary);
            }

            Console.WriteLine("=====================================");

            List<FuckYou> fuckYouList =
                new ConverterByMySelf<List<FuckMe>, List<FuckYou>>(mes => FuckMeListToFuckYouList(mes))(fuckMeList);

            ConverterByMySelf<List<FuckMe>, List<FuckYou>> processConvert = FuckMeListToFuckYouList;
            List<FuckYou> result = processConvert(fuckMeList);

            foreach (FuckYou f in fuckYouList)
            {
                Console.WriteLine(f.Name);
                Console.WriteLine(f.Age);
                Console.WriteLine(f.Salary);
            }

            Console.WriteLine("==============  Not Use delegate =======================");
            Console.ReadLine();
        }

        public static List<FuckYou> FuckMeListToFuckYouList(List<FuckMe> fuckMe)
        {
            var result = new List<FuckYou>();
            int index = default(int);

            foreach (var item in fuckMe)
            {
                result.Add(new FuckYou
                {
                    Name = fuckMe[index].Name,
                    Age = fuckMe[index].Age,
                    Salary = fuckMe[index].Salary
                });
                index++;
            }

            return result;
        }

        public static string Test(int input)
        {
            return input + "Test";
        }

    }
}
