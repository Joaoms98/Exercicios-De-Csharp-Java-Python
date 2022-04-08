package Aula;
import java.util.Scanner;
//Um comerciante comprou um produto e quer vendê-lo com um lucro de 50% 
//se o valor da compra for menor que R$ 200, caso contrário o lucro será de 30%. 
//Crie um algoritmo que leia o valor da compra e exiba o valor da venda.

public class Exercicio7 {
	public static void main (String[]args) {
		Scanner read = new Scanner(System.in);
		double valorProduto, valorVenda50;
		
		System.out.print("Informe o valor do produto?: ");
		valorProduto = read.nextDouble();
		
		if(valorProduto<200){
			valorVenda50=valorProduto*0.5+valorProduto;
			System.out.print("O valor da venda será: "+valorVenda50);
		}else{
			valorVenda50=valorProduto*0.3+valorProduto;
			System.out.print("O valor da venda será: "+valorVenda50);
		}	
	}
}
