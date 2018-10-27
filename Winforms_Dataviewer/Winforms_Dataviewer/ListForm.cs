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
    public partial class ListForm : Form
    {

        List<StarWarsPeople> _starWarsPeoples;
        List<StarWarsPlanets> _starWarsPlanets;
        List<StarWarsStarfighters> _starWarsStarfighters;

        

        public static async Task DisplayPeopleFile()
        {
            //Task<StarWarsPeople> starWarsPeople = GetJsonFiles.GetPeopleFile();

            StarWarsPeople starWarsPeople = await GetJsonFiles.GetPeopleFile();

            var bindingList = new BindingList;

        }

        public ListForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
