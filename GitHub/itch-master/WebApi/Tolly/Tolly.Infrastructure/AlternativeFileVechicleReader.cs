using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolly.Domain.Models;

namespace Tolly.Infrastructure
{
    public class AlternativeFileVechicleReader
    {
        public VechicleInfo Read(string item)
        {
            string data = System.IO.File.ReadAllText("DataAlternative" + item + ".txt");

            return new VechicleInfo
            {
                Weight = int.Parse(data.Split(";")[0]),
                VechicleType = data.Split(";")[1],                
                Hour = int.Parse(data.Split(";")[2])
            };
        }
    }
}

