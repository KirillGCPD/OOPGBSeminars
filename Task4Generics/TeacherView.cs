using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Generics
{
    public class TeacherView : IUserView<Teacher>
    {
        public void SendToConsole(List<Teacher> list)
        {
            foreach (Teacher item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
