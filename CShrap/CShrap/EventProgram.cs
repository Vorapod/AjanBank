using Event.Enum;
using Event.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Event
{
    class MyTestApp
    {
        private static DataManager _dataManager;
        private static int _totalRecord;
        private static Stopwatch _watch;
        private static double _percent;
        private const  int ROW_FOR_WRITE = 5;
        private static int _countWriteString;
        private static int _lastPositionCursor;

        public static void Main()
        {
            _watch = new Stopwatch();
            Console.SetCursorPosition(0, 0);
            Console.Write("[");
            Console.SetCursorPosition(20, 0);
            Console.Write("]");


            List<Person> persons = new List<Person>();
            for (int i = 0; i < 100; i++)
            {
                //if (i == 2)
                //{
                //    Person personFail = new Person
                //    {
                //        LastName = "Bank",
                //        Gender = GenderType.Gay.ToString()
                //    };
                //    persons.Add(personFail);
                //    continue;
                //}

                Person person = new Person
                {
                    FirstName = "Ajan",
                    LastName = "Bank",
                    Gender = GenderType.Gay.ToString()
                };
                persons.Add(person);
            }
            _totalRecord = + persons.Count;

            _dataManager = new DataManager();
            _dataManager.OnBulkInsertCompleted += _dataManager_OnBulkInsertCompleted;
            _dataManager.OnBulkInsertGotError += _dataManager_OnBulkInsertGotError;
            _dataManager.OnBulkInsertInProgress += _dataManager_OnBulkInsertInProgress;
            _dataManager.BulkInsert(persons);
            _watch = Stopwatch.StartNew();

            Console.ReadKey();
        }

        private static void _dataManager_OnBulkInsertInProgress(object sender, InsertInProgress e)
        {
            _percent = (e.RecordFinished) / Convert.ToDouble(_totalRecord) * 100;
            _countWriteString = Convert.ToInt32(_percent) / ROW_FOR_WRITE;

            if (_countWriteString > 0)
            {
                for (int y = 0; y < _countWriteString - _lastPositionCursor; y++)
                {
                    _lastPositionCursor++;
                    Console.SetCursorPosition(_lastPositionCursor, 0);
                    Console.Write("#");
                }
            }

            Console.SetCursorPosition(22, 0);
            Console.Write($"{_percent.ToString("##")}%");
            Console.WriteLine();
            Console.WriteLine($"Record finished: {e.RecordFinished} Remain Record: {_totalRecord - e.RecordFinished}");
        }

        private static void _dataManager_OnBulkInsertGotError(object sender, InsertGotError e)
        {
            Console.WriteLine($"Exception Type: {e.ExceptionType.Name}");
            Console.WriteLine($"There is an error occurred at {e.RecordFailed}(st / nd / rd / th) record, Person: { JsonConvert.SerializeObject(e.Person) }");
        }

        private static void _dataManager_OnBulkInsertCompleted(object sender, EventArgs e)
        {
            long elapsedMs = _watch.ElapsedMilliseconds;
            Console.WriteLine($"Finished: {elapsedMs}");
        }
    }
}
