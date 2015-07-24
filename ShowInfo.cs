using System;
using System.Collections.Generic;

namespace FLS
{
	static public class ShowInfo
	{
		public static void PrintArticleInfo(Article article)
		{
            Console.WriteLine("\tTitle: {0}\n\tContent: {1}\n", article.Title, article.Content);
		}

        public static void PrintUser(User user)
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

        public static void PrintArticlesByUser(List<Article> articlesList, User user)
        {
            Console.WriteLine("All articles published by the user " + user.ToString());
            foreach (var article in articlesList)
            {
                if (article.GetUser.Equals(user))
                {
                    PrintArticleInfo(article);
                }
            }
        }

        public static void PrintAllNoticeElements(List<Article> articles)
        {
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
        }

        public static void PrintCommentOrReviewByArticle(Article article, string type)
        {
            Console.WriteLine(type + " on the article " + article.Title);
            foreach (var a in article.NoticesCollection)
            {
                if (a.GetType().Name == type)
                {
                    Console.WriteLine(a.NoticeStringFormat());
                }
            }
        }

        public static void PrintAverageRatingByArticle(Article article)
        {
            double average = 0;
            int i = 0;
            foreach (var a in article.NoticesCollection)
            {
                try
                {
                    if ((Review)a is Review)
                    {
                        var im = (Review)a;
                        average += im.GetRating;
                        i++;
                    }
                }
                catch
                {
                    continue;
                }
            }
            Console.WriteLine("Average rating by article \"{0}\" is {1:#.##}.", article.Title, average / i);
        }

        public static void PrintArticlesByDate(List<Article> articles, DateTime date)
        {
            Console.WriteLine("All article by this date " + date.ToString("dd.MM.yyyy"));
            foreach (var article in articles)
            {
                if (date.ToString("dd.MM.yyyy") == article.GetDateTime.ToString("dd.MM.yyyy"))
                {
                    PrintArticleInfo(article);
                }
            }
        }

	}
}

