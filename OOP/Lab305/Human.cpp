#include "Human.h"

Human::Human()
{
	Surname = NULL;
	SurnameSize = 0;

	Name = NULL;
	NameSize = 0;

	Middlename = NULL;
	MiddlenameSize = 0;

	Birthday = NULL;
	BirthdaySize = 0;
}

Human::Human(char *_sname, char *_name, char *_mname, char *_bday)
{
	SurnameSize = strlen(_sname);
	if(SurnameSize > 0)
	{
		Surname = new char [SurnameSize+1];
		memset(Surname, '\0', SurnameSize+1);
		strncpy(Surname, _sname, SurnameSize+1);
	}

	NameSize = strlen(_name);
	if(NameSize > 0)
	{
		Name = new char [NameSize+1];
		memset(Name, '\0', NameSize+1);
		strncpy(Name, _name, NameSize+1);
	}

	MiddlenameSize = strlen(_mname);
	if(MiddlenameSize > 0)
	{
		Middlename = new char [MiddlenameSize+1];
		memset(Middlename, '\0', MiddlenameSize+1);
		strncpy(Middlename, _mname, MiddlenameSize+1);
	}

	BirthdaySize = strlen(_bday);
	if(BirthdaySize > 0)
	{
		Birthday = new char [BirthdaySize+1];
		memset(Birthday, '\0', BirthdaySize+1);
		strncpy(Birthday, _bday, BirthdaySize+1);
	}
}

Human::Human(const Human &obj)
{
	SurnameSize = obj.SurnameSize;
	if(SurnameSize > 0)
	{
		Surname = new char [SurnameSize+1];
		memset(Surname, '\0', SurnameSize+1);
		strncpy(Surname, obj.Surname, SurnameSize+1);
	}

	NameSize = obj.NameSize;
	if(NameSize > 0)
	{
		Name = new char [NameSize+1];
		memset(Name, '\0', NameSize+1);
		strncpy(Name, obj.Name, NameSize+1);
	}

	MiddlenameSize = obj.MiddlenameSize;
	if(MiddlenameSize > 0)
	{
		Middlename = new char [MiddlenameSize+1];
		memset(Middlename, '\0', MiddlenameSize+1);
		strncpy(Middlename, obj.Middlename, MiddlenameSize+1);
	}

	BirthdaySize = obj.BirthdaySize;
	if(BirthdaySize > 0)
	{
		Birthday = new char [BirthdaySize+1];
		memset(Birthday, '\0', BirthdaySize+1);
		strncpy(Birthday, obj.Birthday, BirthdaySize+1);
	}
}

Human Human::operator=(const Human &obj)
{
	if(this == &obj)
		return *this;

	if(SurnameSize > 0)
	{
		delete [] Surname;
		Surname = NULL;
		SurnameSize = 0;
	}
	SurnameSize = obj.SurnameSize;
	if(SurnameSize > 0)
	{
		Surname = new char [SurnameSize+1];
		memset(Surname, '\0', SurnameSize+1);
		strncpy(Surname, obj.Surname, SurnameSize+1);
	}

	if(NameSize > 0)
	{
		delete [] Name;
		Name = NULL;
		NameSize = 0;
	}
	NameSize = obj.NameSize;
	if(NameSize > 0)
	{
		Name = new char [NameSize+1];
		memset(Name, '\0', NameSize+1);
		strncpy(Name, obj.Name, NameSize+1);
	}

	if(MiddlenameSize > 0)
	{
		delete [] Middlename;
		Middlename = NULL;
		MiddlenameSize = 0;
	}
	MiddlenameSize = obj.MiddlenameSize;
	if(MiddlenameSize > 0)
	{
		Middlename = new char [MiddlenameSize+1];
		memset(Middlename, '\0', MiddlenameSize+1);
		strncpy(Middlename, obj.Middlename, MiddlenameSize+1);
	}

	if(BirthdaySize > 0)
	{
		delete [] Birthday;
		Birthday = NULL;
		BirthdaySize = 0;
	}
	BirthdaySize = obj.BirthdaySize;
	if(BirthdaySize > 0)
	{
		Birthday = new char [BirthdaySize+1];
		memset(Birthday, '\0', BirthdaySize+1);
		strncpy(Birthday, obj.Birthday, BirthdaySize+1);
	}

	return *this;
}

