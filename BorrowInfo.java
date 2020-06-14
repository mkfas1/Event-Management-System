import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import java.sql.*;
import java.awt.Graphics;
import java.awt.Color;
import java.awt.Component;
import javax.swing.JTable;
import java.awt.Dimension;
import javax.swing.table.TableCellRenderer;
import java.util.*;
import javax.swing.table.DefaultTableModel;

public class BorrowInfo extends JFrame implements ActionListener
{
private JPanel panel;
	private JTable jt;
	private JButton backBtn;
    static JTable table;
	JFrame frame1;
    String[] columnNames = {"Borrow ID","Book ID", "User ID","Borrow Date","Return Date"};
	String userId;
	
	public BorrowInfo(String userId)
	{

	     super("Borrow Table");
		 this.userId = userId;
		 
		 this.setSize(250, 250);
	     this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		 
		 this.setSize(250, 250);
	     this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	     this.setLocationRelativeTo(null);
	
	        panel = new JPanel();
	        panel.setLayout(null);
	        panel.setBackground(Color.WHITE);
			
			 showTableData();
		   
		   backBtn = new JButton("Back");
		backBtn.setBounds(100, 100, 80, 30);
		backBtn.addActionListener(this);
		panel.add(backBtn);
		
		
		this.add(panel);	
		
	}
	
		public void actionPerformed(ActionEvent ae)
	{
		String text = ae.getActionCommand();
		
		if(text.equals(backBtn.getText()))
		{
			CustomerHome ch = new CustomerHome(userId);
			ch.setVisible(true);
			this.setVisible(false);
			
		}
		
	}
		public void showTableData() 
		{
		frame1 = new JFrame("Borrow Info");

        frame1.setLayout(new BorderLayout());
			
			System.out.println("driver loaded"+userId);
			
			DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        table = new JTable();

        table.setModel(model);

        table.setAutoResizeMode(JTable.AUTO_RESIZE_ALL_COLUMNS);

        table.setFillsViewportHeight(true);

        JScrollPane scroll = new JScrollPane(table);

        scroll.setHorizontalScrollBarPolicy(

                JScrollPane.HORIZONTAL_SCROLLBAR_AS_NEEDED);

        scroll.setVerticalScrollBarPolicy(

                JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED);


        String Col1 = "";

        String Col2 = "";
		String Col3 = "";
		String Col4 = "";
		String Col5 = "";

		
		model.addRow(new Object[]{Col1, Col2,Col3,Col4,Col5});


 

        try {
			
	Connection con;

    Statement st;

    PreparedStatement pst;
	
			Class.forName("com.mysql.jdbc.Driver"); 
			System.out.println("driver loaded");
			con = DriverManager.getConnection("jdbc:mysql://localhost:3306/library","root","");
			System.out.println("connection done"); 

            pst = con.prepareStatement("select 'borrowId',`bookId`, `userId`,'borrowDate','returnDate' from `borrowinfo` WHERE userId='"+userId+"';");

            ResultSet rs = pst.executeQuery();

            int i = 0;

            while (rs.next()) {

                Col1 = rs.getString("borrowId");

                Col2 = rs.getString("bookId");
				
				Col3 = rs.getString("userId");
				
				Col4 = rs.getString("borrowDate");
				
				Col5 = rs.getString("returnDate");


                model.addRow(new Object[]{Col1, Col2, Col3,Col4,Col5});

                i++;

            }


            if (i >= 1) {

                System.out.println(i + " Record Found");

            }

        } catch (Exception ex) {

            JOptionPane.showMessageDialog(null, ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);

        }
		frame1.add(scroll);

        frame1.setVisible(true);

        frame1.setSize(600, 500);
		panel.add(frame1);	
			

 
	}
	
	}
	
	
		 
	