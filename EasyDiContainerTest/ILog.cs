namespace EasyDiContainerTest
{
    public interface ILog
    {
        public int LogLevel{get;set;}

        public void Write(string message);
    }
}