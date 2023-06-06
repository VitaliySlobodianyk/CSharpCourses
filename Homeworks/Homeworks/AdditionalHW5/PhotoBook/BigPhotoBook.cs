using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Additional_HW5.PhotoBook
{
    internal class BigPhotoBook : PhotoBook
    {
        private const int _defaultNumberOfPages = 64;
        public BigPhotoBook() : base(_defaultNumberOfPages)
        {

        }
    }
}
