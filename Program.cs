namespace NestedObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Advisors mathAdvisor = new Advisors()
            {
                FullName = "Jane Doe",
                Email = "jane.doe@advisor.cptc.edu",
                OfficeLocation = "Building 17, Room 205"
            };

            Students student = new Students() 
            { 
                FirstName = "John",
                LastName = "Doe",
                SchoolEmail = "john.doe@students.cptc.edu",
                PhoneNumber = "253-555-1234",
                DateOfBirth = new DateTime(1990, 1, 1),
                AssignedAdvisor= mathAdvisor
            };

            Console.WriteLine($"Student: {student.FirstName} has {student.AssignedAdvisor.FullName}");
        }
    }
}
