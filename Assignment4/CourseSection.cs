using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	public class CourseSection : Course
	{
		private double _time;
		private string _location;
		private string _instructor;
		private string _section;
		private string _sectionName;
		public List<int> _waitlisted = new List<int>();
		public double time
		{
			get { return _time; }
			set { _time = value; }
		}
		public string location
		{
			get { return _location;  }
			set { _location = value; }
		}
		public string instructor
		{
			get { return _instructor; }
			set { _instructor = value; }
		}
		public string section
		{
			get { return _section; }
			set { _section = value; }
		}
		public string sectionName
        {
			get { return _sectionName; }
			set { _sectionName = courseID + section; }
        }
		public CourseSection()
		{
			_time = 0.0;
			_location = "NA";
			_instructor = "NA";
			_section = "NA";
			_sectionName = "NA";
		}

		public CourseSection(double Time, string Location, string Instructor, string Section)
		{
			time = Time;
			location = Location;
			instructor = Instructor;
			section = Section;
			sectionName = courseID + Section;
		}

		~CourseSection()
		{
		}
	}
}
