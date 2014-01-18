// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    partial class CreditPanel
    {
        Label Label_1;
        Label Label_2;

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

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 30, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Center;
            Label_1.VerticalAlignment = VerticalAlignment.Top;
            Label_1.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(128f / 255f, 128f / 255f, 128f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Label_2
            Label_2.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_2.Font = new UIFont(FontAlias.System, 36, FontStyle.Bold);
            Label_2.LineBreak = LineBreak.Character;
            Label_2.HorizontalAlignment = HorizontalAlignment.Center;
            Label_2.VerticalAlignment = VerticalAlignment.Top;

            // CreditPanel
            this.BackgroundColor = new UIColor(85f / 255f, 85f / 255f, 85f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Label_1);
            this.AddChildLast(Label_2);

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

                    Label_1.SetPosition(183, 112);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(183, 112);
                    Label_2.SetSize(214, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    break;

                default:
                    this.SetSize(820, 1120);
                    this.Anchors = Anchors.None;

                    Label_1.SetPosition(40, 44);
                    Label_1.SetSize(740, 1115);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(40, 44);
                    Label_2.SetSize(740, 1115);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nYUSUKE HOSONO\r\n\r\n\r\n\r\n\r\n\r\nちゃみ\r\n\r\nゲーム開発日記  (http://dvdm.blog134.fc2.com/)\r\n\r\n暗黒工房\r\n\r\n茫然の流もの喫茶\r\n\r\n\r\n\r\n\r\n\r\nOn-Jin 音人\r\n\r\n01 Sound Earth  (http://www.01earth.net/sound/)\r\n\r\nポケットサウンド  (http://pocket-se.info/)\r\n\r\nフリーBGM DOVA-SYNDROME";

            Label_2.Text = "ブラックリンの野望\r\nCREDIT\r\n\r\n\r\n\r\nプログラム\r\n\r\n\r\n\r\n\r\nイラスト・デザイン\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nサウンド";
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
