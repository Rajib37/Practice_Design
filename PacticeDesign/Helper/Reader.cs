using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacticeDesign.Interface;
using System.IO;
using Newtonsoft.Json;
using Model;

namespace PacticeDesign
{
    class Reader : IReader
    {
        private string jsonFilePath = @"";
        

        
        public List<DataModel> ReadJson(string path)
        {
            var json = File.ReadAllText(jsonFilePath);
            List<DataModel> dataModels = new List<DataModel>();
            try
            {
                dataModels = JsonConvert.DeserializeObject<List<DataModel>>(json);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataModels;
        }
    }
}
