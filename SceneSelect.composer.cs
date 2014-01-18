// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    partial class SelectScene
    {
        PagePanel PagePanel_1;
        Button Button_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            PagePanel_1 = new PagePanel();
            PagePanel_1.Name = "PagePanel_1";
            Button_1 = new Button();
            Button_1.Name = "Button_1";

            // PagePanel_1
            PagePanel_1.AddPage(new PanelStage(StageID.Stage1));
            PagePanel_1.AddPage(new PanelStage(StageID.Stage2));
            PagePanel_1.AddPage(new PanelStage(StageID.Stage3));

            // Button_1
            Button_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Button_1.BackgroundFilterColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);

            // SelectScene
            this.RootWidget.AddChildLast(PagePanel_1);
            this.RootWidget.AddChildLast(Button_1);
			this.Transition = new PushTransition();
			
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

                    PagePanel_1.SetPosition(656, 226);
                    PagePanel_1.SetSize(100, 50);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    Button_1.SetPosition(-39, 37);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    PagePanel_1.SetPosition(0, 0);
                    PagePanel_1.SetSize(960, 544);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    Button_1.SetPosition(18, 20);
                    Button_1.SetSize(84, 54);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_1.Text = "戻る";
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
