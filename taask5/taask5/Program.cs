using System;
using System.Collections.Generic;

namespace taask5
{
   public class Program
    {
        static void Main(string[] args)
           {
                Dictionary<string, bool> characters = new Dictionary<string, bool>()
                {

                    { "Luke", true },
                    { "Han", false },
                    { "Chewbacca", false }
                };
            characters.Remove("Han");  

            foreach (KeyValuePair<string, bool> a in characters)
            {
                Console.WriteLine("Key = {0}, Value = {1}", a.Key, a.Value);
            }




        }
    }
}

