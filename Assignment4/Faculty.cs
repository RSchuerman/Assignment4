using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	public class Faculty : User
	{
		private string _department;
		private Dictionary<String, Schedule> _schedules = new Dictionary<string, Schedule>();

		public string department
		{
			get { return _department; }
			set { _department = value; }
		}

		public Faculty()
		{
			department = "";
			email = "";
			password = "";
			userID = 0;
		}
		public Faculty(string Email, string Password, int UserID, string Department)
		{
			department = Department;
			email = Email;
			password = Password;
			userID = UserID;
		}

		~Faculty()
		{ }


		public void viewSchedule(string ScheduleName)
		{
			_schedules[ScheduleName].printFacultySchedule();
		}

		public void browseCourses()
		{
			foreach( Course a in Program._courses)
            {
				Console.WriteLine(a);
				Console.WriteLine("\n");
            }
		}

		public void enterGrades()
		{
			throw new NotImplementedException();
		}

		public void viewCourseWaitlist(CourseSection Section)
		{
			foreach( int a in Section._waitlisted)
            {
				Console.WriteLine(a);
				Console.WriteLine("\n");
            }
		}

		public void managePrereqOverrides(Course CourseName, string NewPreReq)
		{
			CourseName.preRequisite = NewPreReq;
		}

		public void addSchedule(string Name, string Term, bool Active)
		{
			Schedule schedule = new Schedule(Term, Active);
			_schedules.Add(Name, schedule);
		}

		public void dropSection(CourseSection SectionName, string ScheduleName)
		{
			_schedules[ScheduleName].removeSection(SectionName.sectionName, SectionName);
		}

		public void registerForSection(CourseSection SectionName, string ScheduleName)
		{
			_schedules[ScheduleName].addSection(SectionName.sectionName, SectionName);
		}
	}
}
