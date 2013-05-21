#ifndef LAB0402_HPP
#define LAB0402_HPP

#include <iostream>
using namespace std;
#include <fstream>
#include <string>
#include <conio.h>
#include "FileIO.h"
#include "..\Lab0305\Human.cpp"
#include "..\Lab0307\Stack.cpp"

ostream& operator<<(ostream&, Human&);
ostream& operator<<(ostream&, Teacher&);
ostream& operator<<(ostream&, Partymember&);
ostream& operator<<(ostream&, TeacherPartymember&);

template <typename T>
void DumpStacks(T &, Stack<Human> &, Stack<Teacher> &, Stack<Partymember> &, Stack<TeacherPartymember> &);

template <typename T>
void RestoreStacks(T &, Stack<Human> &, Stack<Teacher> &, Stack<Partymember> &, Stack<TeacherPartymember> &);

#endif LAB0402_HPP
