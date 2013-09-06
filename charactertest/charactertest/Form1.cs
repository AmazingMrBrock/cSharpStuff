/*
 * Created by SharpDevelop.
 * User: b
 * Date: 03/09/2013
 * Time: 6:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace charactertest
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class CharStats : Form
	{
		string name = "";
		string health = "";
		string mana = "";
		string strength = "";
		string agility = "";
		string intelligence = "";
		int pcOrEn = 0;
		int maxHealth;
		
		private MainForm _callingForm;
		
    	public CharStats(MainForm callingForm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			_callingForm = callingForm;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Fighter()
		{
		name = "Reginaldxx";
		health = "200";
		mana = "50";
		strength = "16";
		agility = "12";
		intelligence = "6";
		}
		
		void Ranger()
		{
		name = "Francis";
		health = "150";
		mana = "50";
		strength = "10";
		agility = "18";
		intelligence = "10";
		}
		
		void Mage()
		{
		name = "Charles";
		health = "80";
		mana = "200";
		strength = "5";
		agility = "8";
		intelligence = "18";
		}
		
		void Troll()
		{
		name = "Shirley the Troll";
		health = "300";
		mana = "0";
		strength = "20";
		agility = "10";
		intelligence = "4";
		}
		
		void BanditFighter()
		{
		name = "James";
		health = "200";
		mana = "50";
		strength = "16";
		agility = "12";
		intelligence = "6";
		}
		
		void BanditRanger()
		{
		name = "Charles";
		health = "150";
		mana = "50";
		strength = "10";
		agility = "18";
		intelligence = "10";
		}
		
		void BanditMage()
		{
		name = "Morgan";
		health = "80";
		mana = "200";
		strength = "4";
		agility = "6";
		intelligence = "20";
		}
		
		void StatTransfer()
		{
			if(pcOrEn == 0)
			{
				_callingForm.SetPcInfo(name, health, mana, strength, agility, intelligence, maxHealth);
			}
				
			else if(pcOrEn == 1)
			{
				_callingForm.SetEnInfo(name, health, mana, strength, agility, intelligence, maxHealth);
			}
		}
		
		
		void FighterButtonClick(object sender, EventArgs e)
		{
			pcOrEn = 0;
			Fighter();
			StatTransfer();
		}
		
		void RangerButtonClick(object sender, EventArgs e)
		{
			pcOrEn = 0;
			Ranger();
			StatTransfer();
		}
		
		void MageButtonClick(object sender, EventArgs e)
		{
			pcOrEn = 0;
			Mage();
			StatTransfer();
		}
		
		void TrollButtonClick(object sender, EventArgs e)
		{
			pcOrEn = 1;
			Troll();
			StatTransfer();
		}
		
		void BFighterButtonClick(object sender, EventArgs e)
		{
			pcOrEn = 1;
			BanditFighter();
			StatTransfer();
		}
		
		void BRangerButtonClick(object sender, EventArgs e)
		{
			pcOrEn = 1;
			BanditRanger();
			StatTransfer();
		}
		
		void BMageButtonClick(object sender, EventArgs e)
		{
			pcOrEn = 1;
			BanditMage();
			StatTransfer();
		}
	}
}
