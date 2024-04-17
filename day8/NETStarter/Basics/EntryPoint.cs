// Animal Tiger = new();
// Animal Cow = new();


// Tiger.name = "Tiger";
// Tiger.habitat = "Wild";
// Tiger.foodtype = "Carnivorous";
// Tiger.lifeduration = 10;
// Tiger.leg = 4;

// Tiger.Animaldetails();


// Cow.name = "Cow";
// Cow.habitat = "Domestic";
// Cow.foodtype = "harnivorous";
// Cow.lifeduration = 15;
// Cow.leg = 4;

// Cow.Animaldetails();

var rec1 = new Rectangle(5.7, 3.4);
var p = rec1.GetPerimeter();


var rec2 = new Rectangle(12.76, 9.564);

var a = rec2.GetArea();
Console.WriteLine("Rectangle 1 - Perimeter:" +p );

Console.WriteLine("Rectangle 2 - Area: " +a);

var Square1 = new Square(34.5);
var  sa = Square1.GetArea(); 
var sp = Square1.GetPerimeter();
Console.WriteLine("Square1 - Perimeter: " + sp);
Console.WriteLine("Square1 - Area: " + sa);


Circle c1 = new Circle(9.9);
double perimeter = c1.GetPerimeter();
double area = c1.GetArea();
Console.WriteLine("Circle- Perimeter: " + perimeter);
Console.WriteLine("Circle - Area: " + area);


var  t1 = new Triangle(2, 3, 4);
double ta = t1.GetArea();
double tp = t1.GetPerimeter();
Console.WriteLine("Triangle-Area:" + ta);
Console.WriteLine("Triangle-Perimeter:" +tp);

