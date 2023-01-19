namespace Baltic_Top_Trumps.Models
{
    public class Deck
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<Card> Cards { get; set; }
        public List<Card> SelectedCards{get; set;}
    }
}
