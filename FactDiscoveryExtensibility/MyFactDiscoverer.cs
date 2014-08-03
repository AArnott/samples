namespace FactDiscoveryExtensibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xunit.Abstractions;
    using Xunit.Sdk;

    public class MyFactDiscoverer : IXunitTestCaseDiscoverer
    {
        public IEnumerable<IXunitTestCase> Discover(ITestMethod testMethod, IAttributeInfo factAttribute)
        {
            var args = factAttribute.GetConstructorArguments();
            int start = (int)args.First();
            int length = (int)args.Last();
            for (int i = start; i < start + length; i++)
            {
                yield return new MyTestCase(testMethod, new object[] { i });
            }
        }

        private class MyTestCase : XunitTestCase
        {
            public MyTestCase(ITestMethod testMethod, object[] arguments) :
                base(testMethod, arguments)
            {
            }
        }
    }
}
