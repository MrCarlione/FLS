using System;
using System.Collections.Generic;

namespace FLS
{
	class Program
	{
		static void Main(string[] args)
		{
			var articles = Initialize();
			ShowInfo.PrintArticles(articles);

		    foreach (var article in articles)
		    {
                foreach (var note in article.NoticesCollection)
		        {
		            if (note != null)
		            {
                        Console.WriteLine(note.NoticeStringFormat());
		            }
		        }
		    }
		    Console.ReadKey();
		}

		static public List<Article> Initialize()
		{
			List<Article> resultArticles = new List<Article>();
			User user1 = new User("Oleg", "Popov", 35);
			User user2 = new User("Gleb", "Petrov", 30);
			User user3 = new User("Marat", "Semenov", 43);

			Article article1 = new Article("Sport", "Blatter uhodit s posta prezidenta FIFA.", DateTime.Now, user1);
			Article article12 = new Article("Region news", "Sergei Sobianin otravilsia shaurmoi na kurskom vokzale!", DateTime.Now, user1);
			Article article13 = new Article("Business", "MosOblBank lishen licensii.", DateTime.Now, user1);

			Article article = new Article("Footbal", "'Shachter' probilsia v ligu UEFA!", DateTime.Now, user2);
			Article article2 = new Article("Politics", "B. Obama prodolzhaet rasprostraniat' sredstva PVO!", DateTime.Now, user2);
			Article article3 = new Article("LGBT.", "**diki ustroili marsh protesta.", DateTime.Now, user3);
			Article article4 = new Article("Auto", "Smart FourTwo obzavelsia novoi electronikoi.", DateTime.Now, user3);
			Article article5 = new Article("Music", "Tim Lambesis poluchil 4 goda tur'mu za poputku ubit' zhenu.", DateTime.Now, user3);
			Article article6 = new Article("Counry", "Armenia protestuet protiv povushenia tarifov na elektroenergiu.", DateTime.Now, user3);

            resultArticles.Add(article1); 
            resultArticles.Add(article12); 
            resultArticles.Add(article13);
            resultArticles.Add(article); 
            resultArticles.Add(article2); 
            resultArticles.Add(article3); 
            resultArticles.Add(article4); 
            resultArticles.Add(article5); 
            resultArticles.Add(article6);

            Review review1 = new Review("Good article!", "Article good.", user1, 5);
            Review review2 = new Review("Bad article!", "Article is bad.", user2, 2);
            Comment comment = new Comment("Kruto!", "Vsem obiasnili.", user3);
            Comment comment2 = new Comment("Ne shumit.", "Ded zastrelil sozhitelia i on bol'she ne shumit.", user3);
            Comment comment3 = new Comment("Salut!", "Vsem ponravilos'.", user2);
            Comment comment4 = new Comment("Windows 10", "Zhdem.", user1);

            article.NoticesCollection.Add(review1);
            article.NoticesCollection.Add(comment3);
            article.NoticesCollection.Add(comment);
            article2.NoticesCollection.Add(review2);
            article3.NoticesCollection.Add(comment2);
            article3.NoticesCollection.Add(comment4);

            return resultArticles;
		}
	}
}