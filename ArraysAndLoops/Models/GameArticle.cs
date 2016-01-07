using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArraysAndLoops.Models
{
    public class GameArticle
    {
        public int GameArticleID { get; set; }
        public string Name { get; set; }
        public string Studio { get; set; }
        public string PGRating { get; set; }
        public string ReleaseDate { get; set; }
    }
}