#include <iostream>
using namespace std;

// Constante = valor fixo
#define pi 3.1415
#define dev cout << "Desenvolvido por Gabriel Henrique\n";

int main(){
	
	// variavel
	// TIPO NOME; ou TIPO NOME = VALOR;
	
	int vidas = 3; // Numeros Inteiros
	char letra = 'V'; // Recebe um Caracter um Byte "A" UM CARACTER
	double decimal = 5.2; // Recebe Numeros Decimais (2,49999999)
	float decimal2 = 5.2;  // Recebe Numeros Decimais e arredenda (2.5)
	bool vivo = true; // Verdadeiro ou Falso - True or False
	string nome; // texto "texto"
	
	char letras[20]; // isso vira um vetor - de 20 caractere - [] - adicionar limite

    // declaração fluida 
	int vidas2, tiros, life = 100;	
	
	dev

	cout << "Digite seu nome:";
	cin >> nome; // pega dados do seu teclado
	// << mostra dados
	// >> pega dados
	
	cout << vidas << "\n" << letra << "\n" << decimal << "\n" << decimal2 << "\n" << vivo << "\n" << nome << "\n";




	// inversão de valores
	int num = 10;
	
	num = num * -1;
	
	
	cout << num;
	
	return 0;
}
