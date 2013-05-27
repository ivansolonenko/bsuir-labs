#ifndef STRING_H
#define STRING_H

#include <iostream>
using namespace std;

#define __MSVC6__
#pragma warning(disable: 4996)
// #define _CRT_SECURE_NO_DEPRECATE
// #define _CRT_SECURE_CPP_OVERLOAD_STANDARD_NAMES 1
// #define _CRT_SECURE_CPP_OVERLOAD_STANDARD_NAMES 1
// #define _CRT_SECURE_CPP_OVERLOAD_STANDARD_NAMES_COUNT 1

class String
{
private:
	char* str;
	size_t size;
public:
	String();
	String(const char *);
	//explicit String(const char *);
	String(const String &);
	~String();

	String operator+(const char *);
	String operator+(const String &);

	String operator+=(const char *);
	String operator+=(const String &);
	
	String operator=(const char *);
	String operator=(const String &);

	bool operator==(const char *);
	bool operator==(const String &);

	bool operator!=(const char *);
	bool operator!=(const String &);

	bool operator>(const char *);
	bool operator>(const String &);

	bool operator<(const char *);
	bool operator<(const String &);

	char operator[](const unsigned int);
	String operator()(const unsigned int, const unsigned int);

#ifdef __MSVC6__
	size_t GetSize();
	char* GetStrPointer();
#endif

	friend ostream& operator<<(ostream &, String &);
	friend istream& operator>>(istream &, String &);
};

#endif STRING_H
