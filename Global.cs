using System;

namespace ShootingApp
{
	public static class Global
	{
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ShootingApp.Global"/> is start game.
		/// </summary>
		/// <value>
		/// <c>true</c> if is start game; otherwise, <c>false</c>.
		/// </value>
		public static bool isStartGame{
			get;
			set;
		}
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ShootingApp.Global"/> is game over.
		/// </summary>
		/// <value>
		/// <c>true</c> if is game over; otherwise, <c>false</c>.
		/// </value>
		public static bool isGameOver{
			get;
			set;
		}
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ShootingApp.Global"/> is clear.
		/// </summary>
		/// <value>
		/// <c>true</c> if is clear; otherwise, <c>false</c>.
		/// </value>
		public static bool isClear{
			get;
			set;
		}
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ShootingApp.Global"/> is init game.
		/// </summary>
		/// <value>
		/// <c>true</c> if is init game; otherwise, <c>false</c>.
		/// </value>
		public static bool isInitGame{
			get;
			set;
		}
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ShootingApp.Global"/> character active.
		/// </summary>
		/// <value>
		/// <c>true</c> if character active; otherwise, <c>false</c>.
		/// </value>
		public static bool characterActive{
			get;
			set;	
		}
	
		/// <summary>
		/// Gets or sets the score.
		/// </summary>
		/// <value>
		/// The score.
		/// </value>
		public static int score{
			get;
			set;	
		}
		
		/// <summary>
		/// Gets or sets the skill point.
		/// </summary>
		/// <value>
		/// The skill point.
		/// </value>
		public static int skillPoint{
			get; set;	
		}
		
		/// <summary>
		/// Gets or sets the character stack.
		/// </summary>
		/// <value>
		/// The character stack.
		/// </value>
		public static int characterStack{
			get;
			set;	
		}
		
		/// <summary>
		/// Gets or sets the character level.
		/// </summary>
		/// <value>
		/// The character level.
		/// </value>
		public static int characterLevel{
			get;
			set;
		}
		
		/// <summary>
		/// Gets or sets the character exp.
		/// </summary>
		/// <value>
		/// The character exp.
		/// </value>
		public static int characterExp{
			get;
			set;
		}
		
		/// <summary>
		/// セットされているスキル
		/// </summary>
		/// <value>
		/// The set skill.
		/// </value>
		public static SkillID setSkill{
			get; set;
		}
		
		/// <summary>
		/// 開放されているステージ
		/// </summary>
		public static bool[] isStageOpened = new bool[]{true,true,false,false}; // 0番目はダミー
		
		
										   //Level 0 1  2  3  4  5  6   7   8   9  10  11  12  13  14  15
		public static int[] expTable = new int[]  {0,0,10,20,40,60,90,125,160,200,250,310,380,460,550,600,0}; // 0番目はダミー　（index）レベルになるのに必要な経験値
		public static int[] skilltable = new int[]{0,0, 0, 1, 0, 0, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,0}; // 0:覚えるスキルなし   others:覚えるスキルID
		public static int maxLevel = 15;
	}
}

