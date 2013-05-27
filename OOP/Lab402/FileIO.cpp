#include "FileIO.h"

BaseFile::BaseFile()
{
	file = NULL;
}

BaseFile::BaseFile(char *path, ios::open_mode permissions)
{
	this->name = path;
	try
	{
		file = new fstream;
		if(! file)
			throw "Can not allocate memory";
		file->open(path, permissions);
		if(! *file)
			throw "Can not open file";
	}
	catch(char *ErrorMsg)
	{
		cerr << ErrorMsg << endl;
	}
}

BaseFile::BaseFile(string path, ios::open_mode permissions)
{
	name = path;
	try
	{
		file = new fstream;
		if(! file)
			throw "Can not allocate memory";
		file->open(name.c_str(), permissions);
		if(! *file)
			throw "Can not open file";
	}
	catch(char *ErrorMsg)
	{
		cerr << ErrorMsg << endl;
	}
}

BaseFile::~BaseFile()
{
	if(file)
	{
		name.clear();
		file->close();
		delete file;
		file = NULL;
	}
}

bool BaseFile::EndOfFile()
{
	return file->eof();
}

TextFile& operator<<(TextFile &out, char *str)
{
	*(out).file << str << endl;
	return out;
}

TextFile& operator>>(TextFile &in, string &str)
{
	getline(*(in).file, str);
	return in;
}

BinaryFile& operator<<(BinaryFile &out, char *str)
{
	char buffer[256] = {0};
	strncpy(buffer, str, 255);
	out.file->write(reinterpret_cast<const char *>(&buffer), sizeof(buffer));
//	string buffer = str;
//	out.file->write(reinterpret_cast<const char *>(&buffer), sizeof(string));
	return out;
}

BinaryFile& operator>>(BinaryFile &in, string &str)
{
	char buffer[256] = {0};
	in.file->read(reinterpret_cast<char *>(&buffer), sizeof(buffer));
	str = buffer;
//	in.file->read(reinterpret_cast<char *>(&str), sizeof(string));
	return in;
}
