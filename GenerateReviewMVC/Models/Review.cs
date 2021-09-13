namespace GenerateReviewMVC.Models
{

    /// <summary>    /// Model class for Reviews.    /// </summary>
    public class Review
    {
        public string Overall { get; set; }
        public bool Verified { get; set; }
        public string ReviewTime { get; set; }
        public string ReviewerID { get; set; }        public string ASIN { get; set; }        public string ReviewerName { get; set; }        public string ReviewText { get; set; }        public string Summary { get; set; }        public int UnixReviewTime { get; set; }
        public string Name { get; set; }
        public int StarRating { get; set; }
    }
}