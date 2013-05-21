#include "Exceptions.h"

BaseException::BaseException(int Code)
{
	ErrorCode = Code;
}

BaseException::BaseException(string ErrorMessage)
{
	ErrorCode = 1000;
	Message = ErrorMessage;
}

BaseException::~BaseException()
{
}

unsigned int BaseException::GetErrorCode()
{
	return ErrorCode;
}

string BaseException::PrintErrorMessage()
{
	return this->Message;
}
