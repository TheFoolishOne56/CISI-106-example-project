namespace SemesterProject;

public interface IGridBuilder
{
    /// <summary>
    /// Parses a line with the format `([x], [y]) [color]` and add it to the
    /// SVG builder as a rectangle.
    /// </summary>
    /// <param name="line">The line to parse.</param>
    public void Parse(string line);
}

public class GridBuilder : IGridBuilder
{
    /// <summary>
    /// A reference to an SVG builder. We keep this so that we can add
    /// rectangles to it without having to constantly pass it around.
    /// </summary>
    private readonly ISvgBuilder SvgBuilder;

    /// <summary>
    /// The size of the grid to build. For example, a grid size of 8 will
    /// result in individual grid cells being 8 by 8 units.
    /// </summary>
    private readonly int GridSize;

    /// <summary>
    /// Initialize a new grid builder.
    /// </summary>
    /// <param name="svgBuilder">The SVG builder to reference later.</param>
    /// <param name="gridSize">The size of the grid.</param>
    public GridBuilder(ISvgBuilder svgBuilder, int gridSize)
    {
        SvgBuilder = svgBuilder;
        GridSize = gridSize;
    }

    public void Parse(string line)
    {
        var match = new Regex("\\((?<x>\\d+), (?<y>\\d+)\\) (?<Hex>#[0-9a-f]+)").Match(line);
        var x = match.Groups["x"];
        var X1 = int.Parse(x.Value);
        var y = match.Groups["y"];
        int Y1 = int.Parse(y.Value);
        var Hex = match.Groups["Hex"];
        var HEX1 = int.parse(Hex.Value);
        SvgBuilder.AddRectangle(X1*GridSize, Y1*GridSize, GridSize, GridSize, HEX1);
    }
}
