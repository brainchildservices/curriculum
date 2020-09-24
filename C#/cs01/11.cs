using System;
namespace Brainchild.Curriculum.Solutions
{
    // Create a Class with your Name Syamil
    // It  should have internal state to keep firstname,middlename and lastname which should hold your actual names. If Middlename is not there, you can keep it as empty
    // A readonly property should be exposed as FullName  which should return your full name .
    public class Aneesh
    {
        private string firstName = "";
        private string middleName = "";
        private string lastName = "";
        private string fullName;
        //Read-Only Property
        public string FullName
        {
            get
            {
                fullName = firstName + middleName + lastName;
                return fullName;
            }
        }
        public string FirstName
        {
            set
            {
                firstName = value;
            }
        }
        public string MiddleName
        {
            set
            {
                if (value == null)
                    middleName = null;
                else
                    middleName = " " + value;
            }
        }
        public string LastName
        {
            set
            {
                lastName = " " + value;
            }
        }
    }
}
