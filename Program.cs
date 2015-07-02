using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
	class Program
	{
		static void Main(string[] args)
		{

			User user1 = new User("Oleg", "Popov", 35);
			User user2 = new User("Gleb", "Petrov", 30);
			User user3 = new User("Marat", "Semenov", 43);

			Article a = new Article("Sport", "Blatter uhodit s posta prezidenta FIFA.");
			Article a2 = new Article("Region news", "Sergei Sobianin otravilsia shaurmoi na kurskom vokzale!");
			Article a3 = new Article("Business", "MosOblBank lishen licensii.");

			Article article = new Article("Footbal", "'Shachter' probilsia v ligu UEFA!");
			Article article2 = new Article("Politics", "B. Obama prodolzhaet rasprostraniat' sredstva PVO!");
			Article article3 = new Article("LGBT.", "**diki ustroili marsh protesta.");
			Article article4 = new Article("Auto", "Smart FourTwo obzavelsia novoi electronikoi.");
			Article article5 = new Article("Music", "Tim Lambesis poluchil 4 goda tur'mu za poputku ubit' zhenu.");
			Article article6 = new Article("Counry", "Armenia protestuet protiv povushenia tarifov na elektroenergiu.");

			user1.AddArticle(a);
			user1.AddArticle(a2);
			user1.AddArticle(a3);
			user1.ShowArticles();

			user2.AddArticle(article);
			user2.AddArticle(article2);
			user2.ShowArticles();

			Console.ReadKey();
		}
	}



	//class Comment : Article
	//{
	//    public Comment(String header, String content, DateTime date)
	//        : this(header, content, date)
	//    {

	//    }
	//}

	//class Review : Article
	//{
	//    Int32 rating;

	//    public Review(String header, String content, Int32 rating) : base(header, content)
	//    {
	//        this.rating = rating;
	//    }
	//}
}