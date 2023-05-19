using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilamentManager.userControls
{
    public partial class filamentItem : UserControl
    {
        public int id = -1;
        public filamentItem()
        {
            InitializeComponent();
        }
        public filamentItem(int id)
        {
            InitializeComponent();
            this.id = id;

            loadState();
            adjustTypPosition();

            filamentPreview.Click += filamentPreview_Click;
            creatorLabel.Click += creatorLabel_Click;
            filamentTypLabel.Click += filamentTypLabel_Click;
            amountBox.TextChanged += amountBox_TextChanged;
        }
        bool firstLoad = false;
        private void creatorLabel_Click(object sender, EventArgs e)
        {

            creatorLabel.Text = getDialogResult(creatorLabel.Text);
            saveState();
            adjustTypPosition();
        }
        private void filamentTypLabel_Click(object sender, EventArgs e)
        {
            filamentTypLabel.Text = getDialogResult(filamentTypLabel.Text).ToUpper();
            saveState();
        }
        private string getDialogResult(string old)
        {
            tempHolder.value = string.Empty;
            dialogForms.enterDialog dialog = new(old);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return tempHolder.value;
            }
            return old;
        }
        private void saveState()
        {
            Name = creatorLabel.Text.ToLower() + filamentTypLabel.Text.ToLower();
            string pathToSave = Directory.GetCurrentDirectory() + "\\config\\filament" + id + ".txt";
            if (!File.Exists(pathToSave))
            {
                File.Create(pathToSave).Close();
            }

            File.WriteAllLines(pathToSave, new string[6] {
                string.IsNullOrEmpty(creatorLabel.Text) ? " " : creatorLabel.Text,
                string.IsNullOrEmpty(filamentTypLabel.Text) ? " " : filamentTypLabel.Text,
                string.IsNullOrEmpty(amountBox.Text) ? " " : amountBox.Text,
                filamentPreview.BackColor.R.ToString(),
                filamentPreview.BackColor.G.ToString(),
                filamentPreview.BackColor.B.ToString()
            });
        }
        private void loadState()
        {
            string pathToSave = Directory.GetCurrentDirectory() + "\\config\\filament" + id + ".txt";
            string[] values = File.ReadAllLines(pathToSave);

            if (values.Length >= 6)
            {
                creatorLabel.Text = values[0];
                filamentTypLabel.Text = values[1];
                amountBox.Text = values[2];

                int red, green, blue;
                if (int.TryParse(values[3], out red) && int.TryParse(values[4], out green) && int.TryParse(values[5], out blue))
                {
                    Color c = Color.FromArgb(red, green, blue);
                    filamentPreview.BackColor = c;
                }
            }
        }
        private void adjustTypPosition()
        {
            filamentTypLabel.Location = new Point(creatorLabel.Location.X + creatorLabel.Width + 5, filamentTypLabel.Location.Y);
        }
        private void amountBox_TextChanged(object sender, EventArgs e)
        {
            saveState();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            mainForm.instance.delete(this);
            File.Delete(Directory.GetCurrentDirectory() + "\\config\\filament" + id + ".txt");
        }

        private void filamentPreview_Click(object sender, EventArgs e)
        {
            colorDialog.Color = filamentPreview.BackColor;
            colorDialog.ShowDialog();
            filamentPreview.BackColor = colorDialog.Color;
            saveState();
        }
    }
}
