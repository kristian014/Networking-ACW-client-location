//Demonstrate Sockets
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
   
        class Whois
        {

      public static string Servername = " ";
        public static int PortNumber = 0;
       public static  string Protocol = " ";
       public static string reply = "" ;
       public static int timeout = 1000;
        public static List<string> clientInfo = new List<string>();


        static void Main(string[] args)
            {



             

                try
                {
                    // The purpose of creating this list of strings is to store the arguments from the user
           



                    // This is to check if the argument is less than one. 
                    // If no argument is passed, the webform application is opened
                    if (args.Length == 0)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Locationform());
                       

                        // 
                        //I need to create a boolean method that returns true or false. 
                        // if its true, it goes to the forloop
                        // if it's false, it returns.
                    }


                    else
                    {


                    Servername = "whois.net.dcs.hull.ac.uk";
                    PortNumber = 43;
                    Protocol = "Whois";
                    reply = "OK";
                    int timeout = 1000;
                    List<string> clientInfo = new List<string>();

                    // This goes throug the arguments 
                    // reads which protocol is been used
                    // Reads the port number.
                    // timeout 
                    // Adds the args to the list of string I created above. . 
                    for (int i = 0; i < args.Length; i++)
                        {
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


                                default:


                                    clientInfo.Add(args[i]);
                                    break;

                            }
                        }


                    }



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

                    if (clientInfo.Count < 1)
                    {
                        Console.WriteLine("Please provide atleast one args");
                        return;
                    }

                    // If in the second index in the list which is suppose to be the location is empty,
                    // swtich protocol 
                    else if (clientInfo[1] == null)

                    {


                        switch (Protocol)
                        {
                            case "Whois":
                                sw.WriteLine(clientInfo[0]);
                                sw.Flush();
                                Console.WriteLine(clientInfo[0] + " is " + sr.ReadToEnd());
                                break;

                            case "-h9":
                                sw.WriteLine("GET /" + clientInfo[0]);
                                sw.Flush();
                                string ik = sr.ReadToEnd();
                                string[] j = ik.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                                Console.WriteLine(clientInfo[0] + " is " + j[2]);
                                sw.Flush();
                                break;

                            case "-h1":

                                sw.WriteLine("GET /?name=" + clientInfo[0] + " " + "HTTP/1.1");
                                sw.WriteLine("Host:" + " " + Servername + "\r\n");
                                sw.Flush();


                                string line = sr.ReadLine().Trim();
                                while ((line != "") == true)
                                {
                                    // ignore optional header lines.
                                    line = sr.ReadLine().Trim();
                                }
                                // print to the screen the username "is"
                                Console.Write(clientInfo[0] + " is ");

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

                                }
                                finally
                                {
                                    sr.Close();
                                    sw.Close();
                                    client.Close();

                                }
                                break;




                            case "-h0":
                                sw.WriteLine("GET /?" + clientInfo[0] + " " + "HTTP/1.0" + "\r\n");
                                sw.Flush();

                                string k = sr.ReadToEnd();
                                string[] l = k.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                                Console.WriteLine(clientInfo[0] + " is " + l[2]);
                                sw.Flush();

                                break;

                        }

                        return;
                    }


                    // this is to check for the update of the location. 
                    // If the location is present, and not null, 
                    // swtich protocol to update the location of a username.
                    else if (clientInfo[1] != null)
                    {
                        switch (Protocol)
                        {

                            // this is for Whois protocol. if the user write the below, the server rersponse should be ok according to the ASW.
                            case "Whois":
                                sw.WriteLine(clientInfo[0] + " " + clientInfo[1]);
                                sw.Flush();
                                reply = sr.ReadLine();

                                // This check if the response from the server is ok, the print to the console 
                                if (reply == "OK\r\n")
                                    Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                                else
                                    // if the server response is not ok, then print to the console bad reply and display the reply to the user.
                                    Console.WriteLine("Bad reply: " + reply);
                                sw.Close();
                                break;

                            case "-h9":

                                // if the input from the user is exactly the same as specified in the ASW for update in -0h9 should be as the first line below. 
                                sw.WriteLine("PUT /" + clientInfo[0] + "\r\n");
                                sw.WriteLine(clientInfo[1]);

                                sw.Flush();
                                reply = sr.ReadLine();

                                // the server response should be as the below word
                                if (reply.Equals("HTTP/0.9 200 OK"))
                                    // if the reply is the above, print to the consle the first and second index of the list to the console. 
                                    Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                                else
                                    Console.WriteLine("Bad reply: " + reply);
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
                                    Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1] + "\r\n");
                                else
                                    Console.WriteLine("Bad reply: " + reply);
                                break;

                            case "-h0":
                                sw.WriteLine("POST /" + clientInfo[0] + " " + "HTTP/1.0");
                                sw.WriteLine("Content-Length: " + clientInfo[1].Length);
                                sw.WriteLine();
                                sw.WriteLine(clientInfo[1]);
                                sw.Flush();


                                reply = sr.ReadLine();
                                if (reply.Equals("HTTP/1.0 200 OK"))
                                    Console.WriteLine(clientInfo[0] + " location changed to be " + clientInfo[1]);
                                else
                                    Console.WriteLine("Bad reply: " + reply);
                                break;

                        }
                        return;

                    }

                    else
                    {
                        Console.WriteLine("Invalid protocol type ");
                        return;
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }


            }


        }
    }

