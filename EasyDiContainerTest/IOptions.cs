namespace EasyDiContainerTest
{
    public interface IOptions
    {
        public void Add(IOption option);
        public void Add(string key, string value);
        public string GetValue(string key);
        public bool ContainsKey(string key);
    }
}