using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CShrap.Model;
using Newtonsoft.Json;
using CShrap.Enum;

namespace CShrap
{
    class MyTestApp
    {
        private static DataManager _dataManager;
        public static void Main()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 100; i++)
            {
                if (i == 2)
                {
                    Person personFail = new Person
                    {
                        LastName = "Bank",
                        Gender = GenderType.Gay.ToString()
                    };
                    persons.Add(personFail);
                    continue;
                }

                Person person = new Person
                {
                    FirstName = "Ajan",
                    LastName = "Bank",
                    Gender = GenderType.Gay.ToString()
                };


                persons.Add(person);
            }


            _dataManager = new DataManager();
            _dataManager.OnBulkInsertCompleted += _dataManager_OnBulkInsertCompleted;
            _dataManager.OnBulkInsertGotError += _dataManager_OnBulkInsertGotError;
            _dataManager.OnBulkInsertInProgress += _dataManager_OnBulkInsertInProgress;
            _dataManager.BulkInsert(persons);

            Console.ReadKey();
        }

        private static void _dataManager_OnBulkInsertInProgress(int recordFinished, int remainRecord)
        {
            Console.WriteLine($"Record finished: {recordFinished} Remain Record: {remainRecord}");
        }

        private static void _dataManager_OnBulkInsertGotError(Type exceptionType, int recordFailed, Person personFailed)
        {
            Console.WriteLine($"Exception Type: {exceptionType.Name}");
            Console.WriteLine($"There is an error occurred at {recordFailed}(st / nd / rd / th) record, Person: { JsonConvert.SerializeObject(personFailed) }");

        }

        private static void _dataManager_OnBulkInsertCompleted(int totalRecord, long timeFinished)
        {
            Console.Write($"The {totalRecord} records has been inserted completely in {timeFinished} ms");
        }

    }
}
