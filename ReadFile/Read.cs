using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    internal class Read
    {
        public   void readf(String name)
        {
            String s;
            try
            {
                StreamReader str = new StreamReader(name);
                 s= str.ReadLine();
                while (s != null)
                {
                    Console.WriteLine(s);
                    s = str.ReadLine();
                }
                str.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
