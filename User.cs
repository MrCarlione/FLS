namespace FLS
{
	public class User
	{
		string firstName;
	    string secondName;
		int age;

		public User(string name, string surname, int age)
		{
			firstName = name;
			secondName = surname;
			this.age = age;
		}

		public string Name
		{ 
			get { return firstName; }
            set { firstName = value; }
		}

		public string Surname
		{
			get { return secondName; }
            set { secondName = value; }
		}

		public int Age
		{
			get { return age; }
            set { age = value; }
		}
	}
}
