using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    public partial class SelectScene : Scene
    {
        public SelectScene()
        {
            InitializeWidget();
        
			this.Button_1.TouchEventReceived += new EventHandler<TouchEventArgs>(ChangeToTitleScene);
		}
		
		public void ChangeToTitleScene(object sender, TouchEventArgs e){
			Sounds.PlayCancel();
			UISystem.SetScene(Scenes.titleScene);
		}
    }
}
