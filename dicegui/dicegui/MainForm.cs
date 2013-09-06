/*
 * Created by SharpDevelop.
 * User: b
 * Date: 02/09/2013
 * Time: 4:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dicegui
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		int maxDice;
		int diceType;
		Random _r =new Random();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RollButtonClick(object sender, EventArgs e)
		{
			maxDice = (int) diceNumeric.Value;
			diceType = (int) sidesNumeric.Value;
			
			DiceLoop();
		}
		
		public int RandomDice()
		{
			int n = _r.Next (1, diceType +1);
			return n;
		}

		public void DiceLoop()
		{
			int result = 0;
			for(int i = 0; i < maxDice; i++)
			{
				result += RandomDice();
			}
			string resultS = Convert.ToString(result);
			resultLabel.Text = resultS;
			//MessageBox.Show("You rolled " + result);
		}

	}
}
