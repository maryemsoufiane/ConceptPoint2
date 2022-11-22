public class Point
{
    private double x;
    private double y;

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public void Afficher()
    {
        Console.Out.WriteLine("POINT(" + x + "," + y + ")");
    }
}
class Cercle : Point
{
    private Point centre;                   // Attribut de type Point
    private double rayon;

    public Point Centre
    {
        get { return centre; }
        set { centre = value; }
    }

    public double Rayon
    {
        get { return rayon; }
        set { rayon = value; }
    }

    public Cercle(Point p, double r)
    {
        centre = p;
        rayon = r;
    }

    public double getPerimetre()
    {
        return Math.Round(2 * Math.PI * rayon, 2);            //Arrondir le résultat à 2 chiffres aprés la virgule.
    }

    public double getSurface()
    {
        return Math.Round(Math.PI * rayon * rayon, 2);
    }

    public bool Appartient(Point p)
    {
        double dis;
        dis = Math.Sqrt(Math.Pow(centre.X - p.X, 2) + Math.Pow(centre.Y - p.Y, 2));
        //La distance entre le centre du cercle courant et le point passé en paramètre.
        if (dis <= rayon)
            return true;
        else
            return false;
    }

    public void Afficher()
    {
        Console.Out.WriteLine("CERCLE(" + centre.X + "," + centre.Y + "," + rayon + ")");
    }
}
public class Droite : Point
{
    private int  A ;
    private double B;


    public Droite(double x, int y)
    {
        this.A = (int)x;
        this.B = y;
    }

    public int NUM
    {
        get { return A; }
        set { A = value; }
    }

    public double NUM2
    {
        get { return B; }
        set { B = value; }
    }

  
    }