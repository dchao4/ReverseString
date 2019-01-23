using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2- Write a program and ask the user to enter their name.
//    Use an array to reverse the name and then store the result in a new string. 
//    Display the reversed name on the console.



namespace Sec6Lec56ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name");

            var inputName = Console.ReadLine();
           
            char[] inputChar= inputName.ToCharArray();
            Array.Reverse(inputChar);
            //var count = inputName.Length;
            string reverseName = new string(inputChar);
            //var j = count;

            //for (var i = 0; i < count; i++)
            //{
            //    Console.WriteLine(inputChar[i]);
          
            //}

            Console.WriteLine(reverseName);

        }
    }
}
