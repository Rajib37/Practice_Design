using PacticeDesign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacticeDesign.BusinessLayer
{
    class RulesValidator
    {
        public List<bool> ValidateRules(List<ProcessingModel> processingModels)
        {
            List<bool> result = null;
            //Dictionary<string, Predicate> map = new Dictionary<string, System.Predicate>();
            foreach (var item in processingModels)
            {
                switch (item.Signal)
                {
                    case "ALT1":
                        result.Add(Signal1_Rule(item.ValueModels));
                        break;
                    case "ALT2":
                        result.Add(Signal2_Rule(item.ValueModels));
                        break;
                    case "ALT3":
                        result.Add(Signal3_Rule(item.ValueModels));
                        break;
                    case "ALT4":
                        result.Add(Signal4_Rule(item.ValueModels));
                        break;
                    case "ALT5":
                        result.Add(Signal5_Rule(item.ValueModels));
                        break;
                    case "ALT6":
                        result.Add(Signal6_Rule(item.ValueModels));
                        break;
                    case "ALT7":
                        result.Add(Signal7_Rule(item.ValueModels));
                        break;
                    case "ALT8":
                        result.Add(Signal8_Rule(item.ValueModels));
                        break;
                    case "ALT9":
                        result.Add(Signal9_Rule(item.ValueModels));
                        break;
                    case "ALT10":
                        result.Add(Signal10_Rule(item.ValueModels));
                        break;
                    case "ALT11":
                        result.Add(Signal11_Rule(item.ValueModels));
                        break;
                    default:
                        result.Add(false);
                        break;
                }
                //if (item.Signal == "ALT1" && Signal1_Rule(item.ValueModels))
                //{
                //    //map[item.Signal] = Signal1_Rule;
                //    //var ans=map[item.Signal].Invoke();
                //    result.Add(ans);
                //}
            }

            return result;
        }

        private bool Signal1_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "HIGH")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) > 12)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) == DateTime.Now)
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal2_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "LOW")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) < 240)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) > DateTime.Now)
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal3_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "HIGH")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) < 20)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) <= DateTime.Now)
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal4_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "LOW")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) > 20)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) == DateTime.UtcNow)
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal5_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "HIGH")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) == 63)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) <= DateTime.UtcNow)
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal6_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "LOW")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) <= 48)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) >= Convert.ToDateTime("2017-01-25 13:03:43"))
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal7_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "LOW")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) >= 48)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) <= Convert.ToDateTime("2017-01-25 13:03:43"))
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal8_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "HIGH")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) == 48)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) >= Convert.ToDateTime("2000-01-25 13:03:43"))
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal9_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "LOW")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) <= 260)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) >= Convert.ToDateTime("1999-01-25 13:03:43"))
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal10_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "HIGH")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) > 100)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) == Convert.ToDateTime("2010-01-25 13:03:43"))
            {
                return true;
            }
            else
                return false;
        }
        private bool Signal11_Rule(List<ValueModel> valueModel)
        {
            if (valueModel[1].ToString() == "string" && valueModel[0].ToString().ToUpper() == "HIGH")
            {
                return true;
            }
            else if (valueModel[1].ToString() == "Integer" && Convert.ToInt32(valueModel[0]) == 120)
            {
                return true;
            }
            else if (valueModel[1].ToString() == "string" && Convert.ToDateTime(valueModel[0]) <= Convert.ToDateTime("2007-01-25 13:03:43"))
            {
                return true;
            }
            else
                return false;
        }
    }
}
