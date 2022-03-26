using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	public class Advisor : User 
	{
		public Advisor()
		{
			email = "";
			password = "";
			userID = 0;
		}
		public Advisor(string Email, string Password, int UserID)
		{
			email = Email;
			password = Password;
			userID = UserID;
		}

		~Advisor()
		{ }

		public void viewAdviseeList()
		{
			throw new NotImplementedException();
		}

		public void removeRegistrationHold()
		{
			throw new NotImplementedException();
		}

		public void placeRegistrationHold()
		{
			throw new NotImplementedException();
		}

		public void viewStudentProfile()
		{
			throw new NotImplementedException();
		}

		public void evaluateAdviseeDegreeProgress()
		{
			throw new NotImplementedException();
		}

		public void viewAdviseeCurrentRegistration()
		{
			throw new NotImplementedException();
		}

		
	}
}
