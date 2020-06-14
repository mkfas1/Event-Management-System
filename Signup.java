import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import java.sql.*;
import java.util.*;

public class Signup extends JFrame implements ActionListener
{
	JLabel userLabel,namelabel, passLabel, eNameLabel, phoneLabel,addressLabel;
	JTextField userTF,nameTF, passTF, phoneTF1,phoneTF2, eNameTF, addressTF;
	JButton  ConfirmBtn,ExitBtn;
	JPanel panel;
	String userId;
	
	public Signup(String userId)
	{
		super(" CUSTOMER SIGNUP");
		
		this.setSize(950, 700);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.userId = userId;
		
		panel = new JPanel();
		panel.setBackground(new Color(241-222-132));
		panel.setLayout(null);
		
		
		userLabel = new JLabel("User ID: ");
		userLabel.setBounds(150, 100, 120, 30);
		panel.add(userLabel);
		
		userTF = new JTextField();
		userTF.setBounds(250, 100, 120, 30);
		panel.add(userTF);		
		
		eNameLabel = new JLabel("EMAIL Address : ");
		eNameLabel.setBounds(150, 150, 120, 30);
		panel.add(eNameLabel);
		
		eNameTF = new JTextField();
		eNameTF.setBounds(250, 150, 120, 30);
		panel.add(eNameTF);
		
		phoneLabel = new JLabel("Phone No : ");
		phoneLabel.setBounds(150, 200, 120, 30);
		panel.add(phoneLabel);
		
		phoneTF1 = new JTextField("+880");
		phoneTF1.setBounds(250, 200, 35, 30);
		phoneTF1.setEnabled(false);
		phoneTF1.setForeground(Color.BLACK);
		panel.add(phoneTF1);
		
		phoneTF2 = new JTextField();
		phoneTF2.setBounds(285, 200, 85, 30);
		panel.add(phoneTF2);
	
		addressLabel = new JLabel("Address : ");
		addressLabel.setBounds(150, 250, 120, 30);
		panel.add(addressLabel);
		
		addressTF = new JTextField();
		addressTF.setBounds(250, 250, 120, 30);
		panel.add(addressTF);
		
		passLabel = new JLabel("Password : ");
		passLabel.setBounds(150, 300, 120, 30);
		
		panel.add(passLabel);
		
		passTF = new JTextField();
		passTF.setBounds(250, 300, 120, 30);
		//passTF.setEchoChar('*');
		//passTF.setEnabled(false);
		panel.add(passTF);
		
		ConfirmBtn = new JButton("Confirm");
        ConfirmBtn.setBounds(150, 400, 100, 30);
		ConfirmBtn.setBackground(Color.CYAN);
		ConfirmBtn.addActionListener(this);
		panel.add(ConfirmBtn);
		
		
		ExitBtn = new JButton("Exit");
		ExitBtn.setBounds(350, 400, 100, 30);
		ExitBtn.setBackground(new Color(255,102,102));
		ExitBtn.addActionListener(this);
		panel.add(ExitBtn);
		
		this.add(panel);
	}
	
	public void actionPerformed(ActionEvent ae)
	{
		String text = ae.getActionCommand();
		
		 if(text.equals(ConfirmBtn.getText()))
		{   insertIntoDB();
			Home hg = new Home();
			hg.setVisible(true);
			this.setVisible(false);
		}
		
		else if(text.equals(ExitBtn.getText()))
		{
			System.exit(0);
		}
		else{}
	}
	public void insertIntoDB()
	{
		
		String userId = userTF.getText();
		//String uName= nameTF.getText();
		String password = passTF.getText();
		String eName = eNameTF.getText();
		String phoneNumber = phoneTF1.getText()+phoneTF2.getText();
		String address = addressTF.getText(); 
		
		int status = 1; 
		
		String query1 = "INSERT INTO customer VALUES ('"+userId+"','"+password+"','"+ eName+"','"+phoneNumber+"','"+address+"');";
		//String query1 = "Insert into customer (userId,password,eName,phoneNumber,address)values (?,?,?,?,?)"; //insert query
		String query2 = "INSERT INTO login VALUES ('"+userId+"','"+password+"','"+status+"');";
		System.out.println(query1);
		System.out.println(query2);
        try
		{
			Class.forName("com.mysql.jdbc.Driver");
			Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/library","root","");
			Statement stm = con.createStatement();
			stm.execute(query1);
			stm.execute(query2);
			stm.close();
			con.close();
			JOptionPane.showMessageDialog(this, "Success !!!");
		}
        catch(Exception ex)
		{
			System.out.println(ex.getMessage());
			ex.printStackTrace();
			JOptionPane.showMessageDialog(this, "Oops !!!");
        }
    }	
}
	

	