using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CShrap.Model;

namespace CShrap
{
    class DataManager
    {
        public delegate void EventHandler (IEnumerable<Person> persons);

        public event EventHandler myEvent;
        public void BulkInsert(IEnumerable<Person> persons)
        {
            //TODO: OnBulkInsertCompleted
            foreach (Person person in persons)
            {
                try
                {
                    //TODO: OnBulkInsertInProgress
                    Console.Write("insert to database" + person.FirstName);

                }
                catch (Exception e)
                {
                    //TODO: OnBulkInsertGotError
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public void OnBulkInsertCompleted()
        {

        }

        public void OnBulkInsertGotError()
        {

        }

        public void OnBulkInsertInProgress()
        {

        }
    }
}
