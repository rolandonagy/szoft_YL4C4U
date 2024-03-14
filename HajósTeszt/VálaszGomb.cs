using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajósTeszt
{
    internal class VálaszGomb : TextBox
    {
        public VálaszGomb()
        {
            BackColor = Color.LightGray;
            Multiline = true;
            ReadOnly = true;
            Width = 400;
            Height = 80;

            MouseEnter += VálaszGomb_MouseEnter;
            MouseLeave += VálaszGomb_MouseLeave;

            BorderStyle = BorderStyle.None;
            Cursor = Cursors.Hand;
        }

        private void VálaszGomb_MouseLeave(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void VálaszGomb_MouseEnter(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
