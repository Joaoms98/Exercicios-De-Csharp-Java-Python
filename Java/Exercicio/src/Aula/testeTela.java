package Aula;

import javax.swing.JFrame;

//Como emular janela
//O j f se repete v�rias vezes no c�digo, ent�o posso colocar o extends JFrame
public class testeTela extends JFrame{

	public testeTela() {
		setTitle("T�tulo da janela");//Coloca o t�tulo da janela
		setSize(500,400);//escala da janela
		setVisible(true);//Se janela aparecera ou n�o true/false
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);//quando a janela fecha n�o tem mantem a janela?
		setLocationRelativeTo(null);//inicia a janela no meio da tela
		setResizable(false);//n�o pode dimensionar a tela ou pode

	}
	public static void main(String [] args) {
		new testeTela();
	}
}
