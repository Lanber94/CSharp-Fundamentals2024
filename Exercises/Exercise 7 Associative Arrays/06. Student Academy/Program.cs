using System.Reflection.Emit;

internal class Program
{
/*
5
John
5.5
John
4.5
Alice
6
Alice
3
George
5
*/

    internal class Student
    {

        public List<decimal> Grades { get; set; }
        public string Name { get; set; }
        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }

        public override string ToString()
        {
            string result = $"{Name} -> {Grades.Average():F2}";
            return result;
        }

    }
    
    static void Main(string[] args)
    {
        Dictionary<string, Student> students = new Dictionary<string, Student>();

        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string studentName = Console.ReadLine();
            decimal grade = decimal.Parse(Console.ReadLine());

            if (!students.ContainsKey(studentName))
            {
                students.Add(studentName, new Student(studentName));
            }

            students[studentName].Grades.Add(grade);

        }


        List<Student>/*var*/ filteredStudents = students.Values.Where(pair => pair.Grades.Average() >= 4.50m).ToList();

        foreach (Student student in filteredStudents)
        {
            Console.WriteLine(student.ToString());
        }

        //var filteredStudents = students.Where(pair => pair.Value.Grades.Average() >= 4.50m);

        //foreach(KeyValuePair<string, Student> student in filteredStudents)
        //{
        //    Console.WriteLine(student.Value.ToString());
        //}

    }

}

