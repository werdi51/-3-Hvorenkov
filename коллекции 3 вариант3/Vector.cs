class Vector
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double Z1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }
    public double Z2 { get; set; }

    public Vector(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        X1 = x1;
        Y1 = y1;
        Z1 = z1;
        X2 = x2;
        Y2 = y2;
        Z2 = z2;
    }

    public double[] GetCoordinates()
    {
        return new double[] { X2 - X1, Y2 - Y1, Z2 - Z1 };
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        double[] coords1 = v1.GetCoordinates();
        double[] coords2 = v2.GetCoordinates();
        return new Vector(0, 0, 0, coords1[0] + coords2[0], coords1[1] + coords2[1], coords1[2] + coords2[2]);
    }

    public static Vector operator -(Vector v1, Vector v2)
        //вычит
    {
        double[] coords1 = v1.GetCoordinates();
        double[] coords2 = v2.GetCoordinates();
        return new Vector(0, 0, 0, coords1[0] - coords2[0], coords1[1] - coords2[1], coords1[2] - coords2[2]);
    }

    public static double DotProduct(Vector v1, Vector v2)
    {
        double[] coords1 = v1.GetCoordinates();
        double[] coords2 = v2.GetCoordinates();
        return coords1[0] * coords2[0] + coords1[1] * coords2[1] + coords1[2] * coords2[2];
    }

    public double Length()
    {
        double[] coords = GetCoordinates();
        return Math.Sqrt(coords[0] * coords[0] + coords[1] * coords[1] + coords[2] * coords[2]);
    }

    public static double CosAngle(Vector v1, Vector v2)
    {
        return DotProduct(v1, v2) / (v1.Length() * v2.Length());
    }

    public override string ToString()
    {
        double[] coords = GetCoordinates();
        return $"({coords[0]}, {coords[1]}, {coords[2]})";
    }
}