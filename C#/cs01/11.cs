using System;
namespace Brainchild.Curriculum.Solutions
{
    // Create a Class with your Name Syamil
    // It  should have internal state to keep firstname,middlename and lastname which should hold your actual names. If Middlename is not there, you can keep it as empty
    // A readonly property should be exposed as FullName  which should return your full name .
    public class Sreerag
    {
        public Sreerag()
        {

        }
        public Sreerag(string first, string second, string last)
        {

            firstname = first;
            middlename = second;
            lastname = last;

        }

        string firstname = "";
        string middlename = "";
        string lastname = "";
        private string fullname;

        public string FirstName
        {
            set
            {
                firstname = value;
            }
        }
        public string MiddleName
        {
            set
            {
                if (value != null)
                {
                    middlename = " " + value;
                }
            }
        }
        public string LastName
        {
            set
            {
                lastname = " " + value;
            }
        }
        public string FullName
        {
            get
            {
                fullname = firstname + middlename + lastname;
                return fullname;
            }
        }
    }
}