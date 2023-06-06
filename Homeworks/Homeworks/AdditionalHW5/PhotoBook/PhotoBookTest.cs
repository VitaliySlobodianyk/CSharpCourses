using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Additional_HW5.PhotoBook
{
    internal class PhotoBookTest
    {
        public static void Test()
        {
            var defaultPhotoBoook = new PhotoBook();
            Console.WriteLine(defaultPhotoBoook.NumberOfPages);

            var photoBoook = new PhotoBook(24);
            Console.WriteLine(photoBoook.NumberOfPages);

            var bigPhotoBoook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBoook);
        }
    }
}
