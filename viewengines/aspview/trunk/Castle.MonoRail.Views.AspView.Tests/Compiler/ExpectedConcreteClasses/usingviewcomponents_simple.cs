﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Castle.MonoRail.Framework;
using Castle.MonoRail.Views.AspView;
namespace CompiledViews
{
public class usingviewcomponents_simple : AspViewBase
{
public override void Render()
{
Output(@"A simple viewcomponent, without a body and sections
");
InvokeViewComponent("Simple", null, new KeyValuePair<string, object>[] {  } );
Output(@"
I was supposed to be rendered after the viewcomponent");

}
protected override string ViewName { get { return "\\UsingViewComponents\\Simple.aspx"; } }
protected override string ViewDirectory { get { return "\\UsingViewComponents"; } }
}
}