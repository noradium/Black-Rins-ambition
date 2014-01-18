// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    partial class Result
    {
        Label Label_1;
        Label Label_2;
        Label Label_3;
        Label Label_4;
        Button Button_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            Label_2 = new Label();
            Label_2.Name = "Label_2";
            Label_3 = new Label();
            Label_3.Name = "Label_3";
            Label_4 = new Label();
            Label_4.Name = "Label_4";
            Button_1 = new Button();
            Button_1.Name = "Button_1";

            // Label_1
            Label_1.TextColor = new UIColor(247f / 255f, 255f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 72, FontStyle.Bold);
            Label_1.LineBreak = LineBreak.Hyphenation;
            Label_1.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 3f,
                VerticalOffset = 3f,
            };

            // Label_2
            Label_2.TextColor = new UIColor(247f / 255f, 255f / 255f, 0f / 255f, 255f / 255f);
            Label_2.Font = new UIFont(FontAlias.System, 44, FontStyle.Bold);
            Label_2.LineBreak = LineBreak.Character;
            Label_2.HorizontalAlignment = HorizontalAlignment.Right;
            Label_2.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 3f,
                VerticalOffset = 3f,
            };

            // Label_3
            Label_3.TextColor = new UIColor(247f / 255f, 255f / 255f, 0f / 255f, 255f / 255f);
            Label_3.Font = new UIFont(FontAlias.System, 44, FontStyle.Bold);
            Label_3.LineBreak = LineBreak.Character;
            Label_3.HorizontalAlignment = HorizontalAlignment.Right;
            Label_3.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 3f,
                VerticalOffset = 3f,
            };

            // Label_4
            Label_4.TextColor = new UIColor(255f / 255f, 162f / 255f, 38f / 255f, 255f / 255f);
            Label_4.Font = new UIFont(FontAlias.System, 52, FontStyle.Bold);
            Label_4.LineBreak = LineBreak.Character;
            Label_4.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 3f,
                VerticalOffset = 3f,
            };

            // Button_1
            Button_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 40, FontStyle.Regular);

            // Result
            this.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 220f / 255f);
            this.AddChildLast(Label_1);
            this.AddChildLast(Label_2);
            this.AddChildLast(Label_3);
            this.AddChildLast(Label_4);
            this.AddChildLast(Button_1);
            this.ShowEffect = new FadeInEffect(){Time=2.0f};
            this.HideEffect = new TiltDropEffect();

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetPosition(0, 0);
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    Label_1.SetPosition(300, 87);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(300, 87);
                    Label_2.SetSize(214, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(300, 87);
                    Label_3.SetSize(214, 36);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(300, 87);
                    Label_4.SetSize(214, 36);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    Button_1.SetPosition(640, 397);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    break;

                default:
                    this.SetPosition(0, 0);
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Label_1.SetPosition(85, 31);
                    Label_1.SetSize(673, 121);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(306, 170);
                    Label_2.SetSize(348, 94);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(695, 170);
                    Label_3.SetSize(194, 94);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(250, 328);
                    Label_4.SetSize(400, 165);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    Button_1.SetPosition(747, 402);
                    Button_1.SetSize(163, 98);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "Stage Cleared!";

            Label_2.Text = "獲得経験値";

            Label_3.Text = "0";

            Label_4.Text = "レベルアップ！";

            Button_1.Text = "OK";
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
