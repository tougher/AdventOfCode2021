var lines = await File.ReadAllLinesAsync("input.txt");

var increases = 0;

var prevMeasurement = int.MaxValue;
foreach (var measurement in lines.Select(int.Parse))
{
    if (measurement > prevMeasurement)
        increases++;
    prevMeasurement = measurement;
}

Console.WriteLine($"Increases: {increases}");