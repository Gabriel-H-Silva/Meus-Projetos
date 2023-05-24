#include <iostream>
#include <cstdlib>
using namespace std;


// comando de decisão
int main(){
	
	int num=10;
	char status='A';
	
	// <, >, >=, <=, ==, !=
	// if and else - Teste Logico Basico
	if(status == 'A')
	{
		cout << "Status Ativo\n";
	}
	else
	{
		cout << "Status Inativo\n";
	}
	
	
	if(num <= 10)
	{
		cout << "e menor q 10";
	}
	else
	{
		cout << "e maior q 10";
	}
	
	inicio:
	system("cls");
	int n1,n2, result;
	char opc;
	
	
	cout << "Insira 2 valor pra ser divido por 5 e verificado se o resultado é menor q 4\n\n";
	
	cout << "Insira o valor 1\n";
	cin >> n1;
	cout << "Insira o valor 2\n";
	cin >> n2;
	
	result = (n1 + n2)/5;
	
	if(result <= 4){
		cout << "\n\nParabens seu Resultado é menor que 4 \n" << result;
	}
	else{
		cout << "\n\nVoce errou seu Resultado é maior que 4 \n" << result;
	}
	
	cout << "\n\n Tentar dnv? (s/n) \n";
	cin >> opc;
	
	if(opc == 's' or opc == 'S'){
		goto inicio;
		
	}
	
	// operadores AND, OR, NOT
	
	// && comando E
	// || comando OU
	// ! comando Não
	
	// operador ternario
	
	
	
	int n3,n4,nota;
	string res;
	
	cout << "Insira o valor 1\n";
	cin >> n3;
	cout << "Insira o valor 2\n";
	cin >> n4;
	
	nota=(n3+n4)/2;
	
	// se a nota for >= 6 aprovado
	// se a nota for <= 6 Reprovado
	
	// bom pra dispositivos moveis
	// (comando logico) ? Valor1 = verdairo : valor2  = falso 
	
	// (nota >= 6) ? res="Aprovado" : res="Reprovado";
	
	// 
	res=(nota >= 6) ? "Aprovado" : "Reprovado";
	
	(n1 >= 10) ? n1++ : n1--;
	
	cout << "\n" << n1;
	cout << res;
	return 0;
}
