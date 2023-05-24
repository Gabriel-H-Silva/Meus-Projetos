#include <iostream>
#include <cstdlib>
using namespace std;

int select;
// comando de decisão
int main(){

inicio:

cout << "qual exercícios vai ser:\n";
 cin >> select;

// ex1 
if(select == 1){
 
 int numero;
 
 cout << "\n\nDigite um numero e vou dizer que ele é positivo ou negativo ou zero\n\n";
 cin >> numero;
 
 if(numero > 0){
 	cout << "seu numero é positivo";
 }else if(numero < 0){
 	cout << "seu numero é nativo";
 }
 else{
 	cout << "seu numero é zero";
 }
 goto inicio;
}

// ex2
else if(select == 2){
	
	float nota;
	char res;
	
	cout << "\nQual a Nota do Aluno?\n";
 	cin >> nota;
	
	if(nota >= 6){
		cout << "\nO Aluno foi Aprovado\n";
	}
	else if(nota >= 4 && nota < 6){
		cout << "\nO Aluno ta de Recuperacao \n";
	}
	else{
		cout << "\nO Aluno foi Reprovado\n";
	}
	
	goto inicio;
}

// ex3
else if(select == 3){
	int Idade;
	
	cout << "Qual sua Idade?\n";
	cin >> Idade;
	
	if(Idade <= 12){
		cout << "Voce e crianca\n";
	}
	else if(Idade >= 13 && Idade <= 17){
		cout << "Voce e adolescente\n";
	}
	else if(Idade >= 18 && Idade <= 59){
		cout << "Voce e adulto\n";
	}
	else{
		cout << "Tu e veio\n";
	}
	goto inicio;
}
// ex4
else if(select == 4){

	char caractere;
	
	cout << "Diz ?\n";
	cin >> caractere;

	if(caractere == 'A' || caractere ==  'E' || caractere == 'I' || caractere ==  'O' || caractere ==  'U' ){
		cout << "é Vogal\n";
	}
	else{
		cout << "é consoante\n";
	}
}

return 0;
};
