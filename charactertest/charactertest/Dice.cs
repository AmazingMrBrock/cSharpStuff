/*
 * Created by SharpDevelop.
 * User: b
 * Date: 10/09/2013
 * Time: 11:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace charactertest
{
	/// <summary>
	/// Description of Dice.
	/// </summary>
	public static class Dice
	{
		
		static Random _r = new Random();
				
		public static int RandomDice(int diceType)
		{
			int n = _r.Next (1, diceType +1);
			return n;
		}

		public static void DiceLoop(int maxDice, int diceType, int statHolder)
		{
			ActionVariables.diceResult = 0;
			for(int i = 0; i < maxDice; i++)
			{
				ActionVariables.diceResult += RandomDice(diceType);
			}
			ActionMods.MeleeModifier(statHolder);
			ActionVariables.diceOut = ActionVariables.diceResult + ActionVariables.statAdjuster;
			if(ActionVariables.diceOut <= 0) ActionVariables.diceOut = 1;
		}
	}
}
