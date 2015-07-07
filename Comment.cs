using System.Globalization;

namespace FLS
{
    class Comment : ICommentaries
    {
        string header;
        string content;

        public Comment(string header, string content)
        {
            this.header = header;
            this.content = content;
        }
    }
}
