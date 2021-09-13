﻿namespace GenerateReview.Models
{

    /// <summary>
    public class Review
    {
        public string Overall { get; set; }
        public bool Verified { get; set; }
        public string ReviewTime { get; set; }
        public string ReviewerID { get; set; }
        public string Name { get; set; }
        public int StarRating { get; set; }
    }
}