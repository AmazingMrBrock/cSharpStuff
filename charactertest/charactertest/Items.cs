/*
 * Created by SharpDevelop.
 * User: b
 * Date: 30/09/2013
 * Time: 11:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace charactertest
{
	/// <summary>
	/// TODO
	/// add items that will be used
	/// health and mana potions, 
	/// 
	/// </summary>

	public static class Items
	{	
		public static void HealthPotion()
		{
			ActionVariables.potionHealth = 100;
			ActionVariables.potionOnOff = 1;
			ActionVariables.healthOrMana = 0;
			ActionVariables.healingOnOff = 1;
		}
		
		public static void ManaPotion()
		{
			ActionVariables.potionMana = 100;
			ActionVariables.potionOnOff = 1;
			ActionVariables.healthOrMana = 1;
			ActionVariables.healingOnOff = 1;
		}
	}
}
