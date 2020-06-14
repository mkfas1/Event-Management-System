import java.lang.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.sql.*;
import java.util.*;

public class CustomerHome extends JFrame implements ActionListener
{
	JLabel welcomeLabel;
	//JTextField searchTF;
	JButton search, deleteBtn,viewDetailsBtn, logoutBtn,borrowbook,booklist;
	
	JPanel panel;
	String userId;
	//private ImageIcon img;
	//private JLabel imgLabel;
	
	public CustomerHome(String userId)
	{
		super("Customer Home ");
		
		this.userId = userId;
		this.setSize(950, 700);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		//this.setLocationRelativeTo(null);
		
		panel = new JPanel();
		panel.setBackground(new Color(241-222-132));
		panel.setLayout(null);
		
		welcomeLabel = new JLabel("Welcome "+userId + " !");
		welcomeLabel.setBounds(350, 60, 180, 80);
		panel.add(welcomeLabel);
			
		/* searchTF= new JTextField();
		searchTF.setBounds(400, 20, 120, 30);
		panel.add(searchTF); */
		
		viewDetailsBtn = new JButton("My Information");
		viewDetailsBtn.setBounds(150, 150, 150, 30);
		viewDetailsBtn.addActionListener(this);
		panel.add(viewDetailsBtn);
		
		search = new JButton("Search ");
		search.setBounds(450, 150, 150, 30);
		search.addActionListener(this);
		panel.add(search);
		
		borrowbook = new JButton("Borrow Info");
		borrowbook.setBounds(450, 250, 150, 30);
		borrowbook.addActionListener(this);
		panel.add(borrowbook);
				
		booklist = new JButton("Book List");
		booklist.setBounds(450, 200, 150, 30);
		booklist.addActionListener(this);
		panel.add(booklist);
			
		logoutBtn = new JButton("Logout");
		logoutBtn.setBounds(600, 450, 100, 30);
		logoutBtn.addActionListener(this);
		panel.add(logoutBtn);
	
		
		/* Random rand = new Random();
		int  x = rand.nextInt(5);
		String y= ".jpg";
		String x1 =""+x+".jpg";
		img = new ImageIcon(x1);
		imgLabel = new JLabel(img);
		imgLabel.setBounds(0, 0, 800, 800);
		panel.add(imgLabel);
		 */
		
		this.add(panel);
	}
	
	public void actionPerformed(ActionEvent ae)
	{
	
		String text = ae.getActionCommand();
		
		if(text.equals(logoutBtn.getText()))
		{
			Home hg = new Home();
			hg.setVisible(true);
			this.setVisible(false);
		}
		else if(text.equals(search.getText()))
		{
			BookInfo bi = new BookInfo();
			bi.setVisible(true);
			this.setVisible(false);
		}
		else if(text.equals(viewDetailsBtn.getText()))
		{
			    CustomerProfile vc = new CustomerProfile(userId);
				vc.setVisible(true);
				this.setVisible(false);
			
		}
		
		else if(text.equals(borrowbook.getText()))
		{
			
			    BorrowInfo bi = new BorrowInfo(userId);
				bi.setVisible(true);
				this.setVisible(false);
			
		}
		else if(text.equals(booklist.getText()))
		{
			
			    BookList bi = new BookList(userId);
				bi.setVisible(true);
				this.setVisible(false);
			
		}
		else{}
	}
	
}
	