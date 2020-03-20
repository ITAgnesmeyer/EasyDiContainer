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

There are some drawbacks. You can only have one Implementation of the an Interface...

Dipl.-Ing.(FH) Guido Agnesmeyer.