Human::~Human()
{
	if(SurnameSize > 0)
	{
		delete [] Surname;
		Surname = NULL;
		SurnameSize = 0;
	}
	if(NameSize > 0)
	{
		delete [] Name;
		Name = NULL;
		NameSize = 0;
	}
	if(MiddlenameSize > 0)
	{
		delete [] Middlename;
		Middlename = NULL;
		MiddlenameSize = 0;
	}
	if(BirthdaySize > 0)
	{
		delete [] Birthday;
		Birthday = NULL;
		BirthdaySize = 0;
	}
}

char* Human::GetSurname()
{
	return Surname;
}

void Human::SetSurname(char *_sname)
{
	size_t _size = strlen(_sname);
	if(_size > 0)
	{
		if(SurnameSize > 0)
		{
			delete [] Surname;
			Surname = NULL;
			SurnameSize = 0;
		}
		SurnameSize = _size;
		Surname = new char [SurnameSize+1];
		memset(Surname, '\0', SurnameSize+1);
		strncpy(Surname, _sname, SurnameSize+1);
	}
}

char* Human::GetName()
{
	return Name;
}

void Human::SetName(char *_name)
{
	size_t _size = strlen(_name);
	if(_size > 0)
	{
		if(NameSize > 0)
		{
			delete [] Name;
			Name = NULL;
			NameSize = 0;
		}
		NameSize = _size;
		Name = new char [NameSize+1];
		memset(Name, '\0', NameSize+1);
		strncpy(Name, _name, NameSize+1);
	}
}

char* Human::GetMiddlename()
{
	return Middlename;
}

void Human::SetMiddlename(char *_mname)
{
	size_t _size = strlen(_mname);
	if(_size > 0)
	{
		if(MiddlenameSize > 0)
		{
			delete [] Middlename;
			Middlename = NULL;
			MiddlenameSize = 0;
		}
		MiddlenameSize = _size;
		Middlename = new char [MiddlenameSize+1];
		memset(Middlename, '\0', MiddlenameSize+1);
		strncpy(Middlename, _mname, MiddlenameSize+1);
	}
}

char* Human::GetBirthday()
{
	return Birthday;
}

void Human::SetBirthday(char *_bday)
{
	size_t _size = strlen(_bday);
	if(_size > 0)
	{
		if(BirthdaySize > 0)
		{
			delete [] Birthday;
			Birthday = NULL;
			BirthdaySize = 0;
		}
		BirthdaySize = _size;
		Birthday = new char [BirthdaySize+1];
		memset(Birthday, '\0', BirthdaySize+1);
		strncpy(Birthday, _bday, BirthdaySize+1);
	}
}
/*****************************************************************************/
Teacher::Teacher()
{
	Job = NULL;
	JobSize = 0;

	Degree = NULL;
	DegreeSize = 0;

	Specialty = NULL;
	SpecialtySize = 0;

	TreatisesList = NULL;
	TreatisesListSize = 0;
}

Teacher::Teacher(char *_sname, char *_name, char *_mname, char *_bday,
				 char *_job, char *_degree, char *_spec, char *_list) :
	Human(_sname, _name, _mname, _bday)
{
	JobSize = strlen(_job);
	if(JobSize > 0)
	{
		Job = new char [JobSize+1];
		memset(Job, '\0', JobSize+1);
		strncpy(Job, _job, JobSize+1);
	}

	DegreeSize = strlen(_degree);
	if(DegreeSize > 0)
	{
		Degree = new char [DegreeSize+1];
		memset(Degree, '\0', DegreeSize+1);
		strncpy(Degree, _degree, DegreeSize+1);
	}

	SpecialtySize = strlen(_spec);
	if(SpecialtySize > 0)
	{
		Specialty = new char [SpecialtySize+1];
		memset(Specialty, '\0', SpecialtySize+1);
		strncpy(Specialty, _spec, SpecialtySize+1);
	}

	TreatisesListSize = strlen(_list);
	if(TreatisesListSize > 0)
	{
		TreatisesList = new char [TreatisesListSize+1];
		memset(TreatisesList, '\0', TreatisesListSize+1);
		strncpy(TreatisesList, _list, TreatisesListSize+1);
	}
}

