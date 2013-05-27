#ifndef STACK_H
#define STACK_H

#include "..\Lab306\Node.cpp"

template <typename T>
class Stack
{
private:
	Node<T> *begin;
	Node<T> *end;
	Node<T>* CreateNewNode(const T &);
public:
	Stack();
	Stack(const Stack &);
	~Stack();
	bool IsEmpty() const;
	void Push(const T &);
	T Pop();
};

#endif STACK_H
