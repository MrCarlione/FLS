using System.Globalization;

namespace FLS
{
    class Comment : INotice
    {
        string header;
        string content;

        public Comment(string header, string content)
        {
            this.header = header;
            this.content = content;
        }

        INotice Add(Article a)
        {
            
        }
    }
}
