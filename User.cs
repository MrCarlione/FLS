using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
	class User
	{
		String f_name; //First name
		String s_name; //Last name
		Int32 age; //Age
		List<Article> Articles;

		public User(String name, String surname, Int32 age) //Constructor
		{
			f_name = name;
			s_name = surname;
			this.age = age;
			Articles = new List<Article>(); //("No article.", "No contents."));
		}

		public String Name //Setup/edit name
		{ 
			get { return f_name; }
			set { value = f_name; }
		}

		public String Surname //Setup/edit surname
		{
			get { return s_name; }
			set { value = s_name; }
		}

		public Int32 Age //Setup/edit age
		{
			get { return age; }
			set { value = age; }
		}

		public void AddArticle(Article a) //Add article to the current user
		{
			Articles.Add(a);
		}

		public void ShowArticles() //Show all articles by user
		{
			Console.WriteLine("User {0} have a {1} articles.", this.Name, Articles.Count);
			foreach (var a in Articles)
			{
				Console.WriteLine("\tTitle: {0}\n\tContent: {1}\n", a.Title, a.Content);
			}
		}
	}
}
