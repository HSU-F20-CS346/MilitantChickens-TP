﻿using System;
using MilitantChickensTranferProtocol.Library;

namespace MilitantChickensTransferProtocol.Terminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            //client.Connect("127.0.0.1", "Test Message");
            ClientRequestFactory factory = new ClientRequestFactory();
            RequestHeader header = factory.BuildHeader();
            byte[] requestHeader = header.ReturnRawHeader();
            client.HandleResponse(factory.isPost);

            client.SendHeader("127.0.0.1", requestHeader);
            //Debug Termination of Client -- TEMP DEBUG CODE
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            
        }
    }
}
