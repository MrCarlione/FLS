using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
	public class Article
	{
		string header;
		string content;
		DateTime date;
		User user;

		public Article(string header, string content, DateTime date) //Constructor
		{
			this.header = header;
			this.content = content;
			this.date = date;
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
	}
}
