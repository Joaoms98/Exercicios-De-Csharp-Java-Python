package Aula;
import java.util.Scanner;
//Crie um algoritmo que leia a m�dia das duas unidades para calcular a 
//sua m�dia final. Em seguida exiba a m�dia final e o resultado que pode ser 
//aprovado, prova final ou reprovado. A m�dia de aprova��o � 7, menor que 3 para 
//reprova��o e as demais prova final.
public class Exercicio8 {
	public static void main (String[]Args) {
		Scanner read = new Scanner(System.in);
		double nota1,nota2,media;
		
		System.out.print("Escreva a primeira nota: ");
		nota1 = read.nextDouble();
		System.out.print("Escreva a segunda nota: ");
		nota2 = read.nextDouble();
		media=(nota1+nota2)/2;
		
		if(media>=7) {
			System.out.print("Aprovado");
		}else if(media<3){
			System.out.print("Reprovado");
		}else {
			System.out.print("Prova final");
		}
	}
}