Teacher::Teacher(const Teacher &obj) :
	Human(obj)
{
	JobSize = obj.JobSize;
	if(JobSize > 0)
	{
		Job = new char [JobSize+1];
		memset(Job, '\0', JobSize+1);
		strncpy(Job, obj.Job, JobSize+1);
	}

	DegreeSize = obj.DegreeSize;
	if(DegreeSize > 0)
	{
		Degree = new char [DegreeSize+1];
		memset(Degree, '\0', DegreeSize+1);
		strncpy(Degree, obj.Degree, DegreeSize+1);
	}

	SpecialtySize = obj.SpecialtySize;
	if(SpecialtySize > 0)
	{
		Specialty = new char [SpecialtySize+1];
		memset(Specialty, '\0', SpecialtySize+1);
		strncpy(Specialty, obj.Specialty, SpecialtySize+1);
	}

	TreatisesListSize = obj.TreatisesListSize;
	if(TreatisesListSize > 0)
	{
		TreatisesList = new char [TreatisesListSize+1];
		memset(TreatisesList, '\0', TreatisesListSize+1);
		strncpy(TreatisesList, obj.TreatisesList, TreatisesListSize+1);
	}
}

Teacher Teacher::operator=(const Teacher &obj)
{
	if(this == &obj)
		return *this;

	if(SurnameSize > 0)
	{
		delete [] Surname;
		Surname = NULL;
		SurnameSize = 0;
	}
	SurnameSize = obj.SurnameSize;
	if(SurnameSize > 0)
	{
		Surname = new char [SurnameSize+1];
		memset(Surname, '\0', SurnameSize+1);
		strncpy(Surname, obj.Surname, SurnameSize+1);
	}

	if(NameSize > 0)
	{
		delete [] Name;
		Name = NULL;
		NameSize = 0;
	}
	NameSize = obj.NameSize;
	if(NameSize > 0)
	{
		Name = new char [NameSize+1];
		memset(Name, '\0', NameSize+1);
		strncpy(Name, obj.Name, NameSize+1);
	}

	if(MiddlenameSize > 0)
	{
		delete [] Middlename;
		Middlename = NULL;
		MiddlenameSize = 0;
	}
	MiddlenameSize = obj.MiddlenameSize;
	if(MiddlenameSize > 0)
	{
		Middlename = new char [MiddlenameSize+1];
		memset(Middlename, '\0', MiddlenameSize+1);
		strncpy(Middlename, obj.Middlename, MiddlenameSize+1);
	}

	if(BirthdaySize > 0)
	{
		delete [] Birthday;
		Birthday = NULL;
		BirthdaySize = 0;
	}
	BirthdaySize = obj.BirthdaySize;
	if(BirthdaySize > 0)
	{
		Birthday = new char [BirthdaySize+1];
		memset(Birthday, '\0', BirthdaySize+1);
		strncpy(Birthday, obj.Birthday, BirthdaySize+1);
	}

	if(JobSize > 0)
	{
		delete [] Job;
		Job = NULL;
		JobSize = 0;
	}
	JobSize = obj.JobSize;
	if(JobSize > 0)
	{
		Job = new char [JobSize+1];
		memset(Job, '\0', JobSize+1);
		strncpy(Job, obj.Job, JobSize+1);
	}

	if(DegreeSize > 0)
	{
		delete [] Degree;
		Degree = NULL;
		DegreeSize = 0;
	}
	DegreeSize = obj.DegreeSize;
	if(DegreeSize > 0)
	{
		Degree = new char [DegreeSize+1];
		memset(Degree, '\0', DegreeSize+1);
		strncpy(Degree, obj.Degree, DegreeSize+1);
	}

	if(SpecialtySize > 0)
	{
		delete [] Specialty;
		Specialty = NULL;
		SpecialtySize = 0;
	}
	SpecialtySize = obj.SpecialtySize;
	if(SpecialtySize > 0)
	{
		Specialty = new char [SpecialtySize+1];
		memset(Specialty, '\0', SpecialtySize+1);
		strncpy(Specialty, obj.Specialty, SpecialtySize+1);
	}

	if(TreatisesListSize > 0)
	{
		delete [] TreatisesList;
		TreatisesList = NULL;
		TreatisesListSize = 0;
	}
	TreatisesListSize = obj.TreatisesListSize;
	if(TreatisesListSize > 0)
	{
		TreatisesList = new char [TreatisesListSize+1];
		memset(TreatisesList, '\0', TreatisesListSize+1);
		strncpy(TreatisesList, obj.TreatisesList, TreatisesListSize+1);
	}

	return *this;
}

