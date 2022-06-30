using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public int index = 0;
        Point moveStart;
        public static List<Label> Ls = new List<Label>();
        public struct United
        {
            public Label point1, point2; public int count;
            public United(Label p1, Label p2, int c)
            {
                this.point1 = p1;
                this.point2 = p2;
                this.count = c;
            }
        }
        public static List<United> U = new List<United>();
        Graphics g;
        public bool autb = false;
        public int indexM, x1M = 0, x2M = 0, y1M = 0, y2M = 0;
        public string usName; public PictureBox usAvatar;

        public Main()
        {
            InitializeComponent();
            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;
        }

        private void create_Click(object sender, EventArgs e)
        {
            L = new Label();
            L.MouseMove += L_MouseMove;
            L.Click += L_Click;
            if (index == 0)
            {
                L.Location = new Point(500, 20);
                L.Text = "0";
                L.Size = new Size(30, 30);
                L.BorderStyle = BorderStyle.None;
                L.BackColor = Color.BlueViolet;
                L.TextAlign = ContentAlignment.MiddleCenter;
                LabelElipse(L);
                index++;
            }
            else
            {
                L.Location = new Point(Ls[index - 1].Location.X, Ls[index - 1].Location.Y + 50);
                L.Text = $"{index}";
                L.Size = new Size(30, 30);
                L.BackColor = Color.BlueViolet;
                L.TextAlign = ContentAlignment.MiddleCenter;
                L.BorderStyle = BorderStyle.None;
                LabelElipse(L);
                index++;
            }
            Ls.Add(L);
            this.Controls.Add(L);
        }

        void LabelElipse(Label t)
        {
            System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();
            gPath.AddEllipse(0, 0, 30, 30);
            t.Region = new Region(gPath);
            gPath.Dispose();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
        }
        private void L_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                foreach (var u in U)
                {
                    if (Ls[indexM].Text == u.point1.Text || Ls[indexM].Text == u.point2.Text)
                    {
                        Pen p = new Pen(this.BackColor);
                        g.DrawLine(p, u.point1.Location.X + 15, u.point1.Location.Y + 15, u.point2.Location.X + 15, u.point2.Location.Y + 15);
                    }
                }
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                Ls[indexM].Location = new Point(Ls[indexM].Location.X + deltaPos.X, Ls[indexM].Location.Y + deltaPos.Y);
                foreach (var u in U)
                {
                    if (Ls[indexM].Text == u.point1.Text || Ls[indexM].Text == u.point2.Text)
                    {
                        g.DrawLine(Pens.Black, u.point1.Location.X + 15, u.point1.Location.Y + 15, u.point2.Location.X + 15, u.point2.Location.Y + 15);
                    }
                    else g.DrawLine(Pens.Black, u.point1.Location.X + 15, u.point1.Location.Y + 15, u.point2.Location.X + 15, u.point2.Location.Y + 15);
                }
                
            }
        }
        private void L_Click(object sender, EventArgs e)
        {
            foreach (var a in Ls)
            {
                if ((a.Location.X - 30 < Cursor.Position.X - this.Location.X - 8 && Cursor.Position.X - this.Location.X - 8 < a.Location.X + 30) && (a.Location.Y + 30 > Cursor.Position.Y - this.Location.Y - 30 && a.Location.Y - 30 < Cursor.Position.Y - this.Location.Y - 30))
                {
                    indexM = Convert.ToInt32(a.Text);
                }
            }
            foreach (var u in U)
            {
                if (Ls[indexM].Location == u.point1.Location || Ls[indexM].Location == u.point2.Location)
                {
                    x1M = u.point1.Location.X; y1M = u.point1.Location.Y; x2M = u.point2.Location.X; y2M = u.point2.Location.Y;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (autb == false)
            {
                userName.Visible = false;
            }
            else
            {
                userName.Visible = true;
                userName.Text = usName;
                autorisation.Visible = false;
            }
            connectT.Visible = false;
            MTT.Visible = false;

        }
        private void MTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    string[] s = MTT.Text.Split(' ');
                    Graph g = new Graph(Ls.Count);
                    if (Algoritm.Algo(g.graph(), int.Parse(s[0]), int.Parse(s[1])) == int.MaxValue)
                    {
                        MTT.Text = ""; MessageBox.Show("Достижение конечноц вершины невозможно");
                    }
                    else MTT.Text = Convert.ToString(Algoritm.Algo(g.graph(), int.Parse(s[0]), int.Parse(s[1])));
                }
                else if (Char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(MTT.Text)))
                {
                    return;
                }
                e.Handled = true;
            }
            catch
            {
                MessageBox.Show("Введен неверный индекс вершины");
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            foreach (var a in Ls)
            {
                a.BackColor = colorDialog1.Color;
            }
            L.BackColor = colorDialog1.Color;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            connectT.Visible = false;
            MTT.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            connectT.Visible = true;
            MTT.Visible = false;
        }
        private void File1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            string[] lines = File.ReadAllLines(@path);
            int i = 0;
            foreach (string s in lines)
            {
                string[] str = s.Split(' ');
                if (i < int.Parse(str[0]) || i < int.Parse(str[0])) i = Max(int.Parse(str[0]), int.Parse(str[1]));
            }
            int Max(int a, int b)
            {
                if (a > b) return a;
                else return b;
            }
            for (int j = 0; j <= i; j++)
            {
                L = new Label();
                L.MouseMove += L_MouseMove;
                L.Click += L_Click;
                if (index == 0)
                {
                    L.Location = new Point(500, 20);
                    L.Text = "0";
                    L.Size = new Size(30, 30);
                    L.BorderStyle = BorderStyle.None;
                    L.BackColor = Color.BlueViolet;
                    L.TextAlign = ContentAlignment.MiddleCenter;
                    LabelElipse(L);
                    index++;
                }
                else
                {
                    L.Location = new Point(Ls[index - 1].Location.X, Ls[index - 1].Location.Y + 50);
                    L.Text = $"{index}";
                    L.Size = new Size(30, 30);
                    L.BackColor = Color.BlueViolet;
                    L.TextAlign = ContentAlignment.MiddleCenter;
                    L.BorderStyle = BorderStyle.None;
                    LabelElipse(L);
                    index++;
                }
                Ls.Add(L);
                this.Controls.Add(L);
            }
            foreach (string s in lines)
            {
                United u = new United();
                string[] st = s.Split(' ');
                u.point1 = Ls[Convert.ToInt32(st[0])];
                u.point2 = Ls[Convert.ToInt32(st[1])];
                u.count = Convert.ToInt32(st[2]);
                U.Add(u);
                int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
                foreach (var a in Ls)
                {
                    if (st[0] == a.Text)
                    {
                        x1 = a.Location.X; y1 = a.Location.Y;
                        continue;
                    }
                    else if (st[1] == a.Text)
                    {
                        x2 = a.Location.X; y2 = a.Location.Y;
                        continue;
                    }
                }
                g.DrawLine(Pens.Black, x1 + 15, y1 + 15, x2 + 15, y2 + 15);
                connectT.Text = "";
                VertexList.Text += u.point1.Text + "->" + u.point2.Text + " : " + Convert.ToString(u.count) + "\n";
            }
        }

        private void Main_DoubleClick(object sender, EventArgs e)
        {
            foreach (var a in Ls)
            {
                this.Controls.Remove(a);
            }
            foreach (var u in U)
            {
                g.DrawLine(Pens.White, u.point1.Location.X + 15, u.point1.Location.Y + 15, u.point2.Location.X + 15, u.point2.Location.Y + 15);
            }
            Ls.Clear(); U.Clear(); this.BackColor = Color.White; index = 0; VertexList.Text = "";
        }

        private void reference_Click(object sender, EventArgs e)
        {
            Reference r = new Reference();
            r.Show();
        }

        private void connectT_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    United u = new United();
                    string[] s = connectT.Text.Split(' ');
                    u.point1 = Ls[Convert.ToInt32(s[0])];
                    u.point2 = Ls[Convert.ToInt32(s[1])];
                    u.count = Convert.ToInt32(s[2]);
                    U.Add(u);
                    int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
                    foreach (var a in Ls)
                    {
                        if (s[0] == a.Text)
                        {
                            x1 = a.Location.X; y1 = a.Location.Y;
                            continue;
                        }
                        else if (s[1] == a.Text)
                        {
                            x2 = a.Location.X; y2 = a.Location.Y;
                            continue;
                        }
                    }
                    g.DrawLine(Pens.Black, x1 + 15, y1 + 15, x2 + 15, y2 + 15);
                    connectT.Text = "";
                    VertexList.Text += u.point1.Text + "->" + u.point2.Text + " : " + Convert.ToString(u.count) + "\n";
                }
            }
            catch
            {
                MessageBox.Show("Введен неверный индекс вершины");
            }
        }

        private void connectT_MouseClick(object sender, MouseEventArgs e)
        {
            connectT.Text = "";
            connectT.TextAlign = HorizontalAlignment.Left;
        }

        private void autorisation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Autorisation a = new Autorisation(this);
            a.Show(); this.Hide();
        }
        private void Autorisation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }
    }
}