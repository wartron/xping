using System;
using System.Net.NetworkInformation;

namespace xping
{
    public class XPinger{
    
        int delayMs = 1000;

        public XPinger()
        {

        }

        public bool PingHost(string nameOrAddress)
        {
            int pings = 4;

            bool pingable = false;
            Ping pinger = new Ping();

            string hostnamestring = "127.0.0.1 [testasasdasdasd]";
            string stx = String.Format("\nPinging {0} with 32 bytes of data:\n",hostnamestring);
            Console.Write(stx);

            while (pings>0)
            {
                pings--;
                try
                {
                    PingReply reply = pinger.Send(nameOrAddress);

                    pingable = reply.Status == IPStatus.Success;

                    string st = String.Format("Reply from {0}: time={1}ms\n", reply.Address.ToString(), reply.RoundtripTime.ToString());
                    Console.Write(st);

                    System.Threading.Thread.Sleep(delayMs);
                }
                catch (PingException)
                {
                    // Discard PingExceptions and return false;
                    Console.Write("failed");
                }

            }

            return pingable;
        }

    }
}