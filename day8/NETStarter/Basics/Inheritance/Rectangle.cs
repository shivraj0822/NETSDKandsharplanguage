class Rectangle
{
    //Default parameterless Constructor
    //public Rectangle()
   // {

   // }

      //Parametrized Constructor

 public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    double length;
    double width;

    public double GetArea() => length * width;
    public double GetPerimeter() => 2 * (length + width);
}
    
