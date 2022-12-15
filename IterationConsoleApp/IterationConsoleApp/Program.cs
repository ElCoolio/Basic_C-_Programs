using System;
using System.Collections.Generic;


    class Program
    {
    static void Main(string[] args)
    {
        // Start part 1
            // simple code that makes a string array, then appends the input to the end of each item in the array, and then prints the new content
            Console.WriteLine("Part 1 Code");
            string[] names = { "Stephen", "Michael", "Daniel", "Kevin", "William" };
            Console.WriteLine("Enter what you would like to add to the end of each String");
            string append = Console.ReadLine();

            // loop to append
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = (names[i] + " " + append);
            }

            //loop to print
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        // End Part 1

        // Start part 2
            // make an infinite loop, and then fix said loop.  the loop asks for input, but will necer terminate because there is no clause to make run turn false.
            Console.WriteLine("Part 2 Code");
            bool run = true;

            while (run)
            {
                Console.WriteLine("Isn't this program the best?");
                string answer = Console.ReadLine();

                //add an if statement so when the user inputs "yes" the loop breaks, will accept any type of capitalization.
                if (answer.ToLower() == "yes")
                {
                    run = false;
                }
            }
            Console.WriteLine("Glad you agree!");
        //End Part 2

        // Start part 3
            // loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” and one where it is <=
            Console.WriteLine("Part 3 Code");
            int[] prime = {1, 2, 3, 5, 7, 11};
            //loop with < symbol
            for (int i = 0; i < prime.Length; i++)
            {
                Console.WriteLine(prime[i]);
            }
        
            //loop with <= symbol
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("I've printed this line " + (i+1).ToString() + " time(s)!");
            }

        //End part 3

        // Start part 4
            //creates a list of strings with unique values and lets the user seach the list for that value.  if value is not in list, say so.

            Console.WriteLine("Part 4 Code");

            List<string> listNames = new List<string> { "Stephen", "Michael", "Daniel", "Kevin", "William" };
            Console.WriteLine("Enter in the name you want to search for");
            string answerName = Console.ReadLine();
            bool found = false;
            //The branching statement here will terminate the loop if it iterates through the entire list
            for(int i = 0; i < listNames.Count; i++)
            {
                    if (answerName == listNames[i])
                    {
                            Console.WriteLine("The name " + answerName + " can be found at index " + i.ToString());
                            found = true;
                    }
            }
            if (found == false)
            {
                Console.WriteLine("The name " + answerName + " cannot be found in the list");
            }
        // End part 4


        // Start part 5
            Console.WriteLine("Part 5 Code");
            //creates a list of strings with some duplicate values and lets the user seach the list for that value.  if value is not in list, say so.
            List<string> listNames2 = new List<string> { "Peter","Andrew","James","John","Philip","Bartholomew","Thomas","Matthew","James","Thaddus","Simon","Judas" };
            Console.WriteLine("Enter in the name you want to search for");
            string answerName2 = Console.ReadLine();
            bool found2 = false;
            //The branching statement here will terminate the loop if it iterates through the entire list, which means it will print twice when the value "James" is given
            for (int i = 0; i < listNames2.Count; i++)
                {
                    if (answerName2 == listNames2[i])
                    {
                        Console.WriteLine("The name " + answerName2 + " can be found at index " + i.ToString());
                        found2 = true;
                    }
                }
            if (found2 == false)
            {
                Console.WriteLine("The name " + answerName2 + " cannot be found in the list");
            }
        // End Part 5


        // Start Part 6
            Console.WriteLine("Part 6 Code");
            //creates a list of strings with some duplicate values prints the whole list, duplicate values are printed uniquely.
            List<string> myList = new List<string> { "apple", "banana", "pineapple", "grape", "banana" };   
            List<string> myUniqueList = new List<string>();
            bool isUnique = true;
            
            foreach (string item in myList)
                {
                    //iteration through the loop
                    //first time it doesn't check for uniqueness, because it is assumed
                    if(myUniqueList.Count == 0)
                    {
                        Console.WriteLine(item + " - This item is unique");
                        myUniqueList.Add(item);
                    }
                    //This nested loop is to check if the value is unique by iterating thtough the unique list created.
                    else
                    {
                        for (int i = 0; i < myUniqueList.Count; i++)
                        { 
                            if(item == myUniqueList[i])
                            {
                                Console.WriteLine(item + " - This item is a duplicate");
                                isUnique = false;
                            }       
                        }
                        if(isUnique == true)
                        {
                            Console.WriteLine(item + " - This item is unique");
                            myUniqueList.Add(item);
                        }
                    }
                    // This resest the check that is used later to determine if this is the first time the value has been printed
                    isUnique = true;
                }

        Console.ReadLine();

        




    }
}

