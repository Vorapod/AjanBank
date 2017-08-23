using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        public class MyGenericArray<T>
        {
            private T[] array;
            public MyGenericArray(int size)
            {
                array = new T[size + 1];
            }

            public T getItem(int index)
            {
                return array[index];
            }

            public void setItem(int index, T value)
            {
                array[index] = value;
            }
        }

        static void Main(string[] args)
        {
            ////declaring an int array
            //MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            ////setting values
            //for (int c = 0; c < 5; c++)
            //{
            //    intArray.setItem(c, c * 5);
            //}

            ////retrieving the values
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(intArray.getItem(c) + " ");
            //}

            //Console.WriteLine();

            ////declaring a character array
            //MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            ////setting values
            //for (int c = 0; c < 5; c++)
            //{
            //    charArray.setItem(c, (char)(c + 97));
            //}

            ////retrieving the values
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(charArray.getItem(c) + " ");
            //}
            //Console.WriteLine();


            double totalCount = 100;
            double percent = 0;
            int perProgress = 5;
            int startCursor = 0;
            int lastCursor = 0;
            Console.Write("[");
            Console.SetCursorPosition(21, 1);
            Console.Write("]");
            for (int i = 1; i <= totalCount; i++)
            {
                try
                {
                    percent = i / totalCount * 100;
                    startCursor = Convert.ToInt32(percent) / perProgress;

                    if (i == 1 && startCursor >= 1)
                    {
                        for (int u = 1; u <= startCursor; u++)
                        {
                            Console.SetCursorPosition(u, 1);
                            Console.Write("#");
                            lastCursor = u;
                        }
                    }
                    else
                    {
                        var b = startCursor - lastCursor;

                        for (int p = 1; p <= b; p++)
                        {
                            lastCursor++;
                            Console.SetCursorPosition(lastCursor, 1);
                            Console.Write("#");
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Console.SetCursorPosition(1, 2);
                    Console.Write($"Addes :{i} Remain: {totalCount - i} Percen: {percent}");
                }
            }


            Console.ReadKey();
        }
    }
}
