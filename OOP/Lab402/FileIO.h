#ifndef FILEIO_H
#define FILEIO_H

#include <iostream>
using namespace std;
#include <fstream>
#include <string>
#include "..\Lab305\Human.h"
#include "..\Lab307\Stack.h"

class BaseFile
{
protected:
	string name;
	fstream* file;
public:
	BaseFile();
	BaseFile(char* path, ios::open_mode);
	BaseFile(string, ios::open_mode);
	~BaseFile();
	bool EndOfFile();
};

class TextFile : public BaseFile
{
public:
	TextFile() {};
	TextFile(char* path, ios::open_mode permissions) : BaseFile(path, permissions) {};
	TextFile(string path, ios::open_mode permissions) : BaseFile(path, permissions) {};
	~TextFile() {};

	friend TextFile& operator<<(TextFile &, char *);
	friend TextFile& operator>>(TextFile &, string &);
};

class BinaryFile : public BaseFile
{
public:
	BinaryFile() {};
	BinaryFile(char* path, ios::open_mode permissions) : BaseFile(path, permissions) {};
	BinaryFile(string path, ios::open_mode permissions) : BaseFile(path, permissions) {};
	~BinaryFile() {};

	friend BinaryFile& operator<<(BinaryFile &, char *);
	friend BinaryFile& operator>>(BinaryFile &, string &);

	/*
	struct FileHeader
	{
		unsigned int HumanCount;
		unsigned int TeacherCount;
		unsigned int PartymemberCount;
		unsigned int TeacherPartymemberCount;
	};
	*/

	// template <typename A, typename B, typename C>
	// void Dump(Stack<Human> &, Stack<Teacher> &, Stack<Partymember> &, Stack<TeacherPartymember> &);

	// template <typename A, typename B, typename C>
	// void Restore(Stack<Human> &, Stack<Teacher> &, Stack<Partymember> &, Stack<TeacherPartymember> &);
};

#endif FILEIO_H
