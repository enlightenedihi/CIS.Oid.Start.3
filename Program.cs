using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.Oid.Start._3
{
    static class Program
    {
        private static string DNA =
        "using System;" +
        "namespace Oid" +
        "{" +
        "    class Program" +
        "    {" +
        "        static void Main(string[] args)" +
        "        {" +
        "        }" +
        "        #point_member_class" +
        "    }" +
        "    #point_member_namespace" +
        "}";

        private static void Main(string[] args)
        {
            Console.WriteLine(DNA);

            //  ANALYZE & MODIFICATION
            ////////////////////////////////////

            //  change signature class
            int position = DNA.IndexOf("#point_member_class");
            DNA = DNA.Insert(position - 1, "void Method() { };");
            position = DNA.IndexOf("#point_member_namespace");
            DNA = DNA.Insert(position - 1, "enum A { AA, BB, CC };");

            Console.ReadLine();
        }

        //~
        //  result

        /*
        using System;
        namespace Oid
        {
             class Program
             {
                 static void Main(string[] args) { }
                 void Method() { };
        #point_member_class
             }
             enum A { AA, BB, CC };
        # point_member_namespace
        }
        */
    }
}