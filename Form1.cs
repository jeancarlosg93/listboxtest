using System.Diagnostics;
using CsvHelper;
using System.Globalization;
using System.Runtime.CompilerServices;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Linq;
using System;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;

namespace listboxtest
{
    public partial class Form1 : Form
    {
        List<Meal> meals = new List<Meal>();

        public Form1()

        {

            InitializeComponent();
            generatecontent();
            comboBox1.Text = "Showing all options";
            
        }

        private void generatecontent()
        {
            using (StreamReader inputfile = new StreamReader(@"meal.csv"))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";",
                    HasHeaderRecord = true,
                    Encoding = Encoding.UTF8,
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

                        listSelection.Items.Add(record.Name);



                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = listSelection.SelectedIndex;
            if (index != -1)
            {

                var newitem = listSelection.SelectedItem;
                listIngredient.Items.Clear();
                listNutritionInfo.Items.Clear();



                for (int i = 0; i < meals.Count; i++)
                {
                    if (newitem.Equals(meals[i].Name))
                    {
                        lblName.Text = meals[i].Name;
                        txtDescription.Text = meals[i].Description;
                        listIngredient.Items.Add(meals[i].Ingredient1);
                        listIngredient.Items.Add(meals[i].Ingredient2);
                        listIngredient.Items.Add(meals[i].Ingredient3);
                        listIngredient.Items.Add(meals[i].Ingredient4);
                        listIngredient.Items.Add(meals[i].Ingredient5);
                        listIngredient.Items.Add(meals[i].Ingredient6);
                        listIngredient.Items.Add(meals[i].Ingredient7);
                        listIngredient.Items.Add(meals[i].Ingredient8);
                        listIngredient.Items.Add(meals[i].Ingredient9);

                        listNutritionInfo.Items.Add("Calories:\t" + meals[i].Calories);
                        listNutritionInfo.Items.Add("Fat:\t" + meals[i].Fat);
                        listNutritionInfo.Items.Add("Carbs:\t" + meals[i].Carbs);
                        listNutritionInfo.Items.Add("Protein:\t" + meals[i].Protein);


                        string path = meals[i].Image;

                        pictureBox1.Image = Image.FromFile(path);

                    }
                }

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listSelection.Items.Clear();
            var newitem = comboBox1.SelectedItem;

            for (int i = 0; i < meals.Count; i++)
            {
                if (newitem.Equals(meals[i].Type))
                {
                    //this is a shortcut using the "select" method from the "list" class
                    //it's using linq language to search on the list for all the items
                    //that contain type =="" 
                    //meals.Select(a => a.Type == "");
                    listSelection.Items.Add(meals[i].Name);
                }
            }


        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnclearfilter_Click(object sender, EventArgs e)
        {
            listSelection.Items.Clear();
            comboBox1.Text = "Showing all options";
            generatecontent();
        }
    }
}

