using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework123
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstRecord = new string[7];
            firstRecord[0] = ("1");
            firstRecord[1] = ("This is a bug ticket");
            firstRecord[2] = ("Open");
            firstRecord[3] = ("High");
            firstRecord[4] = ("Drew Kjell");
            firstRecord[5] = ("Jane Doe");
            firstRecord[5] = ("Drew Kjell|John Smith|Bill Jones");


            string[] newRecord = new string[7];
            Console.Write("Ticket ID: ");
            newRecord[0] = Console.ReadLine();
            Console.Write("Summary: ");
            newRecord[1] = Console.ReadLine();
            Console.Write("Status: ");
            newRecord[2] = Console.ReadLine();
            Console.Write("Priority: ");
            newRecord[3] = Console.ReadLine();
            Console.Write("Submitter: ");
            newRecord[4] = Console.ReadLine();
            Console.Write("Assigned: ");
            newRecord[5] = Console.ReadLine();
            Console.Write("watching: ");
            newRecord[6] = Console.ReadLine();
            Console.Write("Save to: ");
            string filePath = Console.ReadLine();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
                try
                {
                    file.WriteLine(newRecord[0] + ", " + newRecord[1] + ", " + newRecord[2] + ", "
                        + newRecord[3] + ", " + newRecord[4] + ", " + newRecord[5] + ", " + newRecord[6]);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("This program made a mistake:");
                }
            StreamReader sr = new StreamReader("tickets.csv");
            string tix = sr.ReadLine();
            while (tix != null)
            {
                Console.WriteLine(tix);
                tix = sr.ReadLine();
                Console.ReadLine();
            }
        }
    }
}

