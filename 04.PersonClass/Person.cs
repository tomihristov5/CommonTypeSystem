namespace _04.PersonClass
{
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("A person should have a name");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0 || value > 200)
                {
                    throw new System.ArgumentException("Age cannot be negative or over 200 :)!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name: {0}, Age: Unknown!", this.Name);
            }

            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
        }
    }
}
