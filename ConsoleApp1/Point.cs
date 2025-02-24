namespace ConsoleApp1;

public class Point
{
    private double X;
    private double Y;
    
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public double DistnaceToOrigin()
    {
        return(Math.Sqrt(X * X + Y * Y));
    }
    
    public double DistanceTo(Point p)
    {
        double dx = this.X - p.X;
        double dy = this.Y - p.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}

