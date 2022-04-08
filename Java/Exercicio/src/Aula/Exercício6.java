package Aula;
import java.util.Scanner;

//Crie um algoritmo que leia duas notas para calcular a 
//média do aluno e determinar se o mesmo foi aprovado ou reprovado. A média para aprovação é 7.

public class Exercício6 {
	public static void main (String[]args) {
		Scanner leia = new Scanner (System .in);
		double nota1,nota2,media;
		
		System.out.print("Escreva a nota do primeiro mês: ");
		nota1=leia.nextDouble();
		System.out.print("Escreva a nota do segundo mês: ");
		nota2=leia.nextDouble();
		
		media=(nota1+nota2) / 2;
		
		if(media>=7){
			System.out.print("Você passou de ano com media:  "+media);
		}else{
			System.out.print("Você reprovou"+media);
		}
	}
}
