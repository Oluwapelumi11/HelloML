using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloML.Model
{
    public class ModelInput
    {
        [LoadColumn(0)]
        public string Month { get; set; }

        [LoadColumn(1)]
        public float Sales { get; set; }
    }
}
