﻿namespace oop_w15
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutId = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutAddress = new System.Windows.Forms.TextBox();
            this.txtAutName = new System.Windows.Forms.TextBox();
            this.txtAutPhone = new System.Windows.Forms.TextBox();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAutId
            // 
            this.txtAutId.Location = new System.Drawing.Point(149, 50);
            this.txtAutId.Name = "txtAutId";
            this.txtAutId.Size = new System.Drawing.Size(100, 22);
            this.txtAutId.TabIndex = 1;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(24, 276);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(479, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // txtAutAddress
            // 
            this.txtAutAddress.Location = new System.Drawing.Point(149, 143);
            this.txtAutAddress.Name = "txtAutAddress";
            this.txtAutAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAutAddress.TabIndex = 7;
            // 
            // txtAutName
            // 
            this.txtAutName.Location = new System.Drawing.Point(149, 91);
            this.txtAutName.Name = "txtAutName";
            this.txtAutName.Size = new System.Drawing.Size(96, 22);
            this.txtAutName.TabIndex = 8;
            // 
            // txtAutPhone
            // 
            this.txtAutPhone.Location = new System.Drawing.Point(149, 189);
            this.txtAutPhone.Name = "txtAutPhone";
            this.txtAutPhone.Size = new System.Drawing.Size(100, 22);
            this.txtAutPhone.TabIndex = 9;
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(138, 276);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 10;
            this.butEdit.Text = "edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(257, 276);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 11;
            this.butDelete.Text = "delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butDisplay
            // 
            this.butDisplay.Location = new System.Drawing.Point(24, 345);
            this.butDisplay.Name = "butDisplay";
            this.butDisplay.Size = new System.Drawing.Size(75, 23);
            this.butDisplay.TabIndex = 12;
            this.butDisplay.Text = "display";
            this.butDisplay.UseVisualStyleBackColor = true;
            this.butDisplay.Click += new System.EventHandler(this.butDisplay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butDisplay);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.txtAutPhone);
            this.Controls.Add(this.txtAutName);
            this.Controls.Add(this.txtAutAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtAutId);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutId;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutAddress;
        private System.Windows.Forms.TextBox txtAutName;
        private System.Windows.Forms.TextBox txtAutPhone;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butDisplay;
    }
}