namespace RestaurangRegister
{
    internal class Personal
    {
        private string firstName;
        private string lastName;
        private string salary;
        public Personal()
        {

        }   
        public Personal(string firstName, string lastName, string salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
    }
}