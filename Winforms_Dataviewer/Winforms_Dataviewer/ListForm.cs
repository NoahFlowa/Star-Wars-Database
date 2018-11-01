using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace Winforms_Dataviewer
{
    public partial class SWdb : Form
    {

        List<StarWarsPeople> _starWarsPeoples;
        List<StarWarsPlanets> _starWarsPlanets;
        List<StarWarsStarfighters> _starWarsStarfighters;


        

        public async Task DisplayPeopleFile()
        {
            //Task<StarWarsPeople> starWarsPeople = GetJsonFiles.GetPeopleFile();

            StarWarsPeople starWarsPeople = await GetJsonFiles.GetPeopleFile();

            List<StarWarsPeople> starWarsPeoples = new List<StarWarsPeople>();
            starWarsPeoples.Add(starWarsPeople);

            dataGridView_swDB.DataSource = new BindingList<StarWarsPeople>(starWarsPeoples);

            var bindingList = new BindingList<StarWarsPeople>(starWarsPeoples);
            var source = new BindingSource(bindingList, null);

        }

        public async Task DisplayPlanetFile()
        {
            //Task<StarWarsPeople> starWarsPeople = GetJsonFiles.GetPeopleFile();

            StarWarsPlanets starWarsPlanets = await GetJsonFiles.GetPlanetFile();

            List<StarWarsPeople> starWarsPlanets = new List<StarWarsPeople>();
            starWarsPlanets.Add(starWarsPlanets);

            dataGridView_swDB.DataSource = new BindingList<StarWarsPeople>(starWarsPlanets);

            var bindingList = new BindingList<StarWarsPeople>(starWarsPlanets);
            var source = new BindingSource(bindingList, null);

        }

        public SWdb()
        {
            InitializeComponent();
        }

        private async Task dataGridView_swDB_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                await DisplayPeopleFile();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on any object in the list to view more about the selected object.");
        }

        private void dataGridView_swDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moreInfo_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_swDB.SelectedRows.Count == 1)
            {
                if (dataGridView_swDB.GetType() == typeof(StarWarsPeople))
                {
                    StarWarsPeople swPeople = new StarWarsPeople();
                    swPeople = (StarWarsPeople)dataGridView_swDB.CurrentRow.DataBoundItem;

                    DetailFormPlanets detailFormPeople = new DetailFormPlanets(swPeople);
                    detailFormPeople.ShowDialog();
                }
                else if (dataGridView_swDB.GetType() == typeof(StarWarsPlanets))
                {
                    StarWarsPlanets swPlanets = new StarWarsPlanets();
                    swPlanets = (StarWarsPlanets)dataGridView_swDB.CurrentRow.DataBoundItem;

                    DetailFormPlanets detailFormPlanets = new DetailFormPlanets(swPlanets);
                    detailFormPlanets.ShowDialog();
                }
                
            }
        }
    }
}
