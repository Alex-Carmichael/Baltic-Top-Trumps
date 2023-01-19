namespace Baltic_Top_Trumps.Models
{
    public class DeckService
    {
        public List<Deck> Decks { get; set; }

        public DeckService()
        {
            Decks = new List<Deck>()
            {
                new Deck()
                {
                    ID = 1,
                    Name = "Animals Deck",
                    Description = "This card features a colorful illustration on the front and various statistics on the back. The statistics include categories such as speed, power, and intelligence, each rated on a scale of 1 to 10.",
                    ImageUrl = "https://www.macmillandictionary.com/external/slideshow/thumb/Grey_thumb.png",
                    Cards = new List<Card>()
                    {
                        new Card() { ID = 1, DeckId = 1, Name = "Lion", Speed = 8, Power = 9, Intelligence = 2 },
                        new Card() { ID = 2, DeckId = 1, Name = "Cheetah", Speed = 10, Power = 7, Intelligence = 4 },
                        new Card() { ID = 3, DeckId = 1, Name = "Elephant", Speed = 6, Power = 10, Intelligence = 7 }
                    }
                },
                new Deck()
                {
                    ID = 2,
                    Name = "Superhero Deck",
                    Description = "This card features a colorful illustration on the front and various statistics on the back. The statistics include categories such as speed, power, and intelligence, each rated on a scale of 1 to 10.",
                    ImageUrl = "https://www.macmillandictionary.com/external/slideshow/thumb/Grey_thumb.png",
                    Cards = new List<Card>()
                    {
                        new Card() { ID = 1, DeckId = 2, Name = "Superman", Speed = 10, Power = 10, Intelligence = 8 },
                        new Card() { ID = 2, DeckId = 2, Name = "Spiderman", Speed = 8, Power = 6, Intelligence = 9 },
                        new Card() { ID = 3, DeckId = 2, Name = "Ironman", Speed = 7, Power = 8, Intelligence = 10 }
                    }
                },
                new Deck()
                {
                    ID = 3,
                    Name = "Cartoon Deck",
                    Description = "This card features a colorful illustration on the front and various statistics on the back. The statistics include categories such as speed, power, and intelligence, each rated on a scale of 1 to 10.",
                    ImageUrl = "https://www.macmillandictionary.com/external/slideshow/thumb/Grey_thumb.png",
                    Cards = new List<Card>()
                    {
                        new Card() { ID = 1, DeckId = 3, Name = "Tom and Jerry", Speed = 5, Power = 2, Intelligence = 1 },
                        new Card() { ID = 2, DeckId = 3, Name = "Bugs Bunny", Speed = 3, Power = 4, Intelligence = 7 },
                        new Card() { ID = 3, DeckId = 3, Name = "Mickey Mouse", Speed = 6, Power = 2, Intelligence = 8 }
                    }
                }
            };
        }
    }
}
