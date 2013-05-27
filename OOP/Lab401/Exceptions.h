#ifndef EXCEPTIONS_H
#define EXCEPTIONS_H

#include <iostream>
using namespace std;

class BaseException
{
protected:
	unsigned int ErrorCode;
	string Message;
public:
	BaseException(int Code = 1000);
	BaseException(string ErrorMessage);
	~BaseException();
	unsigned int GetErrorCode();
	string PrintErrorMessage();
};

class IndexException : public BaseException
{
public:
	IndexException(int Code = 1001) : BaseException(Code)
	{
		Message = "Incorrect index";
	};
	~IndexException()
	{
	};
};

class OverflowException : public BaseException
{
public:
	OverflowException(int Code = 1002) : BaseException(Code)
	{
		Message = "Cannot add value";
	};
	~OverflowException()
	{
	};
};

class RangeException : public BaseException
{
public:
	RangeException(int Code = 1003) : BaseException(Code)
	{
		Message = "Digit out of range";
	};
	~RangeException()
	{
	};
};

class MemoryException : public BaseException
{
public:
	MemoryException(int Code = 1004) : BaseException(Code)
	{
		Message = "Error allocating memory";
	};
	~MemoryException()
	{
	};
};

#endif EXCEPTIONS_H
