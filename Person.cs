using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public abstract class Person
    {
        private int id; 
        private DateTime dateofBirth;
        private string firstName;    
        private string lastName;
        private string  gender;//true Man false Female
        private string address; 
  

        public Person ()
        {
            firstName = default;
            lastName = default;
            id = default;
            gender = default;
            dateofBirth = default;
            address = default; 
        }
        public Person(int id, string firstName,string lastName, string gender, DateTime  dateofBirth  )
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateofBirth = dateofBirth;
            this.gender = gender;
           
        }
        public Person(string firstName, string lastName, string gender, DateTime dateofBirth , string address )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateofBirth = dateofBirth;
            this.gender = gender;
            this.address = address; 

        }
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }

        public string FIRSTNAME 
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LASTNAME
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime  GetDayOfBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; }
        }
        public string GENDER
        {
            get { return gender;  }
            set { gender = value;  }
        }
        public virtual string PrintDetails()
        {
            return $" ID : {ID}, Full Name : {LASTNAME} {FIRSTNAME}, Date of birth {GetDayOfBirth.ToLongDateString()}, Address: {ADDRESS}";
        }
    }
}