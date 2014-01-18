using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    public partial class GameOverScene : Scene
    {
        public GameOverScene()
        {
            InitializeWidget();
			
			this.Button_1.TouchEventReceived += new EventHandler<TouchEventArgs>(ChangeToTitleScene);
        }
		
		public void ChangeToTitleScene(object sender, TouchEventArgs e){
			Sounds.PlayCancel();
			Sounds.PlayTitle();
			UISystem.SetScene(Scenes.titleScene);
		}
    }
}
