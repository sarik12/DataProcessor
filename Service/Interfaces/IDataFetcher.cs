
/// <summary>
/// Created an Interface IDataFetcher which have a "Fetch" method.
/// And it is implemented by One class FileSourceReader and later can be implemeted by more classes which use database or eventlog as source.
/// Date : 07/23/2021
/// Developed by : Sarik
/// Param : 
/// Return : string
/// </summary>

using System;
namespace DataProcessorConsoleApp.Service.Interfaces
{
    public interface IDataFetcher
    {
        string Fetch();
    }
}
