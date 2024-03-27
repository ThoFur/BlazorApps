using BlazorServerApp.Components;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages
{
    public class EenentwintigBase : ComponentBase
    {

        protected string? cursus;
        protected string? info;
        protected CopyrightFooter? cfdynamic;
        protected int currentScore = 0;
        protected List<string> kaarten = new List<string>();
        protected static readonly string[] Soorten = { "H", "D", "C", "S" };
        protected static readonly string[] Beelden = { "7", "8", "9", "10", "J", "Q", "K", "A" };
        protected static readonly byte[] Waarden = { 7, 8, 9, 10, 1, 2, 3, 11 };
        protected string boodschap = "";
        protected string Klas = "";
        protected string GetRandomCard()
        {
            Random random = new Random();
            var soort = Soorten[random.Next(0, 4)];
            var kaart = random.Next(0, 8);
            var beeld = Beelden[kaart];
            var waarde = Waarden[kaart];
            
            currentScore += waarde;
            
            return $"{beeld}{soort}";
        }
        protected void TrekKaart()
        {
            boodschap = "";
            kaarten.Add(GetRandomCard());
            if (currentScore > 21)
            {
                boodschap =  $"The house wins! Your score: {currentScore}";
                Klas = "alert alert-danger";
                kaarten.Clear();
                currentScore = 0;
            }
            if (currentScore == 21)
            {
                boodschap =  $"You win! Your score: {currentScore}";
                Klas = "alert alert-success";
                kaarten.Clear();
                currentScore = 0;
                Console.WriteLine(Klas);
            }
            
        }

        protected void Verander() => footerAttributes["auteur"] = "Niets van, Auteur = Thomas!";

        protected Dictionary<string, object> footerAttributes =
            new Dictionary<string, object>()
            {
            {
                "auteur", "Thomas"
            },
            {
                "jaartal", 2024
            }
            };

        protected void InfoOphalen()
        {
            cursus = cfdynamic?.Cursus;
            info = cfdynamic?.AlleInfo();
        }
    }
}

