package Aula;

import java.util.Scanner;

/*Crie um algoritmo que leia o valor do sal�rio m�nimo e o valor do sal�rio de um usu�rio,
calcule a quantidade de sal�rios m�nimos esse usu�rio ganha e imprima o resultado.
(1SM=R$1212,00)*/

public class Exercicio3 {
	public static void main (String [] args){
		int salarioMinimo,salarioUsuario,QsalarioMinimo;
		Scanner leia = new Scanner(System.in);
		
		System.out.println("Qual o valor do sal�rio m�nimo?: ");
		salarioMinimo = leia.nextInt();
		System.out.println("Qual o valor de seu sal�rio?: ");
		salarioUsuario = leia.nextInt();
		
		QsalarioMinimo=salarioUsuario/salarioMinimo;
		
		System.out.print("Voc� ganha "+ QsalarioMinimo);System.out.print(" sal�rios m�nimos.");		
	}
}
