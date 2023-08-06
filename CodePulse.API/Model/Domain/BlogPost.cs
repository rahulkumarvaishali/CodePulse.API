namespace CodePulse.API.Model.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String ShortDescription { get; set; }
        public String content { get; set; }
        public String FeaturedImageUrl { get; set; }
        public String UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public String Auther { get; set; }
        public String IsVisible { get; set; }
    }
}
