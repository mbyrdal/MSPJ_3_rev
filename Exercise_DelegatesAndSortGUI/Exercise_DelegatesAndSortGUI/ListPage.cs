using DelegatesSortGui.Data;
using Exercise_DelegatesAndSortGUI.Model;

namespace Exercise_DelegatesAndSortGUI
{
    public partial class ListPage : Form
    {
        public ListPage()
        {
            InitializeComponent();
        }
        //vi antager der står noget i tesktboksen
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GamerData gamerData = new GamerData();

            List<string?> gamerNames = new List<string?>();
            List<Gamer> gamers = gamerData.FetchGamers();

            var sortedByNameGamers = gamers.OrderBy(Gamer => Gamer.NickName).ToList();


            foreach(Gamer g in sortedByNameGamers)
            {       
                textBox1.Text += g.ToString() + Environment.NewLine;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GamerData gamerData = new GamerData();
            foreach (Gamer myGamer in gamerData.FetchGamers())
            {
                textBox1.Text += myGamer.ToString() + Environment.NewLine;
            }
        }
    }
}