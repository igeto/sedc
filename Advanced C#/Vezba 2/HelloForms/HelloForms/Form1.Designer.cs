namespace HelloForms
{
    partial class Form1
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
            this.btnHelloForm = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblForTxtName = new System.Windows.Forms.Label();
            this.lvShowList = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelloForm
            // 
            this.btnHelloForm.Location = new System.Drawing.Point(415, 124);
            this.btnHelloForm.Name = "btnHelloForm";
            this.btnHelloForm.Size = new System.Drawing.Size(75, 23);
            this.btnHelloForm.TabIndex = 0;
            this.btnHelloForm.Text = "Hello Form";
            this.btnHelloForm.UseVisualStyleBackColor = true;
            this.btnHelloForm.Click += new System.EventHandler(this.btnHelloForm_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(419, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblForTxtName
            // 
            this.lblForTxtName.AutoSize = true;
            this.lblForTxtName.Location = new System.Drawing.Point(71, 60);
            this.lblForTxtName.Name = "lblForTxtName";
            this.lblForTxtName.Size = new System.Drawing.Size(66, 13);
            this.lblForTxtName.TabIndex = 2;
            this.lblForTxtName.Text = "Vnesete Ime";
            // 
            // lvShowList
            // 
            this.lvShowList.Location = new System.Drawing.Point(71, 172);
            this.lvShowList.Name = "lvShowList";
            this.lvShowList.Size = new System.Drawing.Size(419, 103);
            this.lvShowList.TabIndex = 3;
            this.lvShowList.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(414, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvShowList);
            this.Controls.Add(this.lblForTxtName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHelloForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelloForm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblForTxtName;
        private System.Windows.Forms.ListView lvShowList;
        private System.Windows.Forms.Button btnAdd;
    }
}

