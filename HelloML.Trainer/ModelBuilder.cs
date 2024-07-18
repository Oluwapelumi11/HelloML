using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloML.Model;

namespace HelloML.Trainer
{
    public static class ModelBuilder
    {
        private static MLContext _context  = new MLContext();

        //MAin method
        public static void CreateModel(string inputDataFileName,string outputDataFileName)
        {
            // Load the data
            var dataview = _context.Data.LoadFromTextFile<ModelInput>(inputDataFileName);
            // Build the training pipeline
            var dataProcessPipeline = _context.Transforms.Text.FeaturizeText("");
            var trainer = _context.Regression.Trainers.OnlineGradientDescent("");
            // Train the Model
            var trainingPipeline = dataProcessPipeline.Append(trainer);
            // Quick Evaluation of the Model


            // Save the output Model
        }
    }
}
