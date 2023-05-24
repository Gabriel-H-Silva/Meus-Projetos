#include <iostream>
#include <cstdlib>
using namespace std;

int main(){

	// criar um jogo da forca
	
	char palavras[30],letra[1],secreta[30];
	int acertos, chances=3, i, tamanho;
	bool acertou;
	
	i=0;
	tamanho=0;
	acertou=false;
	acertos=0;
		
	cout << "Bem vindo ao Jogo da forca\n\n";
	
	cout << "Insira a palavra secretra: ";
	cin >>  palavras;
	
	cout << "Quantas chance: ";
	cin >>  chances;
		
	system("cls");
	
	while(palavras[i] != '\0');
	{
		i++;
		tamanho++;
	}
	
	for(i=0;i<30;i++){
		secreta[i]='-';
	}
	
	while((chances > 0) && (acertos < tamanho))
	{
		cout << "Chances Restantes: " << chances << "\n\n";
		cout << "Palavra Secreta: ";
		for(i=0; i<tamanho; i++){
			cout << secreta[i];
		}
		cout << "\n\n Digite uma letra: ";
		cin >> letra[0];
		
		for(i=0; i<tamanho; i++){
			if(palavras[i]==letra[0]){
				acertou=true;
				secreta[i]=palavras[1];
				acertos++;
			}
		}
		if(!acertos){
			chances--;
		}
		acertos=false;
		system("cls");
	
	}
	if(acertos==tamanho){
		cout << "Você venceu";
	}
	else{
		cout << "PErdeuuuuu";
	}
	
	system("pause");
	return 0;	
}
