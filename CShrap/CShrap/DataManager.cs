using Event.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Event
{
    class DataManager
    {
        public event EventHandler OnBulkInsertCompleted;
        public event EventHandler<InsertGotError> OnBulkInsertGotError;
        public event EventHandler<InsertInProgress> OnBulkInsertInProgress;
        AjanBank _dbContext;
        public DataManager()
        {
            _dbContext = new AjanBank();
        }
        public void BulkInsert(IEnumerable<Person> persons)
        {
            if (persons != null || persons.Count() > 0)
            {
                for (int i = 0; i < persons.Count(); i++)
                {
                    try
                    {
                        _dbContext.People.Add(persons.ToList()[i]);
                        _dbContext.SaveChanges();

                        OnBulkInsertInProgress?.Invoke(this, new InsertInProgress
                        {
                            RecordFinished = i + 1
                        });
                    }
                    catch (Exception e)
                    {
                        OnBulkInsertGotError?.Invoke(e.GetType(), new InsertGotError
                        {
                            ExceptionType = e.GetType(),
                            Person = persons.ToList()[i],
                            RecordFailed = i
                        });
                    }
                }
            }
            OnBulkInsertCompleted?.Invoke(this, new EventArgs());
        }


    }
}
