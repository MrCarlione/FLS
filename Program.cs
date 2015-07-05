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
			var i = Initialize ();
			Console.WriteLine (i);
			Console.ReadKey();
		}

		public List<Article> Initialize()
		{
			User user1 = new User("Oleg", "Popov", 35);
			User user2 = new User("Gleb", "Petrov", 30);
			User user3 = new User("Marat", "Semenov", 43);

			Article a = new Article("Sport", "Blatter uhodit s posta prezidenta FIFA.", DateTime.Now);
			Article a2 = new Article("Region news", "Sergei Sobianin otravilsia shaurmoi na kurskom vokzale!", DateTime.Now);
			Article a3 = new Article("Business", "MosOblBank lishen licensii.", DateTime.Now);

			Article article = new Article("Footbal", "'Shachter' probilsia v ligu UEFA!", DateTime.Now);
			Article article2 = new Article("Politics", "B. Obama prodolzhaet rasprostraniat' sredstva PVO!", DateTime.Now);
			Article article3 = new Article("LGBT.", "**diki ustroili marsh protesta.", DateTime.Now);
			Article article4 = new Article("Auto", "Smart FourTwo obzavelsia novoi electronikoi.", DateTime.Now);
			Article article5 = new Article("Music", "Tim Lambesis poluchil 4 goda tur'mu za poputku ubit' zhenu.", DateTime.Now);
			Article article6 = new Article("Counry", "Armenia protestuet protiv povushenia tarifov na elektroenergiu.", DateTime.Now);

			return new List<Article> ();
		}
	}
}