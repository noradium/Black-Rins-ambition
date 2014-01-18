using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;


	
namespace ShootingApp
{
	
	public partial class SceneTitle : Scene
    {
        public SceneTitle()
        {
            InitializeWidget();
			
			this.Button_1.TouchEventReceived += new EventHandler<TouchEventArgs>(ChangeToSelectScene);
        	this.Button_2.TouchEventReceived += new EventHandler<TouchEventArgs>(ChangeToStatusScene);
			this.Button_3.TouchEventReceived += new EventHandler<TouchEventArgs>(ChangeToCreditScene);
        }
		
		public void ChangeToSelectScene(object sender, TouchEventArgs e){
			Sounds.PlayOk();
			UISystem.SetScene(Scenes.selectScene);
		}
		public void ChangeToStatusScene(object sender, TouchEventArgs e){
			Sounds.PlayOk();
			Scenes.characterStatusScene.UpdateValue();
			Scenes.characterStatusScene.ScrollPanel_1_Skills.UpdateSkills();
			UISystem.SetScene(Scenes.characterStatusScene);
		}
		public void ChangeToCreditScene(object sender, TouchEventArgs e){
			Sounds.PlayOk();
			UISystem.SetScene(Scenes.creditScene);
		}
    }
}