Teacher::~Teacher()
{
	if(JobSize > 0)
	{
		delete [] Job;
		Job = NULL;
		JobSize = 0;
	}
	if(DegreeSize > 0)
	{
		delete [] Degree;
		Degree = NULL;
		DegreeSize = 0;
	}
	if(SpecialtySize > 0)
	{
		delete [] Specialty;
		Specialty = NULL;
		SpecialtySize = 0;
	}
	if(TreatisesListSize > 0)
	{
		delete [] TreatisesList;
		TreatisesList = NULL;
		TreatisesListSize = 0;
	}
}

char* Teacher::GetJob()
{
	return Job;
}

void Teacher::SetJob(char *_job)
{
	size_t _size = strlen(_job);
	if(_size > 0)
	{
		if(JobSize > 0)
		{
			delete [] Job;
			Job = NULL;
			JobSize = 0;
		}
		JobSize = _size;
		Job = new char [JobSize+1];
		memset(Job, '\0', JobSize+1);
		strncpy(Job, _job, JobSize+1);
	}
}

char* Teacher::GetDegree()
{
	return Degree;
}

void Teacher::SetDegree(char *_degree)
{
	size_t _size = strlen(_degree);
	if(_size > 0)
	{
		if(DegreeSize > 0)
		{
			delete [] Degree;
			Degree = NULL;
			DegreeSize = 0;
		}
		DegreeSize = _size;
		Degree = new char [DegreeSize+1];
		memset(Degree, '\0', DegreeSize+1);
		strncpy(Degree, _degree, DegreeSize+1);
	}
}

char* Teacher::GetSpecialty()
{
	return Specialty;
}

void Teacher::SetSpecialty(char *_spec)
{
	size_t _size = strlen(_spec);
	if(_size > 0)
	{
		if(SpecialtySize > 0)
		{
			delete [] Specialty;
			Specialty = NULL;
			SpecialtySize = 0;
		}
		SpecialtySize = _size;
		Specialty = new char [SpecialtySize+1];
		memset(Specialty, '\0', SpecialtySize+1);
		strncpy(Specialty, _spec, SpecialtySize+1);
	}
}

char* Teacher::GetTreatises()
{
	return TreatisesList;
}

void Teacher::SetTreatises(char *_list)
{
	size_t _size = strlen(_list);
	if(_size > 0)
	{
		if(TreatisesListSize > 0)
		{
			delete [] TreatisesList;
			TreatisesList = NULL;
			TreatisesListSize = 0;
		}
		TreatisesListSize = _size;
		TreatisesList = new char [TreatisesListSize+1];
		memset(TreatisesList, '\0', TreatisesListSize+1);
		strncpy(TreatisesList, _list, TreatisesListSize+1);
	}
}
/*****************************************************************************/
Partymember::Partymember()
{
	Party = NULL;
	PartySize = 0;

	JoinDate = NULL;
	JoinDateSize = 0;

	Identifier = NULL;
	IdentifierSize = 0;

	Autobiography = NULL;
	AutobiographySize = 0;
}

