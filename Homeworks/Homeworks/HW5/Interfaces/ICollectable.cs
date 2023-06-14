using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.HW_5.Interfaces
{
    public interface ICollectable<T> where T : IDescribable
    {
        protected List<T> List { get; set; }

        void Add(T item)
        {
            if (!List.Contains(item))
            {
                List.Add(item);
            }
        }
        void Remove(T item)
        {
            if (List.Contains(item))
            {
                List.Remove(item);
            }
        }

        string ListItems()
        {
            var resultString = "";
            List.ForEach(item =>
            {
                resultString += $"\n {((IDescribable)item).DescribeYourself()}";
            });
            return resultString;
        }
    }
}
