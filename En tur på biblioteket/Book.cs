using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_tur_på_biblioteket
{
    class Book
    {
        #region variables
        private string title;
        private string author;
        private int pages;
        #endregion
        #region properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }
        #endregion
    }
}
