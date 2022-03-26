using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	public class Course
	{
		private string _courseName;
		private string _courseID;
		private string _department;
		private string _preRequisite;
		public Dictionary<string, CourseSection> _sections = new Dictionary<string, CourseSection>();

		public string courseName
		{
			get { return _courseName; }
			set { _courseName = value; }
		}
		public string courseID
		{
			get { return _courseID; }
			set { _courseID = value; }
		}
		public string department
		{
			get { return _department; }
			set { _department = value; }
		}
		public string preRequisite
		{
			get { return _preRequisite; }
			set { _preRequisite = value; }
		}

		public Course()
		{
			courseName = "NA";
			courseID = "NA";
			department = "NA";
			preRequisite = "NA";
		}
		public Course( string CourseName, string CourseID, string Department, string PreRequisite)
		{
			courseName = CourseName;
			courseID = CourseID;
			department = Department;
			preRequisite = PreRequisite;
		}

		~Course() { }

		public void createSection(double Time, string Location, string Instructor, string Section)
        {
			CourseSection s = new CourseSection(Time, Location, Instructor, Section);
			_sections.Add(s.sectionName, s);
		}

		public void deleteSection(CourseSection Section)
        {
			_sections.Remove(Section.sectionName);
		}

		public void printSections()
        {
			Console.WriteLine("Sections:");
			foreach (KeyValuePair<string, CourseSection> a in _sections)
			{
				Console.WriteLine(a);
				Console.WriteLine("\n");
			}
		}
	}
}
