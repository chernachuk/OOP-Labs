// Lab 4 ++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <cmath>
using namespace std;

class Vector {
private:
	float r;
	float fi;
		
public:
	Vector() {
		r = 0;
		fi = 0;
		
	}
	Vector(float r, float fi) {
		this->r = r;
		this->fi = fi;
	}
	Vector(Vector& vec) {
		this->r = vec.r;
		this->fi = vec.fi;
	}
	void Turn(float fi) {
		this->fi += fi;		
	}
	void Increase(float a) {
		this->r *= a;
	}
	/*void RecevData() {
		cout << "Long of vector: " << r << endl << "Angle of vector: " << fi << endl;
	}*/
	float Radius() {
		return this->r;
	}
	float Angle() {
		return this->fi;
	}
	friend Vector operator*(Vector& vec, float a) {
		Vector tmp;
		tmp.r = vec.r * a;
		tmp.fi = vec.fi;
		return tmp;
	}
	friend Vector operator*(float a, Vector& vec) {
		Vector tmp;
		tmp.r = vec.r * a;
		tmp.fi = vec.fi;
		return tmp;
	}
	friend Vector operator+(Vector vec1, Vector vec2) {
		const double PI = 3.141592653589793;
		float x1 = vec1.r * cos(vec1.fi*PI/180);
		float y1 = vec1.r * sin(vec1.fi * PI / 180);
		float x2 = vec2.r * cos(vec2.fi * PI / 180);
		float y2 = vec2.r * sin(vec2.fi * PI / 180);		
		Vector tmp;
		tmp.r = sqrt(pow(x1+x2,2)+pow(y1+y2,2));
		tmp.fi = (atan((y1 + y2) / (x1 + x2)))*180/PI;
		return tmp;
	}

};

int main()
{
	Vector Z1;
	Vector Z2(3, 45);
	Vector Z3(Z2);
	Z2.Turn(90);
	//Z3.Increase(2);
	//Z2.RecevData();
	cout << "Z2: " << Z2.Radius() << "  " << Z2.Angle()<<endl;
	Z3 = Z3*2;
	//Z3.RecevData();
	cout << "Z3: " << Z3.Radius() << "  " << Z3.Angle() << endl;
	Z1 = Z2 + Z3;
	//Z1.RecevData();	
	cout << "Z1: " << Z1.Radius() << "  " << Z1.Angle() << endl;
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
