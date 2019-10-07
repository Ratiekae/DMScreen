using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMScreen.DMObjects
{
    public class NPCObjects
    {
        private string _firstname;
        private string _lastname;
        private int _age;
        private string _gender;
        private string _bond;
        private string _appearance;
        private List<string> _ideals;
        private List<string> _flaworsecret;


        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Bond
        {
            get { return _bond; }
            set { _bond = value; }
        }
        public string Appearance
        {
            get { return _appearance; }
            set { _appearance = value; }
        }
        public List<string> Ideals
        {
            get { return _ideals; }
            set { _ideals = value; }
        }
        public List<string> FlawOrSecret
        {
            get { return _flaworsecret; }
            set { _flaworsecret = value; }
        }
    }
}
