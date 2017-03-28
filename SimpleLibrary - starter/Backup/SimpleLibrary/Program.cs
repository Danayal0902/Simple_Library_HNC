using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimpleLibrary
{
    static class Program
    {
        /// <summary>
        /// Allocates a new console for current process.
        /// uses  System.Runtime.InteropServices;
        /// 
        /// declaring extern (al) means available anywhere
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();

        /// <summary>
        /// Frees the console.
        /// uses  System.Runtime.InteropServices;
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole();
            /************************
             * uncomment tester code when you have completed the
             * code for that part
             * **********************/
            Console.WriteLine("Simple Library - test Harness 1 run");
            //testHarness1();
            //testHarness2();
            //testHarness3();
            //testHarness4();

            Console.WriteLine("press return to continue");
            Console.ReadLine();
            /***********
             * add this code in when you start the form
             * comment out any test methods called above
             * ************************************/
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLibrary());
            FreeConsole();
        }
        /***
                private static void testHarness1()
                {
                    Member m1, m2, m3, m4;
                    m1 = new Member("Peter", "12 Bowland Street", "Belshill","ML3 abc", 1970, 1);
                    m2 = new Member("Fred", "14 Farthing Street", "Motherwell", "ML1 2DD", 1969, 2);
                    m3 = new Member("Charlie", "100 main street", "Hamilton", "ML2 123", 1972, 3);
                    m4 = new Member();

                    Console.WriteLine("Four members created");
                    Console.WriteLine(m1);
                    Console.WriteLine(m2);
                    Console.WriteLine(m3);
                    Console.WriteLine(m4);
                }
        ****/

        /****
                private static void testHarness2()
                {
                    Library theLibrary = new Library();
                    theLibrary.addMember("Peter", 1955, "100 main street", "Belshill", "ML3 1DD");
                    theLibrary.addMember("Paul", 1956, "12 blantyre road", "Belshill", "ML3 1AB");
                    theLibrary.addMember("Jenny", 1968, "47 grange street", "Motherwell", "ML1 1DD");
                    theLibrary.addMember("Helen", 1975, "61 hamilton street", "Belshill", "ML3 1CC");
                    theLibrary.addMember("Harold", 1959, "1 hastings street", "Motherwell", "ML1 5VV");

                    //now list members 
                    theLibrary.listMembers();
                }
        ******/


        /*****
                private static void testHarness3()
                {
                    Library theLibrary = new Library();
                    theLibrary.populate();

                    theLibrary.listStock();
                    theLibrary.listBooks();
                    theLibrary.listJournals();
                    theLibrary.printStock("testharness3output.txt");
                }
        *****/


        /*****
                private static void testHarness4()
                {
                    Library theLibrary = new Library();
                    theLibrary.populate();
                    theLibrary.borrow(1, 3);
                    theLibrary.borrow(3, 6);
                    theLibrary.borrow(3, 12);
                    try
                    {
                        theLibrary.borrow(25, 25);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    try
                    {
                        theLibrary.borrow(1, 3);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    theLibrary.listStock();

                    Console.WriteLine("now returning stockID 3");
                    theLibrary.returnStock(3);
                    theLibrary.listStock();
                    Console.WriteLine("now returning stockID 3 again");
                    try
                    {
                        theLibrary.returnStock(3);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    theLibrary.printStock("testharness4output.txt");
                }
        ******/

    }
}
