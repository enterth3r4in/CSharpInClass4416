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

    }
}
