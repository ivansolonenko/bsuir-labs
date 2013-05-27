#ifndef QUEUE_H
#define QUEUE_H

#include "Node.cpp"

template <typename T>
class Queue
{
private:
	Node<T> *begin;
	Node<T> *end;
	Node<T>* CreateNewNode(const T &);
public:
	Queue();
	Queue(const Queue &);
	~Queue();
	void Push(const T &);
	T Pop();
	bool IsEmpty() const;
};

#endif QUEUE_H
