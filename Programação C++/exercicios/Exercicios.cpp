#include <iostream>
#include <cstdlib>
using namespace std;

int select;
// comando de decisão
int main(){

cout << "qual exercícios vai ser: \n";
 cin >> select;


// ex1
if(select == 1){
	
	// Faça um programa que leia um vetor de inteiros com 5 elementos e imprima o maior e o menor valor do vetor.
	
	int inteiros[5];
	int n = sizeof(inteiros)/sizeof(inteiros[0]);
	int max_val = INT_MIN;
    int min_val = INT_MAX;
    int i;
	
	for(i=0; i < n; i++ ){		
		cout << "Valor do Int " << i << "\n";
		cin >> inteiros[i];
		
		if(inteiros[i] > max_val) {
			max_val = inteiros[i];
		}
		if(inteiros[i] < min_val){
			min_val = inteiros[i];
		}
	}
	
	cout << "O maior valor de vetor e " << max_val << "\n";
	cout << "O menor valor de vetor e " << min_val << "\n";
	
}
// ex2
if(select == 2){
	
	// Faça um programa que leia um vetor de inteiros com 10 elementos e calcule a média dos valores.
	
	int inteiros[10];
	int n = sizeof(inteiros)/sizeof(inteiros[0]);
	int i;
	float media;
	int soma;
	
	for(i=0; i < n; i++ ){
		
		retorno:
		
		cout << "Nota " << i << "\n";
		cin >> inteiros[i];
		
		if(inteiros[i] <= 10){
			soma += inteiros[i];
		}
		else{
			cout << "Digite Novamente um numero menor ou igual a 10\n\n";
			goto retorno;
		}
		
	}	
	media=soma/n;
	cout << "\n\nA media total e " << media;
	
}
// ex3
if(select == 3){

	// Faça um programa que leia um vetor de caracteres com 20 elementos e verifique quantas vezes o caractere 'a' aparece no vetor.
	
	char letra[20];
	int n = sizeof(letra)/sizeof(letra[0]);
	int i;
	int soma=0;
	
	for(i=0; i < n; i++ ){
		
		retorno2:
			
		cout << "digite a " << i << " vogal\n";
		cin >> letra[i];
		
		if(letra[i] == 'a' || letra[i] == 'e' || letra[i] == 'i' || letra[i] == 'o' || letra[i] == 'u'){
			if(letra[i] == 'a'){
				soma++;
			}			
		}
		else{
			cout << "Digite Novamente uma vogal\n\n";
			goto retorno2;
		}
	}
	
	cout << "\nA letra 'a' apareceu " << soma << " vezes";
	
}
// ex4
if(select == 4){

	// Faça um programa que leia um vetor de inteiros com 12 elementos e ordene os valores em ordem crescente.
	
	int vetor[12] = {5, 1, 9, 3, 7, 6, 8, 2, 4, 11, 10, 12};
    int temp;
    
    // Bubble Sort
    for(int i = 0; i < 11; i++) {
        for(int j = i + 1; j < 12; j++) {
            if(vetor[i] > vetor[j]) {
                temp = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = temp;
            }
        }
    }
    
    // Imprime vetor ordenado
    cout << "Vetor ordenado: ";
    for(int i = 0; i < 12; i++) {
        cout << vetor[i] << " ";
    }
    cout << endl;

}
// ex5
if(select == 5){

	// Faça um programa que leia um vetor de inteiros com 8 elementos e um número inteiro. O programa deve verificar se o número está presente no vetor e em qual posição.
	
	int inteiros[8];
	int n = sizeof(inteiros)/sizeof(inteiros[0]);
	int i;
	int valor;
	
	
	
	for(i=0; i < n; i++ ){
		
		cout << "insira numeros " << i << "\n";
		cin >> inteiros[i];
		
	}
	
	cout << "\nqal valor vc quer\n";
	cin >> valor;
	
	i=0;
	
	for(i=0; i < n; i++ ){
		
		if(inteiros[i] == valor){
			 cout << "o seu valor ta armazenado no vetor int inteiros[" << i << "]\n";
			break;
		}
		
	}
	
}

return 0;
};
