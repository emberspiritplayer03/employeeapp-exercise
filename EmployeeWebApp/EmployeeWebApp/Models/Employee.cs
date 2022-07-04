namespace EmployeeWebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmpNo { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Birthdate { get; set; }
        public int ContactNo { get; set; }
        public string EmailAddress { get; set; }

        public Employee()
        {

        }
    }
}
