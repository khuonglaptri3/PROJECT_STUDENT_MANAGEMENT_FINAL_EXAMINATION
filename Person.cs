using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public abstract class Person
    {
        private int id; 
        private Date dateofBirth;
        private String firstName;    
        private String lastName;
        private bool gender;//true Man false Female
        private string contactInfo;

        public Person ()
        {
            firstName = default;
            lastName = default;
            id = default;
            gender = default;
            dateofBirth = default;
            contactInfo = default;
        }
        public Person(int id, String firstName,String lastName, bool gender, Date dateofBirth,string contactInfo)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateofBirth = dateofBirth;
            this.gender = gender;
            this.contactInfo = contactInfo;
        }  
        public string GetFirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string GetLastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Date GetDayOfBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; }
        }
        public string GetContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }
        public virtual string PrintDetails()
        {
            return $" ID : {ID}, Full Name : {GetLastName} {GetFirstName}, Date of birth {GetDayOfBirth.ToShortDateString()}, Information to Contact: {GetContactInfo}";
        }
    }
}