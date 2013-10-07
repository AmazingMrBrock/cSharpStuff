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
	/// TODO
	/// 
	/// </summary>

	public partial class CharStats : Form
	{
		private MainForm _callingForm;
			
    	public CharStats(MainForm callingForm)
		{
			InitializeComponent();
			_callingForm = callingForm;
		}
    	
    	void StatTransfer()
		{
			_callingForm.SetInfo(Stats.name, Stats.health, Stats.mana, Stats.strength, Stats.agility, Stats.intelligence, Stats.charClass);
		}
    	
		void FighterButtonClick(object sender, EventArgs e)
		{
			Ai.TurnSet(0);
			Stats.Fighter();
			StatTransfer();
		}
		
		void RangerButtonClick(object sender, EventArgs e)
		{
			Ai.TurnSet(0);
			Stats.Ranger();
			StatTransfer();
		}
		
		void MageButtonClick(object sender, EventArgs e)
		{
			Ai.TurnSet(0);
			Stats.Mage();
			StatTransfer();
		}
		
		void TrollButtonClick(object sender, EventArgs e)
		{
			Ai.TurnSet(1);
			Stats.Troll();
			StatTransfer();
		}
		
		void BFighterButtonClick(object sender, EventArgs e)
		{
			Ai.TurnSet(1);
			Stats.BanditFighter();
			StatTransfer();
		}
		
		void BRangerButtonClick(object sender, EventArgs e)
		{
			Ai.TurnSet(1);
			Stats.BanditRanger();
			StatTransfer();
		}
		
		void BMageButtonClick(object sender, EventArgs e)
		{
			Ai.TurnSet(1);
			Stats.BanditMage();
			StatTransfer();
		}
	}
}