Partymember::Partymember(char *_sname, char *_name, char *_mname, char *_bday,
				 char *_party, char *_jday, char *_id, char *_story) :
	Human(_sname, _name, _mname, _bday)
{
	PartySize = strlen(_party);
	if(PartySize > 0)
	{
		Party = new char [PartySize+1];
		memset(Party, '\0', PartySize+1);
		strncpy(Party, _party, PartySize+1);
	}

	JoinDateSize = strlen(_jday);
	if(JoinDateSize > 0)
	{
		JoinDate = new char [JoinDateSize+1];
		memset(JoinDate, '\0', JoinDateSize+1);
		strncpy(JoinDate, _jday, JoinDateSize+1);
	}

	IdentifierSize = strlen(_id);
	if(IdentifierSize > 0)
	{
		Identifier = new char [IdentifierSize+1];
		memset(Identifier, '\0', IdentifierSize+1);
		strncpy(Identifier, _id, IdentifierSize+1);
	}

	AutobiographySize = strlen(_story);
	if(AutobiographySize > 0)
	{
		Autobiography = new char [AutobiographySize+1];
		memset(Autobiography, '\0', AutobiographySize+1);
		strncpy(Autobiography, _story, AutobiographySize+1);
	}
}

Partymember::Partymember(const Partymember &obj) :
	Human(obj)
{
	PartySize = obj.PartySize;
	if(PartySize > 0)
	{
		Party = new char [PartySize+1];
		memset(Party, '\0', PartySize+1);
		strncpy(Party, obj.Party, PartySize+1);
	}

	JoinDateSize = obj.JoinDateSize;
	if(JoinDateSize > 0)
	{
		JoinDate = new char [JoinDateSize+1];
		memset(JoinDate, '\0', JoinDateSize+1);
		strncpy(JoinDate, obj.JoinDate, JoinDateSize+1);
	}

	IdentifierSize = obj.IdentifierSize;
	if(IdentifierSize > 0)
	{
		Identifier = new char [IdentifierSize+1];
		memset(Identifier, '\0', IdentifierSize+1);
		strncpy(Identifier, obj.Identifier, IdentifierSize+1);
	}

	AutobiographySize = obj.AutobiographySize;
	if(AutobiographySize > 0)
	{
		Autobiography = new char [AutobiographySize+1];
		memset(Autobiography, '\0', AutobiographySize+1);
		strncpy(Autobiography, obj.Autobiography, AutobiographySize+1);
	}
}

