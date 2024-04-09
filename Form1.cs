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

        public Form1()

        {
            InitializeComponent();
            using (StreamReader inputfile = new StreamReader(@"C:\Users\jeanc\Downloads\listboxtest\listboxtest\meal.csv"))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";", HasHeaderRecord = true,
                };

            using (var csvreader = new CsvReader(inputfile, config))
                {
                   var records = csvreader.GetRecords<Meal>().ToList();
                   foreach (var record in records)
                   {
                       listBox1.Items.Add(record.Name);

                       while (!comboBox1.Items.Contains(record.Type))
                       {
                        comboBox1.Items.Add(record.Type);
                       }
                   }
                }
            }

            
            
        }
        
       

        void Initializecombobox()
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}

