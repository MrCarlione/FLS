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
	    List<INotice> noteList = new List<INotice>();

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

        public List<INotice> List
	    {
	        get { return noteList; }
	    }

        //public INotice this[int index]
        //{
        //    get { return noteList[index]; }
        //}

	    public void Add(INotice notice)
	    {
            noteList.Add(notice);
	    }

        //private string GetNotice()
        //{
        //    foreach (var note in noteList)
        //    {
        //        return note.GetString();
        //    }
        //    throw new ArgumentOutOfRangeException();
        //}
	}
}
