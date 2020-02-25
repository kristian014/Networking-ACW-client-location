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
        string reply;

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
            StreamWriter sw = new StreamWriter(client.GetStream());
            StreamReader sr = new StreamReader(client.GetStream());
           client.SendTimeout= 1000;
            client.ReceiveTimeout = 1000;


            if (clientInfo.Count < 1)
            {
                Console.WriteLine("Please provide atleast one args");
                return;
            }

           else if (clientInfo.Count == 1)

            {
               

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
                        Console.WriteLine(clientInfo[0] + " is " + sr.ReadToEnd());
                        break;

                    case "-h0":
                        sw.WriteLine("GET" + " " + "/?" + clientInfo[0] + " " + "HTTP/1.0" + "\r\n");
                      sw.Flush();
                        Console.WriteLine(clientInfo[0] + " is " + sr.ReadToEnd());
                        break;

                }
                
              return;
            }


            else if (clientInfo.Count == 2)
            {
               
                switch (Protocol)
                {
                    case "Whois":
                        sw.WriteLine(clientInfo[0] + " " + clientInfo[1]);
                        sw.Flush();
                        reply = sr.ReadLine();
                        if (reply == "OK")
                            Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                        else
                            Console.WriteLine("Bad reply: " + reply);
                        sw.Close();
                        break;

                    case "-h9":
                        sw.WriteLine("PUT" + " " + "/" + clientInfo[0] + "\r\n");
                        sw.WriteLine(clientInfo[1]);
                        //Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                        sw.Flush();
                        reply = sr.ReadLine();
                        if (reply.StartsWith ("HTTP / 0.9" + " " + 200 + " " + "OK" + "\r\n" ))
                            Console.WriteLine(clientInfo[1] + "\r\n");
                        else
                            Console.WriteLine("Bad reply: " + reply);
                        break;

                    case "-h1":
                        sw.WriteLine("POST" + " " + "/" + " " + "HTTP/1.1");
                        sw.WriteLine("Host:" + " " + Servername);
                        sw.WriteLine("Content-Length:" + " " + clientInfo.Count + "\r\n");
                        sw.WriteLine("name" + "=" + clientInfo[0] + "&" + "location" + "=" + clientInfo[1]);
                        sw.Flush();
                        reply = sr.ReadLine();
                        if (reply.StartsWith  ("HTTP / 1.1" + " " + 200 + " " + "OK" + "\r\n"))
                            Console.WriteLine(clientInfo[1] + "\r\n");
                        else
                            Console.WriteLine("Bad reply: " + reply);
                        break;

                    case "-h0":
                        sw.WriteLine("POST" + " " + "/" + clientInfo[0] + " " + "HTTP/1.0");
                        sw.WriteLine("Content-Length:" + " " + clientInfo.Count + "\r\n");
                        sw.WriteLine(clientInfo[1]);
                        sw.Flush();
                        reply = sr.ReadLine();
                        if (reply.StartsWith ("HTTP / 1.0" + " " + 200 + " " + "OK" + "\r\n"))
                            Console.WriteLine(clientInfo[1] + "\r\n");
                        else
                            Console.WriteLine("Bad reply: " + reply);
                        break;

                }
               return;

            }

            else
            {
                Console.WriteLine("Too many args");
                return;
            }

            //return;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
    }
}