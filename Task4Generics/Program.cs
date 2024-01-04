namespace Task4Generics
{
    internal class Program
    {
        /*
         — Создать класс УчительСервис и реализовать аналогично проделанному на семинаре;
            — Создать класс УчительВью и реализовать аналогично проделанному на семинаре;
            — Создать класс УчительКонтроллер и реализовать возможность создания,
        редактирования конкретного учителя и отображения списка учителей, имеющихся в системе.

        */
       
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher("Илья","Соломин","Александрович","Физика");
            Teacher teacher2 = new Teacher("Дмитрий", "Дудо", "Васильевич", "Математика");
            List<Teacher> teachers = new List<Teacher> { teacher1, teacher2 };
            TeacherController teacherController = new TeacherController();
            teacherController.InitTeachers(teachers);
            teacherController.Create("Ростислав", "Бекас", "Владимирович", "Физкультура");
            teacherController.printTeachers();
           
        }
    }
}
