using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3LINQ
{
    public class StreamService
    {
        static public void SortStudyStreamsAsc(List<StudyStream> streams)
        {
            streams.Sort(new StudyStreamComparator(true));
        }
        static public void SortStudyStreamsDsc(List<StudyStream> streams)
        {
            streams.Sort(new StudyStreamComparator(false));
        }
        static public void PrintStreams(List<StudyStream> streams)
        {
            foreach (StudyStream stream in streams)
            {
                Console.WriteLine(stream);
            }
        }
    }
}
