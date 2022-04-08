package Aula;
/*Fazer um programa que imprima a média aritmética dos números 8,9 e 7. A média dos
números 4, 5 e 6. A soma das duas médias. A média das médias*/

public class Exercicio4Java {
	public static void main (String [] args){
	int media1, media2, somaMedia, mediaMedia;
	media1=(8+9+7)/3;
	media2=(4+5+6)/3;
	somaMedia=media1+media2;
	mediaMedia=(media1+media2)/2;
	
	System.out.println("A média de 8,9 e 7 é: "+media1);
	System.out.println("A média de 4,5 e 6 é: "+media2);
	System.out.println("A soma das duas médias é: "+somaMedia);
	System.out.println("A média dads duas médias é: "+mediaMedia);
	
	}
	
}
