using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	public class Schedule
	{
		private string _term;
		private bool _active;
		private double[] _midtermGrade;
		private double[] _finalGrade;
		public Dictionary<string, CourseSection> _scheduledSections = new Dictionary<string, CourseSection>();
		public Dictionary<string, CourseSection> _waitlistedSections = new Dictionary<string, CourseSection>();

		public string term
		{
			get { return _term; }
			set { _term = value; }
		}

		public bool active
		{
			get { return _active; }
			set { _active = value; }
		}

		public Schedule(string Term, bool Active)
		{
			term = Term;
			active = Active;
		}

		~Schedule()
		{ }

		public void addSection(string SectionName, CourseSection CourseSection)
		{
			_scheduledSections.Add(SectionName, CourseSection);
		}
		public void removeSection(string SectionName, CourseSection CourseSection)
		{
			_scheduledSections.Remove(SectionName);
		}

		public void waitlistSection(string SectionName, CourseSection CourseSection, int ID)
		{
			_waitlistedSections.Add(SectionName, CourseSection);
			CourseSection._waitlisted.Add(ID);
		}
		public void removeWaitlistSection(string SectionName, CourseSection CourseSection, int ID)
		{
			_waitlistedSections.Remove(SectionName);
			CourseSection._waitlisted.Remove(ID);
		}

		public void printStudentSchedule()
		{
			Console.WriteLine("Registered: \n");
			foreach (KeyValuePair<string, CourseSection> a in _scheduledSections)
            {
                Console.WriteLine(a);
				Console.WriteLine("\n");
			}
			Console.WriteLine("Waitlisted: \n");
			foreach (KeyValuePair<string, CourseSection> a in _waitlistedSections)

			{
				Console.WriteLine(a);
				Console.WriteLine("\n");
			}
		}
		public void printFacultySchedule()
		{
			Console.WriteLine("Registered: \n");
			foreach (KeyValuePair<string, CourseSection> a in _scheduledSections)
			{
				Console.WriteLine(a);
				Console.WriteLine("\n");
			}
		}
	}
}
