using Model;
using PacticeDesign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacticeDesign.BusinessLayer
{
    class ProcessingController
    {
        private List<ProcessingModel> modelValues;

        public void PreProcessing(string filename)
        {
            var fileReader = new Reader();
            var model = fileReader.ReadJson(filename);
            modelValues = GetProcessingModel(model);
        }

        public void ProcessingRules(List<string> rules)
        {
            RulesValidator rulesValidator = new RulesValidator();
            //invoke stratergy..
            List<bool> result = rulesValidator.ValidateRules(modelValues);
            
        }
        private List<ProcessingModel> GetProcessingModel(List<DataModel> models)
        {
            Dictionary<string, List<ValueModel>> map = new Dictionary<string, List<ValueModel>>();
            foreach (var element in models)
            {
                if (map.ContainsKey(element.signal))
                {
                    var model = map[element.signal];
                    model.Add(new ValueModel() { Value = element.value, ValueType = element.value_type });
                    map[element.signal] = model;
                }
                else
                {
                    var dataModels = new List<ValueModel>();
                    var dataModel = new ValueModel() { Value = element.value, ValueType = element.value_type };
                    dataModels.Add(dataModel);
                    map[element.signal] = dataModels;
                }
            }

            List<ProcessingModel> processModleList = map.Select(x => new ProcessingModel { Signal = x.Key, ValueModels = x.Value }).ToList();
            return processModleList;
        }
    }