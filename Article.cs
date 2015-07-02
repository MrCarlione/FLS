using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
	class Article
	{
		String header;
		String content;
		DateTime date;

		public Article(String header = "", String content = "") //Constructor
		{
			this.header = header;
			this.content = content;
			date = DateTime.Now;
		}

		public String Title //Setup/edit header
		{
			get { return header; }
			set { value = header; }
		}

		public String Content //Setup/edit content
		{
			get { return content; }
			set { value = content; }
		}
	}
}
