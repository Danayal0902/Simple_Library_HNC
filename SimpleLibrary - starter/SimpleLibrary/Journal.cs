using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleLibrary
{
    class Journal : Stock
    {
        int volume; //variable to hold the volume of the journal


        /// <summary>
        /// calls base constructor and adds the required volume 
        /// </summary>
        /// <param name="intid">id</param>
        /// <param name="strtitle">title</param>
        /// <param name="vol">volume</param>
        public Journal(int intid, string strtitle, int vol)
            : base(intid, strtitle)
        {
            volume = vol;
        }

        /// <summary>
        ///Calls the ToString method from the stock class and add the changes to fit the Jornal stock. 
        /// </summary>
        /// <returns>strout</returns>
        public override string ToString()
        {
            string strout;
            if (member != null)
            {

                strout = "Journal " + base.ToString() + " " + "volume" + volume + " " + "Loaned to " + member.Name + " " + "Return due: " + returnDate.ToShortDateString();
                return strout;
            }
            else
            {
                strout = "Journal " + base.ToString() + " " + "volume" + volume;
                return strout;
            }
            
          
        }

        /// <summary>
        /// Journal is borrowed from stock if member exists. 
        /// </summary>
        /// <param name="m"></param>
        public override void borrow(Member m)
        {
            member = m;

            if (member != null)
            {
                returnDate = DateTime.Now.AddDays(2);
            }
            else
            {
                throw new Exception("Not on loan");
            }
            
        }
    }
}
