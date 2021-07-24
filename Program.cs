using System;
using DataProcessorConsoleApp.Service;


namespace DataProcessorConsoleApp
{
  public class Program
    {
        static void Main(string[] args)
        {
            var filepath = args[0]; // Read File Path from Command Line Arguements
            var datatype = args[1]; // Read Data Type from Command Line Arguements
            //Read data from given filepath using FileDataFetcher 
            var fileSource = new FileDataFetcher(filepath);
            var rawData = fileSource.Fetch();

            //Get the required DataProcessor passing datatype and process rawdata 
            var dataProcessor = ServiceProvider.GetDataProcessor(datatype);
            var processedData = dataProcessor.Process(rawData);

            //Output  First 5 Bytes or letter from Processed data
            PrintFirstFive(processedData);

        }

        //Output  First 5 Bytes or letter from Processed data
        private static void PrintFirstFive(byte[] processedData)
        {
                for (int a = 0; a < 5; a++)
                {
                    Console.WriteLine("{0} => {1}", a + 1, processedData.GetValue(a));
                }
                Console.ReadLine();
        }
    }
     
}
