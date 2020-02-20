//Demonstrate Sockets
using System;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
public class Whois
{
    static void Main(string[] args)
    {
        String Servername = "localhost";
         int PortNumber = 43;
        String Protocol = "Whois";
       
        String Location = null;
       
        TcpClient client = new TcpClient();
        client.Connect(Servername, PortNumber);

        try
        {
            /*
             * for (int i =0; i < args.Length; i++)
            {

                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());
                i++;

            }*/

            List<string> clientInfo = new List<string>();
           

            for (int i =0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "-h":
                        i++;
                        Servername = args[i];
                        break;

                    case "-p":
                        i++;
                        PortNumber = Int32.Parse(args[i]);

                        break;


                    case "-h0":
                        Protocol = args[i];
                    break;

                    case "-h1":

                        Protocol = args[i];
                        break;

                    case "-h9":

                        Protocol = args[i];
                        break;


                    default:
                        clientInfo.Add(args[i]);
                        //Console.WriteLine($"An unexpected value ({caseSwitch})");
                        break;
                }
            }
           


            if (clientInfo.Count < 1)
            {
                Console.WriteLine("Args should be more than one");
                return;
            }
            else if (clientInfo.Count == 1)
            {

                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());
                sw.WriteLine(args[0]);
                sw.Flush();
                Console.WriteLine(clientInfo[0] + " is " + sr.ReadToEnd());
                return;
            }


            else if (clientInfo.Count == 2)
            {
                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());
                sw.WriteLine(clientInfo[0] + " " + clientInfo[1]);
                sw.Flush();
                Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
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