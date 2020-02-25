//Demonstrate Sockets
using System;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
public class Whois
{
    static void Main(string[] args)
    {
        String Servername = "whois.net.dcs.hull.ac.uk";
        int PortNumber = 43;
        String Protocol = "Whois";


        try
        {
            
            List<string> clientInfo = new List<string>();


            for (int i = 0; i < args.Length; i++)
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

                    case "Whois":

                        Protocol = args[i];

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

            TcpClient client = new TcpClient();
            client.Connect(Servername, PortNumber);
            

            if (clientInfo.Count == 1)

            {
                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());

                switch (Protocol)
                {
                    case "Whois":
                        sw.WriteLine(clientInfo[0]);
                        sw.Flush();
                        Console.WriteLine(clientInfo[0] + " is " + sr.ReadToEnd());
                        break;

                    case "-h9":
                        sw.WriteLine("GET" + " " + "/" + clientInfo[0] );
                         sw.Flush();
                        Console.WriteLine(clientInfo[0] + " is " + sr.ReadToEnd());
                        break;

                    case "-h1":
                        sw.WriteLine("GET" + " " + "/?" + "name" + "=" + clientInfo[0] + " " + "HTTP/1.1");
                        sw.WriteLine("Host:" + " " + Servername + "\r\n");
                        sw.Flush();
                        break;

                    case "-h0":
                        sw.WriteLine("GET" + " " + "/?" + clientInfo[0] + " " + "HTTP/1.0" + "\r\n");
                       Console.WriteLine(clientInfo[0] + " is " + sr.ReadToEnd());
                        sw.Flush();
                        break;

                }
                
               return;
            }


            else if (clientInfo.Count == 2)
            {
                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());

                switch (Protocol)
                {
                    case "Whois":
                        sw.WriteLine(clientInfo[0] + " " + clientInfo[1]);
                        sw.Flush();
                        Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                        sw.Close();
                        break;

                    case "-h9":
                        sw.WriteLine("PUT" + " " + "/" + clientInfo[0] + "\r\n");
                        sw.WriteLine(clientInfo[1]);
                        sw.Flush();
                         //Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                        break;

                    case "-h1":
                        sw.WriteLine("POST" + " " + "/" + " " + "HTTP/1.1");
                        sw.WriteLine("Host:" + " " + Servername);
                        sw.WriteLine("Content-Length:" + " " + clientInfo.Count + "\r\n");
                        sw.WriteLine("name" + "=" + clientInfo[0] + "&" + "location" + "=" + clientInfo[1]);
                        sw.Flush();

                        break;

                    case "-h0":
                        sw.WriteLine("POST" + " " + "/" + clientInfo[0] + " " + "HTTP/1.0");
                        sw.WriteLine("Content-Length:" + " " + clientInfo.Count + "\r\n");
                        sw.WriteLine(clientInfo[1]);
                        sw.Flush();
                        break;

                }
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