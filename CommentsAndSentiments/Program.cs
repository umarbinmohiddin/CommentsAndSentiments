using System;
using CommentsAndSentiments;


            Console.WriteLine("Please Enter The Comment");

            string userdata = Console.ReadLine();
            //Load sample data
            var sampleData = new CommentSentimentModel.ModelInput();
            sampleData.Review = userdata;
         

            //Load model and predict output
            var result = CommentSentimentModel.Predict(sampleData);

            Console.Write("Sentiment of your Comment is   ");
            Console.WriteLine(result.PredictedLabel);






