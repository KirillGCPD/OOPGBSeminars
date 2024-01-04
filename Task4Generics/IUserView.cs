
namespace Task4Generics
{
    public interface IUserView<T> where T : User
    {
        void SendToConsole(List<T> list);
    }
}