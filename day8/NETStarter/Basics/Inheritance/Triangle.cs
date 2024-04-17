class Triangle
{
     public Triangle(double b, double h, double p)
    {
        basee = b;
        height = h;
        perpendicular = p;
    }
    double basee;
    double height;
    double perpendicular;

    public double GetArea()=> (basee * height )/ 2;
    public double GetPerimeter()=> ( basee + height + perpendicular );

    
}

