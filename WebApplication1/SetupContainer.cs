using Funq;

namespace WebApplication1
{
    public class SetupContainer
    {
        public static void Setup(Container container)
        {
            container.RegisterAutoWiredAs<Something, ISomething>();
        }
    }

    public class Something : ISomething
    {
        public string Say()
        {
            return "What?";
        }
    }

    public interface ISomething
    {
        string Say();
    }
}