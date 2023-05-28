using System;
using System.Windows.Forms;
using TetrisGame.Entities;

namespace TetrisGame.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            Shapes.Load();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            showForm(new GameForm());
            this.Width = 700;
            this.Height = 700;
        }

        private void showForm(Form form)
        {
            this.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
            this.Controls[0].Focus();
        }

    }
}
