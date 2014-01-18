using System;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
	public class AppMain
	{
		public static GraphicsContext graphics;
		
		public static void Main (string[] args)
		{
			Initialize ();

			while (true) {
				System.Console.WriteLine(System.GC.GetTotalMemory(true));
				SystemEvents.CheckEvents ();
				Update ();
				Render ();
			}
		}

		public static void Initialize ()
		{
			// Set up the graphics system
			graphics = new GraphicsContext ();
			
			// UI System Initialize
			UISystem.Initialize(graphics);
			
			// データロード
			FileIO.LoadData();
			
			// UIツールキット使用のシーン作成
			Scenes.InitUIScenes();
			
			// 音関係初期化
			Sounds.InitSound();
			
			Sounds.PlayTitle();
			UISystem.SetScene(Scenes.titleScene);
			
			// ディレクター初期化
			Sce.PlayStation.HighLevel.GameEngine2D.Director.Initialize(1000, 800, graphics);
			
			Scenes.InitGameEngine2dScene();
			
			Game.InitGame(graphics);
			
			Global.setSkill = SkillID.Default;
			Global.isInitGame = true;
			Global.isStartGame = false;
		}

		public static void Update ()
		{
			// Query gamepad for current state
			var gamePadData = GamePad.GetData (0);
			
			
			if(Global.isStartGame){
				Game.Update();
			}else{
				List<TouchData> touchDataList = Touch.GetData(0);
				UISystem.Update(touchDataList);
				
				Peripheral.Update(0.01f);
				if(Peripheral.IsHoldKey(GamePadButtons.Select,2.0f)){
					FileIO.Initialize();
					Scenes.UpdateSelectScene();
					Scenes.UpdateStatusScene();
				}
			}
		}

		public static void Render ()
		{
			// Clear the screen
			graphics.SetClearColor (1.0f, 1.0f, 1.0f, 1.0f);
			graphics.Clear ();
		
			if(Global.isStartGame){
				Game.Render();
			}else{
				UISystem.Render();
				// Present the screen
				graphics.SwapBuffers ();
			}
		}
	}
}