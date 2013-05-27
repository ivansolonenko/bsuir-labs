#include "Lab402.h"

ostream& operator<<(ostream& stream, Human& obj)
{
	stream <<	obj.GetSurname() << " " << obj.GetName() << " " <<
				obj.GetMiddlename() << " - " << obj.GetBirthday();
	return stream;
}

ostream& operator<<(ostream& stream, Teacher& obj)
{
	stream <<	obj.GetSurname() << " " << obj.GetName() << " " <<
				obj.GetMiddlename() << " - " << obj.GetBirthday() << " - " <<
				obj.GetJob() << " - " << obj.GetDegree() << " - " <<
				obj.GetSpecialty() << " - " << obj.GetTreatises();
	return stream;
}

ostream& operator<<(ostream& stream, Partymember& obj)
{
	stream <<	obj.GetSurname() << " " << obj.GetName() << " " <<
				obj.GetMiddlename() << " - " << obj.GetBirthday() << " - " <<
				obj.GetParty() << " - " << obj.GetJoinDate() << " - " <<
				obj.GetIdentifier() << " - " << obj.GetAutobiography();
	return stream;
}

ostream& operator<<(ostream& stream, TeacherPartymember& obj)
{
	stream <<	obj.GetSurname() << " " << obj.GetName() << " " <<
				obj.GetMiddlename() << " - " << obj.GetBirthday() << " - " <<
				obj.GetJob() << " - " << obj.GetDegree() << " - " <<
				obj.GetSpecialty() << " - " << obj.GetTreatises() << " - " <<
				obj.GetParty() << " - " << obj.GetJoinDate() << " - " <<
				obj.GetIdentifier() << " - " << obj.GetAutobiography() <<  " - " <<
				obj.GetPublications();
	return stream;
}

template <typename T1, typename T2>
void PrintStackOut(T2& obj)
{
	T1 person;
	T2 temp;
	while( !obj.IsEmpty() )
		temp.Push(obj.Pop());
	while( !temp.IsEmpty() )
	{
		person = temp.Pop();
		cout << person << endl;
		obj.Push(person);
	}
}

bool YesNo(const char *msg)
{
	char choice;
	cout << msg;
	cin >> choice;
	if(choice == 'y' || choice == 'Y')
		return true;
	else
		return false;
}


template <typename T>
void DumpStacks(T &out, Stack<Human> &stack1, Stack<Teacher> &stack2, Stack<Partymember> &stack3, Stack<TeacherPartymember> &stack4)
{
	Human person1;
	Stack<Human> stack11;
	
	Teacher person2;
	Stack<Teacher> stack22;

	Partymember person3;
	Stack<Partymember> stack33;

	TeacherPartymember person4;
	Stack<TeacherPartymember> stack44;

	out << "#humans";
	while( !stack1.IsEmpty() )
		stack11.Push(stack1.Pop());
	while( !stack11.IsEmpty() )
	{
		person1 = stack11.Pop();
		out <<	person1.GetSurname()
			<<	person1.GetName()
			<<	person1.GetMiddlename()
			<<	person1.GetBirthday();
		stack1.Push(person1);
	}

	out << "#teachers";
	while( !stack2.IsEmpty() )
		stack22.Push(stack2.Pop());
	while( !stack22.IsEmpty() )
	{
		person2 = stack22.Pop();
		out <<	person2.GetSurname()
			<<	person2.GetName()
			<<	person2.GetMiddlename()
			<<	person2.GetBirthday()
			<<	person2.GetJob()
			<<	person2.GetDegree()
			<<	person2.GetSpecialty()
			<<	person2.GetTreatises();
		stack2.Push(person2);
	}

	out << "#partymembers";
	while( !stack3.IsEmpty() )
		stack33.Push(stack3.Pop());
	while( !stack33.IsEmpty() )
	{
		person3 = stack33.Pop();
		out <<	person3.GetSurname()
			<<	person3.GetName()
			<<	person3.GetMiddlename()
			<<	person3.GetBirthday()
			<<	person3.GetParty()
			<<	person3.GetJoinDate()
			<<	person3.GetIdentifier()
			<<	person3.GetAutobiography();
		stack3.Push(person3);
	}

	out << "#teachers-partymembers";
	while( !stack4.IsEmpty() )
		stack44.Push(stack4.Pop());
	while( !stack44.IsEmpty() )
	{
		person4 = stack44.Pop();
		out <<	person4.GetSurname()
			<<	person4.GetName()
			<<	person4.GetMiddlename()
			<<	person4.GetBirthday()
			<<	person4.GetJob()
			<<	person4.GetDegree()
			<<	person4.GetSpecialty()
			<<	person4.GetTreatises()
			<<	person4.GetParty()
			<<	person4.GetJoinDate()
			<<	person4.GetIdentifier()
			<<	person4.GetAutobiography()
			<<	person4.GetPublications();
		stack4.Push(person4);
	}
}

