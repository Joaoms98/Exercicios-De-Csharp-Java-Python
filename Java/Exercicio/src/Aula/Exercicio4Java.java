package Aula;
/*Fazer um programa que imprima a m�dia aritm�tica dos n�meros 8,9 e 7. A m�dia dos
n�meros 4, 5 e 6. A soma das duas m�dias. A m�dia das m�dias*/

public class Exercicio4Java {
	public static void main (String [] args){
	int media1, media2, somaMedia, mediaMedia;
	media1=(8+9+7)/3;
	media2=(4+5+6)/3;
	somaMedia=media1+media2;
	mediaMedia=(media1+media2)/2;
	
	System.out.println("A m�dia de 8,9 e 7 �: "+media1);
	System.out.println("A m�dia de 4,5 e 6 �: "+media2);
	System.out.println("A soma das duas m�dias �: "+somaMedia);
	System.out.println("A m�dia dads duas m�dias �: "+mediaMedia);
	
	}
	
}
