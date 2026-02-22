using System.Reflection.Emit;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        string input = "";
        while ((input = Console.ReadLine()) != "end")
        {
            string[] temp = input.Split();

            Student student = new()
            {
                FirstName = temp[0],
                LastName = temp[1],
                Age = int.Parse(temp[2]),
                HomeTown = temp[3]

            };
            students.Add(student);
        }


        string input2 = Console.ReadLine();

        //foreach (Student student in students)
        //{
        //    if (student.HomeTown == input2)
        //    {
        //        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");


        //    }
        //}
        //List<Student> filteredStudents = students.Where(student => student.HomeTown == input2).ToList();

        students
            .Where(student => student.HomeTown == input2)
            .ToList()
            .ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old."));
    }

}


class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

}
