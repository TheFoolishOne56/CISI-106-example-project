namespace SemesterProject;

public static class Program
{
    public static void Main()
    {
        var svg = new SvgBuilder(500, 500)
            .AddRectangle(100, 50, 150, 200, "#FF0000")
            .AddRectangle(125, 400, 60, 30, "#00ff00")
            .AddRectangle(350, 400, 60, 30, "#00ff00")
            .Build();
        Console.Write("Absolute path to save SVG at: ");
        var path = Console.ReadLine() ?? "";
        using var streamWriter = new StreamWriter(path);

        streamWriter.WriteLine(svg);
    }
}
