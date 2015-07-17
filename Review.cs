using System;
using System.Runtime.Remoting.Messaging;

namespace FLS
{
    class Review : INotice
    {
        string header;
        string content;
        int rating;
        User user;

        public Review(string header, string content, int rating, User user)
        {
            this.header = header;
            this.content = content;
            this.rating = rating;
            this.user = user;
        }

        public void WriteInfo()
        {
            Console.WriteLine(header + " - " + content + " - " + rating);
        }

        public string GetString()
        {
            return header + " - " + content + " - " + rating;
        }
    }
}