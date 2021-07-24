/// <summary>
/// Created a class which overrides TextDataProcessor. 
/// It implements IDataProcessor and reverse
/// Date : 07/23/2021
/// Developed by : Sarik
/// Param : 
/// Return : byte array
/// </summary>
using System;
using DataProcessorConsoleApp.Service.Interfaces;

namespace DataProcessorConsoleApp.Service

{
    public class TextRevereseDataProcessor : IDataProcessor
    {
      public  byte[]  Process(string rawData)
      {
          char[] charArray = rawData.ToCharArray();
          Array.Reverse(charArray);
          return System.Text.UTF8Encoding.UTF8.GetBytes(charArray); 
      }
    }
}
