﻿// Lab2 c++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include<Windows.h>
#include "MyString.h"
#include "MyText.h"

using namespace std;



int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	MySring str("Hello");
	MySring str2("World");
	MySring str3("Im here");
	int kol;

	MyText txt;
	txt.PlussString(str); // Добавление строки str
	txt.PlussString(str2);
	txt.PlussString(str3);
	txt.Print_t();

	txt.DelString(1); // Удаление первой строки
	txt.Print_t();

	kol = txt.KolStrok(); // Количество строк
	cout << kol<<endl;
	txt.Print_t();

	txt.SmenaSimvola('r', 'F'); // Смена всех о на r  в тексте
	txt.Print_t();

	txt.PoiskStroki(2); // Поиск и вывод заданой строки

	txt.DelText(); //  Очистка текста
	txt.Print_t();

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
