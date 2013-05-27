#include "Smartpointer.h"

template <typename T>
SmartPointer<T>::SmartPointer(T *ptr)
{
	if(!ptr)
		this->ptr = NULL;
	else
	{
		this->ptr = ptr;
		this->count++;
	}
}

template <typename T>
SmartPointer<T>::SmartPointer(SmartPointer<T> &obj)
{
	//this->ptr = obj.release();
	this->count++;
}

template <typename T>
SmartPointer<T>::~SmartPointer()
{
	if(NULL != ptr)
		delete ptr;
}

template <typename T>
SmartPointer<T>& SmartPointer<T>::operator=(SmartPointer<T> &obj)
{
	if(this != &obj)
		reset(obj.release());
	return *this;
}

template <typename T>
T& SmartPointer<T>::operator*() const
{
	return *ptr;
}

template <typename T>
T* SmartPointer<T>::operator->() const
{
	return ptr;
}

template <typename T>
T* SmartPointer<T>::get() const
{
	return ptr;
}

template <typename T>
T* SmartPointer<T>::release()
{
	T *_ptr = ptr;
	ptr = NULL;
	return _ptr;
}

template <typename T>
void SmartPointer<T>::reset(T *_ptr)
{
	if(ptr != _ptr)
	{
		delete ptr;
		ptr = _ptr;
	}
}
