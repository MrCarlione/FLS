using System;
using System.Runtime.Remoting.Messaging;

namespace FLS
{
    class Review : Comment, INotice
    {
        string header;
        string content;
        int rating;
        User user;

        public Review(string header, string content, User user)
            : base(header, content, user)
        {
            this.rating = rating;
        }

        new public string INoticeStringFormat()
        {
            return header + " - " + content + " - " + rating;
        }
    }
}