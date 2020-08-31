using System;
using System.Xml;

namespace ClassDemoXml
{
    internal class XmlWorker
    {
        private int serverPort = 0;
        private string serverName = "";

        public XmlWorker()
        {
        }

        public void Start()
        {
            XmlDocument xmlDoc = new XmlDocument(); 
            xmlDoc.Load( "XmlDemo.xml");

            XmlNode serverPortNode = xmlDoc.DocumentElement.SelectSingleNode("ServerPort");
            if (serverPortNode != null)
            {
                String serverPortStr = serverPortNode.InnerText.Trim(); 
                serverPort = Convert.ToInt32(serverPortStr);
            }

            XmlNode serverNameNode = xmlDoc.DocumentElement.SelectSingleNode("ServerName");
            if (serverName != null)
            {
                serverName = serverNameNode.InnerText.Trim();
            }


            Console.WriteLine($"Server {serverName} is started at port {serverPort}");
        }
    }
}