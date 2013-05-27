#include "Lab309.h"

void main()
{
	char ch = 0;
	char buf[256];
	NewHuman obj;

	while(1)
	{
		cout << "Press 1 to generate values automatically" << endl;
		cout << "Press 2 to enter values manually" << endl;
		cin.clear();
		cin >> ch;
		cout << endl;

		if(ch == '1')
		{
			obj.Surname = "Ivanov";
			obj.Name = "Petr";
			obj.Middlename = "Sidorovich";
			obj.Birthday = "27.12.1991";
			break;
		}
		if(ch == '2')
		{
			cout << "Enter surname: "; cin >> buf; obj.Surname = buf;
			cout << "Enter name: "; cin >> buf; obj.Name = buf;
			cout << "Enter middlename: "; cin >> buf; obj.Middlename = buf;
			cout << "Enter birthday: "; cin >> buf; obj.Birthday = buf;
			break;
		}
		system("cls");
	}

	cout<< static_cast<char*>(obj.Surname) << " "
		<< static_cast<char*>(obj.Name) << " "
		<< static_cast<char*>(obj.Middlename) << " - "
		<< static_cast<char*>(obj.Birthday) << endl;
}
