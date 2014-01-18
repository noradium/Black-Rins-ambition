// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    partial class Skills
    {
        ImageBox ImageBox_1;
        CheckBox CheckBox_1;
        ImageBox ImageBox_2;
        CheckBox CheckBox_2;
        ImageBox ImageBox_3;
        CheckBox CheckBox_3;
        Label Label_1;
        CheckBox CheckBox_0;
        ImageBox ImageBox_0;
		

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            CheckBox_1 = new CheckBox();
            CheckBox_1.Name = "CheckBox_1";
            ImageBox_2 = new ImageBox();
            ImageBox_2.Name = "ImageBox_2";
            CheckBox_2 = new CheckBox();
            CheckBox_2.Name = "CheckBox_2";
            ImageBox_3 = new ImageBox();
            ImageBox_3.Name = "ImageBox_3";
            CheckBox_3 = new CheckBox();
            CheckBox_3.Name = "CheckBox_3";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            CheckBox_0 = new CheckBox();
            CheckBox_0.Name = "CheckBox_0";
            ImageBox_0 = new ImageBox();
            ImageBox_0.Name = "ImageBox_0";

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/skill_refrection.png");
            ImageBox_1.ImageScaleType = ImageScaleType.Center;

            // CheckBox_1
            CheckBox_1.Style = CheckBoxStyle.RadioButton;
            CheckBox_1.Enabled = false;

            // ImageBox_2
            ImageBox_2.Image = new ImageAsset("/Application/assets/skill_notImplemented.png");
            ImageBox_2.ImageScaleType = ImageScaleType.Center;

            // CheckBox_2
            CheckBox_2.Style = CheckBoxStyle.RadioButton;
            CheckBox_2.Enabled = false;

            // ImageBox_3
            ImageBox_3.Image = new ImageAsset("/Application/assets/skill_notImplemented.png");
            ImageBox_3.ImageScaleType = ImageScaleType.Center;

            // CheckBox_3
            CheckBox_3.Style = CheckBoxStyle.RadioButton;
            CheckBox_3.Enabled = false;

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Right;
            Label_1.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // CheckBox_0
            CheckBox_0.Style = CheckBoxStyle.RadioButton;
            CheckBox_0.Checked = true;

            // ImageBox_0
            ImageBox_0.Image = new ImageAsset("/Application/assets/skill_TheWORLD.png");
            ImageBox_0.ImageScaleType = ImageScaleType.Center;

            // Skills
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 127f / 255f);
            this.Clip = true;
            this.AddChildLast(ImageBox_1);
            this.AddChildLast(CheckBox_1);
            this.AddChildLast(ImageBox_2);
            this.AddChildLast(CheckBox_2);
            this.AddChildLast(ImageBox_3);
            this.AddChildLast(CheckBox_3);
            this.AddChildLast(Label_1);
            this.AddChildLast(CheckBox_0);
            this.AddChildLast(ImageBox_0);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    ImageBox_1.SetPosition(125, 8);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    CheckBox_1.SetPosition(17, 10);
                    CheckBox_1.SetSize(56, 56);
                    CheckBox_1.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_1.Visible = true;

                    ImageBox_2.SetPosition(125, 8);
                    ImageBox_2.SetSize(200, 200);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;

                    CheckBox_2.SetPosition(17, 10);
                    CheckBox_2.SetSize(56, 56);
                    CheckBox_2.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_2.Visible = true;

                    ImageBox_3.SetPosition(125, 8);
                    ImageBox_3.SetSize(200, 200);
                    ImageBox_3.Anchors = Anchors.None;
                    ImageBox_3.Visible = true;

                    CheckBox_3.SetPosition(17, 10);
                    CheckBox_3.SetSize(56, 56);
                    CheckBox_3.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_3.Visible = true;

                    Label_1.SetPosition(91, 88);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    CheckBox_0.SetPosition(17, 10);
                    CheckBox_0.SetSize(56, 56);
                    CheckBox_0.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_0.Visible = true;

                    ImageBox_0.SetPosition(125, 8);
                    ImageBox_0.SetSize(200, 200);
                    ImageBox_0.Anchors = Anchors.None;
                    ImageBox_0.Visible = true;

                    break;

                default:
                    this.SetSize(400, 544);
                    this.Anchors = Anchors.None;

                    ImageBox_1.SetPosition(75, 164);
                    ImageBox_1.SetSize(300, 68);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    CheckBox_1.SetPosition(15, 179);
                    CheckBox_1.SetSize(39, 39);
                    CheckBox_1.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_1.Visible = true;

                    ImageBox_2.SetPosition(75, 289);
                    ImageBox_2.SetSize(300, 68);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;

                    CheckBox_2.SetPosition(15, 303);
                    CheckBox_2.SetSize(39, 39);
                    CheckBox_2.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_2.Visible = true;

                    ImageBox_3.SetPosition(75, 423);
                    ImageBox_3.SetSize(300, 68);
                    ImageBox_3.Anchors = Anchors.None;
                    ImageBox_3.Visible = true;

                    CheckBox_3.SetPosition(15, 437);
                    CheckBox_3.SetSize(39, 39);
                    CheckBox_3.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_3.Visible = true;

                    Label_1.SetPosition(152, 217);
                    Label_1.SetSize(222, 34);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    CheckBox_0.SetPosition(15, 61);
                    CheckBox_0.SetSize(39, 39);
                    CheckBox_0.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_0.Visible = true;

                    ImageBox_0.SetPosition(75, 47);
                    ImageBox_0.SetSize(300, 68);
                    ImageBox_0.Anchors = Anchors.None;
                    ImageBox_0.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "Lv.3で開放されます";
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
