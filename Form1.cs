using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace mebeluveikals
{
    public partial class Form1 : Form
    {
        private FurnitureManager furnitureManager;

        public Form1()
        {
            InitializeComponent();

            furnitureManager = new FurnitureManager("Data Source=furniture.db");

            var furniture = furnitureManager.ReadFurniture();
            var furnitureNames = new List<string>();

            foreach (var f in furniture)
            {
                furnitureNames.Add(f.Name);
            }

            selectProductComboBox.DataSource = furnitureNames;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var furniture = furnitureManager.ReadFurnitureByName(selectProductComboBox.Text);

            nameTextBox.Text = furniture.Name;
            descTextBox.Text = furniture.Description;
            priceTextBox.Text = furniture.Price.ToString();
            hTextBox.Text = furniture.Height.ToString();
            wTextBox.Text = furniture.Width.ToString();
            lTextBox.Text = furniture.Length.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts nosaukums.");
                }
                else if (string.IsNullOrEmpty(descTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts apraksts.");
                }
                else if (string.IsNullOrEmpty(priceTextBox.Text))
                {
                    MessageBox.Show("Nav norādīta cena.");
                }
                else if (string.IsNullOrEmpty(hTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts augstums.");
                }
                else if (string.IsNullOrEmpty(wTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts platums.");
                }
                else if (string.IsNullOrEmpty(lTextBox.Text))
                {
                    MessageBox.Show("Nav norādīts garums.");
                }


                furnitureManager.AddFurniture(nameTextBox.Text, descTextBox.Text,
                    Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(hTextBox.Text),
                    Convert.ToInt32(wTextBox.Text), Convert.ToInt32(lTextBox.Text));

                List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
                furnitureList.Add(nameTextBox.Text);

                selectProductComboBox.DataSource = null;
                selectProductComboBox.DataSource = furnitureList;

                MessageBox.Show("Ieraksts tika pievienots datubāzei");
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Notikusi SQL kļūda.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notikusi kļūda.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            furnitureManager.DeleteFurnitureByName(selectProductComboBox.Text);

            List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
            furnitureList.Remove(selectProductComboBox.Text);

            selectProductComboBox.DataSource = null;
            selectProductComboBox.DataSource = furnitureList;

            MessageBox.Show("Mēbele tika izdzēsta no datubāzes.");
        }
    }using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace mebeluveikals
    {
        public partial class Form1 : Form
        {
            private FurnitureManager furnitureManager;

            public Form1()
            {
                InitializeComponent();

                furnitureManager = new FurnitureManager("Data Source=furniture.db");

                var furniture = furnitureManager.ReadFurniture();
                var furnitureNames = new List<string>();

                foreach (var f in furniture)
                {
                    furnitureNames.Add(f.Name);
                }

                selectProductComboBox.DataSource = furnitureNames;
            }

            private void selectBtn_Click(object sender, EventArgs e)
            {
                var furniture = furnitureManager.ReadFurnitureByName(selectProductComboBox.Text);

                nameTextBox.Text = furniture.Name;
                descTextBox.Text = furniture.Description;
                priceTextBox.Text = furniture.Price.ToString();
                hTextBox.Text = furniture.Height.ToString();
                wTextBox.Text = furniture.Width.ToString();
                lTextBox.Text = furniture.Length.ToString();
            }

            private void addButton_Click(object sender, EventArgs e)
            {
                try
                {
                    if (string.IsNullOrEmpty(nameTextBox.Text))
                    {
                        MessageBox.Show("Nav norādīts nosaukums.");
                    }
                    else if (string.IsNullOrEmpty(descTextBox.Text))
                    {
                        MessageBox.Show("Nav norādīts apraksts.");
                    }
                    else if (string.IsNullOrEmpty(priceTextBox.Text))
                    {
                        MessageBox.Show("Nav norādīta cena.");
                    }
                    else if (string.IsNullOrEmpty(hTextBox.Text))
                    {
                        MessageBox.Show("Nav norādīts augstums.");
                    }
                    else if (string.IsNullOrEmpty(wTextBox.Text))
                    {
                        MessageBox.Show("Nav norādīts platums.");
                    }
                    else if (string.IsNullOrEmpty(lTextBox.Text))
                    {
                        MessageBox.Show("Nav norādīts garums.");
                    }

                    furnitureManager.AddFurniture(nameTextBox.Text, descTextBox.Text,
                        Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(hTextBox.Text),
                        Convert.ToInt32(wTextBox.Text), Convert.ToInt32(lTextBox.Text));

                    List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
                    furnitureList.Add(nameTextBox.Text);

                    selectProductComboBox.DataSource = null;
                    selectProductComboBox.DataSource = furnitureList;

                    MessageBox.Show("Ieraksts tika pievienots datubāzei");
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show("Notikusi SQL kļūda.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Notikusi kļūda.");
                }
            }

            private void deleteBtn_Click(object sender, EventArgs e)
            {
                furnitureManager.DeleteFurnitureByName(selectProductComboBox.Text);

                List<string> furnitureList = (List<string>)selectProductComboBox.DataSource;
                furnitureList.Remove(selectProductComboBox.Text);

                selectProductComboBox.DataSource = null;
                selectProductComboBox.DataSource = furnitureList;

                MessageBox.Show("Mēbele tika izdzēsta no datubāzes.");
            }

            private void exportCsvButton_Click(object sender, EventArgs e)
            {
                var furniture = furnitureManager.ReadFurniture();
                var csvContent = new StringBuilder();

                csvContent.AppendLine("Name,Description,Price,Height,Width,Length");

                foreach (var item in furniture)
                {
                    csvContent.AppendLine($"{item.Name},{item.Description},{item.Price},{item.Height},{item.Width},{item.Length}");
                }

                File.WriteAllText("furniture.csv", csvContent.ToString());
                MessageBox.Show("Dati tika eksportēti uz furniture.csv");
            }

            private void importCsvButton_Click(object sender, EventArgs e)
            {
                try
                {
                    if (!File.Exists("furniture.csv"))
                    {
                        MessageBox.Show("CSV fails furniture.csv netika atrasts.");
                        return;
                    }

                    var lines = File.ReadAllLines("furniture.csv");
                    foreach (var line in lines.Skip(1))
                    {
                        var columns = line.Split(',');

                        var name = columns[0];
                        var description = columns[1];
                        var price = Convert.ToDouble(columns[2]);
                        var height = Convert.ToInt32(columns[3]);
                        var width = Convert.ToInt32(columns[4]);
                        var length = Convert.ToInt32(columns[5]);

                        var existingFurniture = furnitureManager.ReadFurnitureByName(name);
                        if (existingFurniture != null)
                        {
                            furnitureManager.UpdateFurniture(name, description, price, height, width, length);
                        }
                        else
                        {
                            furnitureManager.AddFurniture(name, description, price, height, width, length);
                        }
                    }

                    MessageBox.Show("Dati tika importēti no furniture.csv");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Notikusi kļūda: {ex.Message}");
                }
            }
        }
    }
}
