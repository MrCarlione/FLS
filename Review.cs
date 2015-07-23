using System;
using System.Runtime.Remoting.Messaging;

namespace FLS
{
    class Review : Comment
    {
        int rating;

        public Review(string header, string content, User user, int rating) : base(header, content, user)
        {
            this.rating = rating;
        }

        public override string NoticeStringFormat()
        {
            return base.NoticeStringFormat() + " - " + rating;
        }
    }
}