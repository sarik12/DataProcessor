/// <summary>
/// Created a class which implement IDataProcessor interface and define Process method. 
/// It takes textData as input and return UTF8 format byte array 
/// Date : 07/23/2021
/// Developed by : Sarik
/// Param : 
/// Return : byte array
/// </summary>

using System;
using DataProcessorConsoleApp.Service.Interfaces;

namespace DataProcessorConsoleApp.Service
{
    public class TextDataProcessor : IDataProcessor
    {

        public  byte[] Process(string rawData)
        {
            var utf8 = System.Text.UTF8Encoding.UTF8;
            return utf8.GetBytes(rawData);
        }
    }
}
