using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExample_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBDataSet.Game". При необходимости она может быть перемещена или удалена.
            this.gameTableAdapter.Fill(this.localDBDataSet.Game);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game ();
            game.player1 = textBox1.Text;
            game.player2 = textBox2.Text;
            game.ball = textBox3.Text;

            localDBEntities _db = new localDBEntities();
            _db.Game.Add(game);
            _db.SaveChanges();

            List<Game> gamelist = new List<Game>();

            gamelist = _db.Game.ToList();
            
            dataGridView1.DataSource = gamelist;    
        }
    }
}
