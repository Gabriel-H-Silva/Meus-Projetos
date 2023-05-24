#include <iostream>
#include <cstdlib>
using namespace std;

// Swith Case
int main(){

	/*
	
	switch(logica){
		case constante 1:
			comandos 1;
			break;
		case constante 2:
			comandos 2;
			break;
		default;
			comandos;
	
	*/
	
	int val;
	
	cout << "selecione a cor\n";
	cout << "[1]=verde, [2]=Azul, [3]=Vermelho\n";

	cin >> val;
	
	switch(val){
		case 1:
			cout << "verde";
			break;
		case 2:
			cout << "Azul";
			break;
		case 3:
			cout << "Vermelho";
			break;
		default:
			cout << "valor invalido";
	}
	
return 0;
};
