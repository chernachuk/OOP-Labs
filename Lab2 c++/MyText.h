#pragma once
#include "MyString.h"
class MyText {
private:
	MySring* _text;
	int count;   // число сторк
public:
	MyText();
	MySring* PlussString(MySring str);
	MySring* DelString(int num);
	int KolStrok();
	MySring* SmenaSimvola(const char a, const char b);
	void PoiskStroki(int num);
	MySring* DelText();
	void Print_t();
};