/*
 * Created by SharpDevelop.
 * User: b
 * Date: 16/09/2013
 * Time: 11:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace charactertest
{
	/// <summary>
	/// TODO
	/// finish moving required variables to GlobalVariables
	/// 
	/// </summary>
	
	public static class ActionVariables
	{
		//Dice variables
		public static int diceOut;
		public static int diceResult;
		
		//Combat Variables
		public static int pcFinalHealth;
		public static int pcFinalMana;
		public static int npcFinalHealth;
		public static int npcFinalMana;
		public static int statAdjuster;
		public static int healingOnOff = 0; //0 = off 1 = on
		public static int potionOnOff;
		public static int healthOrMana = 0; 
		public static int maxHealth;
		public static int curHealth;
		public static int potionMana;
		public static int potionHealth;
		public static int maxMana;
		public static int curMana;
		public static int healthChange;
		
		
		//AI Variables
		public static int aiHealthHolder;
		public static int aiManaHolder;
	}
}
