using System;
using System.Collections.Generic;
using System.Linq;
namespace Program
{
    // this is commit OLOLOLOLO
    class Program
    {
        interface IDataProvider
        {
            string getData();
        }
        interface IDataProcessor
        {
            void ProcessData(IDataProvider dataProvider);
        }

        class ConsoleDataProcessor : IDataProcessor
        {
            public void ProcessData(IDataProvider dataProvider)
            {
                Console.WriteLine(dataProvider.getData());
            }
        }

        class DbDataProvider : IDataProvider
        {
            public string getData()
            {
                return "Данные из бд";
            }
        }

        class FileDataProvider : IDataProvider
        {
            public string getData()
            {
                return "Данные из файла";
            }
        }
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
        }

    }
}