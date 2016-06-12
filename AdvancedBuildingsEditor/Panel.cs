﻿using ColossalFramework.UI;
using UnityEngine;

namespace AdvancedBuildingsEditor
{
    public class Panel : UIPanel
    {
        public override void Start()
        {
            base.Start();
            this.name = "AdvancedBuildingsEditor";
            this.width = 230f;
            this.height = 450f;
            this.backgroundSprite = "MenuPanel2";
            this.canFocus = true;
            this.isInteractive = true;
            this.isVisible = true;
            this.relativePosition = new Vector3(10f, 10f);
            UILabel uiLabel = this.AddUIComponent<UILabel>();
            uiLabel.name = "Title";
            uiLabel.text = "Advanced Buildings Editor";
            uiLabel.textAlignment = UIHorizontalAlignment.Center;
            uiLabel.position = new Vector3((float)((double)this.width / 2.0 - (double)uiLabel.width / 2.0), (float)((double)uiLabel.height / 2.0 - 20.0));
            UIPanel uiPanel1 = this.AddUIComponent<UIPanel>();
            uiPanel1.anchor = UIAnchorStyle.Top | UIAnchorStyle.Left | UIAnchorStyle.Right;
            uiPanel1.transform.localPosition = Vector3.zero;
            uiPanel1.width = this.width;
            uiPanel1.height = this.height - 50f;
            uiPanel1.autoLayout = true;
            uiPanel1.autoLayoutDirection = LayoutDirection.Vertical;
            uiPanel1.autoLayoutPadding = new RectOffset(0, 0, 0, 1);
            uiPanel1.autoLayoutStart = LayoutStart.TopLeft;
            uiPanel1.relativePosition = new Vector3(6f, 50f);
            UIPanel uiPanel2 = uiPanel1.AddUIComponent<UIPanel>();
            string str1 = "SelectionPanel";
            uiPanel2.name = str1;
            double num1 = (double)uiPanel1.width;
            uiPanel2.width = (float)num1;
            double num2 = 30.0;
            uiPanel2.height = (float)num2;
            int num3 = 1;
            uiPanel2.autoLayout = num3 != 0;
            int num4 = 0;
            uiPanel2.autoLayoutDirection = (LayoutDirection)num4;
            RectOffset rectOffset1 = new RectOffset(0, 5, 0, 0);
            uiPanel2.autoLayoutPadding = rectOffset1;

            var bcButton = UIUtil.CreateButton(this, "Bulldoze Ped. Connections");
            bcButton.relativePosition = new Vector3(5, 40);
            bcButton.eventClick +=
            (comp, param) =>
            {
                Scripts.BulldozePedestrianConnections();
            };
            var seButton = UIUtil.CreateButton(this, "Make All Segments Editable");
            seButton.relativePosition = new Vector3(5, 66);
            seButton.eventClick += (comp, param) =>
            {
                Scripts.MakeAllSegmentsEditable();
            };

            var clearSpecialPointsButton = UIUtil.CreateButton(this, "Clear special points");
            clearSpecialPointsButton.relativePosition = new Vector3(5, 92);
            clearSpecialPointsButton.eventClicked += (component, param) =>
            {
                Scripts.ClearSpecialPoints();
            };
        }
    }
}