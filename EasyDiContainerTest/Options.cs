using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyDiContainerTest
{
    public class Options : IOptions
    {
        private Type DefaultOptionType{get;set;}
        private List<IOption> _Options{get;set;}
        public Options()
        {
            this.DefaultOptionType = typeof(TestOption);
            this._Options = new List<IOption>();
        }
        public void Add(IOption option)
        {
            this._Options.Add(option);
        }

        public void Add(string key, string value)
        {
            IOption opt = (IOption)Activator.CreateInstance(this.DefaultOptionType);
            opt.Key = key;
            opt.Value = value;
            this._Options.Add(opt);
        }

        public string GetValue(string key)
        {
            IOption opt = this._Options.Find(x => x.Key == key);
            return opt.Value;

        }

        public bool ContainsKey(string key)
        {
            return this._Options.Any(x => x.Key == key);
        }
    }
}