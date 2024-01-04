using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Generics
{
    public class UserView<T> : IUserView<T> where T : User
    {
        public void SendToConsole(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
