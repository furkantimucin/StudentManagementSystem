namespace StudentManagementSystem;

public static class MenuHelper
{
    public static int ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Ne yapmak istersin?");
        Console.WriteLine("1. Öğrencileri Listele");
        Console.WriteLine("2. Öğrenci Ekle");
        Console.WriteLine("3. Öğrenci Silme");
        Console.WriteLine("4. Çıkış Yap\n");
        Console.Write("Seçimin:");
        return int.Parse(Console.ReadLine());

    }


    public static void ListStudents(List<Student> students)
    {
        Console.Clear();
        foreach (var student in students)
        {
            Console.WriteLine($"{student.FirstName} \n{student.LastName} \n{student.Age}\n{student.Identity}");
        }
        
    }
    public static void AddStudent(List<Student> students)
    {
        Console.Clear();
        var newStudent = new Student();

        Console.Write("Ad: ");
        newStudent.FirstName = Console.ReadLine();

        Console.Write("Soyad: ");
        newStudent.LastName = Console.ReadLine();

        Console.Write("Yaş: ");
        newStudent.Age = int.Parse(Console.ReadLine());

        Console.Write("Kimlik No: ");
        newStudent.Identity = long.Parse(Console.ReadLine());

        students.Add(newStudent);
        Console.WriteLine("\nÖğrenci başarıyla eklendi!");
    }

    public static void DeleteStudent(List<Student> students)
    {
        Console.Clear();
        ListStudents(students);

        if (students.Count == 0 && students.Count >= 5 )
            return;

        Console.Write("\nSilmek istediğiniz öğrencinin numarasını girin: ");
        if (int.TryParse(Console.ReadLine(), out int studentNumber))
        {
            studentNumber--; 

            if (studentNumber >= 0 && studentNumber < students.Count)
            {
                var deletedStudent = students[studentNumber];
                students.Remove(deletedStudent);
                Console.WriteLine($"\n{deletedStudent.FirstName} {deletedStudent.LastName} başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Geçersiz sıra numarası!");
            }
        }
      
    }
}



  