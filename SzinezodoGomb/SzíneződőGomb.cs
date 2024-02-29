using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzinezodoGomb
{
    internal class SzíneződőGomb : Button
    {
        public SzíneződőGomb()
        {
            int meret = 40;
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
