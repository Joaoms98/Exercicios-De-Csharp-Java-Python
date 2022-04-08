package Aula;

import java.util.Scanner;

/*Crie um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário,
calcule a quantidade de salários mínimos esse usuário ganha e imprima o resultado.
(1SM=R$1212,00)*/

public class Exercicio3 {
	public static void main (String [] args){
		int salarioMinimo,salarioUsuario,QsalarioMinimo;
		Scanner leia = new Scanner(System.in);
		
		System.out.println("Qual o valor do salário mínimo?: ");
		salarioMinimo = leia.nextInt();
		System.out.println("Qual o valor de seu salário?: ");
		salarioUsuario = leia.nextInt();
		
		QsalarioMinimo=salarioUsuario/salarioMinimo;
		
		System.out.print("Você ganha "+ QsalarioMinimo);System.out.print(" salários mínimos.");		
	}
}
