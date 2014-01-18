using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
	public enum SkillID{Default,Skill1,Skill2,Skill3,Skill4}
		
    public partial class Skills : Panel
    {
        public Skills()
        {
            InitializeWidget();
			
			this.CheckBox_1.CheckedChanged += new EventHandler<TouchEventArgs>(setSkill1);
			this.CheckBox_2.CheckedChanged += new EventHandler<TouchEventArgs>(setSkill2);
			this.CheckBox_3.CheckedChanged += new EventHandler<TouchEventArgs>(setSkill3);
			this.CheckBox_0.CheckedChanged += new EventHandler<TouchEventArgs>(setSkillDefault);

		}
		
		public void setSkill1(object sender, TouchEventArgs e){
			if(CheckBox_1.Checked){
				Global.setSkill = SkillID.Skill1;
				CheckBox_0.Checked = false;
				CheckBox_2.Checked = false;
				CheckBox_3.Checked = false;
			}
		}
		public void setSkill2(object sender, TouchEventArgs e){
			if(CheckBox_2.Checked){
				Global.setSkill = SkillID.Skill2;
				CheckBox_0.Checked = false;
				CheckBox_1.Checked = false;
				CheckBox_3.Checked = false;
			}
		}
		public void setSkill3(object sender, TouchEventArgs e){
			if(CheckBox_3.Checked){
				Global.setSkill = SkillID.Skill3;
				CheckBox_0.Checked = false;
				CheckBox_1.Checked = false;
				CheckBox_2.Checked = false;
			}
		}
		public void setSkillDefault(object sender, TouchEventArgs e){
			if(CheckBox_0.Checked){
				Global.setSkill = SkillID.Default;
				CheckBox_1.Checked = false;
				CheckBox_2.Checked = false;
				CheckBox_3.Checked = false;
			}
		}
		
		
		public void UpdateSkills(){
			CheckBox_0.Enabled = true;
			CheckBox_0.Checked = true;
			for(int i = 0; i <= Global.characterLevel; i++){
				if(Global.skilltable[i] == 1){
					CheckBox_1.Enabled = true;
					Label_1.Text = "";
					if(Global.setSkill == SkillID.Skill1){
						setSkill1(null,null);	
					}
				}
			}
		}
		
		
    }
}
