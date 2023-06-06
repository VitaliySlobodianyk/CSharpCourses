using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Additional_HW5.PhotoBook
{
    internal class PhotoBook
    {
        public int NumberOfPages { get; private set; }
        private const int _defaultNumberOfPages = 16;

        public PhotoBook() : this(_defaultNumberOfPages)
        {
        }

        public PhotoBook(int numberOfPages)
        {
            if (numberOfPages > 0)
            {
                NumberOfPages = numberOfPages;
            }
            else
            {
                throw new ArgumentException("Photobook should contain at least 1 page");
            }
        }
    }
}
