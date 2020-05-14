// Lab5 ++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <math.h>
using namespace std;

class Punkt {
private:
	float x;
	float y;
public:
	Punkt() {
		this->x = 0;
		this->y = 0;
	}
	Punkt(float x, float y) {
		this->x = x;
		this->y = y;
	}
	float X() {
		return x;
	}
	float Y() {
		return y;
	}
};
class Shape {
protected:
	Punkt* _shape;
	int count;
	float* lenghts;
public:
	Shape() {
		_shape = new Punkt[count];
		lenghts = new float[count];
	}
	float LenSide(Punkt* _shape,int z) {
		for (int i = 0; i < count; i++) {
			if (i == count - 1) {
				int j = i;
				i = 0;
				lenghts[j] = sqrt(pow(_shape[i].X() - _shape[j].X(), 2) + pow(_shape[i].Y() - _shape[j].Y(), 2));
				break;
			}
			else {
				lenghts[i] = sqrt(pow(_shape[i].X() - _shape[i + 1].X(), 2) + pow(_shape[i].Y() - _shape[i + 1].Y(), 2));
			}
		}
		return lenghts[z];
	}
	float LenSide( int z) {
		for (int i = 0; i < count; i++) {
			if (i == count - 1) {
				int j = i;
				i = 0;
				lenghts[j] = sqrt(pow(_shape[i].X() - _shape[j].X(), 2) + pow(_shape[i].Y() - _shape[j].Y(), 2));
				break;
			}
			else {
				lenghts[i] = sqrt(pow(_shape[i].X() - _shape[i + 1].X(), 2) + pow(_shape[i].Y() - _shape[i + 1].Y(), 2));
			}
		}
		return lenghts[z];
	}
};
class Romb: public Shape {
public:
	Romb(Punkt tochka1, Punkt tochka2, Punkt tochka3, Punkt tochka4) {
		count = 4;
		_shape = new Punkt[count];		
		_shape[0] = tochka1;
		_shape[1] = tochka2;
		_shape[2] = tochka3;
		_shape[3] = tochka4;
		lenghts = new float[count];
		for (int i = 0; i < count-1; i++) {
			try {
				if (LenSide(_shape, i) != LenSide(_shape, i + 1)) {
					throw "Sides must be the same";
				}				
			}
			catch (const char* exeption) {
				cerr << "Error: " << exeption << '\n';
			}
		}
	}
	float Square() {
		float diag1 = sqrt(pow(_shape[3].X() - _shape[1].X(), 2) + pow(_shape[3].Y() - _shape[1].Y(), 2));
		float diag2 = sqrt(pow(_shape[2].X() - _shape[0].X(), 2) + pow(_shape[2].Y() - _shape[0].Y(), 2));
		return (diag1 * diag2) / 2;
	}
	float Perimetr() {
		float per = 0;
		for (int i = 0; i < count; i++) {
			per +=LenSide(_shape,i);
		}
		return per;
	}
};


int main()
{
	Punkt tochka1(0, 4);
	Punkt tochka2(3, 0);
	Punkt tochka3(0, -4);
	Punkt tochka4(-3, 0);
	Romb romb(tochka1,tochka2,tochka3,tochka4);
	cout << romb.Perimetr() << endl;
	cout << romb.Square() << endl;
	cout << romb.LenSide(1) << endl;
	
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
