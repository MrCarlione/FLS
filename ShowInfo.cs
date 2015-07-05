using System;

namespace Journal
{
	static public class ShowInfo
	{
		static public void ShowArticles(Article a)
		{
			Console.WriteLine("\tTitle: {0}\n\tContent: {1}\n", a.Title, a.Content);
		}

		static public void ShowUser(User user)
		{
			Console.WriteLine("\tUser name: {0}\n\tUser surname: {1}\n\tAge user: {2}\n", user.Name, user.Surname, user.Age);
		}
	}
}

