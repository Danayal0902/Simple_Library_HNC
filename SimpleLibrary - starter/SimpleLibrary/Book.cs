using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleLibrary
{
    class Book : Stock 
    {
        public string author; //Variable that will hold the name of the author

        /// <summary>
        /// Constructor that will call the base and add the author to it
        /// </summary>
        /// <param name="intid">id</param>
        /// <param name="strtitle">title</param>
        /// <param name="strauthor">author</param>
        public Book(int intid, string strtitle, string strauthor)
            : base(intid, strtitle)
        {
             author = strauthor;
        }

        /// <summary>
        /// Overiding the string in stock to fit the needs of the book. 
        /// </summary>
        /// <returns>strout</returns>
        public override string ToString()
        {
            string strout;
            if (member != null)
            {

                strout = "Book " + base.ToString() + " " + "Author:" + author + " " + "Loaned to " + member.Name + " " + "Return due: " + returnDate.ToShortDateString();
                return strout;
            }
            else
            {
                strout = "Book " + base.ToString() + " " + "Author:" + author;
                return strout;
            }
            
        }
        /// <summary>
        /// book is borrowed from the stock if it is available and the member exists
        /// </summary>
        /// <param name="m"> member</param>
        public override void borrow(Member m)
        {
            member = m;

            if (member != null)
            {
                returnDate = DateTime.Now.AddDays(14);
            }
            else
            {
                throw new Exception("Not on loan");
            }
        }
    }

}
