internal class Program
{

    class Students
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public Students(string firstname, string lastname , double grade)
        {
            FirstName = firstname;
            LastName = lastname;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }

    static void Main(string[] args)
    {

        List<Students> studentsList = new List<Students>();
       

        int n = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            Students student = new Students(input[0], input[1], double.Parse(input[2]));
           

            studentsList.Add(student);

        }

        studentsList = studentsList.OrderByDescending(student => student.Grade).ToList();

        foreach (Students student in studentsList)
        {
            Console.WriteLine(student);
        }

        //foreach (Students student in studentsList)
        //{
        //    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
        //}


    }
}
