using System;
using System.Reflection;

namespace EasyDiContainer
{
    public static class MinimalContainerExtension
    {
        public static DiContainer Create( this DiContainer input)
        {
            DiContainer container = new DiContainer();
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (Type type in assembly.GetTypes())
            {
                var interfaces = type.GetInterfaces();
                foreach (Type interfaceType in interfaces)
                {
                    var types = assembly.GetTypes();
                    foreach (Type type1 in types)
                    {
                        if (type.IsAssignableFrom(interfaceType))
                        {

                        }
                        

                    }
                }
            }

            return container;
        }
    }
}