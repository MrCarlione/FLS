using System;
using System.Collections.Generic;

namespace FLS
{
	public class Article
	{
		string header;
		string content;
		DateTime date;
		User user;
	    List<INotice> INoticeList = new List<INotice>();

		public Article(string header, string content, DateTime date, User user)
		{
			this.header = header;
			this.content = content;
			this.date = date;
			this.user = user;
		}

		public string Title
		{
			get { return header; }
			set { header = value; }
		}

		public string Content
		{
			get { return content; }
			set { content = value; }
		}

        public List<INotice> INoticesCollections
	    {
            get { return INoticeList; }
	    }

	    public void Add(INotice notice)
	    {
            INoticeList.Add(notice);
	    }
	}
}
