using System;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Drawing.Drawing2D;

/// <summary>
/// This program is a client application that 
/// can connect to a server, send argurments and get replies 
/// as specified in the ASW. 
/// </summary>
/// 

namespace location
{



    public class Whois
    {



       static String Servername = "whois.net.dcs.hull.ac.uk";
        static int PortNumber = 43;
        static String Protocol = "whois";
        static String reply = "OK";
        static int timeout = 1000;
        static string response;
        public static List<string> clientInfo = new List<string>();
        static bool debugging = false;

        public static void Main(string[] args)
        {
          

            try {

                // The purpose of creating this list of strings is to store the arguments from the user



                // This is to check if the argument is less than one. 
                // If no argument is passed, the webform application is opened
                if (args.Length <= 0)
                {

                    List<string> clientInfo = new List<string>();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Locationform info = new Locationform();
                    Application.Run(new lacationform2());

                    Servername = info.m_servername;
                    timeout = int.Parse(info.m_timeout);
                    PortNumber = int.Parse(info.m_portnumber);
                    Protocol = info.m_protocol;
                    response = info.m_response;

                    // clientInfo = info.m_username;
                    //Whois.clientInfo.Add(info.m_username);
                    //Whois.clientInfo.Add(info.m_location);
                    // timeout = 1000;

                }





                else
                {
                    Servername = "whois.net.dcs.hull.ac.uk";
                    Protocol = "Whois";
                    PortNumber = 43;
                    timeout = 1000;





                    //else
                    //{
                    //    // continue 
                    //}







                    for (int i = 0; i < args.Length; i++)
                    {
                        if (debugging) Console.WriteLine(args[i]);
                        switch (args[i])
                        {
                            case "-t":

                                i++;
                                timeout = int.Parse(args[i]);
                                break;




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
                            case "-d":
                                debugging = true;
                                break;


                            default:


                                clientInfo.Add(args[i]);
                                break;

                        }
                    }

                }


                

                if (debugging == true) Console.WriteLine($"Servername: {Servername}",  $"Portnumber: {PortNumber}");
                // After going through all the arguments, then you can connect
                // By creating a tcp client and and calling the .connect method
               
            
                TcpClient client = new TcpClient();
                client.Connect(Servername, PortNumber);

                client.SendTimeout = timeout;
                client.ReceiveTimeout = timeout;

                // Using the stream writer to write to the server and a stream reader to read the reply from the server
                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());

                // this checks if the list has any values in it. 
                // if there is not value, then write to the console argurment should be more than one. 

                // If in the second index in the list which is suppose to be the location is empty,
                // swtich protocol 

                if (clientInfo.Count == 1)

                {


                    switch (Protocol)
                    {
                        case "Whois":
                            sw.WriteLine(clientInfo[0]);
                            sw.Flush();

                            string reply_fromserver = sr.ReadToEnd();
                            if (!reply_fromserver.Equals("ERROR: no entries found"))
                            {
                                Console.WriteLine(clientInfo[0] + " is " + reply_fromserver);
                                response = clientInfo[0] + " is " + reply_fromserver;
                                debugging = true;
                            }

                            else
                            {
                                Console.WriteLine("ERROR: no entries found");
                                response = "ERROR: no entries found";
                            }
                            break;

                        case "-h9":
                            sw.WriteLine("GET /" + clientInfo[0]);
                            sw.Flush();

                            string ik = sr.ReadToEnd();

                            string[] j = ik.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                            if (((j[0].StartsWith("HTTP/0.9 200 OK")) && j[1].StartsWith("Content-Type: text/plain")))
                            {

                                Console.WriteLine(clientInfo[0] + " is " + j[2]);
                                response = clientInfo[0] + " is " + j[2];
                                debugging = true;
                            }
                            else
                            {
                                Console.WriteLine("HTTP / 0.9 404 Not Found\r\n" + "Content - Type: text / plain\r\n\r\n");
                                response = "HTTP / 0.9 404 Not Found\r\n" + "Content - Type: text / plain\r\n\r\n";
                            }

                            // Console.WriteLine(clientInfo[0] + " is " + j[2]);
                            sw.Flush();
                            break;

                        case "-h1":
                            if (PortNumber != 80)
                            {
                                sw.WriteLine("GET /?name=" + clientInfo[0] + " " + "HTTP/1.1");
                                sw.WriteLine("Host:" + " " + Servername + "\r\n");
                                sw.Flush();

                                string Read_alllines = sr.ReadToEnd();
                                string[] Get_IndividualLines = Read_alllines.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                                if ((((Get_IndividualLines[0].StartsWith("HTTP/1.1 200 OK")) && Get_IndividualLines[1].StartsWith("Content-Type: text/plain") && PortNumber != 80)))
                                {

                                    Console.WriteLine(clientInfo[0] + " is " + Get_IndividualLines[2]);
                                    response = clientInfo[0] + " is " + Get_IndividualLines[2];
                                    debugging = true;
                                    return;
                                }
                                else
                                {

                                    Console.WriteLine("HTTP / 1.0 404 Not Found\r\n" + "Content - Type: text / plain\r\n\r\n");
                                    response = "HTTP / 1.0 404 Not Found\r\n" + "Content - Type: text / plain\r\n\r\n";
                                }
                            }



                            else if (PortNumber == 80) //This if statment handles the html responce
                            {
                                sw.WriteLine("GET /?name=" + clientInfo[0] + " " + "HTTP/1.1");
                                sw.WriteLine("Host:" + " " + Servername + "\r\n");
                                sw.Flush();
                                string Readhtml_line = sr.ReadLine();


                                while ((Readhtml_line != "") == true)
                                {

                                    Readhtml_line = sr.ReadLine().Trim();
                                }

                                Console.Write(clientInfo[0] + " is " + Readhtml_line);
                                response = clientInfo[0] + " is " + Readhtml_line;
                                debugging = true;
                                try
                                {
                                    int c;
                                    while ((c = sr.Read()) > 0)
                                    {
                                        Console.Write((char)c);

                                    }

                                }
                                catch
                                {
                                    //
                                }
                            }
                            break;





                        case "-h0":
                            sw.WriteLine("GET /?" + clientInfo[0] + " " + "HTTP/1.0" + "\r\n");
                            sw.Flush();

                            string k = sr.ReadToEnd();
                            string[] l = k.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);


                            if (((l[0].StartsWith("HTTP/1.0 200 OK")) && l[1].StartsWith("Content-Type: text/plain")))
                            {

                                Console.WriteLine(clientInfo[0] + " is " + l[2]);
                                response = clientInfo[0] + " is " + l[2];
                                debugging = true;
                            }
                            else
                            {
                                Console.WriteLine("HTTP / 1.0 404 Not Found\r\n" + "Content - Type: text / plain\r\n\r\n");
                                response = "HTTP / 1.0 404 Not Found\r\n" + "Content - Type: text / plain\r\n\r\n";
                            }

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
                            {
                                Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                                response = clientInfo[0] + " location changed to be " + clientInfo[1];
                                debugging = true;
                            }

                            else
                            {
                                Console.WriteLine("Bad reply: " + reply);
                                response = "Bad reply: " + reply;
                                debugging = true;
                            }

                            sw.Close();
                            break;

                        case "-h9":
                            sw.WriteLine("PUT /" + clientInfo[0] + "\r\n");
                            sw.WriteLine(clientInfo[1]);

                            sw.Flush();
                            reply = sr.ReadLine();

                            if (reply.Equals("HTTP/0.9 200 OK"))
                            {
                                Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                                response = clientInfo[0] + " location changed to be " + clientInfo[1];
                                debugging = true;
                            }
                            //

                            else
                            {
                                Console.WriteLine("Bad reply: " + reply);
                                response = "Bad reply: " + reply;
                            }

                            break;

                        case "-h1":
                            sw.WriteLine("POST / HTTP/1.1");
                            sw.WriteLine("Host:" + " " + Servername);
                            string i = "name=" + clientInfo[0] + "&location=" + clientInfo[1];
                            sw.WriteLine("Content-Length:" + " " + i.Length);
                            sw.WriteLine();
                            sw.Write(i);
                            sw.Flush();


                            reply = sr.ReadLine();
                            if (reply.Equals("HTTP/1.1 200 OK"))
                            {
                                Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1] + "\r\n");
                                response = clientInfo[0] + " location changed to be " + clientInfo[1];
                                debugging = true;
                            }

                            else
                            {
                                Console.WriteLine("Bad reply: " + reply);
                                response = "Bad reply: " + reply;
                            }

                            break;

                        case "-h0":
                            sw.WriteLine("POST /" + clientInfo[0] + " " + "HTTP/1.0");
                            sw.WriteLine("Content-Length: " + clientInfo[1].Length);
                            sw.WriteLine();
                            sw.WriteLine(clientInfo[1]);
                            sw.Flush();


                            reply = sr.ReadLine();
                            if (reply.Equals("HTTP/1.0 200 OK"))
                            {
                                Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                                response = clientInfo[0] + " location changed to be " + clientInfo[1];
                                debugging = true;
                            }

                            else
                            {
                                Console.WriteLine("Bad reply: " + reply);
                                response = "Bad reply: " + reply;
                            }

                            break;

                    }
                    return;

                }


                else
                {
                    Console.WriteLine("Too many args");
                    response = "Too many args";
                    return;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            if (debugging == true)
            {
                Console.WriteLine($"Servername: {Servername}", $"Portnumber: {PortNumber}" ,
                    $"clieninfo[0]: {clientInfo[0]}", $"clientinfo[1]: {clientInfo[1]} ");
            }
        }

    }
    }

