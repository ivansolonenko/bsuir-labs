#include "Queue.h"

template <typename T>
Queue<T>::Queue()
{
	begin = end = NULL;
}

template <typename T>
Queue<T>::Queue(const Queue &)
{
	// throw "Undefined action";
}

template <typename T>
Queue<T>::~Queue()
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
bool Queue<T>::IsEmpty() const
{
	return (begin == NULL);
}

template <typename T>
Node<T>* Queue<T>::CreateNewNode(const T &obj)
{
	Node<T> *ptr = new Node<T> (obj);
	return ptr;
}

template <typename T>
void Queue<T>::Push(const T &obj)
{
	Node<T> *ptr = CreateNewNode(obj);
	if(IsEmpty() == true)
		begin = end = ptr;
	else
	{
		end->next = ptr;
		end = ptr;
	}
}

template <typename T>
T Queue<T>::Pop()
{
	if(IsEmpty() == true)
		return (T)NULL;
	Node<T> *temp = begin;
	T rvalue;
	if(begin == end)
		begin = end = NULL;
	else
		begin = begin->next;
	rvalue = temp->value;
	delete temp;
	return rvalue;
}
