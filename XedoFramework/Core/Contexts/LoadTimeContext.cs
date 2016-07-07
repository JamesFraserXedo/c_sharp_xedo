using NUnit.Framework.Compatibility;

namespace XedoFramework.Core.Contexts
{
    public class LoadTimeContext
    {
        public Stopwatch Timer { get; set; }
        public long PageLoadTime { get; set; }
        public long PageContentLoadTime { get; set; }
    }
}
