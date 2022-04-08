package Aula;

import java.util.Scanner;

/** O custo ao consumidor de um carro novo é a soma do custo de fábrica com a
    percentagem do distribuidor e dos impostos (aplicados ao custo de fábrica).
    Supondo que a percentagem do distribuidor seja de 28% e os impostos de 45%,
    escrever um sistema que leia o custo de fábrica de um carro e escreva o custo ao
    consumidor*/

public class ExercicioJava {
	
	public static void main (String [] args){
		Scanner leia = new Scanner(System.in);
		double custoFabrica,custoConsumidor,pcDistribuidor,imposto;
		
		System.out.print("Informar custo do carro na fábrica: ");
		custoFabrica = leia.nextDouble();
		pcDistribuidor = custoFabrica*0.028;
		imposto = custoFabrica*0.045;
		custoConsumidor = custoFabrica+pcDistribuidor+imposto;
		System.out.print("O preço do carro ao consumidor é: "+ custoConsumidor);
	}
}
