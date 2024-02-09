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
            kaarten.Add(GetRandomCard());
        }

        protected void Verander() => footerAttributes["auteur"] = "Juulke";

        protected Dictionary<string, object> footerAttributes =
            new Dictionary<string, object>()
            {
            {
                "auteur", "Thomas"
            },
            {
                "cursus", "Blazor"
            },
            {
                "jaartal", 2024
            },
            {
                "doelgroep", ".NET ontwikkeling met C#"
            },
            };

        protected void InfoOphalen()
        {
            cursus = cfdynamic?.Cursus;
            info = cfdynamic?.AlleInfo();
        }
    }
}

