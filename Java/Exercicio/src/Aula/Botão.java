package Aula;
import javax.swing.JFrame;
import javax.swing.JButton;
public class Bot�o extends JFrame{
	
	JButton jb = new JButton("Botao1");
	JButton jb2 = new JButton("Botao2");
	public Bot�o() {
		
		setLayout(null);
		jb.setBounds(100,300,100,60);//os num significam (x,y,largura,rutura)
		jb2.setBounds(150,150,100,60);
		add(jb);//abrevia��o de getContentPane().
		add(jb2);
		
		setTitle("Teste tela bot�o");
		setSize(800,600);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setLocationRelativeTo(null);
		setVisible(true);
	}
	public static void main(String [] args){
		new Bot�o();
	}
}
