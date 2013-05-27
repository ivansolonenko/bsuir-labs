#include "Node.h"

template <typename T>
Node<T>::Node()
{
	value = NULL;
	next = NULL;
	count++;
}

template <typename T>
Node<T>::Node(const T &obj)
{
	value = obj;
	next = NULL;
	count++;
}

template <typename T>
Node<T>::Node(const Node &obj)
{
	// throw "Undefined action";
}

template <typename T>
Node<T>::~Node()
{
	count--;
}

template <typename T>
T Node<T>::GetValue() const
{
	return value;
}

template <typename T>
size_t Node<T>::GetCount()
{
	return count;
}
