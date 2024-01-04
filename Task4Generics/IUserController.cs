using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Generics
{
    public interface IUserController<T> where T : User
    {
        public T Create(String name, String surname, String patronymic, string discipline);
    }
}
