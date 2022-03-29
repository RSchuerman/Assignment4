using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	public abstract class User
	{
		private string _email;
		private string _password;
		private int _userID;

		public virtual void login()
		{
			throw new NotImplementedException();
		}

		public string email
		{
			get { return _email; }
			set { _email = value; }
		}
		public string password
		{
			get { return _password; }
			set { _password = value; }
		}

		public int userID
		{
			get { return _userID; }
			set { _userID = value; }
		}
	}
}
