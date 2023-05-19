using FilamentManager.userControls;
using System.Collections.Immutable;

namespace FilamentManager
{
    public partial class mainForm : Form
    {
        public static mainForm instance;
        List<filamentItem> items = new List<filamentItem>();
        public mainForm()
        {
            InitializeComponent();

            //Add a placeholder item
            CreateItem();
            loadFilaments();

            instance = this;
        }
        public void delete(filamentItem item)
        {
            items.Remove(item);
            display.Controls.Remove(item);
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            CreateItem(items.Count + 1);
        }
        private void searchBTN_Click(object sender, EventArgs e)
        {
            search();
        }
        private void mainForm_ResizeEnd(object sender, EventArgs e)
        {
            foreach (filamentItem item in items)
            {
                item.Width = display.Width - 5;
            }
        }

        private void CreateItem()
        {
            filamentItem filament = new filamentItem();
            filament.Width = display.Width - 5;
            display.Controls.Add(filament);
            items.Add(filament);
        }

        private void CreateItem(int id)
        {
            filamentItem filament = new filamentItem(id);
            filament.Width = display.Width - 5;
            display.Controls.Add(filament);
            items.Add(filament);
        }

        private void loadFilaments()
        {
            string path = Directory.GetCurrentDirectory() + "\\config\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                return;
            }

            foreach (string fileDir in Directory.GetFiles(path))
            {
                FileInfo fI = new FileInfo(fileDir);
                if (fI.Name.Contains('.'))
                {
                    //Get file name;
                    string name = fI.Name.Remove(fI.Name.IndexOf("."));
                    if (!name.StartsWith("filament"))
                    {
                        continue;
                    }
                    int id = int.Parse(name.Substring(8));
                    CreateItem(id);
                }
            }
        }
        private void search()
        {
            display.Controls.Clear();
            foreach (filamentItem item in items)
            {
                if (item.Name.ToLower().Contains(searchBox.Text.ToLower()))
                {
                    display.Controls.Add(item);
                }
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
            }
        }
    }
}