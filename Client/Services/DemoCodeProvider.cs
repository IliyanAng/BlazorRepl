namespace BlazorRepl.Client.Services
{
    using System.Collections.Generic;
    using static DemoCodeSchema;

    public static class DemoCodeProvider
    {
        public static readonly IDictionary<int, string> DemoCodeMapping = new Dictionary<int, string>()
        {
            {
                CounterDemoId,
                CounterDemoCode
            },
            {
                HttpDemoId,
                HttpDemoCode
            },
            {
                EntryFormDemoId,
                EntryFormDemoCode
            },
        };
    }
}
