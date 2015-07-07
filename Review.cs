using System.Runtime.Remoting.Messaging;

namespace FLS
{
    class Review : ICommentaries
    {
        string header;
        string content;
        int rating;

        public Review(string header, string content, int rating)
        {
            this.header = header;
            this.content = content;
            this.rating = rating;
        }
    }
}