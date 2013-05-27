#ifndef LAB402_H
#define LAB402_H

#include <iostream>
using namespace std;
#include <fstream>
#include <string>
#include <conio.h>
#include "FileIO.h"
#include "..\Lab305\Human.cpp"
#include "..\Lab307\Stack.cpp"

ostream& operator<<(ostream&, Human&);
ostream& operator<<(ostream&, Teacher&);
ostream& operator<<(ostream&, Partymember&);
ostream& operator<<(ostream&, TeacherPartymember&);

template <typename T>
void DumpStacks(T &, Stack<Human> &, Stack<Teacher> &, Stack<Partymember> &, Stack<TeacherPartymember> &);

template <typename T>
void RestoreStacks(T &, Stack<Human> &, Stack<Teacher> &, Stack<Partymember> &, Stack<TeacherPartymember> &);

#endif LAB402_H
