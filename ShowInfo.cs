using System;
using System.Collections.Generic;

namespace FLS
{
	static public class ShowInfo
	{
		public static void ShowArticleInfo(Article article)
		{
            Console.WriteLine("\tTitle: {0}\n\tContent: {1}\n", article.Title, article.Content);
		}

        public static void ShowUser(User user)
        {
            Console.WriteLine(user.ToString());
        }

        public static void PrintArticles(List<Article> articles)
		{
            foreach (var article in articles) 
			{
                Console.WriteLine(article.Title + " - " + article.Content);
			}
		}
	}
}

