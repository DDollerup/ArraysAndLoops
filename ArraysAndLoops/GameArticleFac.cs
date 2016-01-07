using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArraysAndLoops.Models;

namespace ArraysAndLoops
{
    public class GameArticleFac
    {
        private List<GameArticle> gameArticles = new List<GameArticle>()
        {
            new GameArticle()
            {
                GameArticleID = 1,
                Name = "League of Legends",
                PGRating = "PG12",
                Studio = "Riot Games",
                ReleaseDate = "October 27, 2009"
            },
            new GameArticle()
            {
                 GameArticleID = 2,
                 Name  = "Counter Strike Global Offense",
                 PGRating= "PG16",
                 ReleaseDate = "August 21, 2012",
                 Studio = "Valve"
            }
        };

        /*
            Det samme som nedenunder! :)
        */

        //public GameArticleFac()
        //{
        //    gameArticles.Add(new GameArticle()
        //    {
        //        GameArticleID = 1,
        //        Name = "League of Legends",
        //        PGRating = "PG12",
        //        Studio = "Riot Games",
        //        ReleaseDate = "October 27, 2009"
        //    });
        //}

        public GameArticle GetArticleByID(int id)
        {
            return gameArticles.Find(x => x.GameArticleID == id);
        }

        public List<GameArticle> GetAllArticles()
        {
            return gameArticles;
        }
    }
}