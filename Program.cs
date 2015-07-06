using System;
using System.Collections.Generic;

namespace FLS
{
	class Program
	{
		static void Main(string[] args)
		{
			var i = Initialize();
			ShowInfo.PrintArticles(i);
			Console.ReadKey();
		}

		static public List<Article> Initialize()
		{
			List<Article> Articles = new List<Article>();
			User user1 = new User("Oleg", "Popov", 35);
			User user2 = new User("Gleb", "Petrov", 30);
			User user3 = new User("Marat", "Semenov", 43);

			Article a = new Article("Sport", "Blatter uhodit s posta prezidenta FIFA.", DateTime.Now, user1);
			Article a2 = new Article("Region news", "Sergei Sobianin otravilsia shaurmoi na kurskom vokzale!", DateTime.Now, user1);
			Article a3 = new Article("Business", "MosOblBank lishen licensii.", DateTime.Now, user1);

			Article article = new Article("Footbal", "'Shachter' probilsia v ligu UEFA!", DateTime.Now, user2);
			Article article2 = new Article("Politics", "B. Obama prodolzhaet rasprostraniat' sredstva PVO!", DateTime.Now, user2);
			Article article3 = new Article("LGBT.", "**diki ustroili marsh protesta.", DateTime.Now, user3);
			Article article4 = new Article("Auto", "Smart FourTwo obzavelsia novoi electronikoi.", DateTime.Now, user3);
			Article article5 = new Article("Music", "Tim Lambesis poluchil 4 goda tur'mu za poputku ubit' zhenu.", DateTime.Now, user3);
			Article article6 = new Article("Counry", "Armenia protestuet protiv povushenia tarifov na elektroenergiu.", DateTime.Now, user3);

            Articles.Add(a); Articles.Add(a2); Articles.Add(a3);
            Articles.Add(article); Articles.Add(article2); Articles.Add(article3); Articles.Add(article4); Articles.Add(article5); Articles.Add(article6);

            return Articles;
		}
	}
}