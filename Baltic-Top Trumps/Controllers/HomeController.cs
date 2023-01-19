using Baltic_Top_Trumps.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Baltic_Top_Trumps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DeckService _deckService;

        public HomeController(ILogger<HomeController> logger, DeckService deckService)
        {
            _logger = logger;
            _deckService = deckService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Start()
        {
            var _decks = _deckService.Decks;
            return View(_decks);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}