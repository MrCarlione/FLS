namespace FLS
{
	public class User
	{
		string firstName; //First name
		string secondName; //Last name
		int age; //Age

		public User(string name, string surname, int age) //Constructor
		{
			firstName = name;
			secondName = surname;
			this.age = age;
		}

		public string Name //Setup/edit name
		{ 
			get { return firstName; }
			set { value = firstName; }
		}

		public string Surname //Setup/edit surname
		{
			get { return secondName; }
			set { value = secondName; }
		}

		public int Age //Setup/edit age
		{
			get { return age; }
			set { value = age; }
		}
	}
}
