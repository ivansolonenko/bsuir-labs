#ifndef ARRAY_HPP
#define ARRAY_HPP

#include <iostream>
using namespace std;
#include <iomanip>
#include "Exceptions.h"

class Array
{
protected:
	int *arr;
	int size;
public:
	Array();
	Array(int);
	Array(int, int*);
	Array(const Array&);
	~Array();

	Array Cross(const Array&);
	void Cross2(const Array&, const Array&);

	Array Unite(const Array&);
	void Unite2(const Array&, const Array&);

	Array operator+(const Array&);
	Array operator-(const Array&);
	Array operator=(const Array&);

	friend istream& operator>>(istream&, Array&);
	friend ostream& operator<<(ostream&, Array&);
};

#endif ARRAY_HPP
