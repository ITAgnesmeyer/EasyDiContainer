# EasyDiContainer
Verry simple DI-Container

```c#
public class Server:IServer
{
  private ILog _Logging;
  public Server(ILog log)
  {
    this._Logging = log
  }
  public void Log(string message)
  {
    this._Logging.Write(message);
  }
  
}

var container = new DiContainer();
container.Register< ILog,Log>();

var server = container.Create<IServer>();
server.Log("hallo Welt");
```

Of course there are some disadvantages. For example, an interface can only be implemented once.
Basically, however, this clarifies the principle.

Dipl.-Ing.(FH) Guido Agnesmeyer. 2020
