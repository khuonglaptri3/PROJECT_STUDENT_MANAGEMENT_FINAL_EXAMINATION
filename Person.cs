using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public abstract class Person
    {
        private int id; 
        private String name;
        private Date dateofbirth;
        private String firstname;    
        private String lastname; 


        Person ()
        {
            id = default;
            name = default;
            dateofbirth = default; 
        }
        Person(int id, String name, Date dateofbirth)
        {
            this.id = id;
            this.name = name;
            this.dateofbirth = dateofbirth;
        }
        Person (int id , String firstname , String lastname , Date dateofbirth)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.dateofbirth = dateofbirth;
        }    
        String FIRSTNAME
        {
            get { return firstname; }
            set { firstname = value; }
        }
        string LASTNAME
        {
            get { return lastname; }
            set { lastname = value; }
        }
        int ID
        {
            get { return id; }
            set { id = value; }
        }
        String NAME
        {
            get { return name; }
            set { name = value; }
        }
        Date DATEOFBIRTH
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }
        public virtual string PrintDetails()
        {
            return $" ID : {ID}, Full Name : {FIRSTNAME} {LASTNAME}, Date of birth {DATEOFBIRTH.ToString()}";
        }
    }
}