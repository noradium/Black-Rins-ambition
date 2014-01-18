using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    public partial class Result : Dialog
    {
        public Result(int exp, StageID thisStageId)
            : base(null, null)
        {
            InitializeWidget();
			MakeResult(exp,thisStageId);
			
			this.Button_1.TouchEventReceived += new EventHandler<TouchEventArgs>(dialogClose);
        }
		
		public void dialogClose(object sender, TouchEventArgs e){
			Sounds.PlayOk();
			this.Hide();
		}
		
		/// <summary>
		/// Makes the result.
		/// </summary>
		/// <param name='exp'>
		/// 獲得経験値
		/// </param>
		public void MakeResult(int exp, StageID thisStageId){
			if(Global.isClear){
				Label_1.Text = "Stage Cleared!";
				Label_1.TextColor = new UIColor(247f / 255f, 255f / 255f, 0f / 255f, 255f / 255f);
				Global.isStageOpened[(int)thisStageId + 1] = true;
			}else{
				Label_1.Text = "Stage Failed...";
				Label_1.TextColor = new UIColor(255f / 255f, 10f / 255f, 10f / 255f, 255f / 255f);
			}
			
			var newExp = Global.characterExp + exp;
			Label_3.Text = ""+exp;
			
			if(Global.characterLevel < Global.maxLevel){
				if(newExp >= Global.expTable[Global.characterLevel+1]){
					while(newExp >= Global.expTable[Global.characterLevel+1]){
						Global.characterExp = newExp - Global.expTable[Global.characterLevel+1];
						Global.characterLevel++;
						if(Global.characterLevel == Global.maxLevel){
							Global.characterExp = 0;
							break;
						}
					}
					Label_4.Text = "レベルアップ！";
				}else{
						Global.characterExp = newExp;
						Label_4.Text = "";
		
				}	
				FileIO.SaveData();
			}
		}
    }
}
