// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    partial class SceneTitle
    {
        ImageBox ImageBox_1;
        Label Label_1;
        Button Button_1;
		Button Button_2;
		Button Button_3;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            Button_1 = new Button();
            Button_1.Name = "Button_1";
			Button_2 = new Button();
            Button_2.Name = "Button_2";
			Button_3 = new Button();
            Button_3.Name = "Button_3";

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/title.jpg");

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 27f / 255f, 157f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 68, FontStyle.Bold);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Center;
            Label_1.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Button_1
            Button_1.TextColor = new UIColor(253f / 255f, 211f / 255f, 2f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
			
			// Button_2
			Button_2.TextColor = new UIColor(253f / 255f, 211f / 255f, 2f / 255f, 255f / 255f);
            Button_2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
			
			// Button_3
			Button_3.TextColor = new UIColor(253f / 255f, 211f / 255f, 2f / 255f, 255f / 255f);
            Button_3.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
			
            // SceneTitle
            this.RootWidget.AddChildLast(ImageBox_1);
            this.RootWidget.AddChildLast(Label_1);
            this.RootWidget.AddChildLast(Button_1);
			this.RootWidget.AddChildLast(Button_2);
			this.RootWidget.AddChildLast(Button_3);
			
			this.Transition = new CrossFadeTransition();
			
            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    ImageBox_1.SetPosition(362, 158);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    Label_1.SetPosition(349, 104);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Button_1.SetPosition(600, 342);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;
		
					Button_2.SetPosition(600, 310);
                    Button_2.SetSize(214, 50);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;
                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(960, 544);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    Label_1.SetPosition(19, 46);
                    Label_1.SetSize(566, 125);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Button_1.SetPosition(650, 300);
                    Button_1.SetSize(214, 50);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;
					
					Button_2.SetPosition(650, 370);
                    Button_2.SetSize(214, 50);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;
				
					Button_3.SetPosition(650, 440);
                    Button_3.SetSize(214, 50);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "";

            Button_1.Text = "スタート";
			Button_2.Text = "ステータス";
			Button_3.Text = "クレジット";
			
		}

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
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
