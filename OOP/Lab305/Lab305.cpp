#include "Lab305.h"

void main()
{
	Human person1("Ivanov", "Petr", "Sidorovich", "27.12.1991");
	Teacher person2("Ivanov", "Petr", "Sidorovich", "27.12.1991", "Lecturer", "Ph.Dr.", "Programmer", "\"Applied Programming\"");
	Partymember person3("Ivanov", "Petr", "Sidorovich", "27.12.1991", "The Party of Green", "2008", "id123456", "Not written yet :)");
	TeacherPartymember person4("Ivanov", "Petr", "Sidorovich", "27.12.1991", "Lecturer", "Ph.Dr.", "Programmer", "\"Applied Programming\"", "The Party of Green", "2008", "id123456", "Not written yet :)", "Politics And Programming");

	//char buf[256];

	cout << person1.GetSurname() << " " << person1.GetName() << " " << person1.GetMiddlename() << " - " << person1.GetBirthday() << endl;
	cout << endl;

	cout << person2.GetSurname() << " " << person2.GetName() << " " << person2.GetMiddlename() << " - " << person2.GetBirthday() << " - " << person2.GetJob() << " - " << person2.GetDegree() << " - " << person2.GetSpecialty() << " - " << person2.GetTreatises() << endl;
	cout << endl;

	cout << person3.GetSurname() << " " << person3.GetName() << " " << person3.GetMiddlename() << " - " << person3.GetBirthday() << " - " << person3.GetParty() << " - " << person3.GetJoinDate() << " - " << person3.GetIdentifier() << " - " << person3.GetAutobiography() << endl;
	cout << endl;

	cout << person4.GetSurname() << " " << person4.GetName() << " " << person4.GetMiddlename() << " - " << person4.GetBirthday() << " - " << person4.GetJob() << " - " << person4.GetDegree() << " - " << person4.GetSpecialty() << " - " << person4.GetTreatises() << person4.GetParty() << " - " << person4.GetJoinDate() << " - " << person4.GetIdentifier() << " - " << person4.GetAutobiography() <<  " - " << person4.GetAutobiography() << " - " << person4.GetPublications() << endl;
	cout << endl;

	TeacherPartymember *arr[2];
	arr[0] = new TeacherPartymember ("Ivanov", "Petr", "Sidorovich", "27.12.1991", "Lecturer", "Ph.Dr.", "Programmer", "\"Applied Programming\"", "The Party of Green", "2008", "id123456", "Not written yet :)", "Politics And Programming");
	arr[1] = new TeacherPartymember ("Ivanov", "Petr", "Sidorovich", "27.12.1991", "Lecturer", "Ph.Dr.", "Programmer", "\"Applied Programming\"", "The Party of Green", "2008", "id123456", "Not written yet :)", "Politics And Programming");

	cout << arr[0]->GetSurname() << " " << arr[0]->GetName() << " " << arr[0]->GetMiddlename() << " - " << arr[0]->GetBirthday() << " - " << arr[0]->GetJob() << " - " << arr[0]->GetDegree() << " - " << arr[0]->GetSpecialty() << " - " << arr[0]->GetTreatises() << arr[0]->GetParty() << " - " << arr[0]->GetJoinDate() << " - " << arr[0]->GetIdentifier() << " - " << arr[0]->GetAutobiography() <<  " - " << arr[0]->GetAutobiography() << " - " << arr[0]->GetPublications() << endl;
	cout << endl;

	cout << arr[1]->GetSurname() << " " << arr[1]->GetName() << " " << arr[1]->GetMiddlename() << " - " << arr[1]->GetBirthday() << " - " << arr[1]->GetJob() << " - " << arr[1]->GetDegree() << " - " << arr[1]->GetSpecialty() << " - " << arr[1]->GetTreatises() << arr[1]->GetParty() << " - " << arr[1]->GetJoinDate() << " - " << arr[1]->GetIdentifier() << " - " << arr[1]->GetAutobiography() <<  " - " << arr[1]->GetAutobiography() << " - " << arr[1]->GetPublications() << endl;
	cout << endl;

	delete arr[0];
	delete arr[1];
}
