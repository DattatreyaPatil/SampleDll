using System;

namespace FirstSampleDll
{
    using System;

    public class SampleDll1
    {
        public void Output(string s)
        {
            Console.WriteLine(s);
        }

        public string SomeFunction()
        {
            return $"FirstSampleDll.SampleDll1.SomeFunction was called/excuted on {DateTime.Now} ";
        }
    }
}
