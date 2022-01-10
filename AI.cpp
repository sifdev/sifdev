#include <iostream>
using namespace std;
// main variable 
string name;
string info;
int sign;
int menu;
// sing in func
void account() {
    cout << "*************************************";
    cout << "*       enter  your name            *";
    cout << "*************************************\n";
    cin >> name;

    cout<<"hi"<<name << "press 2 to use aidaAI: ";
    cin >> menu;
    if (menu == 2)
    {
        system("cls");
    }
    else
    {
        cout << "error";
    }
}

//main func

int main()
{
    cout << "Hi my name is aidaAi im here for help you \n\n";
    cout << "you need to sign in\n \n";
    cout << "press 1 to go in sign in menu: ";
    cin >> sign;
    // move to sing in menu
    if (sign == 1)
    {
        system("cls");
        account();
    }
   
 //start of AI
    cout << "hi how can i help you: ";
    cin >> info;
   if (info == "hi")
    {
        cout << "hello";
    }
    else  if (info == "hello")
    {
        cout << "hi";
    }

}
