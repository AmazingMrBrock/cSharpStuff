/*
 * Created by SharpDevelop.
 * User: b
 * Date: 16/09/2013
 * Time: 11:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace charactertest
{
	/// <summary>
	/// TODO
	/// get rid of all references to actionvariables max health and current health and replace them with _pcstats and _npcStats health and current health
	/// </summary>
	public static class ActionMods
	{	
		public static void MeleeModifier(int statHolder)//these are the basic functions used for stat modifiers. Will try to shorten later
		{
			if (statHolder > 10)
			{
				int n = statHolder - 10;
				ActionVariables.statAdjuster = n / 2;				
			}
			else if (statHolder < 10)
			{
				int n = statHolder;
				if (n == 9) {ActionVariables.statAdjuster = -1;}
				else if (n == 8) {ActionVariables.statAdjuster = -2;}
				else if (n == 7) {ActionVariables.statAdjuster = -3;}
				else if (n == 6) {ActionVariables.statAdjuster = -4;}
				else if (n == 5) {ActionVariables.statAdjuster = -4;}
				else if (n == 4) {ActionVariables.statAdjuster = -5;}
				else if (n == 3) {ActionVariables.statAdjuster = -5;}
				else if (n == 2) {ActionVariables.statAdjuster = -6;}
				else if (n == 1) {ActionVariables.statAdjuster = -6;}
			}
		}
		
		//Error Report
		//for some reason whenever the npc mage unit would win the pc characters health is synchronized 
		//with the npc's instead of being set to zero. Reason is unknown but I believe its in here somewhere
		public static void StatChanger(int pcHealthChange, int pcManaChange, int npcHealthChange, int npcManaChange,  int manaCost)//handles stat modifiers and finishes converting dice into damage
		{
			if(GlobalVariables.turnCount == 0)
			{
				if(ActionVariables.healingOnOff == 0)
				{
					ActionVariables.npcFinalHealth = npcHealthChange - ActionVariables.diceOut;
					if (ActionVariables.npcFinalHealth < 0) ActionVariables.npcFinalHealth = 0;
					ActionVariables.pcFinalMana = pcManaChange - manaCost;
					if (ActionVariables.pcFinalMana < 0) ActionVariables.pcFinalMana = 0;
				}
				else if(ActionVariables.healingOnOff == 1)
				{
					ActionVariables.pcFinalHealth = pcHealthChange + ActionVariables.diceOut;
					if (ActionVariables.pcFinalHealth < 0) ActionVariables.pcFinalHealth = 0;
					ActionVariables.pcFinalMana = pcManaChange - manaCost;
					if (ActionVariables.pcFinalMana < 0) ActionVariables.pcFinalMana = 0;
				}
			}
			else if(GlobalVariables.turnCount == 1)
			{
				if(ActionVariables.healingOnOff == 0)
				{
					ActionVariables.pcFinalHealth = pcHealthChange - ActionVariables.diceOut;
					if (ActionVariables.pcFinalHealth < 0) ActionVariables.pcFinalHealth = 0;
					ActionVariables.npcFinalMana = npcManaChange - manaCost;
					if (ActionVariables.npcFinalMana < 0) ActionVariables.npcFinalMana = 0;
				}
				if(ActionVariables.healingOnOff == 1)
				{
					ActionVariables.npcFinalHealth = npcHealthChange + ActionVariables.diceOut;
					if (ActionVariables.npcFinalHealth < 0) ActionVariables.npcFinalHealth = 0;
					ActionVariables.npcFinalMana = npcManaChange - manaCost;
					if (ActionVariables.npcFinalMana < 0) ActionVariables.npcFinalMana = 0;
				}
			}
			
//			below is example material
//			ActionVariables.finalHealth = healthChange - ActionVariables.diceOut;
//			if (ActionVariables.finalHealth < 0) ActionVariables.finalHealth = 0;
//			ActionVariables.finalMana = manaChange - manaCost;
//			if (ActionVariables.finalMana < 0) ActionVariables.finalMana = 0;
//				
//			else if(ActionVariables.potionOnOff == 1)
//			{
//				if(ActionVariables.healthOrMana == 0)
//				{
//					if(GlobalVariables.turnCount == 0)
//					{
//						ActionVariables.finalHealth = healthChange + ActionVariables.potionHealth;
//						if (ActionVariables.finalHealth > MainForm._pcStats.health) ActionVariables.finalHealth = MainForm._pcStats.health;
//					}
//					if(GlobalVariables.turnCount == 1)
//					{
//						ActionVariables.finalHealth = healthChange + ActionVariables.potionHealth;
//						if (ActionVariables.finalHealth > MainForm._npcStats.health) ActionVariables.finalHealth = MainForm._npcStats.health;
//					}
//				}
//				else if(ActionVariables.healthOrMana == 1)
//				{
//					if(GlobalVariables.turnCount == 0)
//					{
//						ActionVariables.finalMana = manaChange + ActionVariables.potionMana;
//						if (ActionVariables.finalMana > MainForm._pcStats.mana) ActionVariables.finalMana = MainForm._pcStats.mana;
//					}
//					if(GlobalVariables.turnCount == 1)
//					{
//						ActionVariables.finalMana = manaChange + ActionVariables.potionMana;
//						if (ActionVariables.finalMana > MainForm._npcStats.mana) ActionVariables.finalMana = MainForm._npcStats.mana;
//					}
//				}
//			}
		}
		
		public static double GetPercent(double ratio) // call and give numbers like so GetPercent((double)92 / 255);
        {
            double percent = Math.Round(ratio, 2);
            return percent;
        }
		
		public static void StatPasser()
		{
			if(ActionVariables.healingOnOff == 0) 
			{
				if(GlobalVariables.turnCount == 0)
				{
					GlobalVariables.npcHealthPasser = ActionVariables.finalHealth;
					GlobalVariables.pcManaPasser = ActionVariables.finalMana;
				}
				else if(GlobalVariables.turnCount == 1)
				{
					GlobalVariables.pcHealthPasser = ActionVariables.finalHealth;
					GlobalVariables.npcManaPasser = ActionVariables.finalMana;
				}
			}
			else if(ActionVariables.healingOnOff == 1)
			{
				if(GlobalVariables.turnCount == 0)
				{
					GlobalVariables.pcHealthPasser = ActionVariables.finalHealth;
					GlobalVariables.pcManaPasser = ActionVariables.finalMana;
				}
				else if(GlobalVariables.turnCount == 1)
				{
					GlobalVariables.npcHealthPasser = ActionVariables.finalHealth;
					GlobalVariables.npcManaPasser = ActionVariables.finalMana;
				}
			}
		}
		
		public static void XpSet()
		{
			
		}
	}
}
