#include "MyText.h"
#include <iostream>
using namespace std;

MyText::MyText() {

	_text = {};
	count = 0;
}
MySring* MyText::PlussString(MySring str) {
	MySring* _temptext = new MySring[count];
	for (int i = 0; i < count; i++) {
		_temptext[i] = _text[i];
	}
	_text = new MySring[count + 1];
	for (int i = 0; i < count; i++) {
		_text[i] = _temptext[i];
	}
	_text[count] = str;
	count++;
	return _text;
}
MySring* MyText::DelString(int num) {
	num--;
	MySring* _temptext = new MySring[count - 1];
	for (int i = num; i < count - 1; i++) {
		_text[i] = _text[i + 1];
	}
	for (int i = 0; i < count; i++) {
		_temptext[i] = _text[i];
	}
	count--;
	return _temptext;
}
int MyText::KolStrok() {
	return count;
}
MySring* MyText::SmenaSimvola(char a, char b) {
	for (int i = 0; i < count; i++) {
		_text[i].SmenSimv(a, b);
	}
	return _text;
}

void MyText::PoiskStroki(int num) {
	num--;
	_text[num].Print();
}

MySring* MyText::DelText() {
	_text = {};
	count = 0;
	return _text;
}


void MyText::Print_t() {
	for (int i = 0; i < count; i++) {
		_text[i].Print();
	}
	cout << endl;
}