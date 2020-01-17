using System;

namespace TheDevelopingDeveloper.net
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //create a string array
            //add some names to the array
            string[] names = new string[4] { "Chad", "Wolfie", "Barnyard", "Bertie" };
            //use a for loop to iterate through the array
            for (int i = 0; i < names.Length; i++)
            {
                //write out the console hello + each name
                Console.WriteLine("Hello {0}", names[i]);
            }
        }
    }
}
