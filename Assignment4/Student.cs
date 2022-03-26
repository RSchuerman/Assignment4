using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	public class Student : User
	{
		private bool _registrationHold;
		private double _degreeProgress;
		private string _advisor;

		private Dictionary<String, Schedule> _schedules = new Dictionary<string, Schedule>();
		
		public bool registrationHold
		{
			get { return _registrationHold; }
			set { _registrationHold = value; }
		}

		public double degreeProgress
		{
			get { return _degreeProgress; }
			set { _degreeProgress = value; }
		}

		public string advisor
		{
			get { return _advisor; }
			set { _advisor = value; }
		}

		public Student()
		{
			_registrationHold = false;
			_degreeProgress = 0.0;
			_advisor = "NA";
			email = "";
			password = "";
			userID = 0;
		}
		public Student(string Email, string Password, int UserID, bool RegistrationHold, double DegreeProgress, string Advisor)
		{
			registrationHold = RegistrationHold;
			degreeProgress = DegreeProgress;
			advisor = Advisor;
			email = Email;
			password = Password;
			userID = UserID;
		}

		~Student()
		{ }

		public void browseForSections(Course CourseName)
		{
			CourseName.printSections();
		}

		public void waitlistSection(CourseSection SectionName, string ScheduleName)
		{
			_schedules[ScheduleName].waitlistSection(SectionName.sectionName, SectionName, userID);
		}
		public void removeWaitlistSection(CourseSection SectionName, string ScheduleName)
		{
			_schedules[ScheduleName].removeWaitlistSection(SectionName.sectionName, SectionName, userID);
		}

		public void addSchedule(string Name, string Term, bool Active)
		{
			Schedule schedule = new Schedule(Term, Active);
			_schedules.Add(Name,schedule);
		}

		public void evaluateProgress()
		{
			Console.WriteLine(degreeProgress);
		}

		public void dropSection(CourseSection SectionName, string ScheduleName)
		{
			_schedules[ScheduleName].removeSection(SectionName.sectionName, SectionName);
		}

		public void registerForSection(Course CourseName, string Section, string ScheduleName)
		{
			string lookup = CourseName.courseID + Section;
			_schedules[ScheduleName].addSection(lookup, CourseName._sections[Section]);
		}
		

		public void viewSchedule(string ScheduleName)
		{
			_schedules[ScheduleName].printStudentSchedule();
		}

	}
}
