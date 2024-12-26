using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Assignment
{
    public class Photo
    {
        public int numPages;
        public void GetNumberPages()
        {
            Console.WriteLine(numPages);
        }

        public Photo()
        {
            this.numPages = 16;
        }

        public Photo(int nPages)
        {
            this.numPages = nPages;
        }


        public class BigPhotoBook : Photo
        {
            public BigPhotoBook()
            {
                this.numPages = 64;
            }
        }
    }
}