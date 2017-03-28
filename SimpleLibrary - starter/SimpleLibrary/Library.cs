using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace SimpleLibrary
{
    public class Library 
    {
        List<Member> members;
        List<Stock> stock;


        public List<Member> Members
        {
            get
            {
                return members;
            }

        }

        public List<Stock> StockItems
        {
            get
            {
                return stock;
            }
        }


        public Library()
        {
            members = new List<Member>(); //instantiate lists
            stock = new List<Stock>();

        }



        /// <summary>
        /// Adds a member to the list using the input parameters 
        /// </summary>
        /// <param name="stname">name</param>
        /// <param name="yr"> year</param>
        /// <param name="strStreet">street</param>
        /// <param name="strTown">town</param>
        /// <param name="strpc">postcode</param>
        public void addMember(string stname, int yr, string strStreet, string strTown, string strpc)
        {
                       
                int ID = members.Count + 1;
                Member m = new Member(stname, strStreet, strTown, strpc, yr, ID);
                members.Add(m);
            }
    



        
        /// <summary>
        /// Displays all the members
        /// </summary>
        public void listMembers()
        {


            foreach (Member m in members)//for every object in the members list
            {
                m.ToString(); //call the toString method to format the objects
                Console.WriteLine(m); //display the objects in the console window               
            }


        }

        /// <summary>
        /// Adds a book type to the stock
        /// </summary>
        /// <param name="t">title</param>
        /// <param name="a">author</param>
        /// <param name="quantity">number of copies</param>
        public void addBook(string t, string a, int quantity)
        {
            if (quantity < 5 && quantity > 10)
            {
                throw new Exception("Quantity must be between 5 and 10.");
            }
            else
            {

                for (int i = 0; i < quantity; i++)
                {
                    int sid = stock.Count + 1;
                    Book b = new Book(sid, t, a);
                    stock.Add(b);
                }





            }
        }


        /// <summary>
        /// add journal type to stock
        /// </summary>
        /// <param name="t">title</param>
        /// <param name="v">volume</param>
        /// <param name="quantity">number of copies</param>
        public void addJournal(string t, int v, int quantity)
        {
            if (v < 0 && quantity < 1 && quantity > 3)
            {
                throw new Exception("Volume must be more than 0. Quantity must be between 1 and 3");
            }
            else
            {
                for (int i = 0; i < quantity; i++)
                {
                    int sid = stock.Count + 1;
                    Journal j = new Journal(sid, t, v);
                    stock.Add(j);
                }

            }

        }

        /// <summary>
        /// list all of the stock
        /// </summary>
        public void listStock()
        {
            foreach (Stock s in stock)
            {
                s.ToString(); //Display the member from the list
                Console.WriteLine(s);
            }

        }
        /// <summary>
        /// list all the books 
        /// </summary>
        public void listBooks()
        {

            Console.WriteLine("Books in Library");
            foreach (Stock s in stock)
            {
                if (s.GetType() == typeof(Book))
                    Console.WriteLine(s);
            }

        }

        /// <summary>
        /// lists all the journals
        /// </summary>
        public void listJournals()
        {
            Console.WriteLine("Journals in Library");
            foreach (Stock s in stock)
            {
                if (s.GetType() == typeof(Journal))
                    Console.WriteLine(s);
            }

        }

        /// <summary>
        /// find the member in the list by using the ID
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>the member</returns>
        public Member findMemberByID(int id)
        {

            foreach (Member m in members)
            {
                if (m.ID == id)
                    return m;
            }
            throw new Exception("No such member");


        }

        /// <summary>
        /// find the member by name 
        /// </summary>
        /// <param name="strname">name of the member</param>
        /// <returns>the member</returns>
        public Member findMemberByName(string strname)
        {
            foreach (Member m in members)
            {
                if (m.Name == strname)
                    return m;
            }
            throw new Exception("No such member");
        }

        /// <summary>
        /// finds the stock relating to the member id
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>stock</returns>
        public Stock findStock(int id)
        {
            foreach (Stock s in stock)
            {
                if (s.ID == id)
                    return s;
            }
            throw new Exception("No such stock");
           

        }

        /// <summary>
        /// finds the stock out on loan by a member
        /// </summary>
        /// <param name="memID"> member id </param>
        /// <param name="stockid">stock id</param>
        public void borrow(int memID, int stockid)
        {
            
            findStock(stockid).borrow(findMemberByID(memID));

        }

        /// <summary>
        /// returns the stock that is out on loan by a member 
        /// </summary>
        /// <param name="stockID"></param>
        public void returnStock(int stockID)
        {
            Stock s = findStock(stockID);
            s.returnStock();


           

        }

        /// <summary>
        /// Displays the stock in a .txt file 
        /// </summary>
        /// <param name="filename"></param>
        public void printStock(string filename)
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine("Stock List");
                sw.WriteLine("-----------");
                sw.WriteLine(DateTime.Now);
                {

                                    
                    foreach (Stock s in stock)
                    {
                        s.ToString(); //Display the member from the list
                        sw.WriteLine(s);
                        
                    }
                }
            }
        }




        /// <summary>
        /// Populating list for testing purposes 
        /// </summary>
        public void populate()
        {
            addBook("Harry Potter", "Rawlinson", 5);
            addBook("Where Eagles Dare", "Hawkins", 4);
            addJournal("Nature", 2, 2);
            addJournal("New Scientist", 4, 2);

            addMember("Peter", 1955, "100 main street", "Belshill", "ML 1DD");
            addMember("Paul", 1956, "12 blantyre road", "Belshill", "ML3 1AB");
            addMember("Jenny", 1968, "47 grange street", "Motherwell", "ML1 1DD");
            addMember("Helen", 1975, "61 hamilton street", "Belshill", "ML3 1CC");
            addMember("Harold", 1959, "1 hastings street", "Motherwell", "ML1 5VV");

        }
    }
}








