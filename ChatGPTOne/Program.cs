using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string ask, ans;

            while (true)
            { 

                Console.Write("Pode fazer-me perguntas? ");
                ask = Console.ReadLine();

                if (ask == "EXIT")
                {
                    break;
                }

                switch (ask)
                {
                    case "Qual é o tempo para amanha?":
                        ans = "Nublado com chuviscos.";
                        break;
                    case "Qual é o teu nome?":
                        ans = "ChatGPTOne.";
                        break;
                    case "O que achas de computação?":
                        ans = "Perfeita!";
                        break;
                    case "Gostas de música?":
                        ans = "Sim, especialmente Pop!";
                        break;
                    default:
                        ans = "Desculpe-me, não consigo responder a isso...";
                        break;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
