using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;

namespace ShootingApp
{
	public static class Scenes
	{
		public static SceneTitle titleScene;
		public static SelectScene selectScene;
		public static GameOverScene gameOverScene;
		public static CharacterStatus characterStatusScene;
		public static Credit creditScene;
		public static StageClearScene stageClearScene;
		
		public static Scene sceneOnGame;
		
		public static void InitUIScenes ()
		{
			titleScene = new SceneTitle();
			selectScene = new SelectScene();
			gameOverScene = new GameOverScene();
			characterStatusScene = new CharacterStatus();
			creditScene = new Credit();
			stageClearScene = new StageClearScene();
		}
		public static void InitGameEngine2dScene(){
			sceneOnGame = new Scene();
		}
		
		public static void UpdateSelectScene(){
			selectScene = new SelectScene();	
		}
		public static void UpdateStatusScene(){
			characterStatusScene = new CharacterStatus();	
		}
	}
}

