#include "Lab304.h"
#define DEBUG

Shape::Shape(int BasePointX, int BasePointY)
{
	this->BasePointX = BasePointX;
	this->BasePointY = BasePointY;
#ifdef DEBUG
	cout << "Shape Constructor" << endl;
#endif
}

Shape::~Shape()
{
#ifdef DEBUG
	cout << "Shape Destructor" << endl;
#endif
}

TwoDShape::TwoDShape(int BasePointX, int BasePointY) : Shape(BasePointX, BasePointY)
{
#ifdef DEBUG
	cout << "TwoDShape Constructor" << endl;
#endif
}

TwoDShape::~TwoDShape()
{
#ifdef DEBUG
	cout << "TwoDShape Destructor" << endl;
#endif
}

Circle::Circle(int BasePointX, int BasePointY, int Radius) : TwoDShape(BasePointX, BasePointY)
{
	this->Radius = Radius;
#ifdef DEBUG
	cout << "Circle Constructor" << endl;
#endif
}

Circle::~Circle()
{
#ifdef DEBUG
	cout << "Circle destructor" << endl;
#endif
}

double Circle::Area()
{
	return (double)(3,14*Radius*Radius);
}

void Circle::Print()
{
	cout << "Circle. Area: " << this->Area() << endl;
}

Rectangle::Rectangle(int BasePointX, int BasePointY, int Length, int Width) : TwoDShape(BasePointX, BasePointY)
{
	this->Length = Length;
	this->Width = Width;
#ifdef DEBUG
	cout << "Rectangle Constructor" << endl;
#endif
}

Rectangle::~Rectangle()
{
#ifdef DEBUG
	cout << "Rectangle destructor" << endl;
#endif
}

double Rectangle::Area()
{
	return (double)(Length*Width);
}

void Rectangle::Print()
{
	cout << "Rectangle. Area: " << this->Area() << endl;
}

Triangle::Triangle(int BasePointX, int BasePointY, int CathetusOne, int CathetusTwo, int Hypotenuse) : TwoDShape(BasePointX, BasePointY)
{
	this->CathetusOne = CathetusOne;
	this->CathetusTwo = CathetusTwo;
	this->Hypotenuse = Hypotenuse;
#ifdef DEBUG
	cout << "Triangle Constructor" << endl;
#endif
}

Triangle::~Triangle()
{
#ifdef DEBUG
	cout << "Triangle destructor" << endl;
#endif
}

double Triangle::Area()
{
	return (double)(0.5*CathetusOne*CathetusTwo);
}

void Triangle::Print()
{
	cout << "Triangle. Area: " << this->Area() << endl;
}


ThreeDShape::ThreeDShape(int BasePointX, int BasePointY, int BasePointZ) : Shape(BasePointX, BasePointY)
{
	this->BasePointZ = BasePointZ;
#ifdef DEBUG
	cout << "ThreeDShape Constructor" << endl;
#endif
}

ThreeDShape::~ThreeDShape()
{
#ifdef DEBUG
	cout << "ThreeDShape destructor" << endl;
#endif
}

Cube::Cube(int BasePointX, int BasePointY, int BasePointZ, int Length, int Width, int Height) : ThreeDShape(BasePointX, BasePointY, BasePointZ)
{
	this->Length = Length;
	this->Width = Width;
	this->Height = Height;
#ifdef DEBUG
	cout << "Cube Constructor" << endl;
#endif
}

Cube::~Cube()
{
#ifdef DEBUG
	cout << "Cube destructor" << endl;
#endif
}

double Cube::Area()
{
	return (double)(2*Length*Width + 2*Length*Height + 2*Width*Height);
}

double Cube::Volume()
{
	return (double)(Length*Width*Height);
}

void Cube::Print()
{
	cout << "Cube. Area: " << this->Area() << ", Volume: " << this->Volume() << endl;
}

Cylinder::Cylinder(int BasePointX, int BasePointY, int BasePointZ, int Radius, int Height) : ThreeDShape(BasePointX, BasePointY, BasePointZ)
{
	this->Radius = Radius;
	this->Height = Height;
#ifdef DEBUG
	cout << "Cylinder Constructor" << endl;
#endif
}

Cylinder::~Cylinder()
{
#ifdef DEBUG
	cout << "Cylinder destructor" << endl;
#endif
}

double Cylinder::Area()
{
	return (double)(2*3.14*Radius*(Height+Radius));
}

double Cylinder::Volume()
{
	return (double)(3,14*Radius*Radius*Height);
}

void Cylinder::Print()
{
	cout << "Cylinder. Area: " << this->Area() << ", Volume: " << this->Volume() << endl;
}

Sphere::Sphere(int BasePointX, int BasePointY, int BasePointZ, int Radius) : ThreeDShape(BasePointX, BasePointY, BasePointZ)
{
	this->Radius = Radius;
#ifdef DEBUG
	cout << "Sphere Constructor" << endl;
#endif
}

Sphere::~Sphere()
{
#ifdef DEBUG
	cout << "Sphere destructor" << endl;
#endif
}

double Sphere::Area()
{
	return (double)(4*3.14*Radius*Radius);
}

double Sphere::Volume()
{
	return (double)(4/3*3.14*Radius*Radius*Radius);
}

void Sphere::Print()
{
	cout << "Sphere. Area: " << this->Area() << ", Volume: " << this->Volume() << endl;
}

void main()
{
	Shape *Figures[6];

	Figures[0] = new Circle(0,0,5);
#ifdef DEBUG
	cout << endl;
#endif
	Figures[1] = new Rectangle(0,0,4,5);
#ifdef DEBUG
	cout << endl;
#endif
	Figures[2] = new Triangle(0,0,2,3,4);
#ifdef DEBUG
	cout << endl;
#endif
	Figures[3] = new Cube(0,0,0,4,5,6);
#ifdef DEBUG
	cout << endl;
#endif
	Figures[4] = new Cylinder(0,0,0,5,10);
#ifdef DEBUG
	cout << endl;
#endif
	Figures[5] = new Sphere(0,0,0,5);
#ifdef DEBUG
	cout << endl;
#endif

	for(int i=0; i<6; i++)
	{
		Figures[i]->Print();
		cout << endl;
	}

	for(int i=0; i<6; i++)
	{
		delete Figures[i];
#ifdef DEBUG
		cout << endl;
#endif
	}
}
