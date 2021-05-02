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

namespace To_Do_App
{
    public partial class frmToDo : Form
    {
        public frmToDo()
        {
            InitializeComponent();
            populateListBox();
        }
        private void populateListBox() {
            ReadTextHandler newRead = new ReadTextHandler();
            newRead.readFromFile();
            lsttoDoItems.Items.Clear();
            lsttoDoItems.Items.Add(listHandler.newItem);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName;
            string taskDesc;
            string priority;

            taskName = txbName.Text;
            taskDesc = txbDescription.Text;
            priority = cmbxPrio.SelectedItem.ToString();
            textHandler newWorker = new textHandler(taskName,taskDesc,priority);
            newWorker.writeToFile();
            populateListBox();

        }


        private void frmToDo_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
