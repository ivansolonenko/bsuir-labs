#ifndef NODE_H
#define NODE_H

template <typename T>
class Queue;

template <typename T>
class Stack;

template <typename T>
class Node
{
	friend class Queue<T>;
	friend class Stack<T>;
private:
	T value;
	Node *next;
	static size_t count;
public:
	Node();
	Node(const T &);
	Node(const Node &);
	~Node();
	T GetValue() const;
	static size_t GetCount();
};

template <typename T>
size_t Node<T>::count = 0;

#endif NODE_H
