#include <iostream>
#include "MyString.h"

using namespace std;

MySring::MySring() {
	str = nullptr;
	length = 0;
}
MySring::MySring(const char* str) {
	length = Dovgina(str);
	this->str = new char[length + 1];
	for (int i = 0; i < length; i++) {
		this->str[i] = str[i];
	}
	this->str[length] = '\0';

}
void MySring::Print() {
	cout << str << " ";
}
int MySring:: Dovgina() {
	int len = 0;
	while (str[len] != '\0') {
		len++;
	}
	return len;
}
int MySring:: Dovgina(const char* str) {
	int len = 0;
	while (str[len] != '\0') {
		len++;
	}
	return len;
}
MySring MySring:: SmenSimv(const char a, const char b) {
	for (int i = 0; i < length; i++) {
		if (str[i] == a) {
			str[i] = b;
		}
	}
	return str;
}
MySring MySring:: Concat(MySring& other, MySring& other1) {
	int len1 = Dovgina(other.str);
	int len2 = Dovgina(other1.str);
	str = new char[len1 + len2 + 1];
	for (int i = 0; i < len1; i++) {
		str[i] = other.str[i];
	}
	for (int j = 0; j < len2; j++) {
		str[j + len1] = other1.str[j];
	}
	str[len1 + len2] = '\0';
	return str;
}
