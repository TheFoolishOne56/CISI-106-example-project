public class Brick
{
    public double Width;
    public double Height;
    public double Length;
    private string Color;
    public Double GetVol()
    {
        return this.Width * this.Height * this.Length;
    }
}