namespace FactDiscoveryExtensibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyFacts
    {
        // Should be invoked twice: once with 5 and once with 6.
        [MyFact(5, 2)]
        public void MyOwnFact(int param)
        {
            Console.WriteLine(param);
        }
    }
}
