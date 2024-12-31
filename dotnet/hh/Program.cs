
using System;

class SantaGiftingSystem
{
    static void Main()
    {
        string name;
        
        // Input: Name
        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        // Validate Name: Only alphabetic characters and not empty
        while (string.IsNullOrWhiteSpace(name) || !IsValidName(name))
        {
            Console.WriteLine("Please enter a valid name.");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }

        // New quiz questions and correct answers
        string[] questions = new string[]
        {
            "What is the square root of 16?",
            "Which planet is closest to the sun?",
            "What is the largest ocean on Earth?",
            "Who painted the Mona Lisa?",
            "How many continents are there on Earth?"
        };

        string[] correctAnswers = new string[]
        {
            "4", 
            "mercury", 
            "pacific", 
            "leonardo da vinci", 
            "7"
        };

        int correctCount = 0;

        // Loop through quiz questions
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine().Trim().ToLower();

            // Check if the answer is correct
            if (userAnswer == correctAnswers[i])
            {
                correctCount++;
            }
        }

        // Output the result
        if (correctCount > 0)
        {
            Console.WriteLine($"Hey! Mr./Miss {name}, you got {correctCount} gift(s) from Santa.");
        }
        else
        {
            Console.WriteLine("santa is sleeping. Better luck next time!");
        }
    }

    // Function to validate the name (alphabetic characters only)
    static bool IsValidName(string name)
    {
        foreach (char c in name)
        {
            if (!Char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }
}

