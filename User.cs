using System;

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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            User user = (User)obj;
            return (firstName == user.firstName) && (secondName == user.secondName) && (age == user.age);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
	}
}
