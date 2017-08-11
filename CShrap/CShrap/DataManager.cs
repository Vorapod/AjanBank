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
        public event Action<int, string> OnBulkInsertCompleted;
        public event Action<Exception, int, Person> OnBulkInsertGotError;
        public event Action<int, int> OnBulkInsertInProgress;

        public void BulkInsert(IEnumerable<Person> persons)
        {
                for (int i = 0; i < persons.Count(); i++)
                {
                    try
                    {
                        //TODO:Insert To Database
                        OnBulkInsertInProgress(i + 1, persons.Count() - (i + 1));
                    }
                    catch (Exception ex)
                    {
                        OnBulkInsertGotError(ex, i, persons.ToList()[i]);
                        throw;
                    }
                }
            OnBulkInsertCompleted(persons.Count(), "1 minute");
        }


    }
}
