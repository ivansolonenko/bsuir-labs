#include "Stack.h"

template <typename T>
Stack<T>::Stack()
{
	begin = end = NULL;
}

template <typename T>
Stack<T>::Stack(const Stack &)
{
	// throw "Undefined action";
}

template <typename T>
Stack<T>::~Stack()
{
	if(IsEmpty() == false)
	{
		Node<T> *current = begin, *temp;
		while(current != NULL)
		{
			temp = current;
			current = temp->next;
			delete temp;
		}
	}
}

template <typename T>
bool Stack<T>::IsEmpty() const
{
	return (begin == NULL);
}

template <typename T>
Node<T>* Stack<T>::CreateNewNode(const T &obj)
{
	Node<T> *ptr = new Node<T> (obj);
	if(NULL == ptr)
	{
		MemoryException exc;
		throw exc;
	}
	return ptr;
}

template <typename T>
void Stack<T>::Push(const T &obj)
{
	RangeException exc;
	if( typeid(T) == typeid(char) )
	{
		if(obj >= SCHAR_MAX || obj < SCHAR_MIN)
			throw exc;
	}
	else if( typeid(T) == typeid(short) )
	{
		if(obj >= SHRT_MAX || obj < SHRT_MIN)
			throw exc;
	}
	else if( typeid(T) == typeid(unsigned short) )
	{
		if(obj >= USHRT_MAX || obj < 0)
			throw exc;
	}
	else if( typeid(T) == typeid(int) )
	{
		if(obj >= INT_MAX || obj < INT_MIN)
			throw exc;
	}
	else if( typeid(T) == typeid(unsigned int) )
	{
		if(obj >= UINT_MAX || obj < 0)
			throw exc;
	}

	Node<T> *ptr = CreateNewNode(obj);
	if(IsEmpty() == true)
		begin = end = ptr;
	else
	{
		ptr->next = begin;
		begin = ptr;
	}
}

template <typename T>
T Stack<T>::Pop()
{
	T rvalue = NULL;
	if(IsEmpty() == true)
		return rvalue;
	Node<T> *temp = begin;
	if(begin == end)
		begin = end = NULL;
	else
		begin = begin->next;
	rvalue = temp->value;
	delete temp;
	return rvalue;
}
