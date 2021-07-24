using System;
using DataProcessorConsoleApp.Service.Interfaces;

namespace DataProcessorConsoleApp.Service
{
    public class FileDataFetcher : IDataFetcher
    {
        private string _filePath;
        public  FileDataFetcher(string filePath)
        {
            _filePath = filePath;
           
        }
        public string Fetch()
        {
            // Read the file as one string and return the content of file as string
            return System.IO.File.ReadAllText(_filePath);
            
        }
    }
}
