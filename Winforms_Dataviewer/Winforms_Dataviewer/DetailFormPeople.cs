using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Dataviewer
{
    public partial class DetailFormPlanets : Form
    {
        StarWarsPeople _swPeople = new StarWarsPeople();

        public DetailFormPlanets(StarWarsPeople swPeople)
        {
            InitializeComponent();
            _swPeople = swPeople;
        }

        private void DetailFormPeople_Load(object sender, EventArgs e)
        {
            name_lbl_people.Text = _swPeople.name;
            height_lbl_people.Text = _swPeople.height;
            mass_lbl_people.Text = _swPeople.mass;
            hair_lbl_people.Text = _swPeople.hair_color;
            skin_lbl_people.Text = _swPeople.skin_color;
            eye_lbl_people.Text = _swPeople.eye_color;
            bday_lbl_people.Text = _swPeople.birth_year;
            gender_lbl_people.Text = _swPeople.gender;
            home_lbl_people.Text = _swPeople.homeworld;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void name_lbl_people_Click(object sender, EventArgs e)
        {

        }
    }
}
