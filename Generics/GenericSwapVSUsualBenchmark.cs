using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    [MemoryDiagnoser]
    public class GenericSwapVSUsualBenchmark
    {
        [Benchmark]
        public void GenericSwapBenchmark()
        {
            double a = 1.6;
            double b = 2.6;

            Program.GenericSwap(ref a, ref b);
        }

        [Benchmark]
        public void UsualSwapBenchmark()
        {
            object a = 1.6;
            object b = 2.6;

            Program.UsualSwap(ref a, ref b);
        }
    }
}
