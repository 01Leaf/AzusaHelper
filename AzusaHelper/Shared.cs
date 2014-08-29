using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AzusaHelper
{
    static class Shared
    {
        static public Queue<string> msg = new Queue<string>();

        static public string trigger ="";
        static public string response="";

        static public bool trig_testing = false;
        static public bool testing = false;
    }
}
