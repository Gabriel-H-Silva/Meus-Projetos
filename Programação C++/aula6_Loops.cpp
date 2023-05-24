#include <iostream>
#include <cstdlib>
using namespace std;

// loops
int main(){
	
	int n;
	int n2;
	
	n=1;
	n2=1;
	while(n<10){
		cout << "loop .\n " << n;
		n++;
	}
	
	// do While
	
	do{
		cout << " loop 2.\n " << n2;
		n2++;
	}while(n2<10);
	
	
	
	/*
	
	for( 1 parametro ; 2 parametro ; x++ ){
		comando
	}
	
	*/
	int x, y;
	
	for( x=0,y=1 ; x<=10 ; x++,y+=2){
		
		cout << x << " - " << y << "\n";
		
	}
	
return 0;
};
