/*
Шаблон типа очередь для любых (встроенных и пользовательских) типов

TO-DO: Использование объектов множественного наследования и smart-указатели
*/

#include "Lab306.h"

void main()
{
	int i, int_size, double_size, str_size;
	char buf[256];

	int int_buf;
	double double_buf;
	string str_buf;

	Queue<int> q_int;
	Queue<double> *q_double = new Queue<double>;
	Queue<string> q_str;

	/**************************/
	cout << "INT queue length: ";
	cin >> buf;
	int_size = atoi(buf);
	for(i=0; i<int_size; i++)
	{
		cout << "$ ";
		cin >> int_buf; 
		q_int.Push(int_buf);
	}
	/**************************/
	cout << "DOUBLE queue length: ";
	cin >> buf;
	double_size = atoi(buf);
	for(i=0; i<double_size; i++)
	{
		cout << "$ ";
		cin >> double_buf; 
		q_double->Push(double_buf);
	}
	/**************************/
	cout << "STRING queue length: ";
	cin >> buf;
	str_size = atoi(buf);
	for(i=0; i<str_size; i++)
	{
		cout << "$ ";
		cin >> str_buf;
		q_str.Push(str_buf);
	}
	/**************************/
	system("cls");
	/**************************/
	cout << "q_int: ";
	for(i=0; i<int_size; i++)
		cout << q_int.Pop() << "\t";
	cout << endl;
	/**************************/
	cout << "q_double: ";
	for(i=0; i<double_size; i++)
		cout << q_double->Pop() << "\t";
	cout << endl;
	/**************************/
	cout << "q_str: ";
	for(i=0; i<str_size; i++)
		cout << q_str.Pop() << "\t";
	cout << endl;

	delete q_double;
}
