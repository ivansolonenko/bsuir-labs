#include "Array.h"

Array::Array()
{
	arr = NULL;
	size = 0;
}

Array::Array(int _size)
{
	size = _size;
	arr = new int [size];
	if(!arr)
	{
		MemoryException exc;
		throw exc;
	}
}

Array::Array(int _size, int *_arr)
{
	size = _size;
	arr = new int [size];
	if(!arr)
	{
		MemoryException exc;
		throw exc;
	}
	for(int i=0; i<size; i++)
		arr[i] = _arr[i];
}

Array::Array(const Array &obj)
{
	size = obj.size;
	arr = new int [size];
	if(!arr)
	{
		MemoryException exc;
		throw exc;
	}

	for(int i=0; i<size; i++)
		arr[i] = obj.arr[i];
}

Array::~Array()
{
	if(size > 0)
	{
		delete [] arr;
		arr = NULL;
		size = 0;
	}
}

Array Array::Cross(const Array &obj)
{
	int flag = 0, sum = 0;
	int _size = this->size > obj.size ? this->size : obj.size;
	int *_arr = new int [_size];
	if(!_arr)
	{
		MemoryException exc;
		throw exc;
	}
	int *p = _arr;

	for(int i=0; i<this->size; i++)
	{
		flag = 0;
		for(int j=0; j<obj.size; j++)
		{
			if(this->arr[i] == obj.arr[j])
			{
				flag = 1;
				for(int k=0; k<i; k++)
					if(this->arr[k] == this->arr[i])
						flag = 0;
			}
		}
		if(flag)
		{
			*p = this->arr[i];
			p++;
			sum++;
		}
	}

	Array result(sum, _arr);
	delete [] _arr;
	return result;
}

void Array::Cross2(const Array& array1, const Array& array2)
{
	if(this->size > 0)
	{
		delete [] this->arr;
		this->arr = NULL;
		this->size = 0;
	}

	int i = 0, flag = 0, sum = 0;
	int _size = array1.size > array2.size ? array1.size : array2.size;
	int *_arr = new int [_size];
	if(!_arr)
	{
		MemoryException exc;
		throw exc;
	}
	int *p = _arr;

	for(i=0; i<array1.size; i++)
	{
		flag = 0;
		for(int j=0; j<array2.size; j++)
		{
			if(array1.arr[i] == array2.arr[j])
			{
				flag = 1;
				for(int k=0; k<i; k++)
					if(array1.arr[k] == array1.arr[i])
						flag = 0;
			}
		}
		if(flag)
		{
			*p = array1.arr[i];
			p++;
			sum++;
		}
	}

	this->size = sum;
	this->arr = new int [this->size];
	if(!this->arr)
	{
		MemoryException exc;
		throw exc;
	}
	for(i=0; i<sum; i++)
		this->arr[i] = _arr[i];
	delete [] _arr;
}

Array Array::Unite(const Array &obj)
{
	int i = 0, flag = 0, sum = 0;
	int _size = this->size + obj.size;
	int *_arr = new int [_size];
	if(!_arr)
	{
		MemoryException exc;
		throw exc;
	}
	int *p = _arr;

	for(i=0; i<this->size; i++)
	{
		flag = 1;
		for(int j=0; j<i; j++)
			if(this->arr[j] == this->arr[i])
				flag = 0;
		if(flag)
		{
			*p = this->arr[i];
			p++;
			sum++;
		}
	}

	for(i=0; i<obj.size; i++)
	{
		flag = 1;
		for(int j=0; j<this->size; j++)
			if(obj.arr[i] == this->arr[j])
				flag = 0;
		for(int k=0; k<i; k++)
			if(obj.arr[k] == obj.arr[i])
				flag = 0;
		if(flag)
		{
			*p = obj.arr[i];
			p++;
			sum++;
		}
	}

	Array result(sum, _arr);
	delete [] _arr;
	return result;

}

void Array::Unite2(const Array& array1, const Array& array2)
{
	if(this->size > 0)
	{
		delete [] this->arr;
		this->arr = NULL;
		this->size = 0;
	}

	int i = 0, flag = 0, sum = 0;
	int _size = array1.size + array2.size;
	int *_arr = new int [_size];
	if(!_arr)
	{
		MemoryException exc;
		throw exc;
	}
	int *p = _arr;

	for(i=0; i<array1.size; i++)
	{
		flag = 1;
		for(int j=0; j<i; j++)
			if(array1.arr[j] == array1.arr[i])
				flag = 0;
		if(flag)
		{
			*p = array1.arr[i];
			p++;
			sum++;
		}
	}

	for(i=0; i<array2.size; i++)
	{
		flag = 1;
		for(int j=0; j<array1.size; j++)
			if(array2.arr[i] == array1.arr[j])
				flag = 0;
		for(int k=0; k<i; k++)
			if(array2.arr[k] == array2.arr[i])
				flag = 0;
		if(flag)
		{
			*p = array2.arr[i];
			p++;
			sum++;
		}
	}

	this->size = sum;
	this->arr = new int [this->size];
	if(!this->arr)
	{
		MemoryException exc;
		throw exc;
	}
	for(i=0; i<sum; i++)
		this->arr[i] = _arr[i];
	delete [] _arr;
}

Array Array::operator+(const Array &obj)
{
	return this->Unite(obj);
}

Array Array::operator-(const Array &obj)
{
	return this->Cross(obj);
}

Array Array::operator=(const Array &obj)
{
	if(this == &obj)
		return *this;
	
	if(size > 0)
	{
		delete [] arr;
		arr = NULL;
		size = 0;
	}

	size = obj.size;
	arr = new int [size];
	if(!arr)
	{
		MemoryException exc;
		throw exc;
	}

	for(int i=0; i<size; i++)
		arr[i] = obj.arr[i];

	return *this;
}

istream& operator>>(istream& stream, Array &obj)
{
	static int i = 0;
	static Array* current = &obj;
	if(current != &obj)
	{
		current = &obj;
		i = 0;
	}
	int input;
	stream >> input;
	if(input > 32678 || input < -32678)
	{
		RangeException exc;
		throw exc;
	}
	else if(i <= 0 || i > obj.size)
	{
		IndexException exc;
		throw exc;
	}
	else
	{
		obj.arr[i] = input;
		i++;
	}
	return stream;
}

ostream& operator<<(ostream& stream, Array &obj)
{
	if(!obj.size)
		return stream;
	for(int i=0; i<obj.size; i++)
		stream << setw(4) << obj.arr[i];
	stream << endl;
	return stream;
}
