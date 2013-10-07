/*
 * Created by SharpDevelop.
 * User: b
 * Date: 16/09/2013
 * Time: 11:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace charactertest
{
	/// <summary>
	/// TODO
	/// go through and change all instances of pcOrEn to turnCount. 
	/// Reorganize all items to work on a turn based system.
	/// go through all instance of maxHealth and change them to the corrosponding pc or en curHealth 
	/// 
	/// </summary>
	
	
	
	public static class GlobalVariables
	{
		public static int turnCount; //pc = 0 npc = 1
		public static int pcHealthPasser;
		public static int pcManaPasser;
		public static int npcHealthPasser;
		public static int npcManaPasser;
	}
	
	public class GlobalCharStats
	{
		public string name;
		public int health;
		public int mana;
		public int curHealth;
		public int curMana;
		public int stren;
		public int agili;
		public int intel;
		public int experience = 0;
		public int charClass;//1 = fighter 2 = ranger 3 = mage 4 = troll 
	}
}

