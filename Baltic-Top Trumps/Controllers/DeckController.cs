using Baltic_Top_Trumps.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baltic_Top_Trumps.Controllers
{
    public class DeckController : Controller
    {
        private readonly DeckService _deckService;
        public List<Card> SelectedCards { get; set; }

        public DeckController(DeckService deckService)
        {
            _deckService = deckService;
            SelectedCards = new List<Card>();
        }
        public IActionResult Start()
        {
            var _decks = _deckService.Decks;
            return View(_decks);
        }
        public IActionResult Arena(int id)
        {
            var _decks = _deckService.Decks;
            var selectedDeck = _decks.FirstOrDefault(d => d.ID == id);
            selectedDeck.SelectedCards = SelectedCards;
            return View(selectedDeck);
        }

        public IActionResult SelectCard(int cardId)
        {
            var selectedCard = _deckService.Decks
                .SelectMany(d => d.Cards)
                .FirstOrDefault(c => c.ID == cardId);
            if (selectedCard != null)
            {
                SelectedCards.Add(selectedCard);
            }

            // Get the selected deck
            var selectedDeck = _deckService.Decks.FirstOrDefault(d => d.ID == selectedCard.DeckId);
            // Assign the selected cards to the selected deck
            selectedDeck.SelectedCards = SelectedCards;

            return View("Arena", selectedDeck);
        }

        [HttpPost]
        public IActionResult Battle(string selectedValue)
        {
            // Store the selectedValue in a variable or somewhere else for later use
            return View();
        }

    }
}
