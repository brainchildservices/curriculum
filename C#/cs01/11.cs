using System;
namespace Brainchild.Curriculum.Solutions
{
// Create a Class with your Name Syamil
// It  should have internal state to keep firstname,middlename and lastname which should hold your actual names. If Middlename is not there, you can keep it as empty
// A readonly property should be exposed as FullName  which should return your full name .
    public class Sreerag
    {
        public Sreerag() {

        }
        public Sreerag(string enteredname) {
           
            String[] split = {" "}; 
            String[] stringlist = enteredname.Split(split,StringSplitOptions.RemoveEmptyEntries); 
            if(stringlist.Length==3) {
                 FirstName =stringlist[0];
                 MiddleName =stringlist[1];
                 LastName = stringlist[2];
            } else {
                 FirstName =stringlist[0];
                 LastName = stringlist[1];
            }

        }
       
        string firstname="";
        string middlename="";
        string lastname="";
        private string fullname;
         
        public string FirstName
        {
            set {
                firstname=value;
            }
        }
        public string MiddleName
        {
            set {
               if( value != null) {
                  middlename = " "+value; 
               }
            } 
        }
        public string LastName
        {
            set {
                lastname = " "+value;
            }
        }
       public string FullName
        {
            get {
                fullname = firstname+middlename + lastname;
                return fullname;
            }
        }
    }
}