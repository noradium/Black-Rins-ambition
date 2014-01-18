// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    partial class CharacterStatus
    {
        ImageBox ImageBox_1;
        ProgressBar ProgressBar_1;
        ImageBox ImageBox_2;
		Button Button_1;
		Label Label_1;
        Label Label_level;
        Label Label_2;
        Label Label_exp;
        Label Label_3;
        Label Label_rem;
        ScrollPanel ScrollPanel_1;
        Label Label_4;
		public Skills ScrollPanel_1_Skills;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            ProgressBar_1 = new ProgressBar();
            ProgressBar_1.Name = "ProgressBar_1";
            ImageBox_2 = new ImageBox();
            ImageBox_2.Name = "ImageBox_2";
            Button_1 = new Button();
        	Button_1.Name = "Button_1";
			Label_1 = new Label();
            Label_1.Name = "Label_1";
            Label_level = new Label();
            Label_level.Name = "Label_level";
            Label_2 = new Label();
            Label_2.Name = "Label_2";
            Label_exp = new Label();
            Label_exp.Name = "Label_exp";
            Label_3 = new Label();
            Label_3.Name = "Label_3";
            Label_rem = new Label();
            Label_rem.Name = "Label_rem";
            ScrollPanel_1 = new ScrollPanel();
            ScrollPanel_1.Name = "ScrollPanel_1";
            Label_4 = new Label();
            Label_4.Name = "Label_4";

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/statusbg.jpg");
            ImageBox_1.ImageScaleType = ImageScaleType.Center;

            // ImageBox_2
            ImageBox_2.Image = new ImageAsset("/Application/assets/myCharacter.png");
            ImageBox_2.ImageScaleType = ImageScaleType.Center;

			// Button_1
            Button_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
			Button_1.BackgroundFilterColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 191f / 255f, 116f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 40, FontStyle.Bold);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Label_level
            Label_level.TextColor = new UIColor(255f / 255f, 191f / 255f, 116f / 255f, 255f / 255f);
            Label_level.Font = new UIFont(FontAlias.System, 60, FontStyle.Bold);
            Label_level.LineBreak = LineBreak.Character;
            Label_level.HorizontalAlignment = HorizontalAlignment.Right;
            Label_level.VerticalAlignment = VerticalAlignment.Bottom;
            Label_level.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Label_2
            Label_2.TextColor = new UIColor(255f / 255f, 191f / 255f, 116f / 255f, 255f / 255f);
            Label_2.Font = new UIFont(FontAlias.System, 40, FontStyle.Bold);
            Label_2.LineBreak = LineBreak.Character;
            Label_2.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Label_exp
            Label_exp.TextColor = new UIColor(255f / 255f, 191f / 255f, 116f / 255f, 255f / 255f);
            Label_exp.Font = new UIFont(FontAlias.System, 32, FontStyle.Bold);
            Label_exp.LineBreak = LineBreak.Character;
            Label_exp.HorizontalAlignment = HorizontalAlignment.Right;
            Label_exp.VerticalAlignment = VerticalAlignment.Bottom;
            Label_exp.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Label_3
            Label_3.TextColor = new UIColor(255f / 255f, 191f / 255f, 116f / 255f, 255f / 255f);
            Label_3.Font = new UIFont(FontAlias.System, 28, FontStyle.Bold);
            Label_3.LineBreak = LineBreak.Character;
            Label_3.VerticalAlignment = VerticalAlignment.Bottom;
            Label_3.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Label_rem
            Label_rem.TextColor = new UIColor(255f / 255f, 191f / 255f, 116f / 255f, 255f / 255f);
            Label_rem.Font = new UIFont(FontAlias.System, 28, FontStyle.Bold);
            Label_rem.LineBreak = LineBreak.Character;
            Label_rem.HorizontalAlignment = HorizontalAlignment.Right;
            Label_rem.VerticalAlignment = VerticalAlignment.Bottom;
            Label_rem.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // ScrollPanel_1
            ScrollPanel_1.HorizontalScroll = false;
            ScrollPanel_1.VerticalScroll = true;
            ScrollPanel_1.ScrollBarVisibility = ScrollBarVisibility.ScrollableVisible;
            ScrollPanel_1_Skills = new Skills();
			ScrollPanel_1_Skills.UpdateSkills();
            ScrollPanel_1.PanelWidth = ScrollPanel_1_Skills.Width;
            ScrollPanel_1.PanelHeight = ScrollPanel_1_Skills.Height;
            ScrollPanel_1.PanelX = 0;
            ScrollPanel_1.PanelY = 0;
            ScrollPanel_1.AddChildLast(ScrollPanel_1_Skills);
			
			
            // Label_4
            Label_4.TextColor = new UIColor(255f / 255f, 191f / 255f, 116f / 255f, 255f / 255f);
            Label_4.Font = new UIFont(FontAlias.System, 40, FontStyle.Bold);
            Label_4.LineBreak = LineBreak.Character;
            Label_4.HorizontalAlignment = HorizontalAlignment.Center;
            Label_4.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // CharacterStatus
            this.RootWidget.AddChildLast(ImageBox_1);
            this.RootWidget.AddChildLast(ProgressBar_1);
            this.RootWidget.AddChildLast(ImageBox_2);
			this.RootWidget.AddChildLast(Button_1);
            this.RootWidget.AddChildLast(Label_1);
            this.RootWidget.AddChildLast(Label_level);
            this.RootWidget.AddChildLast(Label_2);
            this.RootWidget.AddChildLast(Label_exp);
            this.RootWidget.AddChildLast(Label_3);
            this.RootWidget.AddChildLast(Label_rem);
            this.RootWidget.AddChildLast(ScrollPanel_1);
            this.RootWidget.AddChildLast(Label_4);
            this.Transition = new JumpFlipTransition();
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

                    ImageBox_1.SetPosition(426, 278);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    ProgressBar_1.SetPosition(336, 328);
                    ProgressBar_1.SetSize(362, 16);
                    ProgressBar_1.Anchors = Anchors.Height;
                    ProgressBar_1.Visible = true;

                    ImageBox_2.SetPosition(101, 91);
                    ImageBox_2.SetSize(200, 200);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;

                    Label_1.SetPosition(0, 229);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_level.SetPosition(146, 149);
                    Label_level.SetSize(214, 36);
                    Label_level.Anchors = Anchors.None;
                    Label_level.Visible = true;

                    Label_2.SetPosition(0, 229);
                    Label_2.SetSize(214, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_exp.SetPosition(146, 149);
                    Label_exp.SetSize(214, 36);
                    Label_exp.Anchors = Anchors.None;
                    Label_exp.Visible = true;

                    Label_3.SetPosition(146, 149);
                    Label_3.SetSize(214, 36);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_rem.SetPosition(146, 149);
                    Label_rem.SetSize(214, 36);
                    Label_rem.Anchors = Anchors.None;
                    Label_rem.Visible = true;

                    ScrollPanel_1.SetPosition(511, 109);
                    ScrollPanel_1.SetSize(100, 50);
                    ScrollPanel_1.Anchors = Anchors.None;
                    ScrollPanel_1.Visible = true;

                    Label_4.SetPosition(0, 229);
                    Label_4.SetSize(214, 36);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(960, 544);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    ProgressBar_1.SetPosition(42, 379);
                    ProgressBar_1.SetSize(362, 16);
                    ProgressBar_1.Anchors = Anchors.Height;
                    ProgressBar_1.Visible = true;

                    ImageBox_2.SetPosition(42, 19);
                    ImageBox_2.SetSize(182, 182);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;
	
					Button_1.SetPosition(860, 20);
                    Button_1.SetSize(84, 54);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;


                    Label_1.SetPosition(42, 220);
                    Label_1.SetSize(134, 57);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_level.SetPosition(176, 210);
                    Label_level.SetSize(118, 67);
                    Label_level.Anchors = Anchors.None;
                    Label_level.Visible = true;

                    Label_2.SetPosition(42, 313);
                    Label_2.SetSize(109, 57);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_exp.SetPosition(176, 323);
                    Label_exp.SetSize(228, 46);
                    Label_exp.Anchors = Anchors.None;
                    Label_exp.Visible = true;

                    Label_3.SetPosition(42, 401);
                    Label_3.SetSize(228, 46);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_rem.SetPosition(288, 401);
                    Label_rem.SetSize(115, 46);
                    Label_rem.Anchors = Anchors.None;
                    Label_rem.Visible = true;

                    ScrollPanel_1.SetPosition(488, 118);
                    ScrollPanel_1.SetSize(400, 362);
                    ScrollPanel_1.Anchors = Anchors.None;
                    ScrollPanel_1.Visible = true;

                    Label_4.SetPosition(488, 38);
                    Label_4.SetSize(247, 57);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
			Button_1.Text = "戻る";
			
            Label_1.Text = "レベル";

            Label_level.Text = "0";

            Label_2.Text = "Exp.";

            Label_exp.Text = "0/0";

            Label_3.Text = "次レベルまであと";

            Label_rem.Text = "0";

            Label_4.Text = "習得スキル";
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
