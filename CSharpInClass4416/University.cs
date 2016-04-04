using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInClass4416
{
    class University
    {
        private string _name;
        private string _location;
        private string _fieldOfStudy;
        private double _costPerSemester;
        private bool _doCreditsTransfer;

        public University()
        {
            _name = "";
            _location = "";
            _fieldOfStudy = "";
            _costPerSemester = 0.00;
            _doCreditsTransfer = false;
        }
       
        public University(string name, string location, string fieldOfStudy, double costPerSemester, bool doCreditsTransfer)
        {
            _name = name;
            _location = location;
            _fieldOfStudy = fieldOfStudy;
            _costPerSemester = costPerSemester;
            _doCreditsTransfer = doCreditsTransfer;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public string FieldOfStudy
        {
            get { return _fieldOfStudy; }
            set { _fieldOfStudy = value; }
        }
        public double CostPerSemester
        {
            get { return _costPerSemester; }
            set { _costPerSemester = value; }
        }
        public bool DoCreditsTransfer
        {
            get { return _doCreditsTransfer; }
            set { _doCreditsTransfer = value; }
        }

        public string summary()
        {
            return "Name Of University: " + _name + " || Location of University: " + _location +
                " || Field of Study: " + _fieldOfStudy + " || Cost Per Semester: " + _costPerSemester.ToString("c") +
                " || Will Credits Transfer: " + _doCreditsTransfer.ToString();
        }

        public string summary(string name, string location, string fieldOfStudy, double costPerSemester, bool doCreditsTransfer)
        {
            return "Name Of University: " + name + "\nLocation of University: " + location +
                "\nField of Study: " + fieldOfStudy + "\nCost Per Semester: " + costPerSemester.ToString("c") +
                "\nWill Credits Transfer: " + doCreditsTransfer.ToString();
        }

        public string summary(string name, string location, string fieldOfStudy)
        {
            return "Name Of University: " + name + "\nLocation of University: " + location +
                "\nField of Study: " + fieldOfStudy;
        }
    }
}
