using System;

// This is a simple program that is meant to take in content from the user and convert it into the correct data types.  

class Program
    {
        static void Main()
        {
        
        //Prints intro of program in console, uses a \n escape character to display a line break
        Console.WriteLine("The Tech Academy\nStudent Daily Report");

        //Asks and takes studentName as a String var
        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine();

        //Asks and takes courseName as a String var
        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();

        //Asks and takes pageNum as a int16
        Console.WriteLine("What page number?");
        string pageNum = Console.ReadLine();
        Int16 pageNumShort = Convert.ToInt16(pageNum);

        //Asks and takes needsHelp as a boolean
        Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
        string needsHelp = Console.ReadLine();
        bool needsHelpBool = Convert.ToBoolean(needsHelp);

        //Asks and takes posExp as a String
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string posExp = Console.ReadLine();

        //Asks and takes feedback as a String
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        //Asks and takes hoursStudied as a byte
        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        byte hoursStudiedByte = Convert.ToByte(hoursStudied);

        // Farewell Line
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        // Used to keep the Console open.
        Console.Read();


    }
    }

