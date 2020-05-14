// Lab6 ++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

using namespace std;
class Calculate
{
private:
	double _a, _b, _c, _d;
public:


	Calculate(double a, double b, double c, double d)
	{
		if (a == 0)
			throw "Value in logarifm must be mare than zero , change a!";
		_a = a;
		if (b == 0) throw " b can't be zero!";

		if (a * b <= 0) throw "Value in logarifm must be mare than zero , change b!";
		_b = b;
		_c = c;
		if (_c + _b + _a - d == 0) throw "Sum of a, b, c and -d can't be zero!";
		_d = d;

	}
	double Result()
	{
		return (4 * log(_a / _b) + 1) / (_c + _b - _d + _a);
	}
};

int main()
{
	try
	{
		Calculate c1 ( 1,  2,  3,  4); //right values
		//Calculate c2( 0,  2, 3,  4); //a==0
		//Calculate c3 = new Calculate( 1, 0,  3,  4); //b=0
		//Calculate c4 = new Calculate( 1,  -2,  3,  4); //a*b<0
		//Calculate c5 = new Calculate( 1,  2,  3, 6); 
		cout<<c1.Result()<<endl;

	}
	catch (const char* exeption) {
		cerr << "Error: " << exeption << '\n';
	}	
}



/*double A_get()
	{
		return _a;

	}
	double A_set(double a)
	{
		if (a == 0) {
		throw "Value in logarifm must be mare than zero , change a!";
}

		_a = a;
	}

	double B_get(){ return _b; }
	double B_set(double b)
			{
				if (b == 0) throw " b can't be zero!";

				if (A_get * b <= 0) throw "Value in logarifm must be mare than zero , change b!";

				_b = value;
			}
		}
		double C
			{
				get { return _c; }
				set
				{
					_c = value;
				}
			}
		double D
				{
					get { return _d; }
					set
					{
						if (_c + _b + _a - value == 0) throw "Sum of a, b, c and -d can't be zero!";
						_d = value;
					}
				}*/

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
