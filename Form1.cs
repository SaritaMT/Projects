//SARITA TIGADI
//1001634958
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClientApplication
{
    public partial class Form1 : Form
    {
        public static string serverData;      
        TcpClient socketForServer  = new TcpClient();
        public static NetworkStream networkStream;

        public Form1()
        {
            InitializeComponent();
            ConnectToServer();        
        }
        /// <summary>
        ///The ConnectToServer() function connects the client to the server. The connection parameters used are "localHost" and port 10 since the
        ///server is also configured to the same.
        /// </summary>
        ///
        private void ConnectToServer()
        {
            labelServerData.Text = "Not Connected To Server";
            socketForServer.Connect("localHost", 10);
            labelServerData.Text = "Connected To Server";
        }

        /// <summary>
        ///The buttonRegister_Click() event is invoked when the Register button is clicked.
        ///The data is written from the specific client to the server over the networkStream.
        ///server is also configured to the same.
        ///The Message sent is concatenated HTTP String format
        /// </summary>
        ///
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            /// Reference https://www.infoworld.com/article/3016922/application-development/how-to-work-with-sockets-in-c.html
            /// Reference https://www.codeproject.com/Questions/621289/get-http-request-header-values-in-to-csharp

            networkStream = socketForServer.GetStream();
            if (socketForServer.Connected)
            {
                /// Reference https://developer.mozilla.org/en-US/docs/Web/HTTP/Messages
                
                string registerClientRequest = "{'ClientName':'" + textBoxRegister.Text + "'}";
                HttpPOSTMessage.HttpBody = registerClientRequest;
                HttpPOSTMessage.HttpContentLength = "Content - Length:" + registerClientRequest.Length.ToString() + "\r\n";
               
                byte[] requestStream = System.Text.Encoding.ASCII.GetBytes(HttpPOSTMessage.HttpRequesteType  + HttpPOSTMessage.HttpHost +
                    HttpPOSTMessage.HttpUserAgent + HttpPOSTMessage.HttpContentType + HttpPOSTMessage.HttpContentLength + HttpPOSTMessage.HttpBody);

                byte[] serverMessage = new byte[1024];
                byte[] myWriteBuffer = requestStream;
                networkStream.Write(myWriteBuffer, 0, myWriteBuffer.Length);

                // Start a thread to listen to the Server
                Thread newThread = new Thread(new ThreadStart(listenToServer));
                newThread.Start();
            }
            else
            {
                labelServerData.Text = "Server Not Started";
            }
        }

        /// <summary>
        ///The buttonSendServer_Click() event is invoked on click of the "Send To Server" button.
        ///The following fields have to be filled - Message , Delivery option and client Name .
        ///These values are sent as part the data to the server. The server will be parsing these parameters to make specific 
        ///decisions
        /// </summary>
        private void buttonSendServer_Click(object sender, EventArgs e)
        {
            ///Reference https://www.infoworld.com/article/3016922/application-development/how-to-work-with-sockets-in-c.html
            
            TcpClient socketForServer;
            socketForServer = new TcpClient("localHost", 10);
            networkStream = socketForServer.GetStream();
            if (socketForServer.Connected)
            {
                string textMessage = textBoxMessage.Text.ToString();
                string option = comboBoxDeliveryOption.Text.ToString();
                string destinationClient = " ";
                if (option.ToString() == "option1")
                {                  
                    destinationClient = textBoxDestinationClientName.Text.ToString();
                }
                /// Reference : https://forum.uipath.com/t/how-to-create-json-body-text-in-http-request/268/11
                /// Reference : https://weblog.west-wind.com/posts/2015/mar/31/prettifying-a-json-string-in-net

                string sendRequest = "{'ClientName':'" + textBoxRegister.Text + "','textMessage':'" + textMessage.ToString() + "','option':'" + option.ToString() + "','destinationClient':'" + destinationClient.ToString() + "'}";
                HttpPOSTMessage.HttpBody = sendRequest;              
                HttpPOSTMessage.HttpContentLength = "Content - Length:" + sendRequest.Length.ToString() + "\r\n";
                byte[] requestStream = System.Text.Encoding.ASCII.GetBytes(HttpPOSTMessage.HttpRequesteType + HttpPOSTMessage.HttpHost
                    + HttpPOSTMessage.HttpUserAgent + HttpPOSTMessage.HttpContentType + HttpPOSTMessage.HttpContentLength + HttpPOSTMessage.HttpBody);

                byte[] myWriteBuffer = requestStream;
                networkStream.Write(myWriteBuffer, 0, myWriteBuffer.Length);
            }
        }

        /// <summary>
        ///The comboBoxDeliveryOption_SelectedIndexChanged() enables and disables the Destination Field label and Textbox
        ///based on whether the value is "option1" or "option2".        
        /// </summary>
        
        private void comboBoxDeliveryOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = comboBoxDeliveryOption.Text.ToString();
            if (option.ToString() == "option1")
            {
                labelDestinationClientName.Enabled = true;
                textBoxDestinationClientName.Enabled = true;
            }
            else
            {
                labelDestinationClientName.Enabled = false;
                textBoxDestinationClientName.Enabled = false;
            }
        }

        /// <summary>
        ///The listenToServer() function is invoked to listen to the server when the data is sent.
        ///The data will be sent from server in HTTP concatenated format.
        /// </summary>
        private void listenToServer()       
        {
            byte[] serverMessage = new byte[1024];
            int numberOfBytesRead = 0;
            string serverData;
          
            if (socketForServer.Connected)
            {
                networkStream = socketForServer.GetStream();
                numberOfBytesRead = networkStream.Read(serverMessage, 0, serverMessage.Length);
                serverData = Encoding.ASCII.GetString(serverMessage, 0, numberOfBytesRead);
                string[] clientDataArray = serverData.Split('\n');               
                serverData = clientDataArray[3].ToString();
                textBoxDataFromServer.Text = serverData.ToString();
            }
        }

        /// <summary>
        ///The buttonDisconnect_Click() function is used to close the client application
        /// </summary>
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            TcpClient socketForServer;
            socketForServer = new TcpClient("localHost", 10);
            networkStream = socketForServer.GetStream();
            if (socketForServer.Connected)
            {
                string textMessage = "Disconnect";
                string sendRequest = "{'ClientName':'" + textBoxRegister.Text + "','textMessage':'" + textMessage.ToString() + "'}";
                HttpPOSTMessage.HttpBody = sendRequest;
                HttpPOSTMessage.HttpContentLength = "Content - Length:" + sendRequest.Length.ToString() + "\r\n";
                byte[] requestStream = System.Text.Encoding.ASCII.GetBytes(HttpPOSTMessage.HttpRequesteType + HttpPOSTMessage.HttpHost
                    + HttpPOSTMessage.HttpUserAgent + HttpPOSTMessage.HttpContentType + HttpPOSTMessage.HttpContentLength + HttpPOSTMessage.HttpBody);

                byte[] myWriteBuffer = requestStream;
                networkStream.Write(myWriteBuffer, 0, myWriteBuffer.Length);
                labelServerData.Text = "Disconnected To Server";
            }

            foreach (System.Diagnostics.Process myProc in System.Diagnostics.Process.GetProcesses())
            {
                if (myProc.ProcessName == "ClientApplication")
                {
                    myProc.Kill();
                }
            }
            socketForServer.Close();
        }
    }

    /// <summary>
    ///The HttpPOSTMessage class has the HTTP fields and formats defined that will be used by the client to format the data
    ///in HTTP String concatenated form
    /// </summary>
    public static class HttpPOSTMessage
    {
        public static string HttpHost = "Host:127.0.0.1\r\n";
        public static string HttpUserAgent = "User-Agent:ClientApplication\r\n";
        public static string HttpContentType = "Content-Type: text/json\r\n";       
        public static string HttpContentLength = "";
        public static string HttpRequesteType = "POST ServerApplication HTTP/1.1\r\n";   
        public static string HttpBody = "";
    }

    /// <summary>
    ///The HttpGETMessage class has the HTTP fields and formats defined that will be used by the client to format the data
    ///in HTTP String concatenated form
    /// </summary>
    public static class HttpGETMessage
    {
        public static string HttpHost = "Host:127.0.0.1\r\n";
        public static string HttpUserAgent = "User-Agent:ClientApplication\r\n";
        public static string HttpContentType = "Content-Type: text/json\r\n";
        public static string HttpContentLength = "";
        public static string HttpRequesteType = "GET ServerApplication HTTP/1.1\r\n";
        public static string HttpBody = "";
    }
}

