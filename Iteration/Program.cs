using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //     if (testScores[i] > 85)
            //     {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //     }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{   
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(71);

            //foreach(int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int> { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}

            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();

            //----------


            //1.
            string[] showArray = new string[4];

            showArray[0] = "Criminal Minds";
            showArray[1] = "The Outsider";
            showArray[2] = "New Girl";
            showArray[3] = "Dexter";
            Console.WriteLine("Add your favorite TV show:");
            string show = Convert.ToString(Console.ReadLine());

            //4. 
            for (int s = 0; s < showArray.Length; s++) 
            //2. infinite loop (int s = 0; s < 50; s--)  ????
            {   
                Console.WriteLine(showArray[s] + "\n" + show);
            }
            Console.ReadLine();



            //6.
            string[] candyArray = new string[4];

            candyArray[0] = "M&ms";
            candyArray[1] = "Snickers";
            candyArray[2] = "Kit Kat";
            candyArray[3] = "Butterfinger";
            Console.WriteLine("Add your favorite candy:");
            string candy = Convert.ToString(Console.ReadLine());


            //5.
            for (int s = 0; s <= candyArray.Length; s++)
            {
                Console.WriteLine(candyArray[s]);
            }
            Console.ReadLine();



            List<string> animalTypes = new List<string>();
            animalTypes.Add("cat");
            animalTypes.Add("dog");
            animalTypes.Add("bird");
            Console.WriteLine("Guess an animal:");
            string guess = Convert.ToString(Console.ReadLine());
            if (guess != "cat")
            {
                Console.WriteLine("Animal not in list.");
            }
            if (guess != "dog")
            {
                Console.WriteLine("Animal not in list.");
            }
            //7.
            if (guess != "bird")
            {
                Console.WriteLine("Animal not in list.");
            }

            //8.?
            Console.WriteLine("index of: " + animalTypes.IndexOf(guess));

            //9.
            List<string> petTypes = new List<string>();
            petTypes.Add("cat");
            petTypes.Add("dog");
            petTypes.Add("dog");
            petTypes.Add("dog");
            
            //10. need help getting the idices of each item and creating the loop
            foreach (string item in petTypes)
            {
                string index = petTypes.IndexOf(item);
            }

            Console.ReadLine();

            //11.
            List<string> colorNames = new List<string>();
            colorNames.Add("yellow");
            colorNames.Add("blue");
            colorNames.Add("green");
            colorNames.Add("blue");

            for (int c = 0; c < showArray.Length; c++) 
            {   
                //Console.WriteLine()unsure how to make the loop display a message 
                //if string already is in the list;
            }
            Console.ReadLine();
        }
    } 
}
