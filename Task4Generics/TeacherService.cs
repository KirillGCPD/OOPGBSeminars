using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Generics
{
    public class TeacherService : IUserService<Teacher>
    {
        List<Teacher> _teacherList = new List<Teacher>();
        public void Add(Teacher user)
        {
            _teacherList.Add(user);
        }

        public List<Teacher> GetAll()
        {
            return _teacherList;
        }

        public void InitData(List<Teacher> data)
        {
            _teacherList.Clear();
            _teacherList.AddRange(data);
        }
    }
}
