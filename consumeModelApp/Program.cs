using System;
using SampleClassification.Model;

namespace consumeModelApp
{
    class Program
    {
        static void Main(string[] args)
        {
             System.Console.Write("What did you think of the restuarant: ");
            var input = new ModelInput() 
            {
                Col0 = Console.ReadLine()
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
            string sentiment = result.Prediction == "1" ? "Positive" : "Negative";
            Console.WriteLine($"Text: {input.Col0}\nSentiment: {sentiment}");
        }
    }
}
