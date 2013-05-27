#include "Property.h"

template <typename T1, typename T2>
Property<T1,T2>::operator T1()
{
	if(NULL == owner || NULL == get_method)
		return NULL;
	return (owner->*get_method)();
}

template <typename T1, typename T2>
void Property<T1,T2>::operator=(T1 data)
{
	if(NULL == owner || NULL == set_method)
		return;
	(owner->*set_method)(data);
}

template <typename T1, typename T2>
Property<T1,T2>::Property() :
	owner(NULL), get_method(NULL), set_method(NULL)
{
	return;
}

template <typename T1, typename T2>
void Property<T1,T2>::init(T2* const owner, get get_method, set set_method)
{
	this->owner = owner;
	this->get_method = get_method;
	this->set_method = set_method;
}
