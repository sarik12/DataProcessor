/// <summary>
/// Created a class which implement IDataProcessor interface and define Process method. 
/// It takes Binary as input and return Base64 byte array 
/// Date : 07/23/2021
/// Developed by : Sarik
/// Param : 
/// Return : byte array
/// </summary>

using System;
using System.Text;
using DataProcessorConsoleApp.Service.Interfaces;

namespace DataProcessorConsoleApp.Service
{
    public class BinaryDataProcessor : IDataProcessor
    {

        public byte[] Process(string rawData)
        {
            var rawBytes = Encoding.ASCII.GetBytes(rawData);
            return Encoding.ASCII.GetBytes(Convert.ToBase64String(rawBytes));
           
        }  
    }
}
