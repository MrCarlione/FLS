using System;
using System.Globalization;

namespace FLS
{
    class Comment : INotice
    {
        protected string header;
        protected string content;
        User user;

        public Comment(string header, string content, User user)
        {
            this.header = header;
            this.content = content;
            this.user = user;
        }

        public virtual string NoticeStringFormat()
        {
            return header + " - " + content;
        }
    }
}
