
using AboutObjectConsoleApp;

Point firstPoint = new Point();

Point secondPoint = new Point(5, 9);

firstPoint = new Point(18, -7);
firstPoint = new(18, -7);

firstPoint.Show();

int a;
//firstPoint.x = 99;
firstPoint.SetX(99);
firstPoint.X = 99;

//a = firstPoint.x;
a = firstPoint.GetX();
a = firstPoint.X;

Point3D point3D = new(5, 7 ,9);
point3D.Show();

