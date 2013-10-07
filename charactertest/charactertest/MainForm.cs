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
	public partial class MainForm : Form
	{
		public static GlobalCharStats _pcStats = new GlobalCharStats();
		public static GlobalCharStats _npcStats = new GlobalCharStats();
		
		public MainForm()
		{
			InitializeComponent();
			CharStats form = new CharStats(this);
			form.Show();
			
			/// <summary>
			/// TODO
			/// fix program to have classes to return variables more often
			/// make attack buttons context sensitive for each class
			/// add actions and items
			/// may need to have pages pop up for skills and items respectively
			/// set up an experience and levelling system with changable attributes
			/// 
			/// Errors
			/// First round yields no results
			/// 
			/// </summary>
		}
				
		public void SetInfo(string setName, string setHealth, string setMana, string setSt, string setAg, string setInt, int setClass)
		{
			if(GlobalVariables.turnCount == 0)
			{
				this.pcNameLabel.Text = setName;
				_pcStats.health = Convert.ToInt32(setHealth);
				this.pcHealthLabel.Text = Convert.ToString(_pcStats.health);
				_pcStats.curHealth = MainForm._pcStats.health;
				_pcStats.mana = Convert.ToInt32(setMana);
				_pcStats.curMana = Convert.ToInt32(setMana);
				this.pcManaLabel.Text = Convert.ToString(_pcStats.mana);
				this.pcStLabel.Text = setSt;
				_pcStats.stren = Convert.ToInt32(setSt);
				this.pcAgLabel.Text = setAg;
				_pcStats.agili = Convert.ToInt32(setAg);
				this.pcIntLabel.Text = setInt;
				_pcStats.intel = Convert.ToInt32(setInt);
				_pcStats.charClass = setClass;
				Ai.TurnSet(1);
			}
			else if(GlobalVariables.turnCount == 1)
			{
				this.enNameLabel.Text = setName;
				_npcStats.health = Convert.ToInt32(setHealth);
				this.enHealthLabel.Text = Convert.ToString(_npcStats.health);
				_npcStats.curHealth = MainForm._npcStats.health;
				_npcStats.mana = Convert.ToInt32(setMana);
				_npcStats.curMana = Convert.ToInt32(setMana);
				this.enManaLabel.Text = Convert.ToString(_npcStats.mana);
				this.enStLabel.Text = setSt;
				_npcStats.stren = Convert.ToInt32(setSt);
				this.enAgLabel.Text = setAg;
				_npcStats.agili = Convert.ToInt32(setAg);
				this.enIntLabel.Text = setInt;
				_npcStats.intel = Convert.ToInt32(setInt);
				_npcStats.charClass = setClass;
				Ai.TurnSet(0);
			}
		}

		public void StatSet()
		{
			enHealthLabel.Text = Convert.ToString(GlobalVariables.npcHealthPasser);
			enManaLabel.Text = Convert.ToString(GlobalVariables.npcManaPasser);
			if (GlobalVariables.npcHealthPasser == 0)MessageBox.Show("Enemy has died. You win");

			pcHealthLabel.Text = Convert.ToString(GlobalVariables.pcHealthPasser);
			pcManaLabel.Text = Convert.ToString(GlobalVariables.pcManaPasser);
			if (GlobalVariables.pcHealthPasser == 0)MessageBox.Show("You have died. Fail");
		}

		void AiRoutine()//used to handle background ai functions
		{
			Ai.TurnSet(1);
			Ai.NpcAi(MainForm._npcStats.curMana, MainForm._npcStats.mana, MainForm._npcStats.curHealth, MainForm._npcStats.health);
			StatSet();
			ActionVariables.healingOnOff = 0;
			ActionVariables.potionOnOff = 0;
		}

		void PcMeleeButtClick(object sender, EventArgs e)
		{ 
			Ai.TurnSet(0);
			Actions.Melee(_pcStats.stren);
			AiRoutine();
		}

		void PcRangedButtClick(object sender, EventArgs e)
		{
			Ai.TurnSet(0);
			Actions.Ranged(_pcStats.agili);
			AiRoutine();
		}

		void PcFireballButtClick(object sender, EventArgs e)
		{
			Ai.TurnSet(0);
			Actions.FireBall(_pcStats.intel);
			AiRoutine();
		}

		void PcHealingButtClick(object sender, EventArgs e)
		{
			Ai.TurnSet(0);
			Actions.Healing(_pcStats.intel);
			ActionVariables.healingOnOff = 0;
			AiRoutine();
		}
		
		void HealthPotionButtonClick(object sender, EventArgs e)
		{
			Ai.TurnSet(0);
			Actions.HealthPotion();
			ActionVariables.potionOnOff = 0;
			ActionVariables.healingOnOff = 0;
			AiRoutine();
		}
		
		void ManaPotionButtonClick(object sender, EventArgs e)
		{
			Ai.TurnSet(0);
			Actions.ManaPotion();
			ActionVariables.potionOnOff = 0;
			ActionVariables.healingOnOff = 0;
			AiRoutine();
		}
	}
}
