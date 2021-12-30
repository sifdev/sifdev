#include <iostream>
using namespace std;

void showmenu() {
	cout << "**********MENU**********"<<endl;
	cout << "**                    ** \n";
	cout << "*   1.  check balance  *\n";
	cout << "*   2.  deposit        *\n";
	cout << "*   3.  withdraw       * \n";
	cout << "*   4.  exit           *\n";
	cout << "**                   **\n";
	cout << "************************" << endl;

}

int main() {
	int option;
	double balance = 500;
	do{
	showmenu();
	cout << "option: ";
	cin >> option;
	system("cls");
	switch (option)
	{
	case 1:cout << "balance is: " << balance << "$" << endl; break;
	case 2:cout << "deposet amount: ";
		double depodetamount;
		cin >> depodetamount;
		balance += depodetamount; break;
	case 3:cout << " withdraw amount: ";
		double  withdrawamount;
		cin >> withdrawamount;
		if (withdrawamount <= balance)

			balance -= withdrawamount;
		else
			cout << "not enough money" << endl;
break;
	}
	} while (option != 4);
system("pause>0");
}
