// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ShootingApp
{
    partial class Credit
    {
        ImageBox ImageBox_1;
        ScrollPanel ScrollPanel_1;
        Button Button_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            ScrollPanel_1 = new ScrollPanel();
            ScrollPanel_1.Name = "ScrollPanel_1";
            Button_1 = new Button();
            Button_1.Name = "Button_1";

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset(new Image(ImageMode.Rgba,new ImageSize(960,544),new ImageColor(50,50,50,255)));
            ImageBox_1.ImageScaleType = ImageScaleType.Center;

            // ScrollPanel_1
            ScrollPanel_1.HorizontalScroll = false;
            ScrollPanel_1.VerticalScroll = true;
            ScrollPanel_1.ScrollBarVisibility = ScrollBarVisibility.ScrollableVisible;
            var ScrollPanel_1_CreditPanel = new CreditPanel();
            ScrollPanel_1.PanelWidth = ScrollPanel_1_CreditPanel.Width;
            ScrollPanel_1.PanelHeight = ScrollPanel_1_CreditPanel.Height;
            ScrollPanel_1.PanelX = 0;
            ScrollPanel_1.PanelY = 0;
            ScrollPanel_1.AddChildLast(ScrollPanel_1_CreditPanel);

            // Button_1
            Button_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 20, FontStyle.Regular);

            // Credit
            this.RootWidget.AddChildLast(ImageBox_1);
            this.RootWidget.AddChildLast(ScrollPanel_1);
            this.RootWidget.AddChildLast(Button_1);
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

                    ImageBox_1.SetPosition(6, 0);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    ScrollPanel_1.SetPosition(323, 312);
                    ScrollPanel_1.SetSize(100, 50);
                    ScrollPanel_1.Anchors = Anchors.None;
                    ScrollPanel_1.Visible = true;

                    Button_1.SetPosition(-55, 7);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(960, 544);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    ScrollPanel_1.SetPosition(70, 63);
                    ScrollPanel_1.SetSize(820, 444);
                    ScrollPanel_1.Anchors = Anchors.None;
                    ScrollPanel_1.Visible = true;

                    Button_1.SetPosition(10, 7);
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
