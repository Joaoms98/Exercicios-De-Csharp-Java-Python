package Aula;
import java.util.Scanner;

//Crie um algoritmo que leia duas notas para calcular a 
//m�dia do aluno e determinar se o mesmo foi aprovado ou reprovado. A m�dia para aprova��o � 7.

public class Exerc�cio6 {
	public static void main (String[]args) {
		Scanner leia = new Scanner (System .in);
		double nota1,nota2,media;
		
		System.out.print("Escreva a nota do primeiro m�s: ");
		nota1=leia.nextDouble();
		System.out.print("Escreva a nota do segundo m�s: ");
		nota2=leia.nextDouble();
		
		media=(nota1+nota2) / 2;
		
		if(media>=7){
			System.out.print("Voc� passou de ano com media:  "+media);
		}else{
			System.out.print("Voc� reprovou"+media);
		}
	}
}
