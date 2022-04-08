package Aula;
/**Desenvolva um algoritmo em Java que leia um número inteiro e imprima o seu
antecessor e seu sucessor.*/

import java.util.Scanner;
public class Exercicio2Java {
	public static void main (String [] args){
		Scanner l = new Scanner(System.in);
		double n,a,b;
		System.out.print("Informe um número inteiro: ");
		n = l.nextDouble();
		b = n-1;
		a = n+1;
		System.out.print("Seu antecesor é: "+ b);System.out.print(" Seu sucessor é: "+ a);
	}
}

