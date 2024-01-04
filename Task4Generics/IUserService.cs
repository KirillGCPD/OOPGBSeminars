using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Generics
{
    public interface IUserService<T> where T: User
    {
        public List<T> GetAll();
        public void InitData(List<T> data);
        void Add(T user);
    }
}
