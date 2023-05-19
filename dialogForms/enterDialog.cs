using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilamentManager.dialogForms
{
    public partial class enterDialog : Form
    {
        private readonly int offset = 5;
        public enterDialog()
        {
            InitializeComponent();
        }
        public enterDialog(string old)
        {
            InitializeComponent();
            oldLabel.Text = old;

            //Calculate new pos for arrow and textbox
            int posX = oldLabel.Location.X + oldLabel.Size.Width + offset;
            arrow.Location = new Point(posX, arrow.Location.Y);
            inputBox.Location = new Point(posX + offset + arrow.Width, inputBox.Location.Y);

            //Resize inputbox
            int availableSpace = Width - inputBox.Location.X;
            inputBox.Width = availableSpace - offset;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Trim() == "")
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            tempHolder.value = inputBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
