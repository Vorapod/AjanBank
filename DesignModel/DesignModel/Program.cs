using DesignModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    class Program
    {
        static List<TreeViewModel> _result = new List<TreeViewModel>();
        static List<TableDataModel> _dataSource;
        static void Main(string[] args)
        {

            _dataSource = new List<TableDataModel>
            {
                new TableDataModel
                {
                    Id = 1,
                    Name = "A"
                },
                new TableDataModel
                {
                    Id = 2,
                    Name = "B"
                },
                new TableDataModel
                {
                    Id = 3,
                    Name = "C",
                    ParentId = 1
                },
                new TableDataModel
                {
                    Id = 4,
                    Name = "D",
                    ParentId = 1
                },
                new TableDataModel
                {
                    Id = 5,
                    Name = "E",
                    ParentId = 2
                },
                new TableDataModel
                {
                    Id = 6,
                    Name = "F",
                    ParentId = 2
                },
                new TableDataModel
                {
                    Id = 7,
                    Name = "G",
                    ParentId = 3
                },
                new TableDataModel
                {
                    Id = 8,
                    Name = "H",
                    ParentId = 3
                },
                new TableDataModel
                {
                    Id = 9,
                    Name = "I",
                    ParentId = 7
                },
                new TableDataModel
                {
                    Id = 10,
                    Name = "J",
                    ParentId = 6
                }
            };
            if (!_dataSource.Where(t => t.ParentId == 0).Any())
            {
                throw new Exception("Eror becase it doesn't have parnt data");
            }
            else
            {
                foreach (var item in _dataSource)
                {
                    TreeViewModel treeView = new TreeViewModel();

                    if (item.ParentId == 0)
                    {
                        treeView.Id = item.Id;
                        treeView.Name = item.Name;

                        foreach (TreeViewModel itemChild in GetChildren(item.Id))
                        {
                            treeView.Children.Add(itemChild);
                        }
                        _result.Add(treeView);
                    }
                    
                }
            }

            Console.ReadKey();
        }

        private static List<TreeViewModel> GetChildren(int parentId)
        {
            List<TreeViewModel> childTreeNodes = new List<TreeViewModel>();

            List<TableDataModel> dataSource = _dataSource.Where(t => t.ParentId == parentId).ToList();

            if (dataSource.Any())
            {
                foreach (TableDataModel item in dataSource)
                {
                    TreeViewModel childNode = new TreeViewModel
                    {
                        Id = item.Id,
                        Name = item.Name
                    };

                    foreach (var itemNode in GetChildren(item.Id))
                    {
                        childNode.Children.Add(itemNode);
                    }
                    childTreeNodes.Add(childNode);
                }
            }

            return childTreeNodes;

        }
    }
}
