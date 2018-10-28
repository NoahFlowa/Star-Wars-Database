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

            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Homeworld");

            dataGridView_swDB.DataSource = dt;

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
            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Homeworld");

            dataGridView_swDB.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_swDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
