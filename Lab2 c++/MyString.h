#pragma once
class MySring
{
private:
	char* str;
	int length;
public:
	MySring();
	MySring(const char* str);
	void Print();
	int Dovgina();		
	int Dovgina(const char* str);
	MySring SmenSimv(const char a, const char b);
	MySring Concat(MySring& other, MySring& other1);
};

