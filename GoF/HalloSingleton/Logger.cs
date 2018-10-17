using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloSingleton
{
    class Logger
    {
        private Logger()
        {
            instance_counter++;
        }
        private static object syncObject = new object();
        private static int instance_counter = 0;
        private static Logger instance;
        public static Logger Instance
        {
            get
            {
                if (instance == null) // Performance, damit Lock nicht unnötig oft aufgerufen wird, sondern nur 1 Mal
                {
                    lock (syncObject)
                    {
                        if (instance == null)
                            instance = new Logger();
                    }
                }

                return instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"{instance_counter}[{DateTime.Now}]: {message}");
            #region String Interpolation

            //// "Normal"
            //Console.WriteLine("Vorname:" + vorname + " Nachname: " + nachname + " Alter:" + alter );

            //// pre C# 6.0
            //// String.Format
            //int zahl1 = 5;
            //int zahl2 = 10;
            ////int erg = zahl1 + zahl2;

            ////Console.WriteLine("Die Summe von {0} und {1} ist {2}",zahl1,zahl2,erg);

            //// C# 6.0 : String-Interpolation
            //Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {zahl1+zahl2}");

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Die Summe von");
            //sb.Append(zahl1); 
            #endregion
        }
    }
}
