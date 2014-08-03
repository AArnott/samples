namespace FactDiscoveryExtensibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xunit;

    public class MyFactAttribute : FactAttribute
    {
        public MyFactAttribute(int start, int length)
        {
            this.Start = start;
            this.Length = length;
        }

        public int Start { get; set; }

        public int Length { get; set; }
    }
}
