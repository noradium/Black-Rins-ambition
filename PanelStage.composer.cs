// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    partial class PanelStage
    {
        ImageBox ImageBox_1;
        Button Button_1;
        Panel Panel_1;
		Label Label_1;
		Label Label_2;

        private void InitializeWidget(StageID stageID)
        {
            InitializeWidget(LayoutOrientation.Horizontal, stageID);
        }

        private void InitializeWidget(LayoutOrientation orientation, StageID stageID)
        {
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            Panel_1 = new Panel();
            Panel_1.Name = "Panel_1";
			Label_1 = new Label();
			Label_1.Name = "Label_1";
			Label_2 = new Label();
			Label_2.Name = "Label_2";

            // ImageBox_1
            ImageBox_1.ImageScaleType = ImageScaleType.Center;

            // Button_1
            Button_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
			
            // Panel_1
            Panel_1.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            Panel_1.Clip = true;
            Panel_1.AddChildLast(ImageBox_1);
            Panel_1.AddChildLast(Button_1);
			
			
			// Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 80, FontStyle.Bold);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Center;
            Label_1.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };
			
			// Label_2
			Label_2.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
			Label_2.Font = new UIFont(FontAlias.System, 50, FontStyle.Bold);
			Label_2.LineBreak = LineBreak.Character;
			Label_2.HorizontalAlignment = HorizontalAlignment.Center;
			Label_2.TextShadow = new TextShadowSettings()
			{
				Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
				HorizontalOffset = 2f,
				VerticalOffset = 2f,
			};
			
            // PanelStage
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Panel_1);
			this.AddChildLast(Label_1);
			this.AddChildLast(Label_2);
			

            SetWidgetLayout(orientation);

            Update(stageID);
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    ImageBox_1.SetPosition(319, 9);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    Button_1.SetPosition(369, 415);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Panel_1.SetPosition(400, 201);
                    Panel_1.SetSize(100, 100);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;
				
					Label_1.SetPosition(100, 100);
                    Label_1.SetSize(400, 100);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;
				
					Label_2.SetPosition(400, 240);
                    Label_2.SetSize(300, 100);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;
				
                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(960, 544);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    Button_1.SetPosition(373, 424);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Panel_1.SetPosition(0, 0);
                    Panel_1.SetSize(960, 544);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;
				
					Label_1.SetPosition(30, 50);
                    Label_1.SetSize(500, 100);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;
				
					Label_2.SetPosition(300, 120);
                    Label_2.SetSize(600, 100);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;
				
                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void Update(StageID stageID)
        {
			Button_1.Text = ""+stageId;
			Label_1.Text = ""+stageId;
			
			if(Global.isStageOpened[(int)stageID]){
				if(stageID == StageID.Stage1){
					ImageBox_1.Image = new ImageAsset("/Application/assets/statusbg.jpg");
					Label_2.Text = "市街地ステージ";
				}
			}else{
				ImageBox_1.Image = new ImageAsset(new Image(ImageMode.Rgba,new ImageSize(960,544),new ImageColor(0,0,0,255))); ;
				Button_1.Enabled = false;
				Label_2.Text = "Stage " + ((int)stageId-1) + "クリアで開放";
				
			}
			
        }
		
        public void InitializeDefaultEffect()
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        public void StartDefaultEffect()
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

    }
}
