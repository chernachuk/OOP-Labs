// Lab5-2 ++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;
class Strings {
protected:
	char* str;
	int length;
public:
	Strings(){
		str = nullptr;
		length = 0;
	}
	Strings(const char* str) {
		length = Lent(str);
		this->str = new char[length + 1];
		for (int i = 0; i < length; i++) {
			this->str[i] = str[i];
		}
		this->str[length] = '\0';
	}
	
	virtual int Len(){
		int len = 0;
		while (str[len] != '\0') {
			len++;
		}
		return len;
	}
	int Lent(const char* str) {
		int len = 0;
		while (str[len] != '\0') {
			len++;
		}
		return len;
	}
	virtual char* Return() {
		return str;
	}
	virtual void Decrease(int n) { // Уменьшение
		char* _tempstr = new char [length -n];
		
		for (int i = 0; i < length - n; i++) {
			_tempstr[i] = str[i];
		}
		_tempstr[length - n] = '\0';
		str = new char[length - n];
		str = _tempstr;

	}

};
class Simbols :Strings {

public:
	Simbols() {
		str = nullptr;
		length = 0;
	}
	Simbols(const char* str) {
		length = Lent(str);
		this->str = new char[length + 1];
		for (int i = 0; i < length; i++) {
			this->str[i] = str[i];
		}
		char* numbers = new char[11]{'0','1','2','3','4','5','6','7','8','9','\0'};
		this->str[length] = '\0';
		for (int i = 0; i < length; i++) {
			try {
				for (int j = 0; j < Lent(numbers); j++) {
					if (str[i] == numbers[j]) {
						throw "Simbols can't have numbers.";
						break;
					}
				}
			}
			catch (const char* exeption) {
				cerr << "Error: " << exeption << '\n';
			}
		}
	}
	int Len() {
		int len = 0;
		while (str[len] != '\0') {
			len++;
		}
		return len;
	}
	char* Return() {
		return str;
	}

	
	void Decrease() {	
		char* _tempstr = new char[length / 2];
		_tempstr[length / 2] = '\0';		
		int j = 0;
		for (float i = 0.5; j < length / 2; i++) {
			int k = i * 2;
			_tempstr[j] = str[k];
			j++;
		}				
		str = new char[length / 2];
		str = _tempstr;
	}

};
class Numbers : Strings {
public:
	Numbers() {
		str = nullptr;
		length = 0;
	}
	Numbers(const char* str) {
		length = Lent(str);
		this->str = new char[length + 1];
		for (int i = 0; i < length; i++) {
			this->str[i] = str[i];
		}
		char* simbols = new char[52] {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M',
			'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'};
		this->str[length] = '\0';
		for (int i = 0; i < length; i++) {
			try {
				for (int j = 0; j < Lent(simbols); j++) {
					if (str[i] == simbols[j]) {
						throw "Numers can't have simbols.";
						break;
					}
				}
			}
			catch (const char* exeption) {
				cerr << "Error: " << exeption << '\n';
			}
		}
	}
	void Decrease() {
		char* _tempstr= new char[length/2+1];
		_tempstr[length / 2+1] = '\0';
		for (int i = 0; i < length / 2+1; i++) {
			_tempstr[i] = str[i * 2];
		}
		
		str = new char[length / 2 + 1];
		str = _tempstr;
	}
	char* Return() {
		return str;
	}
	int Len() {
		int len = 0;
		while (str[len] != '\0') {
			len++;
		}
		return len;
	}


};

int main()
{
	Strings str = "Hello";
	cout << str.Return() << endl;
	cout << str.Len() << endl;
	str.Decrease(2);
	cout << str.Len() << endl;
	cout << str.Return() << endl;
	cout << endl << endl;

	Simbols simb = "World";
	cout << simb.Return() << endl;	
	cout << simb.Len() << endl;
	simb.Decrease();
	cout << simb.Len() << endl;
	cout << simb.Return() << endl;
	cout << endl << endl;

	Numbers num = "12345678";
	cout << num.Return() << endl;
	cout << num.Len() << endl;
	num.Decrease();
	cout << num.Len() << endl;
	cout << num.Return() << endl;
	cout << endl << endl;
		
	
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
