namespace Project.Model
{
    public class Employee
    {
        public int Age { get; set; }
        public bool IsSeniorCitizen(int age)
        {
            return age >= 60;
        }
    }
}
