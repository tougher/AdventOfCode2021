var lines = await File.ReadAllLinesAsync("input.txt");

var increases = 0;
var measurements = lines.Select(int.Parse).ToArray();

var prevWindow = int.MaxValue;
for (var i = 0; i < measurements.Length; i++)
{
    if (i > measurements.Length - 3) break;
    var window = measurements[i] + measurements[i + 1] + measurements[i + 2];
    if (window > prevWindow)
        increases++;
    prevWindow = window;
}

Console.WriteLine($"Increases: {increases}");