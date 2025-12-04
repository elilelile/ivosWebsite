using System.Diagnostics;
using ivosWebsite.Models;
using ivosWebsite.Service;
using Microsoft.AspNetCore.Mvc;

namespace ivos_website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MemberService _memberService;
        private readonly MusicService _musicService;

        public HomeController(ILogger<HomeController> logger, MemberService memberService, MusicService musicService)
        {
            _logger = logger;
            _memberService = memberService;
            _musicService = musicService;
        }

        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Home";
            return View();
        }

        public IActionResult Music()
        {
            ViewData["ActivePage"] = "Music";
            var music = _musicService.GetMusics();
            return View(music);
        }

        public IActionResult About()
        {
            ViewData["ActivePage"] = "About";
            var members = _memberService.GetMembers();
            return View(members);
        }

        public IActionResult SignUp()
        {
            ViewData["ActivePage"] = "SignUp";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
