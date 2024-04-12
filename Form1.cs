using System.Diagnostics;
using CsvHelper;
using System.Globalization;
using System.Runtime.CompilerServices;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Linq;

namespace listboxtest
{
    public partial class Form1 : Form
    {
        List<Meal> meals = new List<Meal>();

        public Form1()

        {
            InitializeComponent();
            comboBox1.Text = "Showing all options";
            using (StreamReader inputfile =
                   new StreamReader(@"C:\Users\jeanc\Downloads\listboxtest\listboxtest\meal.csv"))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";",
                    HasHeaderRecord = true,
                };

                using (var csvreader = new CsvReader(inputfile, config))
                {
                    meals = csvreader.GetRecords<Meal>().ToList();
                    foreach (var record in meals)
                    {
                        while (!comboBox1.Items.Contains(record.Type))
                        {
                            comboBox1.Items.Add(record.Type);

                        }

                        listBox1.Items.Add(record.Name);



                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            var newitem = listBox1.SelectedItem;

            for (int i = 0; i < meals.Count; i++)
            {
                if (newitem.Equals(meals[i].Name))
                {
                    txtDescription.Text = meals[i].Description;
                    lblName.Text = meals[i].Name;
                }
            }

        }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

                listBox1.Items.Clear();
                var newitem = comboBox1.SelectedItem;

                for (int i = 0; i < meals.Count; i++)
                {
                    if (newitem.Equals(meals[i].Type))
                    {
                        //this is a shortcut using the "select" method from the "list" class
                        //it's using linq language to search on the list for all the items
                        //that contain type =="" 
                        //meals.Select(a => a.Type == "");
                        listBox1.Items.Add(meals[i].Name);

                    }
                }

            }
        
    

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

