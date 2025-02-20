namespace SemesterProject;

public static class Program
{
    public static void Main()
    {
        //var svg = new SvgBuilder(500, 500)
        //    .AddRectangle(100, 50, 350, 200, "#FF0000")
        //    .AddRectangle(125, 400, 60, 30, "#00ff00")
        //    .AddRectangle(350, 400, 60, 30, "#00ff00")
        //    .Build();
        var svgBuilder = new SvgBuilder(500,500);
        var gridBuilder = new GridBuilder(svgBuilder, 8);
        
        var inputPath = "../input.txt";
        using var streamReader = new StreamReader(inputPath);

        foreach (var line in streamReader.ReadToEnd().Split("\n")) { 
            gridBuilder.Parse(line);
        }
        Console.Write("Absolute path to save SVG at: ");
        var path = Console.ReadLine() ?? "";
        using var streamWriter = new StreamWriter(path);

        streamWriter.WriteLine(svgBuilder.Build());
    }
}
