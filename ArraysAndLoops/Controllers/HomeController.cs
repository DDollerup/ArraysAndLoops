using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArraysAndLoops.Models;

namespace ArraysAndLoops.Controllers
{
    public class HomeController : Controller
    {
        GameArticleFac gameFac = new GameArticleFac();

        // GET: Home
        public ActionResult Index()
        {
            GameArticle article = gameFac.GetArticleByID(1);
            return View(article);
        }

        public ActionResult ShowAllArticles()
        {
            return View(gameFac.GetAllArticles());
        }
    }
}