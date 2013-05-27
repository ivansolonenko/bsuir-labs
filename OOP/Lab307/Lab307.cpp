#include "Lab307.h"

void main()
{
	int choice;
	char buf[256];
	Human person ("Ivanov", "Petr", "Sidorovich", "27.12.1991");

	while(1)
	{
		cout << "Press 1 to generate values automatically" << endl;
		cout << "Press 2 to enter values manually" << endl;
		cin.clear();
		cin >> choice;
		cout << endl;

		if(choice == 1 || choice == '1')
		{
			break;
		}
		if(choice == 2 || choice == '2')
		{
			cout << "Enter surname: "; cin >> buf; person.SetSurname(buf);
			cout << "Enter name: "; cin >> buf; person.SetName(buf);
			cout << "Enter middlename: "; cin >> buf; person.SetMiddlename(buf);
			cout << "Enter birthday: "; cin >> buf; person.SetBirthday(buf);
			break;
		}
		system("cls");
	}
	system("cls");

	Transaction<Human> obj(person);

	do {
		cout << "1 - Edit surname" << endl;
		cout << "2 - Edit name" << endl;
		cout << "3 - Edit middlename" << endl;
		cout << "4 - Edit birthday" << endl;
		cout << "5 - Print out" << endl;
		cout << "6 - Undo last action" << endl;
		cout << "7 - Exit" << endl;
		cout << "What do you want to do?" << " ";

		cin >> choice;

		switch(choice)
		{
			case 1:
				cout << endl << "> ";
				cin >> buf;
				obj.Commit(&Human::SetSurname,(buf));
				cout << "Press any key to continue..." << endl;
				_getch();
				system("cls");
				break;
			case 2:
				cout << endl << "> ";
				cin >> buf;
				obj.Commit(&Human::SetName,(buf));
				cout << "Press any key to continue..." << endl;
				_getch();
				system("cls");
				break;
			case 3:
				cout << endl << "> ";
				cin >> buf;
				obj.Commit(&Human::SetMiddlename,(buf));
				_getch();
				system("cls");
				break;
			case 4:
				cout << endl << "> ";
				cin >> buf;
				obj.Commit(&Human::SetBirthday,(buf));
				_getch();
				system("cls");
				break;
			case 5:
				cout << endl << "$ Number of undos: " << Node<Human>::GetCount() << endl;
				cout << "$ " << obj.Ensure(&Human::GetSurname) << " " << obj.Ensure(&Human::GetName)
					 << " " << obj.Ensure(&Human::GetMiddlename) << " - " << obj.Ensure(&Human::GetBirthday) << endl;
				cout << endl;
				cout << "Press any key to continue..." << endl;
				_getch();
				system("cls");
				break;
			case 6:
				obj.Undo();
				system("cls");
				break;
			default:
				break;
		}
	} while(choice != 7);
}
