using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrap.Model
{
    public class InsertInProgress : EventArgs
    {
        public int RecordFinished { get; set; }
    }
}