template <typename T>
void RestoreStacks(T &in, Stack<Human> &stack1, Stack<Teacher> &stack2, Stack<Partymember> &stack3, Stack<TeacherPartymember> &stack4)
{
	string buffer;
	Human person1;
	Teacher person2;
	Partymember person3;
	TeacherPartymember person4;

	while(! in.EndOfFile())
	{
		static unsigned int LastSection = 0;
		buffer.clear();
		in >> buffer;

		if(!strcmp(buffer.c_str(), ""))
		{
			LastSection = 0;
		}
		else if(!strcmp(buffer.c_str(), "#humans"))
		{
			LastSection = 1;
		}
		else if(!strcmp(buffer.c_str(), "#teachers"))
		{
			LastSection = 2;
		}
		else if(!strcmp(buffer.c_str(), "#partymembers"))
		{
			LastSection = 3;
		}
		else if(!strcmp(buffer.c_str(), "#teachers-partymembers"))
		{
			LastSection = 4;
		}
		else if(LastSection == 1)
		{
											person1.SetSurname(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person1.SetName(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person1.SetMiddlename(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person1.SetBirthday(const_cast<char*>(buffer.c_str()));
			stack1.Push(person1);
		}
		else if(LastSection == 2)
		{
											person2.SetSurname(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person2.SetName(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person2.SetMiddlename(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person2.SetBirthday(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person2.SetJob(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person2.SetDegree(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person2.SetSpecialty(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person2.SetTreatises(const_cast<char*>(buffer.c_str()));
			stack2.Push(person2);
		}
		else if(LastSection == 3)
		{
											person3.SetSurname(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person3.SetName(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person3.SetMiddlename(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person3.SetBirthday(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person3.SetParty(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person3.SetJoinDate(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person3.SetIdentifier(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person3.SetAutobiography(const_cast<char*>(buffer.c_str()));
			stack3.Push(person3);
		}
		else if(LastSection == 4)
		{
											person4.SetSurname(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetName(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetMiddlename(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetBirthday(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetJob(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetDegree(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetSpecialty(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetTreatises(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetParty(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetJoinDate(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetIdentifier(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetAutobiography(const_cast<char*>(buffer.c_str()));
			buffer.clear();	in >> buffer;	person4.SetPublications(const_cast<char*>(buffer.c_str()));
			stack4.Push(person4);
		}
		else
		{
			continue;
		}
	}
}

void main()
{
	Human person1;
	Stack<Human> stack1, stack11;
	
	Teacher person2;
	Stack<Teacher> stack2, stack22;

	Partymember person3;
	Stack<Partymember> stack3, stack33;

	TeacherPartymember person4;
	Stack<TeacherPartymember> stack4, stack44;

	string buf;
	char choice;

	bool exit = false;
	do {
		cout << "1. Add Human\n2. Add Teacher\n3. Add Partymember\n4. Add TeacherPartymember\n5. Print everyone\n" <<
				"6. Export information into text file\n7. Import information from text file\n" <<
				"8. Dump information into binary file\n9. Restore information from binary file\n" <<
				"0. Exit\nWhat should be done? ";
		cin >> choice;
		cout << endl;
		switch(choice)
		{
			case '1':
				do {
					cout << "Enter surname: ";		cin >> buf; person1.SetSurname(const_cast<char*>(buf.c_str()));
					cout << "Enter name: ";			cin >> buf; person1.SetName(const_cast<char*>(buf.c_str()));
					cout << "Enter middlename: ";	cin >> buf; person1.SetMiddlename(const_cast<char*>(buf.c_str()));
					cout << "Enter Birthday: ";		cin >> buf; person1.SetBirthday(const_cast<char*>(buf.c_str()));

					cout << person1 << endl;

					if( YesNo("Correct? (y/n) ") ) stack1.Push(person1);
					else continue;

					if( YesNo("Add one more? (y/n) ") ) continue;
					else break;
				} while(true);
				break;
			case '2':
				do {
					cout << "Enter surname: ";		cin >> buf; person2.SetSurname(const_cast<char*>(buf.c_str()));
					cout << "Enter name: ";			cin >> buf; person2.SetName(const_cast<char*>(buf.c_str()));
					cout << "Enter middlename: ";	cin >> buf; person2.SetMiddlename(const_cast<char*>(buf.c_str()));
					cout << "Enter Birthday: ";		cin >> buf; person2.SetBirthday(const_cast<char*>(buf.c_str()));

					cout << "Enter job: ";			cin >> buf; person2.SetJob(const_cast<char*>(buf.c_str()));
					cout << "Enter degree: ";		cin >> buf; person2.SetDegree(const_cast<char*>(buf.c_str()));
					cout << "Enter specialty: ";	cin >> buf; person2.SetSpecialty(const_cast<char*>(buf.c_str()));
					cout << "Enter treatises: ";	cin >> buf; person2.SetTreatises(const_cast<char*>(buf.c_str()));

					cout << person2 << endl;

					if( YesNo("Correct? (y/n) ") ) stack1.Push(person1);
					else continue;

					if( YesNo("Add one more? (y/n) ") ) continue;
					else break;
				} while(true);
				break;
			case '3':
				do {
					cout << "Enter surname: ";		cin >> buf; person3.SetSurname(const_cast<char*>(buf.c_str()));
					cout << "Enter name: ";			cin >> buf; person3.SetName(const_cast<char*>(buf.c_str()));
					cout << "Enter middlename: ";	cin >> buf; person3.SetMiddlename(const_cast<char*>(buf.c_str()));
					cout << "Enter Birthday: ";		cin >> buf; person3.SetBirthday(const_cast<char*>(buf.c_str()));
					
					cout << "Enter party name: ";	cin >> buf; person3.SetParty(const_cast<char*>(buf.c_str()));
					cout << "Enter join date: ";	cin >> buf; person3.SetJoinDate(const_cast<char*>(buf.c_str()));
					cout << "Enter ID: ";			cin >> buf; person3.SetIdentifier(const_cast<char*>(buf.c_str()));
					cout << "Enter autobio: ";		cin >> buf; person3.SetAutobiography(const_cast<char*>(buf.c_str()));

					cout << person3 << endl;

					if( YesNo("Correct? (y/n) ") ) stack1.Push(person1);
					else continue;

					if( YesNo("Add one more? (y/n) ") ) continue;
					else break;
				} while(true);
				break;
			case '4':
				do {
					cout << "Enter surname: ";		cin >> buf; person4.SetSurname(const_cast<char*>(buf.c_str()));
					cout << "Enter name: ";			cin >> buf; person4.SetName(const_cast<char*>(buf.c_str()));
					cout << "Enter middlename: ";	cin >> buf; person4.SetMiddlename(const_cast<char*>(buf.c_str()));
					cout << "Enter Birthday: ";		cin >> buf; person4.SetBirthday(const_cast<char*>(buf.c_str()));

					cout << "Enter job: ";			cin >> buf; person4.SetJob(const_cast<char*>(buf.c_str()));
					cout << "Enter degree: ";		cin >> buf; person4.SetDegree(const_cast<char*>(buf.c_str()));
					cout << "Enter specialty: ";	cin >> buf; person4.SetSpecialty(const_cast<char*>(buf.c_str()));
					cout << "Enter treatises: ";	cin >> buf; person4.SetTreatises(const_cast<char*>(buf.c_str()));

					cout << "Enter party name: ";	cin >> buf; person4.SetParty(const_cast<char*>(buf.c_str()));
					cout << "Enter join date: ";	cin >> buf; person4.SetJoinDate(const_cast<char*>(buf.c_str()));
					cout << "Enter ID: ";			cin >> buf; person4.SetIdentifier(const_cast<char*>(buf.c_str()));
					cout << "Enter autobio: ";		cin >> buf; person4.SetAutobiography(const_cast<char*>(buf.c_str()));

					cout << "Enter publications: ";	cin >> buf; person4.SetPublications(const_cast<char*>(buf.c_str()));

					cout << person4 << endl;

					if( YesNo("Correct? (y/n) ") ) stack1.Push(person1);
					else continue;

					if( YesNo("Add one more? (y/n) ") ) continue;
					else break;
				} while(true);
				break;
			case '5':
				cout << "All humans:" << endl;
				PrintStackOut< Human, Stack<Human> >(stack1);
				cout << endl;

				cout << "All teachers:" << endl;
				PrintStackOut< Teacher, Stack<Teacher> >(stack2);
				cout << endl;

				cout << "All partymembers:" << endl;
				PrintStackOut< Partymember, Stack<Partymember> >(stack3);
				cout << endl;

				cout << "All teachers-partymembers:" << endl;
				PrintStackOut< TeacherPartymember, Stack<TeacherPartymember> >(stack4);
				cout << endl;
				break;
			case '6':
				{
					string filename;
					cout << "Enter file name: ";
					cin >> filename;
					TextFile out(filename, ios::out);
					DumpStacks(out, stack1, stack2, stack3, stack4);
				}
				cout << "Done!" << endl;
				break;
			case '7':
				if( !stack1.IsEmpty() || !stack2.IsEmpty() || !stack3.IsEmpty() || !stack4.IsEmpty() )
				{
					if( YesNo("Overwrite current values? (y/n) ") )
					{
						while( !stack1.IsEmpty() ) stack1.Pop();
						while( !stack2.IsEmpty() ) stack2.Pop();
						while( !stack3.IsEmpty() ) stack3.Pop();
						while( !stack4.IsEmpty() ) stack4.Pop();
					}
					cout << endl;
				}
				{
					string buffer;
					string filename;
					cout << "Enter file name: ";
					cin >> filename;
					
					TextFile in(filename, ios::in);
					RestoreStacks(in, stack1, stack2, stack3, stack4);
				}
				cout << "Done!" << endl;
				break;
			case '8':
				{
					string filename;
					cout << "Enter file name: ";
					cin >> filename;
					BinaryFile out(filename, ios::out | ios::binary);
					DumpStacks(out, stack1, stack2, stack3, stack4);
				}
				cout << "Done!" << endl;
				break;
			case '9':
				if( !stack1.IsEmpty() || !stack2.IsEmpty() || !stack3.IsEmpty() || !stack4.IsEmpty() )
				{
					if( YesNo("Overwrite current values? (y/n) ") )
					{
						while( !stack1.IsEmpty() ) stack1.Pop();
						while( !stack2.IsEmpty() ) stack2.Pop();
						while( !stack3.IsEmpty() ) stack3.Pop();
						while( !stack4.IsEmpty() ) stack4.Pop();
					}
					cout << endl;
				}
				{
					string buffer;
					string filename;
					cout << "Enter file name: ";
					cin >> filename;
					
					BinaryFile in(filename, ios::in | ios::binary);
					RestoreStacks(in, stack1, stack2, stack3, stack4);
				}
				cout << "Done!" << endl;
				break;
			case '0':
				exit = true;
				break;
		}
		cout << "Press any key to continue..." << endl;
		_getch();
		system("cls");
	} while(exit != true);
}
