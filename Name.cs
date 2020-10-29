using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace NameCode
{
    class Name
    {
        private static string fileName = "/tmp/Names.txt";
        private static string name = Console.ReadLine();

        public void NameGame()
        {
            Console.WriteLine("Would you like to see if you have a unique name? [y/n]");
            string a = Console.ReadLine();
            if (a == "y")
            {
                Console.WriteLine("Type in your name to see if it is unique!");
                ReadFromFile();
            }
            else
            {
                Console.WriteLine("Exited.");
            }
        }
        private static void WriteToFile(string whatTo)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(whatTo);
            writer.Close();

        }

        private static void ReadFromFile()
        {
            if (!File.Exists(fileName))
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine("JUST CREATED");
                }
            }
            
            string[] lines = File.ReadAllLines(fileName);

            IEnumerable<string> match =
                from l in lines
                where l == name
                select l;

        
                int matches = 0;
                foreach (string m in match)
                {
                    matches++;
                }
                switch(matches)
                {

                    case 0:
                
                        Console.WriteLine("Your name is unique! There are no matches!");
                        break;

                    case 1:
                
                        Console.WriteLine($"Your name is not unique! There is {matches} match.");
                        break;
               
                    default:
                        Console.WriteLine($"Your name is not unique! There are {matches} matches.");
                        break;
                }
            
            Console.WriteLine("Do you want to save your name? [y/n]");
            string b = Console.ReadLine();
            if (b == "y")
            {
                Console.WriteLine($"Writing '{name}'.");
                WriteToFile(name);
            }
            else
            {
                Console.WriteLine("Exited.");
            }
        }
    }
}
