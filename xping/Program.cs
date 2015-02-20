using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xping
{
    class Program
    {
        static void Main(string[] args)
        {
            XPinger xp = new XPinger();

            xp.PingHost("google.com");

            var name = Console.ReadLine();
        }

    }
}
