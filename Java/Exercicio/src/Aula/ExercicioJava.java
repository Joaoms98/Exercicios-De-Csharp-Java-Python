package Aula;

import java.util.Scanner;

/** O custo ao consumidor de um carro novo � a soma do custo de f�brica com a
    percentagem do distribuidor e dos impostos (aplicados ao custo de f�brica).
    Supondo que a percentagem do distribuidor seja de 28% e os impostos de 45%,
    escrever um sistema que leia o custo de f�brica de um carro e escreva o custo ao
    consumidor*/

public class ExercicioJava {
	
	public static void main (String [] args){
		Scanner leia = new Scanner(System.in);
		double custoFabrica,custoConsumidor,pcDistribuidor,imposto;
		
		System.out.print("Informar custo do carro na f�brica: ");
		custoFabrica = leia.nextDouble();
		pcDistribuidor = custoFabrica*0.028;
		imposto = custoFabrica*0.045;
		custoConsumidor = custoFabrica+pcDistribuidor+imposto;
		System.out.print("O pre�o do carro ao consumidor �: "+ custoConsumidor);
	}
}
