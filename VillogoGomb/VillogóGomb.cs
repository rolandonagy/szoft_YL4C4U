using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class VillogóGomb : Button
    {
        public VillogóGomb()
        {
            BackColor = Color.Green;
             MouseEnter += OnMouseEnter;
             MouseLeave += OnMouseLeave;
        }

        private void OnMouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void OnMouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }
    }
}
