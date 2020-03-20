namespace EasyDiContainerTest
{
    public interface IServer
    {
        public IOptions Options{get;}
        public void Log(string message);

    }
}