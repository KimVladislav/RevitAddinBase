﻿using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAddinBase.RevitControls
{
    public class Separator : RibbonItemBase
    {
        public override Autodesk.Windows.RibbonItem CreateRibbon(UIControlledApplication app, Dictionary<string, object> resources, bool isStacked = false)
        {
            return new Autodesk.Windows.RibbonSeparator();
        }
    }
}
