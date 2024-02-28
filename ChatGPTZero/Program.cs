using System;

namespace ChatGPTZero
{
    class Program
    {
        static void Main(string[] args)
        {
             string question, response;

            Console.Write("Place your question? ");
            question = Console.ReadLine();

            switch (question)

            {
                case "Are you more intelligent than me?":
                    response = "Obviously!";
                    break;

            }

             Console.WriteLine(response);
        }
    }
}
