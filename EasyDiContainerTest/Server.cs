namespace EasyDiContainerTest
{
    public class Server : IServer
    {
        private ILog _Logging;
       

        public Server(ILog log,IOptions options)
        {
            this._Logging = log;
            this.Options = options;
            this.Options.Add("hallo", "welt");
        }

        public IOptions Options { get; }

        public void Log(string message)
        {
            this._Logging.Write(message);
        }
    }
}