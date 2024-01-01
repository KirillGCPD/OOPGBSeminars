namespace Task3LINQ
{
    public class StudyStreamComparator : IComparer<StudyStream>
    {
        private bool _ascending;
        /// <summary>
        /// ascendin - параметр в какую сторону сортировать
        /// </summary>
        /// <param name="ascending"></param>
        public StudyStreamComparator(bool ascending)
        {
            _ascending = ascending;
        }
        public int Compare(StudyStream? x, StudyStream? y)
        {
            if (x==null) return _ascending ? - 1:1;
            if (y==null) return _ascending ? 1 : -1;
            return _ascending ?  x.Count.CompareTo(y.Count) : y.Count.CompareTo(x.Count);
        }
    }

}