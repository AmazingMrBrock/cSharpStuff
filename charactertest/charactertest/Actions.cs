/*
 * Created by SharpDevelop.
 * User: b
 * Date: 10/09/2013
 * Time: 11:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace charactertest
{
	/// <summary>
	/// Description of Combat.
	/// </summary>

	public static class Actions
	{
		/// <summary>
		/// TODO
		/// Add items and skills to actions list
		/// 
		/// </summary>
		
		public static void ActionStart(int setMaxDice, int setDiceType, int manaCost, int statHolder)//handles base action functions.
		{
			int pcHealthHolder = 0;
			int pcManaHolder = 0;
			int npcHealthHolder = 0;
			int npcManaHolder = 0;
			//if 0 needs to be npc health, if 1 needs to be pc health since health of the enemy is required
			pcHealthHolder = MainForm._pcStats.curHealth;
			pcManaHolder = MainForm._pcStats.curMana;
			npcHealthHolder = MainForm._npcStats.curHealth;
			npcManaHolder = MainForm._npcStats.curMana;		
			
			Dice.DiceLoop(setDiceType, setMaxDice, statHolder);
			ActionMods.StatChanger(pcHealthHolder, pcManaHolder, npcHealthHolder,npcManaHolder, manaCost);
			ActionMods.StatPasser();
		}
		//these pass actionstart its required variables. 
		public static void Melee(int stHolder)
		{ActionStart(1, 6, 0, stHolder);} //inside brackets: maxDice, diceType, manaCost, statHolder
		
		public static void Ranged(int agHolder)
		{ActionStart(2, 6, 0, agHolder);}
		
		public static void FireBall(int intHolder)
		{ActionStart(4, 6, 15, intHolder);}
		
		public static void Healing(int intHolder)
		{
		 	ActionVariables.healingOnOff = 1;
			ActionStart(3, 12, 10, intHolder);
		}
		
		public static void HealthPotion()
		{
			Items.HealthPotion();
			ActionStart(0, 0, 0, 0);
		}
		
		public static void ManaPotion()
		{
			Items.ManaPotion();
			ActionStart(0, 0, 0, 0);
		}
	}
}
