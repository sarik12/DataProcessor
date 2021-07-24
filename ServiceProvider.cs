using System;
using DataProcessorConsoleApp.Service.Interfaces;
using DataProcessorConsoleApp.Service;
namespace DataProcessorConsoleApp
{
   public class ServiceProvider
    {
       public static IDataProcessor GetDataProcessor(string dataType)
       {

           DataTypeEnum dataTypeEnum;
           Enum.TryParse(dataType, out dataTypeEnum);
           switch (dataTypeEnum)
           {
               case DataTypeEnum.Binary:
                   return new BinaryDataProcessor();
               case DataTypeEnum.Text:
                   return new TextDataProcessor();
               case DataTypeEnum.TextReverse:
                   return new TextRevereseDataProcessor();
               default:
                   return new TextDataProcessor();  //by default return Text processor
           }
       }

    }
}
