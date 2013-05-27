// Diamond Inheritance
// class Human, class Teacher, class Partymember, class TeacherPartymember

#ifndef HUMAN_H
#define HUMAN_H

#include <iostream>
using namespace std;

#pragma warning(disable: 4996)

class Human
{
protected:
	char *Surname;
	size_t SurnameSize;
	char *Name;
	size_t NameSize;
	char *Middlename;
	size_t MiddlenameSize;
	char *Birthday;
	size_t BirthdaySize;
public:
	Human();
	Human(char*, char*, char*, char*);
	Human(const Human &);
	Human operator=(const Human &);
	~Human();

	char* GetSurname();
	void SetSurname(char*);
	char* GetName();
	void SetName(char*);
	char* GetMiddlename();
	void SetMiddlename(char*);
	char* GetBirthday();
	void SetBirthday(char*);
};

class Teacher : public virtual Human
{
protected:
	char *Job;
	size_t JobSize;
	char *Degree;
	size_t DegreeSize;
	char *Specialty;
	size_t SpecialtySize;
	char *TreatisesList;
	size_t TreatisesListSize;
public:
	Teacher();
	Teacher(char*, char*, char*, char*,
		char*, char*, char*, char*);
	Teacher(const Teacher &);
	Teacher operator=(const Teacher &);
	~Teacher();

	char* GetJob();
	void SetJob(char*);
	char* GetDegree();
	void SetDegree(char*);
	char* GetSpecialty();
	void SetSpecialty(char*);
	char* GetTreatises();
	void SetTreatises(char*);
};

class Partymember : public virtual Human
{
protected:
	char *Party;
	size_t PartySize;
	char *JoinDate;
	size_t JoinDateSize;
	char *Identifier;
	size_t IdentifierSize;
	char *Autobiography;
	size_t AutobiographySize;
public:
	Partymember();
	Partymember(char*, char*, char*, char*,
		char*, char*, char*, char*);
	Partymember(const Partymember &);
	Partymember operator=(const Partymember &);
	~Partymember();

	char* GetParty();
	void SetParty(char*);
	char* GetJoinDate();
	void SetJoinDate(char*);
	char* GetIdentifier();
	void SetIdentifier(char*);
	char* GetAutobiography();
	void SetAutobiography(char*);
};

class TeacherPartymember: public Teacher, public Partymember
{
protected:
	char *Publications;
	size_t PublicationsSize;
public:
	TeacherPartymember();
	TeacherPartymember(char*, char*, char*, char*,
		char*, char*, char*, char*,
		char*, char*, char*, char*,
		char*);
	TeacherPartymember(const TeacherPartymember &);
	TeacherPartymember operator=(const TeacherPartymember &);
	~TeacherPartymember();

	char* GetPublications();
	void SetPublications(char*);
};

#endif HUMAN_H