Partymember Partymember::operator=(const Partymember &obj)
{
	if(this == &obj)
		return *this;

	if(SurnameSize > 0)
	{
		delete [] Surname;
		Surname = NULL;
		SurnameSize = 0;
	}
	SurnameSize = obj.SurnameSize;
	if(SurnameSize > 0)
	{
		Surname = new char [SurnameSize+1];
		memset(Surname, '\0', SurnameSize+1);
		strncpy(Surname, obj.Surname, SurnameSize+1);
	}

	if(NameSize > 0)
	{
		delete [] Name;
		Name = NULL;
		NameSize = 0;
	}
	NameSize = obj.NameSize;
	if(NameSize > 0)
	{
		Name = new char [NameSize+1];
		memset(Name, '\0', NameSize+1);
		strncpy(Name, obj.Name, NameSize+1);
	}

	if(MiddlenameSize > 0)
	{
		delete [] Middlename;
		Middlename = NULL;
		MiddlenameSize = 0;
	}
	MiddlenameSize = obj.MiddlenameSize;
	if(MiddlenameSize > 0)
	{
		Middlename = new char [MiddlenameSize+1];
		memset(Middlename, '\0', MiddlenameSize+1);
		strncpy(Middlename, obj.Middlename, MiddlenameSize+1);
	}

	if(BirthdaySize > 0)
	{
		delete [] Birthday;
		Birthday = NULL;
		BirthdaySize = 0;
	}
	BirthdaySize = obj.BirthdaySize;
	if(BirthdaySize > 0)
	{
		Birthday = new char [BirthdaySize+1];
		memset(Birthday, '\0', BirthdaySize+1);
		strncpy(Birthday, obj.Birthday, BirthdaySize+1);
	}

	if(PartySize > 0)
	{
		delete [] Party;
		Party = NULL;
		PartySize = 0;
	}
	PartySize = obj.PartySize;
	if(PartySize > 0)
	{
		Party = new char [PartySize+1];
		memset(Party, '\0', PartySize+1);
		strncpy(Party, obj.Party, PartySize+1);
	}

	if(JoinDateSize > 0)
	{
		delete [] JoinDate;
		JoinDate = NULL;
		JoinDateSize = 0;
	}

	JoinDateSize = obj.JoinDateSize;
	if(JoinDateSize > 0)
	{
		JoinDate = new char [JoinDateSize+1];
		memset(JoinDate, '\0', JoinDateSize+1);
		strncpy(JoinDate, obj.JoinDate, JoinDateSize+1);
	}

	if(IdentifierSize > 0)
	{
		delete [] Identifier;
		Identifier = NULL;
		IdentifierSize = 0;
	}
	IdentifierSize = obj.IdentifierSize;
	if(IdentifierSize > 0)
	{
		Identifier = new char [IdentifierSize+1];
		memset(Identifier, '\0', IdentifierSize+1);
		strncpy(Identifier, obj.Identifier, IdentifierSize+1);
	}

	if(AutobiographySize > 0)
	{
		delete [] Autobiography;
		Autobiography = NULL;
		AutobiographySize = 0;
	}
	AutobiographySize = obj.AutobiographySize;
	if(AutobiographySize > 0)
	{
		Autobiography = new char [AutobiographySize+1];
		memset(Autobiography, '\0', AutobiographySize+1);
		strncpy(Autobiography, obj.Autobiography, AutobiographySize+1);
	}

	return *this;
}

Partymember::~Partymember()
{
	if(PartySize > 0)
	{
		delete [] Party;
		Party = NULL;
		PartySize = 0;
	}
	if(JoinDateSize > 0)
	{
		delete [] JoinDate;
		JoinDate = NULL;
		JoinDateSize = 0;
	}
	if(IdentifierSize > 0)
	{
		delete [] Identifier;
		Identifier = NULL;
		IdentifierSize = 0;
	}
	if(AutobiographySize > 0)
	{
		delete [] Autobiography;
		Autobiography = NULL;
		AutobiographySize = 0;
	}
}

char* Partymember::GetParty()
{
	return Party;
}

void Partymember::SetParty(char *_party)
{
	size_t _size = strlen(_party);
	if(_size > 0)
	{
		if(PartySize > 0)
		{
			delete [] Party;
			Party = NULL;
			PartySize = 0;
		}
		PartySize = _size;
		Party = new char [PartySize+1];
		memset(Party, '\0', PartySize+1);
		strncpy(Party, _party, PartySize+1);
	}
}

char* Partymember::GetJoinDate()
{
	return JoinDate;
}

void Partymember::SetJoinDate(char *_jday)
{
	size_t _size = strlen(_jday);
	if(_size > 0)
	{
		if(JoinDateSize > 0)
		{
			delete [] JoinDate;
			JoinDate = NULL;
			JoinDateSize = 0;
		}
		JoinDateSize = _size;
		JoinDate = new char [JoinDateSize+1];
		memset(JoinDate, '\0', JoinDateSize+1);
		strncpy(JoinDate, _jday, JoinDateSize+1);
	}
}

char* Partymember::GetIdentifier()
{
	return Identifier;
}

void Partymember::SetIdentifier(char *_id)
{
	size_t _size = strlen(_id);
	if(_size > 0)
	{
		if(IdentifierSize > 0)
		{
			delete [] Identifier;
			Identifier = NULL;
			IdentifierSize = 0;
		}
		IdentifierSize = _size;
		Identifier = new char [IdentifierSize+1];
		memset(Identifier, '\0', IdentifierSize+1);
		strncpy(Identifier, _id, IdentifierSize+1);
	}
}

char* Partymember::GetAutobiography()
{
	return Autobiography;
}

