/*
 * Created by SharpDevelop.
 * User: b
 * Date: 10/09/2013
 * Time: 11:12 AM
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
	/// Description of Ai.
	/// </summary>
	public static class Ai
	{
		
		/// <summary>
		/// TODO
		/// find a way to make turn set work without wrecking everything or abandon it
		/// finish NpcAI.
		/// need to work out how to perform commands based on percentages of health and mana
		/// 
		/// Make sure stats are reset upon win lose scenario
		/// </summary>
	
		public static void TurnSet(int turnCount)// currently unused needs to be fixed so it doesnt screw up the turn order
		{
			if (turnCount == 0)
			{
				GlobalVariables.turnCount = 0;
			}
			else if(turnCount == 1)
			{
				GlobalVariables.turnCount = 1 ;
			}
		}
		
		public static void NpcAi(int curMana, int maxMana, int curHealth, int maxHealth)//handles npc actions
		{			
			double healthPercent = ActionMods.GetPercent((double) curHealth / maxHealth);
			double manaPercent = ActionMods.GetPercent((double) curMana / maxMana);
			
			if(MainForm._npcStats.charClass == 1)//warrior
			{
				Actions.Melee(MainForm._npcStats.stren);
			}
			else if(MainForm._npcStats.charClass == 2)//ranger
			{
				Actions.Ranged(MainForm._npcStats.agili);
			}
			else if(MainForm._npcStats.charClass == 3)//mage //Currently mage functions are not working. Mage performs melee action and no others.
			{
				if(manaPercent > 0.0)//mana is over a certain number
				{
					if(healthPercent > 0.5)// over a certain health
					{
						Actions.FireBall(MainForm._npcStats.intel);
					}
					else if(healthPercent < 0.5)//if under a certain health
					{
						Actions.Healing(MainForm._npcStats.intel);
					}
				}
				else if(manaPercent < 0.05)//mana is under a certain range
				{
					Actions.Melee(MainForm._npcStats.stren);
				}
			}
			else if(MainForm._npcStats.charClass == 4)//troll
			{
				Actions.Melee(MainForm._npcStats.stren);
			}
		}
	}
}
