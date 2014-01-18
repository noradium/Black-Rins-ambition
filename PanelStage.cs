using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    public partial class PanelStage : Panel
    {
		public StageID stageId;
		
        public PanelStage(StageID stageID)
        {
			stageId = stageID;
            InitializeWidget(stageID);
			this.Button_1.TouchEventReceived += new EventHandler<TouchEventArgs>(ChangeToGameScene);
        }
		
		public void ChangeToGameScene(object sender, TouchEventArgs e){
			if(Button_1.Enabled){
				Sounds.PlayOk();
				Game.StartGame(stageId);
				Global.isStartGame = true;
			}else{
				
			}
		}
		
    }
}
