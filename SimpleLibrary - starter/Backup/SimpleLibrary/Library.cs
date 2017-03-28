using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SimpleLibrary
{
    public class Library
    {
        //add attributes called members abd stock

        
        public Library()
        {
            //TO DO

        }

        public void addMember(string stname, int yr, string strStreet, string strTown, string strpc)
        {
            // you need to code
        }

        public void listMembers()
        {
            // you need to code
        }

        public void addBook(string t, string a, int quantity)
        {

           // you need to code
        }

        public void addJournal(string t, int v, int quantity)
        {

           //you need to code
        }

        public void listStock()
        {
            //you need to code

        }

        public void listBooks()
        {
            /***uncomment when ready
            Console.WriteLine("Books in Library");
            foreach (Stock s in stock)
            {
                if (s.GetType() == typeof(Book))
                    Console.WriteLine(s);
            }
             * *****/
        }

        public void listJournals()
        {
           //you need to code
        }

        public Member findMemberByID(int id)
        {
            /**uncomment when ready
            foreach (Member m in members)
            {
                if (m.ID == id)
                    return m;
            }
            throw new Exception("No such member");
             * *******/
            return new Member();//delete thie line!
        }
        public Member findMemberByName(string strname)
        {
            //you need to code
            return new Member();//delete thie line!
        }

        /**** you need to add this one in
        public Stock findStock(int id)
        {
            //you need to code
            
        }
         * ****/
        public void borrow(int memID, int stockid)
        {
            //you need to code

        }
        public void returnStock(int stockID)
        {
            //you need to code
        }

        public void printStock(string filename)
        {
            //you need to code
           
         }

        public void populate()
        {
            addBook("Harry Potter", "Rawlinson", 5);
            addBook("Where Eagles Dare", "Hawkins", 4);
            addJournal("Nature", 2, 2);
            addJournal("New Scientist", 4, 2);

            addMember("Peter", 1955, "100 main street", "Belshill", "ML3 1DD");
            addMember("Paul", 1956, "12 blantyre road", "Belshill", "ML3 1AB");
            addMember("Jenny", 1968, "47 grange street", "Motherwell", "ML1 1DD");
            addMember("Helen", 1975, "61 hamilton street", "Belshill", "ML3 1CC");
            addMember("Harold", 1959, "1 hastings street", "Motherwell", "ML1 5VV");

        }

    }
}
