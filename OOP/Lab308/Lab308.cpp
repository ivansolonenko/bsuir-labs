#include "Lab308.h"

void main()
{
	char ch = 0;
	char buf[256];

	SmartPointer<Human> obj1(new Human);

	while(1)
	{
		cout << "Press 1 to generate values automatically" << endl;
		cout << "Press 2 to enter values manually" << endl;
		cin.clear();
		cin >> ch;
		cout << endl;

		if(ch == '1')
		{
			obj1->SetSurname("Ivanov");
			obj1->SetName("Petr");
			obj1->SetMiddlename("Sidorovich");
			obj1->SetBirthday("27.12.1991");
			break;
		}
		if(ch == '2')
		{
			cout << "Enter surname: "; cin >> buf; obj1->SetSurname(buf);
			cout << "Enter name: "; cin >> buf; obj1->SetName(buf);
			cout << "Enter middlename: "; cin >> buf; obj1->SetMiddlename(buf);
			cout << "Enter birthday: "; cin >> buf; obj1->SetBirthday(buf);
			break;
		}
		system("cls");
	}

	SmartPointer<Human> obj2 = obj1;

	do {
		system("cls");
		cout << obj2->GetSurname() << " " << obj2->GetName() << " " << obj2->GetMiddlename() << " - " << obj2->GetBirthday() << endl;
		cout << endl;

		cout << "1 - Edit surname" << endl;
		cout << "2 - Edit name" << endl;
		cout << "3 - Edit middlname" << endl;
		cout << "4 - Edit birthday" << endl;
		cout << "5 - Exit" << endl;
		cout << "What do you want to do? ";
		cin >> ch;
		cout << endl;

		switch(ch)
		{
		case '1':
			cout << "Enter new surname: "; cin >> buf; obj2->SetSurname(buf);
			break;

		case '2':
			cout << "Enter new name: "; cin >> buf; obj2->SetName(buf);
			break;

		case '3':
			cout << "Enter new middlename: "; cin >> buf; obj2->SetMiddlename(buf);
			break;

		case '4':
			cout << "Enter new birthday: "; cin >> buf; obj2->SetBirthday(buf);
			break;

		case '5':
			break;

		default:
			break;
		}
	} while(ch != '5');
}
