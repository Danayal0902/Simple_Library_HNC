using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleLibrary
{
    public abstract class Stock
    {
        int libraryNum; //the library num (id) of the member
        string title; //title of the piece of stock
        public Member member; 
        public DateTime returnDate;


        /// <summary>
        /// default constructor member doesn't exist
        /// </summary>
        public Stock()
        {
            member = null;
        }

        /// <summary>
        /// returns the librarynum as the member ID
        /// </summary>
        public int ID
        {
            get
            {
                return libraryNum;
            }
            set
            {
                libraryNum = value;
            }
        }

        /// <summary>
        /// returns the title of the stock
        /// </summary>
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


        /// <summary>
        /// abstract borrow method that can be overriden to fit needs
        /// </summary>
        /// <param name="m">member</param>
        public abstract void borrow(Member m);




        /// <summary>
        /// returning borrowed stock if the member exists and the stock is actually on loan
        /// </summary>
        public void returnStock()
        {

            if (member == null)
            {
                throw new Exception("Not on loan");
            }
            else
            {
                member = null;
            }

        }


        /// <summary>
        /// Details of stock
        /// </summary>
        /// <param name="intid">id</param>
        /// <param name="strtitle">title</param>
        public Stock(int intid, string strtitle)
        {
            libraryNum = intid;
            title = strtitle;
            member = null;



        }
        /// <summary>
        /// base to string that will output the data in particular format
        /// </summary>
        /// <returns>strout</returns>
        public override string ToString()
        {
            string strout;
            strout = ID + "\t " + Title;
            return strout;
            }
        }
    }

        
    


