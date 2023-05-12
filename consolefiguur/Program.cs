using System;
using System.Text;

namespace ConsoleFiguur
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;

            // Maak een StringBuilder object aan om de output op te bouwen
            StringBuilder sb = new StringBuilder();

            // Loop over alle rijen van het figuur
            for (int i = 0; i <= n; i++)
            {
                // Voeg de even getallen toe aan de rij
                for (int j = 0; j <= n; j += 2)
                {
                    if (j <= n - i)
                    {
                        sb.Append($"even({j}) ");
                    }
                }

                // Voeg de oneven getallen toe aan de rij
                for (int j = 1; j <= n; j += 2)
                {
                    if (j <= i)
                    {
                        sb.Append($"odd({j}) ");
                    }
                }

                // Voeg een regelovergang toe aan de rij
                sb.Append("\r\n");
            }

            // Schrijf de volledige output naar de console
            Console.WriteLine(sb.ToString());

            // Wacht op gebruikersinput voordat de console wordt afgesloten
            Console.ReadLine();
        }
    }
}
