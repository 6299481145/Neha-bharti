import java.awt.*;
import java.awt.event.*;

class Addition extends Frame implements ActionListener {
	Label lbl_augend, lbl_addend, lbl_sum;
	TextField txt_augend, txt_addend, txt_sum;
	Button btn_add,btn_reset;
	
	Addition() {
	//----lbl_augend--------------
		lbl_augend = new Label("Augend");
		lbl_augend.setBounds(60,120, 50, 30);
		add(lbl_augend);
		
	//-----txt_augend--------------
		txt_augend = new TextField();
		txt_augend.setBounds(120,120,50,30);
		add(txt_augend);
		
	//----lbl_addend--------------
		lbl_addend = new Label("Addend");
		lbl_addend.setBounds(60,180, 50, 30);
		add(lbl_addend);
		
	//-----txt_addend--------------
		txt_addend = new TextField();
		txt_addend.setBounds(120,180,50,30);
		add(txt_addend);
		
	//----lbl_sum--------------
		lbl_sum = new Label("Sum");
		lbl_sum.setBounds(60,240, 50, 30);
		add(lbl_sum);
		
	//-----txt_sum--------------
		txt_sum = new TextField();
		txt_sum.setBounds(120,240,50,30);
		add(txt_sum);
		
	//----btn_add---------------
		btn_add = new Button("Add");
		btn_add.setBounds(60, 300, 50, 30);
		this.add(btn_add);
		btn_add.addActionListener(this);
		
	//----btn_reset---------------
		btn_reset = new Button("Reset");
		btn_reset.setBounds(120, 300, 50, 30);
		this.add(btn_reset);
		btn_reset.addActionListener(this);
		
	//-------Frame Properties
		this.setLayout(null);
		this.setSize(500, 500);
		this.setVisible(true);
		this.setTitle("Addition App");
		
			//-----Eventhandler for closing window
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				dispose();
			}
		});
	}
	
	//----ActionListener Eventhandler----------
	public void actionPerformed(ActionEvent e) {
		if(e.getSource() == btn_add) {
			btn_addClick();
		}
		else if(e.getSource() == btn_reset) {
			btn_resetClick();
		}
	}
	
	//----btn_add event handler --------
	void btn_addClick() {
		int a, b, c;
		a = Integer.parseInt(txt_augend.getText());
		b = Integer.parseInt(txt_addend.getText());
		
		c = a + b;
		
		txt_sum.setText(Integer.toString(c));
	}
	
	//-----btn_reset event handler --------
	void btn_resetClick() {
		txt_augend.setText("");
		txt_addend.setText("");
		txt_sum.setText("");
	}
	
}

class AdditionGUI {
	public static void main(String[] args) {
		new Addition();		//anonymous object
	}
}
