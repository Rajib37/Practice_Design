using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacticeDesign.Interface
{
    /// <summary>
    /// Read the json file
    /// </summary>
    interface IReader
    {
        List<DataModel> ReadJson(string path);

    }
}
