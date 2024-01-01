using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3LINQ
{
    public class StudyStream : IEnumerable<StudyGroup>, IComparable<StudyStream>
    {
        public string Name { get; set; }
        List<StudyGroup> _studyGroups;
        public StudyStream(string name)
        {
            _studyGroups = new List<StudyGroup>();
            Name = name;
        }
        public void AddGroup(StudyGroup group)
        {
            _studyGroups.Add(group);
        }

        public int CompareTo(StudyStream? other)
        {
            if (other == null) return -1;
            return _studyGroups.Count.CompareTo(other._studyGroups.Count);
        }

        public IEnumerator<StudyGroup> GetEnumerator()
        {
            return _studyGroups.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _studyGroups.GetEnumerator();
        }
        public int Count { get { return _studyGroups.Count; } }
        public override string ToString()
        {
            return $"Поток: {Name}. Количество групп: {Count}";
        }
    }

}