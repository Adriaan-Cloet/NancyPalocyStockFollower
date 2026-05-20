using Microsoft.AspNetCore.Mvc;
using NancyPalocyStockFollower.Models;
using NancyPalocyStockFollower.Services;
using System.Diagnostics;

namespace NancyPalocyStockFollower.Controllers
{
    public class TradesController : Controller
    {
        private readonly TradeService _tradeService;

        public TradesController(TradeService tradeService)
        {
            _tradeService = tradeService;
        }

        public async Task<IActionResult> Index()
        {
            var trades = await _tradeService.GetPelosiTradesAsync();
            return View(trades);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
