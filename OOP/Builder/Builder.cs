namespace OOP.Builder
{
    public class Builder
    {
        private Person person;

        public Builder()
        {
            this.person = new Person();
        }

        public Builder WithName(string name)
        {
            this.person.name = name;
            return this;
        }
        
        public Builder WithSurname(string surname)
        {
            this.person.surname = surname;
            return this;
        }
        
        public Builder WithMiddleName(string middlename)
        {
            this.person.middlename = middlename;
            return this;
        }

        public Person build()
        {
            return this.person;
        }
    }
}