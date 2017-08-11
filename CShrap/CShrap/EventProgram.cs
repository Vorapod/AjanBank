using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CShrap.Model;
using Newtonsoft.Json;

namespace CShrap
{
    class MyTestApp
    {
        private static DataManager _dataManager;
        public static void Main()
        {
            int a = 0;
            List<Person> persons = new List<Person>()
            {
                new Person
                {
                  Id = 1,
                  FirstName = "Toon",
                  LastName = "Naja",
                  GenderId = 1
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Toon2",
                    LastName = "Naja2",
                    GenderId = 1
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Toon3",
                    LastName = "Naja3",
                    GenderId = 1
                },
                new Person
                {
                    Id = 4,
                    FirstName = "Toon4",
                    LastName = "Naja4",
                    GenderId = 1
                },
                new Person
                {
                    Id = 5,
                    FirstName = "Toon5",
                    LastName = "Naja5",
                    GenderId = 1
                },
            };


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

        private static void _dataManager_OnBulkInsertGotError(Exception exception, int recordFailed, Person personFailed)
        {
            Console.WriteLine($"There is an error occurred at {recordFailed}(st / nd / rd / th) record, Person: { JsonConvert.SerializeObject(personFailed) }");

        }

        private static void _dataManager_OnBulkInsertCompleted(int totalRecord, string timeFinished)
        {
            Console.WriteLine($"The {totalRecord} records has been inserted completely in n {timeFinished}");
        }

    }
}
