using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_AfekWinForms.Формы
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Position product = new Position();
            product.ShowDialog(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Employee_Form client = new Employee_Form();
            client.ShowDialog(this);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ShowDialog(this);
        }

        private void TbClients_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ShowDialog(this);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TypeProduct tp = new TypeProduct();
            tp.ShowDialog(this);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.ShowDialog(this);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Purchase purc = new Purchase();
            purc.ShowDialog(this);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Work_Client work = new Work_Client();
            work.ShowDialog(this);
        }
    }
}
