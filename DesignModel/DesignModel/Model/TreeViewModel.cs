using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Model
{
    class TreeViewModel
    {
        public TreeViewModel()
        {
            Children = new List<TreeViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<TreeViewModel> Children { get; set; }
    }
}
