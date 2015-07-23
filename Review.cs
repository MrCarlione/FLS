using System;

namespace FLS
{
    class Review : Comment
    {
        int rating;

        public Review(string header, string content, User user, int rating) : base(header, content, user)
        {
            this.rating = rating;
        }

        public int GetRating
        {
            get { return rating; }
        }

        public override string NoticeStringFormat()
        {
            return base.NoticeStringFormat() + " - " + rating;
        }
    }
}