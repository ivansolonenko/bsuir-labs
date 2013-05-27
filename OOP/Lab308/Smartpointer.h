#ifndef SMARTPOINTER_H
#define SMARTPOINTER_H

template <typename T>
class SmartPointer
{
private:
	T *ptr;
	unsigned int count;
public:
	explicit SmartPointer(T *p = NULL);
	SmartPointer(SmartPointer<T> &obj);
	~SmartPointer();
	SmartPointer<T>& operator=(SmartPointer<T> &obj);

	T& operator*() const;
	T* operator->() const;

	T* get() const;
	T* release();
	void reset(T *p = 0);
};

#endif SMARTPOINTER_H
