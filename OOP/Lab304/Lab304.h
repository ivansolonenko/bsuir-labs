#ifndef LAB304_H
#define LAB304_H

#include <iostream>
using namespace std;

class Shape
{
protected:
	int BasePointX;
	int BasePointY;
public:
	Shape(int BasePointX, int BasePointY);
	virtual ~Shape();
	virtual void Print() = 0;
};

class TwoDShape : public Shape 
{
public:
	TwoDShape(int BasePointX, int BasePointY);
	virtual ~TwoDShape();
	virtual double Area() = 0;
};

class Circle : public TwoDShape
{
protected:
	int Radius;
public:
	Circle(int BasePointX, int BasePointY, int Radius);
	virtual ~Circle();
	virtual double Area();
	virtual void Print();
};

class Rectangle : public TwoDShape
{
protected:
	int Length;
	int Width;
public:
	Rectangle(int BasePointX, int BasePointY, int Length, int Width);
	virtual ~Rectangle();
	virtual double Area();
	virtual void Print();
};

class Triangle : public TwoDShape
{
protected:
	int CathetusOne;
	int CathetusTwo;
	int Hypotenuse;
public:
	Triangle(int BasePointX, int BasePointY, int CathetusOne, int CathetusTwo, int Hypotenuse);
	virtual ~Triangle();
	virtual double Area();
	virtual void Print();
};

class ThreeDShape : public Shape
{
protected:
	int BasePointZ;
public:
	ThreeDShape(int BasePointX, int BasePointY, int BasePointZ);
	virtual ~ThreeDShape();
	virtual double Area() = 0;
	virtual double Volume() = 0;
};

class Cube : public ThreeDShape
{
protected:
	int Length;
	int Width;
	int Height;
public:
	Cube(int BasePointX, int BasePointY, int BasePointZ, int Length, int Width, int Height);
	virtual ~Cube();
	virtual double Area();
	virtual double Volume();
	virtual void Print();
};

class Cylinder : public ThreeDShape
{
protected:
	int Radius;
	int Height;
public:
	Cylinder(int BasePointX, int BasePointY, int BasePointZ, int Radius, int Height);
	virtual ~Cylinder();
	virtual double Area();
	virtual double Volume();
	virtual void Print();
};

class Sphere : public ThreeDShape
{
protected:
	int Radius;
public:
	Sphere(int BasePointX, int BasePointY, int BasePointZ, int Radius);
	virtual ~Sphere();
	virtual double Area();
	virtual double Volume();
	virtual void Print();
};

#endif LAB304_H
