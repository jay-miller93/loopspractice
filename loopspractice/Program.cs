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

            //foreach loop - used to iterate over a collection (ex. list or array)
            //you can think of a structure of a foreach loop as the statement;
            //for each item in the collection, do something
            //             foreach(dataType variable in arrayName)
            //                 {
            //                     do something
            //                 }

            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "June" };
            //// always start with keyword foreach
            //foreach (string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}
            //foreach loops allow the temporary variable to know to assign itself to each element...
            //... in the collection (like an array), one at a time

            //foreach loop will always go from beginning to end, no matter what
            //it counts the number of elements in the collection, and runs that many times

            //create an array of musicions(bands or solo artists)
            //using a foreach loop, pring each musicians name

            //string[] bands = { "Slipknot", "Justin Bieber", "Avenged Sevenfold", "Brittney Spears"};
            //foreach (string band in bands)
            //{
            //    Console.WriteLine(band);
            //}

            //while loop is used when you want a chunk of code to run only if a condition is met first
            //while something is true, do this thing

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while(firstName.ToUpper() == "JAY")
            //{
            //    Console.WriteLine("Dude, you are amazing!");
            //    break;
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("Its a remach!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            // a do-while loop is similar to a while loop however a do-while loop is used when you want a chunk of code to run at least...
            //....once but repeat only if a while condition is met

            //the structure of a do-while loop looks like:
            //do
            //{
            //do something
            //}
            //while(condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //code for game goes here
            //    Console.WriteLine("Great Game!");
            //    Console.WriteLine("Do you want to play again?");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");

            // ask the user for the class that they would like to add to there gpa calculation
            //ask user for the letter grade for the class (no+ or-)
            //ask the if they have another class they would like to take
            //using a do-while loop repeat the code if user says "YES"

            //string moreGpa;
            //do
            //{
            //    Console.WriteLine("What class would you like to take to add to your GPA?");
            //    Console.ReadLine();
            //    Console.WriteLine("please enter the letter grade for the class you want to add.");
            //    Console.ReadLine();
            //    Console.WriteLine("Is there another class you would like to take? Type YES/NO");
            //    moreGpa = Console.ReadLine();
            //}
            //while (moreGpa == "YES");

            //nested loops
            //a loop inside of another loop
            //the inner loop is executed more times than the outter loop(clock)

            //create nested loop structure that prints:
            //1234
            //1234 

            //for(int rows = 1; rows <=2; rows++)
            //{
            //    for(int columns = 1; columns <=4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //print a triangle
            //outter loop will go line by line
            //inner loop will go over different elements in the line
            //result:
            //1
            //12
            //123
            //1234...

            //Console.WriteLine("How many rows do you want in your triangle?");
            //int n = int.Parse(Console.ReadLine());
            //for(int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}

            //print the hello world to the console 10 times 
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Hello world");
            //}
            ////print 100 numbers to the console 
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //print the elements of the string 


            //foreach (char word in words)
            //{
            //    Console.WriteLine(word);
            //}

            ////vowels problem 
            //Console.WriteLine("please say something");
            //string words2 = Console.ReadLine();
            //int vowelCount = 0;
            //foreach (char letter in words2)
            //{
            //    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        vowelCount += 1;

            //    }


            //}
            //Console.WriteLine(vowelCount);

            ////lucky number slevin
            //Console.WriteLine("Pick a number");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many times do you want this repeated");
            //int repeat = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= repeat; i++)
            //{
            //    Console.WriteLine(number);
            //}

            //Remember that in FizzBuzz, if it is not a FizzBuzz, Fizz, or Buzz number
            //you print the number itself.
            //Console.WriteLine("Let's Play FizzBuzz!");
            //Console.WriteLine("Please enter your FIZZ number");
            //int fizz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your BUZZ number");
            //int buzz = int.Parse(Console.ReadLine());
            //Console.WriteLine("What number would you like me to count to? (Pick a high one)");
            //int endNumber = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= endNumber; i++)
            //{
            //    if (i % fizz == 0 && i % buzz == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz!");
            //    }
            //    else if (i % fizz == 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }
            //    else if (i % buzz == 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //multiplcation table
            //    int multNum = 1;
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        for (int j = 1; j <= 5; j++)
            //        {
            //            Console.Write(multNum * j + " ");
            //}
            //multNum += 1;
            //               Console.WriteLine();
            //    }

            //Create an array of your favorite movies.
            //Print out each movie in the list, unless the move starts with a vowel. Hint: Research.startsWith()

            //string[] favMovies = { "Star Wars", "Anchorman", "Avatar", "Serenity", "Super Troppers" };
            //foreach (string movie in favMovies)
            //{
            //    if (movie.StartsWith("A"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("E"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("I"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("O"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("U"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(movie);
            //    }

            //Write a console application that asks the user for an integer. If that integer is evenly divisible by 3, 
            //then write “You Won!” If it isn’t, write “You Lost.” Keep asking them for a number (looping)until they win.

            //Console.WriteLine("Please enter an integer:");
            //int userNum = int.Parse(Console.ReadLine());

            //while(userNum % 3 != 0)
            //    {
            //    Console.WriteLine("You Lost!");
            //    Console.WriteLine(" Please enter another integer:");
            //    userNum = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("You won!");
            
           











            }
        }
    
}
