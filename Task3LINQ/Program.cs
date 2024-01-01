namespace Task3LINQ
{
    internal class Program
    {
        /*
          — Создать класс Поток, содержащий в себе список УчебныхГрупп и реализующий интерфейс Iterable;
          — Создать класс StreamComparator, реализующий сравнение количества групп, входящих в Поток;
          — Создать класс ПотокСервис, добавив в него метод сортировки списка потоков, используя созданный StreamComparator;
          — Модифицировать класс Контроллер, добавив в него созданный сервис;
          — Модифицировать класс Контроллер, добавив в него метод, сортирующий список потоков, путём вызова созданного сервиса.

Ф           ормат сдачи: ссылка на гитхаб проект
         */
        static void Main(string[] args)
        {
            StudyStream stream = new StudyStream("Разработчики 30.09.23");
            stream.AddGroup(new StudyGroup("Разработчик 2234", 25));
            stream.AddGroup(new StudyGroup("Разработчик 2233", 20));
            stream.AddGroup(new StudyGroup("Разработчик 2232", 18));
            stream.AddGroup(new StudyGroup("Разработчик 2434", 21));
           
            foreach (StudyGroup group in stream)
            {
                Console.WriteLine(group);
            }

            StudyStream stream2 = new StudyStream("Тестировщики 30.09.23");
            stream2.AddGroup(new StudyGroup("Тестировщик 2234", 25));
            stream2.AddGroup(new StudyGroup("Тестировщик 2233", 20));
            stream2.AddGroup(new StudyGroup("Тестировщик 2232", 18));
            stream2.AddGroup(new StudyGroup("Тестировщик 2434", 21));
            stream2.AddGroup(new StudyGroup("Тестировщик 5423", 11));
            stream2.AddGroup(new StudyGroup("Тестировщик 4333", 12));

            StudyStream stream3 = new StudyStream("Аналитики 30.09.23");
            stream3.AddGroup(new StudyGroup("Тестировщик 2234", 25));
            stream3.AddGroup(new StudyGroup("Тестировщик 2233", 20));
            stream3.AddGroup(new StudyGroup("Тестировщик 2232", 18));
            stream3.AddGroup(new StudyGroup("Тестировщик 2434", 21));
            stream3.AddGroup(new StudyGroup("Тестировщик 2232", 11));
            stream3.AddGroup(new StudyGroup("Тестировщик 2434", 2));
            stream3.AddGroup(new StudyGroup("Тестировщик 5423", 11));
            stream3.AddGroup(new StudyGroup("Тестировщик 4333", 12));

            List<StudyStream> streams = new List<StudyStream>();
            streams.Add(stream);
            streams.Add(stream3);
            streams.Add(stream2);
            Console.WriteLine("Поток:");
            StreamService.PrintStreams(streams);

            Console.WriteLine("Сортировка по возрастанию:");
            StreamService.SortStudyStreamsAsc(streams);

            StreamService.PrintStreams(streams);
            Console.WriteLine("Сортировка по убыванию:");
            StreamService.SortStudyStreamsDsc(streams);
            StreamService.PrintStreams(streams);
        }
    }
}
