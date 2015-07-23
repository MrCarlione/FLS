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

	    public override string ToString()
	    {
	        string toString = firstName + " " + secondName + ", " + age;
	        return toString;
	    }
	}
}
