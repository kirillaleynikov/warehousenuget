namespace warehouselibrary
{
        public class NugetLogic<T> where T : class
        {
            private List<T> nuget = new List<T>();

            public NugetLogic() { }
            public void Add(T argument)
            {
                nuget.Add(argument);
            }
            public void Remove(T argument)
            {
                nuget.Remove(argument);
            }
            public void Change(T argument, T id)
            {
                var index = nuget.IndexOf(id);
            nuget[index] = argument;
            }
            public List<T> Get()
            {
                return nuget;
            }
        }
}