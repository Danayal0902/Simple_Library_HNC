using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using People;

namespace SimpleLibrary
{
    /// <summary>
    /// Member encapsulates library members
    /// 
    /// extends People.Person class
    /// </summary>
    public class Member : Person
    {
        public int ID; //declare ID variable

        /// <summary>
        /// Adds the details of the members
        /// </summary>
        /// <param name="strn">name</param>
        /// <param name="strst">street</param>
        /// <param name="strtwn">town</param>
        /// <param name="strpc">postal code</param>
        /// <param name="yr">year</param>
        /// <param name="mid">member id</param>
        public Member(string strn, string strst, string strtwn, string strpc, int yr, int mid)
        {            
            setAddress(strst, strtwn, strpc);
            Name = strn;
            Year = yr;
            ID = mid;
            
           

        }

        /// <summary>
        /// base ToString for member details output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strout ="Member: " + ID + base.ToString();
            return strout;

        }
     
        
        /// <summary>
        /// Default method if no parameters are input
        /// </summary>
        public Member() :base()

        {
            setAddress("unkown", "unknown", "unknown");
            Year = 0;
            Name = "no name";
            ID = 0;
            
        }
     
       
    }



}
