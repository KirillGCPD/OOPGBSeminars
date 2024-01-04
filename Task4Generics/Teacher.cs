using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Generics
{
    public class Teacher : User
    {
        public string Discipline { get; set; }
        public Teacher(string name, string surname, string patronymic, string discipline) : base(name, surname, patronymic)
        {
            Discipline = discipline;
        }
        public override string ToString()
        {
            return base.ToString()+$" Предмет: {Discipline}";
        }
    }
}
