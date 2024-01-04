using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Generics
{
    public class TeacherController : IUserController<Teacher>
    {
        private IUserService<Teacher> _teacherService = new TeacherService();
        private IUserView<Teacher> _teacherView = new TeacherView();
        public Teacher Create(string name, string surname, string patronymic, string discipline)
        {
            var teacher = new Teacher(name, surname, patronymic, discipline);
            _teacherService.Add(teacher);
            return teacher;
        }

        public void InitTeachers(List<Teacher> list)
        {
            _teacherService.InitData(list);
        }
        public void printTeachers()
        {
            _teacherView.SendToConsole(_teacherService.GetAll());
        }
    }
}
