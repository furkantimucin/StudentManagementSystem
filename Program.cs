using System.Threading.Channels;
using StudentManagementSystem;

var student = new List<Student>();

var furkan = new Student()
{
  FirstName = "Furkan",
  LastName = "İŞCAN",
  Age = 24,
  Identity = 11111111110
};

var erdal = new Student()
{
  FirstName = "Erdal",
  LastName = "Bakkal",
  Age = 18,
  Identity = 22222222220
};

var ismail = new Student()
{
  FirstName = "İsmail",
  LastName = "Abi",
  Age = 40,
  Identity = 33333333330
};

var mecnun = new Student()
{
  FirstName = "Mecnun",
  LastName = "Çınar",
  Age = 29,
  Identity = 44444444440
};

student.Add(furkan);
student.Add(erdal);
student.Add(ismail);
student.Add(mecnun);

for (int i = 0; i < student.Count; i++)
{
  Console.WriteLine($"{i + 1} : {student[i].FirstName} {student[i].LastName} {student[i].Age} {student[i].Identity}]");
}

foreach (var Student in student)
{
  Console.WriteLine($"{Student.FirstName} \n{Student.LastName} \n{Student.Age} \n{Student.Identity}");
}

Console.Clear();
int inputMenuSelection = MenuHelper.ShowMenu();
switch (inputMenuSelection)
{
  case 1:
    MenuHelper.ListStudents(student);
    break;
  case 2:
    MenuHelper.AddStudent(student);
    Console.ReadKey();
    break;
  case 3:
    MenuHelper.DeleteStudent(student);
    Console.ReadKey();
    break;
  
}