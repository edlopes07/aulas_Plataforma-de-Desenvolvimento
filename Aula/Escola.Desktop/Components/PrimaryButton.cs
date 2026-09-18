using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Escola.Desktop.Components
{
    public partial class PrimaryButton : Button
    {
        public PrimaryButton()
        {
            InitializeComponent();
        }

        public PrimaryButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
