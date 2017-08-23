using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CShrap.Model;
using System.Threading;
using System.Diagnostics;

namespace CShrap
{
    class DataManager
    {
        public event Action<int, long> OnBulkInsertCompleted;
        public event Action<Type, int, Person> OnBulkInsertGotError;
        public event Action<int, int> OnBulkInsertInProgress;
        AjanBank _dbContext;
        public DataManager()
        {
            _dbContext = new AjanBank();
        }
        public void BulkInsert(IEnumerable<Person> persons)
        {
            Stopwatch watch = Stopwatch.StartNew();
            long elapsedMs = default(long);

            double percent = 0;
            int i = 1;
            int perProgress = 5;
            int countWriteString = 0;
            int lastPositionCursor = 0;
            Console.SetCursorPosition(0, 0);
            Console.Write("[");
            Console.SetCursorPosition(21, 0);
            Console.Write("]");


            foreach (Person item in persons)
            {
                try
                {
                    _dbContext.People.Add(item);
                    _dbContext.SaveChanges();

                    percent = i / Convert.ToDouble(persons.Count()) * 100;
                    countWriteString = Convert.ToInt32(percent) / perProgress;

                    if (countWriteString > 0)
                    {
                        for (int y = 1; y <= countWriteString - lastPositionCursor; y++)
                        {
                            lastPositionCursor++;
                            Console.SetCursorPosition(lastPositionCursor, 0);
                            Console.Write("#");
                        }
                    }
                    Console.SetCursorPosition(22, 0);
                    Console.Write($"{percent}%");
                }
                catch (Exception ex)
                {
                    // -1 cause represent index of persons
                    OnBulkInsertGotError(ex.GetType(), i - 1, item);
                }
                finally
                {
                    OnBulkInsertInProgress(i, persons.Count() - i);
                    i++;
                }

            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            OnBulkInsertCompleted(persons.Count(), elapsedMs);
        }


    }
}
