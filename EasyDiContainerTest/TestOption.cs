using System;

namespace EasyDiContainerTest
{
    public class TestOption : IOption
    {
        
        public string Key { get; set; }
        public string Value { get; set; }
        public Type Type
        {
            get => typeof(TestOption);
        }
    }
}