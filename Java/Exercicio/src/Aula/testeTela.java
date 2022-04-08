package Aula;

import javax.swing.JFrame;

//Como emular janela
//O j f se repete várias vezes no código, então posso colocar o extends JFrame
public class testeTela extends JFrame{

	public testeTela() {
		setTitle("Título da janela");//Coloca o título da janela
		setSize(500,400);//escala da janela
		setVisible(true);//Se janela aparecera ou não true/false
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);//quando a janela fecha não tem mantem a janela?
		setLocationRelativeTo(null);//inicia a janela no meio da tela
		setResizable(false);//não pode dimensionar a tela ou pode

	}
	public static void main(String [] args) {
		new testeTela();
	}
}
