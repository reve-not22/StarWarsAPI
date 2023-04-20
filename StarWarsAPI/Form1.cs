using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.Reflection;

namespace StarWarsAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            list_Planet.Items.Clear();
            Planet t = await JSONHelper.GetPlanet(txt_ID_Planet.Text);
            list_Planet.Items.Add("Name: " + t.name);
            list_Planet.Items.Add("Rotation Period: " + t.rotation_period);
            list_Planet.Items.Add("Orbital Period: " + t.orbital_period);
            list_Planet.Items.Add("Diameter: " + t.diameter);
            list_Planet.Items.Add("Gravity: " + t.gravity);
            list_Planet.Items.Add("Terrain: " + t.terrain);
            list_Planet.Items.Add("Surface Water: " + t.surface_water);
            list_Planet.Items.Add("Population: " + t.population);
        }

        private async void btn_AllSpecies_Click(object sender, EventArgs e)
        {
            List_AllSpecies.Items.Clear();
            AllSpecies a = await JSONHelper.GetAllSpecies();
            foreach (var item in a.results)
            {
                Type type = typeof(Species);
                PropertyInfo[] properties = type.GetProperties();
                foreach (var propertyinfo in properties) 
                { 
                    List_AllSpecies.Items.Add(propertyinfo.Name + ": " + propertyinfo.GetValue(item, null));
                }
                List_AllSpecies.Items.Add(" ");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            list_Person.Items.Clear();
            Person p = await JSONHelper.GetPerson(txt_ID_Person.Text);
            list_Person.Items.Add("Name: " + p.name);
            list_Person.Items.Add("Height: " + p.height);
            list_Person.Items.Add("Skin Color: " + p.skin_color);
            list_Person.Items.Add("Hair Color: " + p.hair_color);
            list_Person.Items.Add("Mass: " + p.mass);
            list_Person.Items.Add("Birth Year: " + p.birth_year);
            list_Person.Items.Add("Gender: " + p.gender);
            Planet pl = await JSONHelper.GetPlanetByURL(p.homeworld);
            list_Person.Items.Add("Home Planet: " + pl.name);
            string listToString = "Starships: ";
            if (p.starships.Count <= 0)
            {
                listToString += "None";
            }

            for (int i = 0; i < p.starships.Count; i++) 
            {
                Starship s = await JSONHelper.GetStarship(p.starships[i]);
                if (i < p.starships.Count - 1) 
                {
                    listToString += (s.name + ", ");
                }
                else
                {
                    listToString += (s.name);
                }
            }
            list_Person.Items.Add(listToString);
        }
    }
}
