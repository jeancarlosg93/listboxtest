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
            using (StreamReader inputfile = new StreamReader(@"C:\Users\jeanc\Downloads\listboxtest\listboxtest\meal.csv"))
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
                        listBox1.Items.Add(record.Name);
                    }
                }
            }

            filldescription();

        }

        void filldescription()
        {
            MessageBox.Show(meals[1].ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  lblName.Text = sender.ToString();
         //   var index=listBox1.Items.IndexOf(ItemChangedEventArgs.);
         //  txtDescription.Text= meals[index].Name;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

