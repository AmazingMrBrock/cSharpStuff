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
		int maxPcHealth;
		int maxEnHealth;
		int maxPcMana;
		int maxEnMana;
		int manaHolder;
		int manaHolder2;
		int pcClass; //1-fighter 2-ranger 3-mage
		int enClass; //1-troll 2-fighter 3-ranger 4-mage 
	
		
		Random _r = new Random();
		
	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
								
			//
			// TODO:
			//	
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
			if(diceOut <= 0) diceOut = 1;
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
			if(pcOrEn == 0)
			{
				if (pcClass < 3)
				{
					finalHealth = healthChange - diceOut;
					if (finalHealth < 0)
					{
						finalHealth = 0;
					}
				}
				else if (pcClass == 3)
				{
					finalHealth = healthChange + diceOut;
					if (finalHealth > maxEnHealth) finalHealth = maxEnHealth;
				}
			}
			else if(pcOrEn == 1)
			{
				if (enClass < 4)
				{
					finalHealth = healthChange - diceOut;
					if (finalHealth < 0)
					{
						finalHealth = 0;
					}
				}
				else if (enClass == 4)
				{
					finalHealth = healthChange + diceOut;
					if (finalHealth > maxPcHealth) finalHealth = maxEnHealth;
				}
			}
			
			healthHolder = Convert.ToString(finalHealth);	
		}
		
		void WinLoseCondition()
		{
			if (finalHealth == 0)
			{
				if (pcOrEn == 0) MessageBox.Show("Enemy has died. You win");
				else if (pcOrEn == 1) MessageBox.Show("You have died. Fail");
				enHealthLabel.Text = Convert.ToString(maxEnHealth);
				pcHealthLabel.Text = Convert.ToString(maxPcHealth);
			}
		}
		
		void TurnSetAi(int aiHealthHolder, int aiManaHolder)
		{
			// AI todo
			// Enemies can use magic and healing
			// 
			aiHealthHolder = Convert.ToInt32(enHealthLabel.Text);
			aiManaHolder = Convert.ToInt32(enManaLabel.Text);
			
			if (turnCount == 1)
			{
				if(enClass == 4)
				{
					if(aiManaHolder >= 50)
					{
						if(aiHealthHolder <= 50)
						{
							EnHealing();
						}
						else if(aiHealthHolder >= 50)
						{
							EnFireball();
						}
					}
					
					else if(aiManaHolder <= 50)
					{
						EnMeleeAttack();
					}
				}
				else if(enClass < 4)
				{
					EnMeleeAttack();
				}
			}
			
		}
		
		public void SetEnInfo(string setName, string setHealth, string setMana, string setSt, string setAg, string setInt, int setClass)
		{
			this.enNameLabel.Text = setName;
			maxEnHealth = Convert.ToInt32(setHealth);
			this.enHealthLabel.Text = Convert.ToString(maxEnHealth);
			maxEnMana = Convert.ToInt32(setMana);
			this.enManaLabel.Text = Convert.ToString(maxEnMana);
			this.enStLabel.Text = setSt;
			this.enAgLabel.Text = setAg;
			this.enIntLabel.Text = setInt;
			enClass = setClass;
		}
		
		public void SetPcInfo(string setName, string setHealth, string setMana, string setSt, string setAg, string setInt, int setClass)
		{
			this.pcNameLabel.Text = setName;
			maxPcHealth = Convert.ToInt32(setHealth);
			this.pcHealthLabel.Text = Convert.ToString(maxPcHealth);
			maxPcMana = Convert.ToInt32(setMana);
			this.pcManaLabel.Text = Convert.ToString(maxPcMana);
			this.pcStLabel.Text = setSt;
			this.pcAgLabel.Text = setAg;
			this.pcIntLabel.Text = setInt;
			pcClass = setClass;
		}
		
		void PcMeleeButtClick(object sender, EventArgs e)
		{
			EnMeleeAttack();
			statHolder = Convert.ToInt32(pcStLabel.Text);
			healthHolder = enHealthLabel.Text;
			maxDice = 1;
			diceType = 6;
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
			pcOrEn = 1;
			DiceLoop();
			StatChanger();
			pcHealthLabel.Text = healthHolder;
			WinLoseCondition();
			turnCount = 0;
		}
		
		void EnRangedAttack()
		{
			statHolder = Convert.ToInt32(enStLabel.Text);
			healthHolder = pcHealthLabel.Text;
			maxDice = 1;
			diceType = 6;
			pcOrEn = 1;
			DiceLoop();
			StatChanger();
			pcHealthLabel.Text = healthHolder;
			WinLoseCondition();
			turnCount = 0;
		}
				
		void EnFireball()
		{
			pcOrEn = 1;
			statHolder = Convert.ToInt32(enStLabel.Text);
			healthHolder = pcHealthLabel.Text;
			manaHolder = Convert.ToInt32(enManaLabel.Text);
			manaHolder2 = manaHolder - 10;
			enManaLabel.Text =  Convert.ToString(manaHolder2);
			maxDice = 4;
			diceType = 6;
			DiceLoop();
			StatChanger();
			pcHealthLabel.Text = healthHolder;
			WinLoseCondition();
			turnCount = 0;
		}
						
		void EnHealing()
		{
			pcOrEn = 1;
			statHolder = Convert.ToInt32(enIntLabel.Text);
			healthHolder = enHealthLabel.Text;
			manaHolder = Convert.ToInt32(enManaLabel.Text);
			manaHolder2 = manaHolder - 15;
			enManaLabel.Text =  Convert.ToString(manaHolder2);
			maxDice = 5;
			diceType = 10;
			DiceLoop();
			StatChanger();
			pcHealthLabel.Text = healthHolder;
			turnCount = 0;
		}
		
		void ChClassButtClick(object sender, EventArgs e)
		{
			CharStats form = new CharStats(this);
     		form.Show();
		}
	}
}
