using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzíneződőGomb : Button
    {
        public int meret = 50;
        public SzíneződőGomb()
        {
            Height = meret;
            Width = meret;
            Click += OnClick;
        }

        private void OnClick(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
