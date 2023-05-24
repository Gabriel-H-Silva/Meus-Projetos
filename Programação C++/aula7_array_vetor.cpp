#include <iostream>
#include <cstdlib>
using namespace std;

// vetores
int main(){

// tipo nome[tamanho];
// int carros[5]

int vetor[5];
int i;

vetor[0]=2;
vetor[1]=4;
vetor[2]=6;
vetor[3]=8;
vetor[4]=10;


// sizeof = retorna o tamanho vetor
for(i=0; i<sizeof(vetor);i++){
	cout << vetor[i] << "\n";
}


int tam=6;
int vetor2[tam]={2,4,6,8,10,12};
int i2;

for(i=0; i<tam;i++){
	cout << vetor2[i] << "\n";
}
// aula 19
return 0;
};
