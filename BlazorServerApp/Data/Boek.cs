namespace BlazorServerApp.Data
{
    public class Boek
    {
        public string? Auteur { get; set; }
        public string? Titel { get; set; }
        public string? Afbeelding { get; set; }
        public string? Taal { get; set; }
        public string? Afwerking { get; set; }
        public long? ISBN { get; set; }
        public DateTime UitgifteDatum { get; set; }
        public int? AantalPaginas { get; set; }
        public string? Beschrijving { get; set; }
    }
}
