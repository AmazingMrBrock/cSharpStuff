/*
 * Created by SharpDevelop.
 * User: b
 * Date: 10/09/2013
 * Time: 11:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace charactertest
{
	/// <summary>
	/// Description of Stats.
	/// </summary>

	public static class Stats
	{	
		
		
		public static string name = "";
		public static string health = "";
		public static string mana = "";
		public static string strength = "";
		public static string agility = "";
		public static string intelligence = "";
		public static int charClass;
		
		public static void Fighter()
		{
			name = "Reginaldx";
			health = "200";
			mana = "50";
			strength = "16";
			agility = "12";
			intelligence = "6";
			charClass = 1;
		}
		
		public static void Ranger()
		{
			name = "Francis";
			health = "150";
			mana = "50";
			strength = "10";
			agility = "18";
			intelligence = "10";
			charClass = 2;
		}
		
		public static void Mage()
		{
			name = "Charles";
			health = "80";
			mana = "200";
			strength = "5";
			agility = "8";
			intelligence = "18";
			charClass = 3;
		}
		
		public static void BanditFighter()
		{
			name = "James";
			health = "200";
			mana = "50";
			strength = "16";
			agility = "12";
			intelligence = "6";
			charClass = 1;
		}
		
		public static void BanditRanger()
		{
			name = "Charles";
			health = "150";
			mana = "50";
			strength = "10";
			agility = "18";
			intelligence = "10";
			charClass = 2;
		}
		
		public static void BanditMage()
		{
			name = "Morgan";
			health = "80";
			mana = "200";
			strength = "4";
			agility = "6";
			intelligence = "20";
			charClass = 3;
		}
		
		public static void Troll()
		{
			name = "Shirley the Troll";
			health = "300";
			mana = "0";
			strength = "20";
			agility = "10";
			intelligence = "4";
			charClass = 4;
		}
	}
}
