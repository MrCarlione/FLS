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
	    List<ICommentaries> IComm; 

		public Article(string header, string content, DateTime date, User user) //Constructor
		{
			this.header = header;
			this.content = content;
			this.date = date;
			this.user = user;
		}

		public string Title //Setup/edit header
		{
			get { return header; }
			set { value = header; }
		}

		public string Content //Setup/edit content
		{
			get { return content; }
			set { value = content; }
		}

	    void AddNotice(ICommentaries commentaries)
	    {
	        IComm.Add(commentaries);
	    }
	}
}
