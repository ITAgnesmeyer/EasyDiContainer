using System.Runtime.CompilerServices;
using EasyDiContainer;

namespace EasyDiContainerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new DiContainer();
            
 
            container.Register< IServer,Server>();
            container.Register< ILog,Log>();
            container.Register<IOptions, Options>();
            container.Register<IOption, TestOption>();
 
            var welcomer = container.Create<IServer>();
            welcomer.Log("Hallo Welt!");
            if (welcomer.Options.ContainsKey("hallo"))
            {
                welcomer.Log(welcomer.Options.GetValue("hallo"));
            }
        }
    }
}
