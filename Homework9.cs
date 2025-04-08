namespace Homework9
{
    class Student
    {
        private int studentID;
        private string studentName;

        public static List<Student> studentList = new List<Student>();

        public string Name { get { return studentName; } }

        public Student(int id, string name)
        {
            this.studentID = id;
            this.studentName = name;
            studentList.Add(this);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Create 4 students
            new Student(111, "Alice");
            new Student(222, "Bob");
            new Student(333, "Cathy");
            new Student(444, "David");

            // Step 3: Create gradebook
            Dictionary<string, double> gradebook = new Dictionary<string, double>
            {
                { "Alice", 4.0 },
                { "Bob", 3.6 },
                { "Cathy", 2.5 },
                { "David", 1.8 }
            };

            // Step 4: Add Tom if not present
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 3.3;
            }

            // Step 5: Calculate average GPA
            double avgGPA = gradebook.Values.Average();
            Console.WriteLine($"The average GPA is: {avgGPA:F2}");

            // Step 6: Print info of students whose GPA > average
            foreach (var student in Student.studentList)
            {
                if (gradebook.ContainsKey(student.Name) && gradebook[student.Name] > avgGPA)
                {
                    student.PrintInfo();
                }
            }
        }
    }
}