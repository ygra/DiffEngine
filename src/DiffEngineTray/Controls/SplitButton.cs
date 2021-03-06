using System;
using System.Drawing;
using System.Windows.Forms;

class SplitButton :
    ToolStripSplitButton
{
    public SplitButton(string text, Action? action = null, Image? image = null) :
        base(text, image)
    {
        AutoToolTip = false;

        if (action != null)
        {
            ButtonClick += delegate { action(); };
        }
    }
}