using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    public partial class CharacterStatus : Scene
    {
        public CharacterStatus()
        {
            InitializeWidget();
			
			this.Button_1.TouchEventReceived += new EventHandler<TouchEventArgs>(ChangeToTitleScene);
        }
		
		public void ChangeToTitleScene(object sender, TouchEventArgs e){
			Sounds.PlayCancel();
			
			UISystem.SetScene(Scenes.titleScene);
		}
		
		public void UpdateValue(){
			this.Label_level.Text = ""+Global.characterLevel;
			this.Label_exp.Text = Global.characterExp + "/" + Global.expTable[Global.characterLevel + 1];
			this.Label_rem.Text = ""+(Global.expTable[Global.characterLevel + 1] - Global.characterExp);
			this.ProgressBar_1.Progress = (float)((float)(Global.characterExp) / (float)(Global.expTable[Global.characterLevel + 1]));
			
		}
    }
}
