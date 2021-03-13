using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wizardry.Structures;

namespace Wizardry
{
    public partial class MainForm : Form
    {
        public List<Player> AllPlayers = new List<Player>();
        public Configuration ActiveConfiguration = new Configuration();
        public List<Garrison> AllGarrison = new List<Garrison>();

        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadConfiguration()
        {
            ActiveConfiguration = new Configuration();
            ActiveConfiguration.TargetPowerLevel = int.Parse(config_targetPower.Text);
            ActiveConfiguration.MaxMarchPower = int.Parse(config_maxMarchPower.Text);
            ActiveConfiguration.MaxMarches = int.Parse(config_maxMarches.Text);
        }

        public void RefreshDataGrid()
        {
            for (int i = 0; i < data_gv.Rows.Count; i++)
            {
                
                if (AllPlayers[i].ArmyPower > ActiveConfiguration.TargetPowerLevel)
                    data_gv.Rows[i].Cells[4].Style.BackColor = Color.Green;
                else if (AllPlayers[i].ArmyPower < ActiveConfiguration.TargetPowerLevel)
                    data_gv.Rows[i].Cells[4].Style.BackColor = Color.Red;
                else
                    data_gv.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
            }
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            btnCalculate.Visible = false;
            LoadConfiguration();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;

            DataTable dtexcel = new DataTable();
            bool hasHeaders = true;
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (System.IO.Path.GetExtension(filePath).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                conn.Open();
                DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                string query = "SELECT * FROM [Garrisons$]";
                OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                dtexcel.Locale = CultureInfo.CurrentCulture;
                daexcel.Fill(dtexcel);
                conn.Close();

                AllPlayers = new List<Player>();
                foreach (DataRow row in dtexcel.Rows)
                {
                    string name = row[1] == DBNull.Value || row[1] == null || (string)row[1] == "" ? null : (string)row[1];

                    if (string.IsNullOrEmpty(name))
                        break;

                    Player p = new Player();
                    p.Id = Convert.ToInt32(row[0]);
                    p.Name = name;
                    p.Is_Active = row[2].ToString() == "1";
                    p.Is_LessActive = row[3].ToString() == "1";
                    p.ArmyPower = Convert.ToInt32(row[4]);
                    AllPlayers.Add(p);
                }

                data_gv.DataSource = AllPlayers;
                data_gv.Refresh();

                RefreshDataGrid();
                btnCalculate.Visible = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            LoadConfiguration();
            results_results.Text = "";

            List<Player> CalculatedPlayers = new List<Player>();
            foreach (Player p in AllPlayers)
                CalculatedPlayers.Add(new Player(p));

            AllGarrison = new List<Garrison>();

            while(CalculatedPlayers.Count(x => x.ArmyPower < ActiveConfiguration.TargetPowerLevel) > 0)
            {
                int playerIndex = CalculatedPlayers.IndexOf(CalculatedPlayers.Where(x => x.ArmyPower < ActiveConfiguration.TargetPowerLevel).OrderByDescending(x => x.ArmyPower).First());
                int delta = ActiveConfiguration.TargetPowerLevel - CalculatedPlayers[playerIndex].ArmyPower;
                if (CalculatedPlayers.Count(x => x.Is_Active && x.ArmyPower - delta > ActiveConfiguration.TargetPowerLevel) == 0)
                    break;

                int fromPlayerIndex = CalculatedPlayers.IndexOf(CalculatedPlayers.Where(x => x.Is_Active && x.ArmyPower - delta > ActiveConfiguration.TargetPowerLevel && AllGarrison.Count(z => z.From_Id == x.Id) < ActiveConfiguration.MaxMarches).OrderBy(x => x.ArmyPower).First());

                Garrison g = new Garrison();
                g.From_Id = CalculatedPlayers[fromPlayerIndex].Id;
                g.From_Name = CalculatedPlayers[fromPlayerIndex].Name;
                g.To_Id = CalculatedPlayers[playerIndex].Id;
                g.To_Name = CalculatedPlayers[playerIndex].Name;
                g.ArmyPower = delta;

                CalculatedPlayers[fromPlayerIndex].ArmyPower -= delta;
                CalculatedPlayers[playerIndex].ArmyPower += delta;
                AllGarrison.Add(g);
            }

            foreach (Garrison g in AllGarrison)
            {
                string template = $"From {g.From_Name} to {g.To_Name} -> {g.ArmyPower}\r\n";
                results_results.Text += template;
            }
        }
    }
}
