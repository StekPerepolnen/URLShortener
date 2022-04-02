using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using URLShortener.Utils;
using URLShortener.Web.Models;
using URLShortener.Web.Data;

namespace URLShortener.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUrlKeyGenerator _urlKeyGenerator;
        private readonly URLShortenerContext _context;

        public HomeController(ILogger<HomeController> logger, IUrlKeyGenerator urlKeyGenerator, URLShortenerContext context)
        {
            _logger = logger;
            _urlKeyGenerator = urlKeyGenerator;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // POST: ShortUrlModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Origin")] ShortenUrlModel addUrlModel)
        {
            if (ModelState.IsValid)
            {
                string key = _urlKeyGenerator.Next();
                var shortUrlModel = new ShortUrlModel()
                {
                    Origin = addUrlModel.Origin,
                    Short = key
                };
                _context.Add(shortUrlModel);
                await _context.SaveChangesAsync();

                TempData["success-message"] = "Success!";
                return Redirect("~/ShortUrl/Details/" + shortUrlModel.Id);
                //return RedirectToAction(nameof(Index));
            }
            return View(addUrlModel);
        }
    }
}