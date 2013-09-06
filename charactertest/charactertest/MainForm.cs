/*
 * Created by SharpDevelop.
 * User: b
 * Date: 03/09/2013
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace charactertest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int statHolder;
		int statAdjuster;
		string healthHolder;
		int finalHealth;
		int diceOut;
		int maxDice;
		int healingOnOff = 0;
		int pcOrEn = 0;
		int turnCount = 0;
		int diceType;
		int diceResult;
		int maxHealth;
		int curHealth;
	
		
		Random _r = new Random();
		
	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
								
			//
			// TODO: setup attack so it doen't give health with negative st modifier
			//	make maxHealth for pc and en 
			//	figure out why I was thinking about curhealth
			//	setup ai
			//	
			//
		}
			
		public int RandomDice()
		{
			int n = _r.Next (1, diceType +1);
			return n;
		}

		public void DiceLoop()
		{
			diceResult = 0;
			for(int i = 0; i < maxDice; i++)
			{
				diceResult += RandomDice();
			}
			MeleeModifier();
			diceOut = diceResult + statAdjuster;
			
			if(pcOrEn == 0)
			{
				
			}
			else if(pcOrEn == 1)
			{
				
			}
			
		}
		
		public void MeleeModifier()
		{
			if (statHolder > 10)
			{
				int n = statHolder - 10;
				statAdjuster = n / 2;				
			}
			else if (statHolder < 10)
			{
				int n = statHolder;
				if (n == 9) {statAdjuster = -1;}
				else if (n == 8) {statAdjuster = -2;}
				else if (n == 7) {statAdjuster = 3;}
				else if (n == 6) {statAdjuster = -4;}
				else if (n == 5) {statAdjuster = -4;}
				else if (n == 4) {statAdjuster = -5;}
				else if (n == 3) {statAdjuster = -5;}
				else if (n == 2) {statAdjuster = -6;}
				else if(n == 1) {statAdjuster = -6;}
			}
		}
		
		public void StatChanger()
		{
			string x = "0";
			x = healthHolder;
			int healthChange = Convert.ToInt32(x);
			if (healingOnOff == 0)
			{
				finalHealth = healthChange - diceOut;
				if (finalHealth < 0) 
				{
					finalHealth = 0;
				}
			}
			else if (healingOnOff == 1)
			{
				finalHealth = healthChange + diceOut;
				if (finalHealth > maxHealth) finalHealth = maxHealth;
			}
			healthHolder = Convert.ToString(finalHealth);	
		}
		
		void WinLoseCondition()
		{
			if (finalHealth == 0)
			{
				if (pcOrEn == 0) MessageBox.Show("Enemy has died. You win");
				else if (pcOrEn == 1) MessageBox.Show("You have died. Fail");
				enHealthLabel.Text = "200";
				pcHealthLabel.Text = "100";
			}
		}
		
		void TurnSetAi()
		{
			if (turnCount == 1)
			{
				EnMeleeAttack();
			}
		}
		
		public void SetEnInfo(string setName, string setHealth, string setMana, string setSt, string setAg, string setInt, int setMax)
		{
			this.enNameLabel.Text = setName;
			this.enHealthLabel.Text = setHealth;
			this.enManaLabel.Text = setMana;
			this.enStLabel.Text = setSt;
			this.enAgLabel.Text = setAg;
			this.enIntLabel.Text = setInt;
			this.maxHealth = setMax;
		}
		
		public void SetPcInfo(string setName, string setHealth, string setMana, string setSt, string setAg, string setInt, int setMax)
		{
			this.pcNameLabel.Text = setName;
			this.pcHealthLabel.Text = setHealth;
			this.pcManaLabel.Text = setMana;
			this.pcStLabel.Text = setSt;
			this.pcAgLabel.Text = setAg;
			this.pcIntLabel.Text = setInt;
			this.maxHealth = setMax;
		}
		
		void PcMeleeButtClick(object sender, EventArgs e)
		{
			EnMeleeAttack();
			statHolder = Convert.ToInt32(pcStLabel.Text);
			healthHolder = enHealthLabel.Text;
			maxDice = 1;
			diceType = 6;
			healingOnOff = 0;
			pcOrEn = 0;
			DiceLoop();
			StatChanger();
			enHealthLabel.Text = healthHolder;
			WinLoseCondition();
			turnCount = 1;
		}
		
		void PcRangedButtClick(object sender, EventArgs e)
		{
			statHolder = Convert.ToInt32(pcAgLabel.Text);
			healthHolder = enHealthLabel.Text;
			maxDice = 1;
			diceType = 6;
			healingOnOff = 0;
			pcOrEn = 0;
			DiceLoop();
			StatChanger();
			enHealthLabel.Text = healthHolder;
			WinLoseCondition();
			turnCount = 1;
		}
		
		void PcFireballButtClick(object sender, EventArgs e)
		{
			statHolder = Convert.ToInt32(pcIntLabel.Text);
			healthHolder = enHealthLabel.Text;
			maxDice = 1;
			diceType = 6;
			healingOnOff = 0;
			pcOrEn = 0;
			DiceLoop();
			StatChanger();
			enHealthLabel.Text = healthHolder;
			WinLoseCondition();
			turnCount = 1;
		}
		
		void PcHealingButtClick(object sender, EventArgs e)
		{
			statHolder = Convert.ToInt32(pcIntLabel.Text);
			healthHolder = pcHealthLabel.Text;
			maxDice = 2;
			diceType = 6;
			healingOnOff = 1;
			DiceLoop();
			StatChanger();
			pcHealthLabel.Text = healthHolder;
			turnCount = 1;
		}
		
		void EnMeleeAttack()
		{
			statHolder = Convert.ToInt32(enStLabel.Text);
			healthHolder = pcHealthLabel.Text;
			maxDice = 1;
			diceType = 6;
			healingOnOff = 0;
			pcOrEn = 1;
			DiceLoop();
			StatChanger();
			pcHealthLabel.Text = healthHolder;
			WinLoseCondition();
			turnCount = 0;
		}
		
		void ChClassButtClick(object sender, EventArgs e)
		{
			CharStats form = new CharStats(this);
     		form.Show();
		}
	}
}
