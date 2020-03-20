using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EasyDiContainer
{
    public class DiContainer
    {
        private readonly Dictionary<Type, Type> _Types = new Dictionary<Type, Type>();
 
        public void Register<T, TI>() where TI : T 
        {
            this._Types[typeof(T)] = typeof(TI);
        }
 
        public T Create<T>()
        {
            return (T)Create(typeof(T));
        }
 
        private object Create(Type type)
        {
            
            Type concreteType = this._Types[type];
            ConstructorInfo constructor = concreteType.GetConstructors()[0]; 
            ParameterInfo[] paramInfos = constructor.GetParameters();
            object[] parameters = paramInfos.Select(CreateParameterItem).ToArray();
 
            return constructor.Invoke(parameters);
        }

        private object CreateParameterItem(ParameterInfo param)
        {
            //calls the constructor of each item!
            return Create(param.ParameterType);
        }
    }
}