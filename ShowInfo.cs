using System;
using System.Collections.Generic;
using System.Linq;

namespace FLS
{
	public class ShowInfo
	{
		public static void PrintArticleInfo(Article article)
		{
            Console.WriteLine("Title: {0}\n\tContent: {1}\n", article.Title, article.Content);
		}

        public static void PrintUser(User user)
        {
            Console.WriteLine(user.ToString());
        }

        public void GetArticles(List<Article> articles)
		{
            foreach (var article in articles) 
			{
                Console.WriteLine(article.Title + " - " + article.Content);
			}
		}

        public void GetArticlesByUser(List<Article> articlesList, User user)
        {
            Console.WriteLine("All articles published by the user " + user.ToString());
            foreach (var article in articlesList)
            {
                if (article.User.Equals(user))
                {
                    PrintArticleInfo(article);
                }
            }
        }

        public void AllNoticeElements(List<Article> articles)
        {
            foreach (var article in articles)
            {
                if (article.NoticesCollection != null)
                {
                    foreach (var note in article.NoticesCollection)
                    {
                        Console.WriteLine(note.NoticeStringFormat());
                    }
                }
                else
                {
                    Console.WriteLine("Article hasn't elements.");
                }
            }
        }

        public void CommentOrReviewByArticle<T>(Article article) where T : Comment
        {
            Console.WriteLine("INotice on the article " + article.Title);
            foreach (var a in article.NoticesCollection.OfType<T>)
            {
                Console.WriteLine(a.NoticeStringFormat());
            }
        }

        public double AverageRating(Article article)
        {
            double average = 0;
            int i = 0;
            IEnumerable<Review> notice = from note in article.NoticesCollection
                         where note.GetType() == typeof(Review)
                         select (Review)note;
            foreach (var n in notice)
            {
                average += n.Rating;
                i++;
            }
            return average / i;
        }

        public void AverageRatingByArticle(Article article)
        {
            Console.WriteLine("Average rating by article \"{0}\" is {1:#.##}.", article.Title, AverageRating(article));
        }

        public void ArticlesByDate(List<Article> articles, DateTime date)
        {
            Console.WriteLine("All article by this date " + date.ToString("dd.MM.yyyy"));
            foreach (var article in articles)
            {
                if (DateTime.Equals(date.Date, article.DateOfCreation.Date))
                {
                    PrintArticleInfo(article);
                }
            }
        }

	    public void UserWithNCommentByArticle(List<Article> articles, int n)
	    {
            foreach (var article in articles)
            {
                int count = 0;
                foreach (var note in article.NoticesCollection)
                {
                    if (note.GetType().Name == "Comment")
                    {
                        count++;
                    }
                }
                if (count > n)
                {
                    Console.WriteLine("Article by user {0} has more than {1} comments", article.User, n);
                }
            }
	    }

        public void ArticleWithAverageRating(List<Article> articles, double rating)
        {
            foreach (var article in articles)
            {
                if (AverageRating(article) > rating)
                    Console.WriteLine("Article '{0}' has a rating not lower than {1}.", article.Title, rating);
            }
        }

        public void ArticlesContainsSearchText(List<Article> articles, string searchText)
        {
            foreach (var article in articles)
            {
                if (article.Title.Contains(searchText))
                    PrintArticleInfo(article);
            }
        }
	}
}