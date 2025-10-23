using System.Collections.Generic;

namespace RPCMWEB.Models
{
    public class CorporateArticleViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string BannerImageUrl { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public List<string> Highlights { get; set; } = new List<string>();
        public List<string> RecentStories { get; set; } = new List<string>();
    }
}