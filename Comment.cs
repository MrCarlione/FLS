using System;
using System.Globalization;

namespace FLS
{
    class Comment : INotice
    {
        string header;
        string content;
        User user;

        public Comment(string header, string content, User user)
        {
            this.header = header;
            this.content = content;
            this.user = user;
        }

        public string INoticeStringFormat()
        {
            return header + " - " + content;
        }
    }
}
