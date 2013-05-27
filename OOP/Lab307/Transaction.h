#ifndef TRANSACTION_H
#define TRANSACTION_H

#include "Stack.cpp"

template <typename T>
class Transaction
{
	typedef char* (T::*get)();
	typedef void  (T::*set)(char *);
private:
	T *Property;
	Stack<T> undo;
public:
	Transaction();
	Transaction(const T &);
	~Transaction();

	void Commit(set, char *);
	char* Ensure(get);
	void Undo();
};

#endif TRANSACTION_H
