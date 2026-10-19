
using Data;
using Microsoft.ML;
using Microsoft.ML.Data;
using static Microsoft.ML.DataOperationsCatalog;

// Location of the training dataset
string _dataPath = Path.Combine(
    AppContext.BaseDirectory,
    "yelp_labelled.txt"
);

// Step 1: Initialize ML.NET
MLContext mlContext = new MLContext(seed: 1);

// Step 2: Load and split the dataset
TrainTestData splitDataView = LoadData(mlContext);

// Step 3: Build and train the model
ITransformer model = BuildAndTrainModel(
    mlContext,
    splitDataView.TrainSet
);

// Step 4: Evaluate model accuracy
Evaluate(mlContext, model, splitDataView.TestSet);

// Step 5: Predict a single comment
UseModelWithSingleItem(mlContext, model);

// Step 6: Predict multiple comments
UseModelWithBatchItems(mlContext, model);


// --------------------------------------------------
// LOAD DATA
// --------------------------------------------------
TrainTestData LoadData(MLContext context)
{
    IDataView dataView =
        context.Data.LoadFromTextFile<SentimentData>(
            _dataPath,
            hasHeader: false
        );

    return context.Data.TrainTestSplit(
        dataView,
        testFraction: 0.2
    );
}


// --------------------------------------------------
// BUILD AND TRAIN MODEL
// --------------------------------------------------
ITransformer BuildAndTrainModel(
    MLContext context,
    IDataView trainingData)
{
    var estimator = context.Transforms.Text
        .FeaturizeText(
            outputColumnName: "Features",
            inputColumnName: nameof(SentimentData.SentimentText)
        )
        .Append(
            context.BinaryClassification.Trainers
                .SdcaLogisticRegression(
                    labelColumnName: "Label",
                    featureColumnName: "Features"
                )
        );

    Console.WriteLine("Training the model...");

    ITransformer trainedModel = estimator.Fit(trainingData);

    Console.WriteLine("Model training complete.");

    return trainedModel;
}


// --------------------------------------------------
// EVALUATE MODEL
// --------------------------------------------------
void Evaluate(
    MLContext context,
    ITransformer trainedModel,
    IDataView testData)
{
    IDataView predictions = trainedModel.Transform(testData);

    CalibratedBinaryClassificationMetrics metrics =
        context.BinaryClassification.Evaluate(
            predictions,
            labelColumnName: "Label"
        );

    Console.WriteLine();
    Console.WriteLine("Model Quality Metrics");
    Console.WriteLine("-------------------------");
    Console.WriteLine($"Accuracy: {metrics.Accuracy:P2}");
    Console.WriteLine($"AUC: {metrics.AreaUnderRocCurve:P2}");
    Console.WriteLine($"F1 Score: {metrics.F1Score:P2}");
}


// --------------------------------------------------
// SINGLE PREDICTION
// --------------------------------------------------
void UseModelWithSingleItem(
    MLContext context,
    ITransformer trainedModel)
{
    var predictionEngine =
        context.Model.CreatePredictionEngine<
            SentimentData,
            SentimentPrediction
        >(trainedModel);

    var sampleStatement = new SentimentData
    {
        SentimentText = "This was a very bad steak"
    };

    SentimentPrediction result =
        predictionEngine.Predict(sampleStatement);

    Console.WriteLine();
    Console.WriteLine("Single Prediction");
    Console.WriteLine("-------------------------");
    Console.WriteLine($"Text: {sampleStatement.SentimentText}");
    Console.WriteLine(
        $"Prediction: {(result.Prediction ? "Positive" : "Negative")}"
    );
    Console.WriteLine($"Probability: {result.Probability:P2}");
}


// --------------------------------------------------
// BATCH PREDICTIONS
// --------------------------------------------------
void UseModelWithBatchItems(
    MLContext context,
    ITransformer trainedModel)
{
    IEnumerable<SentimentData> sentiments = new[]
    {
        new SentimentData
        {
            SentimentText = "This was a horrible meal"
        },
        new SentimentData
        {
            SentimentText = "I love this spaghetti."
        }
    };

    IDataView batchComments =
        context.Data.LoadFromEnumerable(sentiments);

    IDataView predictions =
        trainedModel.Transform(batchComments);

    IEnumerable<SentimentPrediction> results =
        context.Data.CreateEnumerable<SentimentPrediction>(
            predictions,
            reuseRowObject: false
        );

    Console.WriteLine();
    Console.WriteLine("Batch Predictions");
    Console.WriteLine("-------------------------");

    foreach (SentimentPrediction prediction in results)
    {
        Console.WriteLine($"Text: {prediction.SentimentText}");
        Console.WriteLine(
            $"Prediction: {(prediction.Prediction ? "Positive" : "Negative")}"
        );
        Console.WriteLine(
            $"Probability: {prediction.Probability:P2}"
        );
        Console.WriteLine();
    }
}
