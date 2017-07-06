using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopspractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //when you would use loop
            //why you use loop
            //nested loops
            //infinite loops
            //keywords break and continue

            //for loop 
            //can be used for both counting and iterating through an array(or other collection type)
            //looks like:

            //for(initializer; condition; updater)
            //{
            // do something
            //}

            //ex: for(int i = 0; i<=10; i++)  
            //{ Console.WriteLine(i)}


            //for(int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 50; i <=100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string greeting = "My name is Little Bill.";
            //// the .Split method takes a string and turns it into an arraay of smaller strings (substrings). it defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            //// for loop to print the words
            //for (int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            //create an array called days with the elements Monday, Tuesday, and Wednesday...
            //...using a for loop, print the elements of the days array.
            //start with the string "once upon a time" and create an array called story words...
            //...using the split method. reverse the order of the elements in the array and using for loop, print each word
            //add the product(multiplcation) of 1 through 10 using a for loop and print product to screen

            //string[] days = {"Monday", "Tuesday", "Wednesday"};
            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //string story = "In a galaxy far far away";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);

            //Option of last question
            //int product = 1;
            //for(int i = 1; i <=10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);

        }
    }
}
