
namespace To_Do_App
{
    partial class frmToDo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbxPrio = new System.Windows.Forms.ComboBox();
            this.lsttoDoItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(13, 32);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(103, 25);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Task name:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(13, 129);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(125, 25);
            this.lblPriority.TabIndex = 1;
            this.lblPriority.Text = "Priority Level:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 81);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 25);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(223, 24);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(312, 33);
            this.txbName.TabIndex = 3;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(223, 73);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(312, 33);
            this.txbDescription.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbxPrio
            // 
            this.cmbxPrio.FormattingEnabled = true;
            this.cmbxPrio.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbxPrio.Location = new System.Drawing.Point(223, 121);
            this.cmbxPrio.Name = "cmbxPrio";
            this.cmbxPrio.Size = new System.Drawing.Size(312, 33);
            this.cmbxPrio.TabIndex = 7;
            this.cmbxPrio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lsttoDoItems
            // 
            this.lsttoDoItems.FormattingEnabled = true;
            this.lsttoDoItems.ItemHeight = 25;
            this.lsttoDoItems.Location = new System.Drawing.Point(552, 24);
            this.lsttoDoItems.Name = "lsttoDoItems";
            this.lsttoDoItems.Size = new System.Drawing.Size(292, 204);
            this.lsttoDoItems.TabIndex = 8;
            // 
            // frmToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(860, 238);
            this.Controls.Add(this.lsttoDoItems);
            this.Controls.Add(this.cmbxPrio);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblTaskName);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmToDo";
            this.Text = "To Do App";
            this.Load += new System.EventHandler(this.frmToDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbxPrio;
        private System.Windows.Forms.ListBox lsttoDoItems;
    }
}

