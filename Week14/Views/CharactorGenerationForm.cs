using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week14.Views
{
    public partial class CharactorGenerationForm : Week14.Views.MasterForm
    {
        public CharactorGenerationForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTapControl.SelectedIndex != 0)
            {
                MainTapControl.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTapControl.SelectedIndex < MainTapControl.TabPages.Count - 1)
            {
                MainTapControl.SelectedIndex++;
            }
        }
    }
}
