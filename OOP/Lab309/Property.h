#ifndef PROPERTY_H
#define PROPERTY_H

#include <iostream>
using namespace std;

template <typename T1, typename T2>
class Property
{
private:
	typedef T1 (T2::*get)();
	typedef void (T2::*set)(T1);
	T2 *owner;
	get get_method;
	set	set_method;

public:
	operator T1();
	void operator=(T1 data);
	Property();
	void init(T2* const, get, set);
};

#endif PROPERTY_H
