class Vector3
{
    public double x { get; private set; }
    public double y { get; private set; }
    public double z { get; private set; }

    public Vector3() { }
    public Vector3(double x, double y, double z)
    {
        this.x = x; this.y = y; this.z = z;
    }

    public double Lenth()
    {
        return Math.Sqrt(x * x + y * y + z * z);
    }

    static public double ScalarProduct(Vector3 a, Vector3 b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }

    static public Vector3 CrossProduct(Vector3 a, Vector3 b)
    {
        return new Vector3(a.y * b.z - b.y * a.z, b.x * a.z - a.x * b.z, a.x * b.y - b.x * a.y);
    }

    static public double Angle(Vector3 a, Vector3 b)
    {
        return Math.Acos(ScalarProduct(a, b) / (a.Lenth() * b.Lenth()));
    }

    public static Vector3 operator + (Vector3 a, Vector3 b)
    {
        return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static Vector3 operator - (Vector3 a, Vector3 b)
    {
        return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
    }
}