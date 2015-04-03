namespace _01to03.StudentClass
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhoneNumber;
        private string eMailAddress;
        private int course;

        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress,
            string mobilePhoneNumber, string eMailAddress, int course, Universities university,
            Faculties faculty, Specialties specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhoneNumber = mobilePhoneNumber;
            this.EMailAddress = eMailAddress;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("All students must have first, middle and last name!");                   
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("All students must have first, middle and last name!");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("All students must have first, middle and last name!");
                }

                this.lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("All students must have SSN!");
                }

                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("All students must have an address!");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhoneNumber
        {
            get
            {
                return this.mobilePhoneNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("All students must have a phone number!");
                }

                this.mobilePhoneNumber = value;
            }
        }

        public string EMailAddress
        {
            get
            {
                return this.eMailAddress;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("All students must have an e-mail address!");
                }

                this.eMailAddress = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                if (value < 1 || value > 6)
                {
                    throw new System.ArgumentException("Valid courses are between 1 and 6!");
                }

                this.course = value;
            }
        }

        public Universities University { get; private set; }

        public Faculties Faculty { get; private set; }

        public Specialties Specialty { get; private set; }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (object.Equals(this.SSN, student.SSN))
            {
                return false; // Two people cannot have the same SSN!!!
            }

            return true;
        }

        public override int GetHashCode()
        {
            return SSN.GetHashCode() ^ MobilePhoneNumber.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}\nSSN: {3}\nAddress: {4}\nCell number: {5}\nE-mail: {6}\nCourse :" +
                "{7}\nUniversity: {8}\nFaculty: {9}\nSpecialty: {10}",
                this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
                this.MobilePhoneNumber, this.EMailAddress, this.Course, this.University, this.Faculty, this.Specialty);
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
                this.MobilePhoneNumber, this.EMailAddress, this.Course, this.University, this.Faculty, this.Specialty);
        }

        public int CompareTo(Student otherStudent)
        {
            var thisFullName = this.FirstName + this.MiddleName + this.LastName;
            var otherFullName = this.FirstName + this.MiddleName + this.LastName;
            if (thisFullName.Equals(otherFullName))
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }

            return thisFullName.CompareTo(otherFullName);
        }
    }
}
