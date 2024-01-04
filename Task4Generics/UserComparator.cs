namespace Task4Generics
{
    public class UserComparator<T> : IComparer<T> where T : User
    {
        public int Compare(T? x, T? y)
        {
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            var str1 = x.Name+x.Surname+x.Patronymic;
            var str2 = y.Name+y.Surname+y.Patronymic;
            return StringComparer.OrdinalIgnoreCase.Compare(str1, str2);
            
        }
    }
}
