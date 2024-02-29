using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzámolóGomb : Button
    {
        int szám = 1;
        public SzámolóGomb()
        {
            Height = 20;
            Width = 20;
            Click += OnClick;
        }

        private void OnClick(object? sender, EventArgs e)
        {
            if(szám > 5)
            {
                szám = 1;
                Text = szám.ToString();
            } else
            {
                Text = szám.ToString();
                szám += 1;
            }

        }
    }
}
