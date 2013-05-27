#include "Transaction.h"

template <typename T>
Transaction<T>::Transaction()
{
	Property = NULL;
}

template <typename T>
Transaction<T>::Transaction(const T &obj)
{
	Property = new T(obj);
}

template <typename T>
Transaction<T>::~Transaction()
{
	if(Property)
	{
		delete Property;
		Property = NULL;
	}
}

template <typename T>
void Transaction<T>::Commit(set set_method, char *x)
{
	if(NULL == Property)
		Property = new T;
	else
	{
		undo.Push(*Property);
	}
	(Property->*set_method)(x);
}

template <typename T>
char* Transaction<T>::Ensure(get get_method)
{
	return (Property->*get_method)();
}

template <typename T>
void Transaction<T>::Undo()
{
	if(undo.IsEmpty() == true)
		return;
	if(Property)
	{
		delete Property;
		Property = NULL;
	}
	Property = new T (undo.Pop());
}
