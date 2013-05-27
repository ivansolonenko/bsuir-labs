#include "String.h"

String::String()
{
	str = NULL;
	size = 0;
}

String::String(const char *_str)
{
	size = (unsigned int) strlen(_str);
	if(size > 0)
	{
		str = new char [size+1];
		//if(!str) exit(1);
		memset(str, '\0', size+1);
		strncpy(str, _str, size+1);
	}
}

String::String(const String &obj)
{
	size = obj.size;
	if(size > 0)
	{
		str = new char [size+1];
		//if(!str) exit(1);
		memset(str, '\0', size+1);
		strncpy(str, obj.str, size+1);
	}
}

String::~String()
{
	if(size > 0)
	{
		delete [] str;
		str = NULL;
		size = 0;
	}
}
/***********************************************/
String String::operator+(const char *_str)
{
	if(!strcmp(this->str, _str))
		return *this;
	String result;
	result.size = this->size + (unsigned int) strlen(_str);
	if(result.size > 0)
	{
		result.str = new char [result.size+1];
		//if(!result.str) exit(1);
		memset(result.str, '\0', size+1);
		strncpy(result.str, this->str, this->size+1);
		strncat(result.str, _str, (unsigned int) strlen(_str)+1);
	}

	return result;
}

String String::operator+(const String &obj)
{
	if(this == &obj)
		return *this;
	String result;
	result.size = this->size + obj.size;
	if(result.size > 0)
	{
		result.str = new char [result.size+1];
		//if(!result.str) exit(1);
		memset(result.str, '\0', size+1);
		strncpy(result.str, this->str, this->size+1);
		strncat(result.str, obj.str, obj.size+1);
	}

	return result;
}
/***********************************************/
String String::operator+=(const char *_str)
{
	String result = *this + _str;
	*this = result;
	return *this;
}

String String::operator+=(const String &obj)
{
	String result = *this + obj;
	*this = result;
	return *this;
}
/***********************************************/
String String::operator=(const char *_str)
{
	//if(!strcmp(this->str, _str))	// ERROR
	//	return *this;				// ERROR
	if(size > 0)
	{
		delete [] str;
		str = NULL;
		size = 0;
	}
	size = strlen(_str);
	if(size > 0)
	{
		str = new char [size+1];
		//if(!str) exit(1);
		memset(str, '\0', size+1);
		strncpy(str, _str, size+1);
	}
	return *this;
}

String String::operator=(const String &obj)
{
	if(this == &obj)
		return *this;
	if(size > 0)
	{
		delete [] str;
		str = NULL;
		size = 0;
	}
	size = obj.size;
	if(size > 0)
	{
		str = new char [size+1];
		//if(!str) exit(1);
		memset(str, '\0', size+1);
		strncpy(str, obj.str, size+1);
	}
	return *this;
}
/***********************************************/
bool String::operator==(const char *_str)
{
	if(!strcmp(this->str, _str))
		return true;
	else
		return false;
}

bool String::operator==(const String &obj)
{
	if(!strcmp(this->str, obj.str))
		return true;
	else
		return false;
}
/***********************************************/

bool String::operator!=(const char *_str)
{
	if(strcmp(this->str, _str))
		return true;
	else
		return false;
}

bool String::operator!=(const String &obj)
{
	if(strcmp(this->str, obj.str))
		return true;
	else
		return false;
}
/***********************************************/
bool String::operator>(const char *_str)
{
	if(this->size > strlen(_str))
		return true;
	else
		return false;
}

bool String::operator>(const String &obj)
{
	if(this->size > obj.size)
		return true;
	else
		return false;
}
/***********************************************/
bool String::operator<(const char *_str)
{
	if(this->size < strlen(_str))
		return true;
	else
		return false;
}

bool String::operator<(const String &obj)
{
	if(this->size < obj.size)
		return true;
	else
		return false;
}
/***********************************************/
char String::operator[](const unsigned int i)
{
	if(i<0 || i>size)
		return 0;
	else
		return this->str[i];
}

String String::operator()(const unsigned int begin, const unsigned int end)
{
	if (str==0 || size==0 || begin<0 || end<0 || end<begin || begin>size || end>size)
		exit(1);
	int _size = end-begin+1;
	char *_str;
	if(size > 0)
	{
		_str = new char [_size+1];
		//if(!_str) exit(1);
		memset(_str, '\0', _size+1);
		strncpy(_str, str+begin, _size);
	}
	String result(_str);
	return result;
}

#ifdef __MSVC6__
size_t String::GetSize()
{
	return size;
}

char* String::GetStrPointer()
{
	return str;
}
#endif

ostream& operator<<(ostream &stream, String &obj)
{
#ifdef __MSVC6__
	if(!obj.GetSize())
#else
	if(!obj.size)
#endif
		return stream;
#ifdef __MSVC6__
	stream << obj.GetStrPointer();
#else
	stream << obj.str;
#endif
	return stream;
}

istream& operator>>(istream &stream, String &obj)
{
	char buf[256];
	stream >> buf;
	obj = buf;
	return stream;
}
