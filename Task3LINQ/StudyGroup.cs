namespace Task3LINQ
{
    public class StudyGroup
    {
        public StudyGroup(string number, int count) {
            Number = number;
            PupilCount = count;
        }
        public string Number { get; set; }
        public int PupilCount { get; set; }

        public override string ToString()
        {
            return $"Группа: {Number}. Количество учеников: {PupilCount}";
        }
    }
}