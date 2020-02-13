//Demonstrate Sockets
using System;
using System.Net.Sockets;
using System.IO;
public class Whois
{
    static void Main(string[] args)
    {

        TcpClient client = new TcpClient();
        client.Connect("whois.net.dcs.hull.ac.uk", 43);

        try
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Args should be more than one");
                return;
            }
            else if (args.Length == 1)
            {

                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());
                sw.WriteLine(args[0]);
                sw.Flush();
                Console.WriteLine(args[0] + " is " + sr.ReadToEnd());
                return;
            }


            else if (args.Length == 2)
            {
                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());
                sw.WriteLine(args[0] + " " + args[1]);
                sw.Flush();
                Console.WriteLine(args[0] + " location changed to be " + args[1]);
                sw.Close();
                return;
            }

            else
            {
                Console.WriteLine("Too many args");
                return;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
    }
}