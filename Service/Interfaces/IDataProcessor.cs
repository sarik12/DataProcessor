/// <summary>
/// Created an Interface IDataProcessor which have a "Process" method.
/// Which is implemented by three classes BinaryDataProcessor, TextDataProcessor and TextReverseDataProcessor 
/// Date : 07/23/2021
/// Developed by : Sarik
/// Param : string
/// Return : byte Array
/// </summary>

using System;
using System.Threading.Tasks;

namespace DataProcessorConsoleApp.Service.Interfaces
{

    public interface IDataProcessor
    {

        byte[] Process(string rawData);
    }
}
