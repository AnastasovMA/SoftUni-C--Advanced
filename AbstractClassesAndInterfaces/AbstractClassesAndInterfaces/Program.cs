using System;

namespace AbstractClassesAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var ci = new CInterface();
            Ifc2 ifc2 = new CInterface();
            Ifc3 ifc3 = new CInterface();
            ifc2.Display();
            ifc3.Display();
        }
    }
}