void Partymember::SetAutobiography(char *_story)
{
	size_t _size = strlen(_story);
	if(_size > 0)
	{
		if(AutobiographySize > 0)
		{
			delete [] Autobiography;
			Autobiography = NULL;
			AutobiographySize = 0;
		}
		AutobiographySize = _size;
		Autobiography = new char [AutobiographySize+1];
		memset(Autobiography, '\0', AutobiographySize+1);
		strncpy(Autobiography, _story, AutobiographySize+1);
	}
}
/*****************************************************************************/
TeacherPartymember::TeacherPartymember()
{
	Publications = NULL;
	PublicationsSize = 0;
}

TeacherPartymember::TeacherPartymember(char *_sname, char *_name, char *_lname, char *_bday,
				char *_job, char *_degree, char *_spec, char *_list,
				char *_party, char *_jday, char *_id, char *_story,
				char *_written) :
	Human(_sname, _name, _lname, _bday),
	Teacher(_sname, _name, _lname, _bday, _job, _degree, _spec, _list),
	Partymember(_sname, _name, _lname, _bday, _party, _jday, _id, _story)
{
	PublicationsSize = strlen(_written);
	if(PublicationsSize > 0)
	{
		Publications = new char [PublicationsSize+1];
		memset(Publications, '\0', PublicationsSize+1);
		strncpy(Publications, _written, PublicationsSize+1);
	}
}

TeacherPartymember::TeacherPartymember(const TeacherPartymember &obj) :
	Human(obj), Teacher(obj), Partymember(obj)
{
	PublicationsSize = obj.PublicationsSize;
	if(PublicationsSize > 0)
	{
		Publications = new char [PublicationsSize+1];
		memset(Publications, '\0', PublicationsSize+1);
		strncpy(Publications, obj.Publications, PublicationsSize+1);
	}
}

