using System;
using System.Collections;
using static System.Console;

namespace UsingHashtable
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht[3] = "three";
            ht[4.1] = "4.1";

            WriteLine(ht["하나"]);
            WriteLine(ht[3]);
            WriteLine(ht[4.1]);
        }
    }
}
