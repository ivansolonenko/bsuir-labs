#ifndef LAB309_H
#define LAB309_H

#include <iostream>
using namespace std;
#include "property.cpp"
#include "..\Lab305\Human.cpp"

class NewHuman : public Human
{
public:
	Property <char*, Human> Surname;
	Property <char*, Human> Name;
	Property <char*, Human> Middlename;
	Property <char*, Human> Birthday;
	NewHuman()
	{
		Surname.init(this, &Human::GetSurname, &Human::SetSurname);
		Name.init(this, &Human::GetName, &Human::SetName);
		Middlename.init(this, &Human::GetMiddlename, &Human::SetMiddlename);
		Birthday.init(this, &Human::GetBirthday, &Human::SetBirthday);
	}
};

#endif LAB309_H