TeacherPartymember TeacherPartymember::operator=(const TeacherPartymember &obj)
{
	if(this == &obj)
		return *this;

	if(SurnameSize > 0)
	{
		delete [] Surname;
		Surname = NULL;
		SurnameSize = 0;
	}
	SurnameSize = obj.SurnameSize;
	if(SurnameSize > 0)
	{
		Surname = new char [SurnameSize+1];
		memset(Surname, '\0', SurnameSize+1);
		strncpy(Surname, obj.Surname, SurnameSize+1);
	}

	if(NameSize > 0)
	{
		delete [] Name;
		Name = NULL;
		NameSize = 0;
	}
	NameSize = obj.NameSize;
	if(NameSize > 0)
	{
		Name = new char [NameSize+1];
		memset(Name, '\0', NameSize+1);
		strncpy(Name, obj.Name, NameSize+1);
	}

	if(MiddlenameSize > 0)
	{
		delete [] Middlename;
		Middlename = NULL;
		MiddlenameSize = 0;
	}
	MiddlenameSize = obj.MiddlenameSize;
	if(MiddlenameSize > 0)
	{
		Middlename = new char [MiddlenameSize+1];
		memset(Middlename, '\0', MiddlenameSize+1);
		strncpy(Middlename, obj.Middlename, MiddlenameSize+1);
	}

	if(BirthdaySize > 0)
	{
		delete [] Birthday;
		Birthday = NULL;
		BirthdaySize = 0;
	}
	BirthdaySize = obj.BirthdaySize;
	if(BirthdaySize > 0)
	{
		Birthday = new char [BirthdaySize+1];
		memset(Birthday, '\0', BirthdaySize+1);
		strncpy(Birthday, obj.Birthday, BirthdaySize+1);
	}

	if(JobSize > 0)
	{
		delete [] Job;
		Job = NULL;
		JobSize = 0;
	}
	JobSize = obj.JobSize;
	if(JobSize > 0)
	{
		Job = new char [JobSize+1];
		memset(Job, '\0', JobSize+1);
		strncpy(Job, obj.Job, JobSize+1);
	}

	if(DegreeSize > 0)
	{
		delete [] Degree;
		Degree = NULL;
		DegreeSize = 0;
	}
	DegreeSize = obj.DegreeSize;
	if(DegreeSize > 0)
	{
		Degree = new char [DegreeSize+1];
		memset(Degree, '\0', DegreeSize+1);
		strncpy(Degree, obj.Degree, DegreeSize+1);
	}

	if(SpecialtySize > 0)
	{
		delete [] Specialty;
		Specialty = NULL;
		SpecialtySize = 0;
	}
	SpecialtySize = obj.SpecialtySize;
	if(SpecialtySize > 0)
	{
		Specialty = new char [SpecialtySize+1];
		memset(Specialty, '\0', SpecialtySize+1);
		strncpy(Specialty, obj.Specialty, SpecialtySize+1);
	}

	if(TreatisesListSize > 0)
	{
		delete [] TreatisesList;
		TreatisesList = NULL;
		TreatisesListSize = 0;
	}
	TreatisesListSize = obj.TreatisesListSize;
	if(TreatisesListSize > 0)
	{
		TreatisesList = new char [TreatisesListSize+1];
		memset(TreatisesList, '\0', TreatisesListSize+1);
		strncpy(TreatisesList, obj.TreatisesList, TreatisesListSize+1);
	}

	if(PartySize > 0)
	{
		delete [] Party;
		Party = NULL;
		PartySize = 0;
	}
	PartySize = obj.PartySize;
	if(PartySize > 0)
	{
		Party = new char [PartySize+1];
		memset(Party, '\0', PartySize+1);
		strncpy(Party, obj.Party, PartySize+1);
	}

	if(JoinDateSize > 0)
	{
		delete [] JoinDate;
		JoinDate = NULL;
		JoinDateSize = 0;
	}

	JoinDateSize = obj.JoinDateSize;
	if(JoinDateSize > 0)
	{
		JoinDate = new char [JoinDateSize+1];
		memset(JoinDate, '\0', JoinDateSize+1);
		strncpy(JoinDate, obj.JoinDate, JoinDateSize+1);
	}

	if(IdentifierSize > 0)
	{
		delete [] Identifier;
		Identifier = NULL;
		IdentifierSize = 0;
	}
	IdentifierSize = obj.IdentifierSize;
	if(IdentifierSize > 0)
	{
		Identifier = new char [IdentifierSize+1];
		memset(Identifier, '\0', IdentifierSize+1);
		strncpy(Identifier, obj.Identifier, IdentifierSize+1);
	}

	if(AutobiographySize > 0)
	{
		delete [] Autobiography;
		Autobiography = NULL;
		AutobiographySize = 0;
	}
	AutobiographySize = obj.AutobiographySize;
	if(AutobiographySize > 0)
	{
		Autobiography = new char [AutobiographySize+1];
		memset(Autobiography, '\0', AutobiographySize+1);
		strncpy(Autobiography, obj.Autobiography, AutobiographySize+1);
	}

	if(PublicationsSize > 0)
	{
		delete [] Publications;
		Publications = NULL;
		PublicationsSize = 0;
	}
	PublicationsSize = obj.PublicationsSize;
	if(PublicationsSize > 0)
	{
		Publications = new char [PublicationsSize+1];
		memset(Publications, '\0', PublicationsSize+1);
		strncpy(Publications, obj.Publications, PublicationsSize+1);
	}

	return *this;
}

TeacherPartymember::~TeacherPartymember()
{
	if(PublicationsSize > 0)
	{
		delete [] Publications;
		Publications = NULL;
		PublicationsSize = 0;
	}
}

char* TeacherPartymember::GetPublications()
{
	return Publications;
}

void TeacherPartymember::SetPublications(char *_written)
{
	size_t _size = strlen(_written);
	if(_size > 0)
	{
		if(PublicationsSize > 0)
		{
			delete [] Publications;
			Publications = NULL;
			PublicationsSize = 0;
		}
		PartySize = _size;
		Publications = new char [PublicationsSize+1];
		memset(Publications, '\0', PublicationsSize+1);
		strncpy(Publications, _written, PublicationsSize+1);
	}
}
