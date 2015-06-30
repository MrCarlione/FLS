using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLS
{
	class Program
	{
		static void Main(string[] args)
		{
			Article article = new Article("Footbal", "'Shachter' probilsia v ligu UEFA!");
			//Task.Delay(30000).Wait();
			Article article2 = new Article("Politics", "B. Obama prodolzhaet rasprostraniat' sredstva PVO!");
			article.ShowArticle();
			//Task.Delay(70000).Wait();
			article2.ShowArticle();
			Console.ReadKey();

			User user = new User("Ivan", "Ivanov", 35);
			User user2 = new User("Petr", "Petrov", 28, new Article("Culture", "Grammy 2015!"));
			Console.WriteLine("{0}, {1}, {2}, {3}", user2.Name, user2.Surname, user2.Age, user2.Article);
			Console.WriteLine("User article is " + user.Article);
			user.CreateArticle("Counry", "Armenia protestuet protiv povushenia tarifov na elektroenergiu.");
			Console.WriteLine("User was created article!");
			Console.ReadKey();
			Console.WriteLine("User article is " + user.Article);
			Console.ReadKey();

		}
	}

	class User
	{
		String f_name;
		String s_name;
		Int32 age;
		Article article; //массив/лист или словарь, т. к. статей у одного пользователя может быть много…

		public User(String name, String surname, Int32 age)
		{
			f_name = name;
			s_name = surname;
			this.age = age;
			article = new Article("No article.", "No contents.");
		}

		public User(String name, String surname, Int32 age, Article a)
		{
			f_name = name;
			s_name = surname;
			this.age = age;
			article = a;
		}

		public String Name
		{
			get { return f_name; }
		}

		public String Surname
		{
			get { return s_name; }
		}

		public Int32 Age
		{
			get { return age; }
		}

		public String Article
		{
			get { return new StringBuilder(article.ToString()).ToString(); }
		}

		public String CreateArticle(String header, String content)
		{
			article = new Article(header, content);
			return article.ToString();
		}
	}

	class Article
	{
		String header;
		String content;
		DateTime date;

		public Article(String header = "", String content = "")
		{
			this.header = header;
			this.content = content;
			date = DateTime.Now;
		}

		public override string ToString()
		{
			String s = "Title: " + header + " Content: " + content; 
			return s;
		}

		public void ShowArticle()
		{
			Console.WriteLine("Article was created in the {0}\nTitle:\n\t {1} \nContent: \n\t {2}\n", this.date, header, content);
		}
	}

//	class Comment : Article
//	{
//		public Comment(String header, String content, DateTime date)
//			: this(header, content, date)
//		{
//
//		}
//	}

	class Review : Article
	{
		Int32 rating;

		public Review(String header, String content, Int32 rating) : base(header, content)
		{
			this.rating = rating;
		}
	}
}
