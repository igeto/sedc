namespace WinFormWithReflections
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.btnGetMethodName = new System.Windows.Forms.Button();
            this.listOfMethods = new System.Windows.Forms.ListView();
            this.listOfProperties = new System.Windows.Forms.ListView();
            this.listOfConstructors = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(81, 32);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(218, 20);
            this.txtMethodName.TabIndex = 1;
            // 
            // btnGetMethodName
            // 
            this.btnGetMethodName.Location = new System.Drawing.Point(350, 29);
            this.btnGetMethodName.Name = "btnGetMethodName";
            this.btnGetMethodName.Size = new System.Drawing.Size(154, 23);
            this.btnGetMethodName.TabIndex = 2;
            this.btnGetMethodName.Text = "Discover Type Info";
            this.btnGetMethodName.UseVisualStyleBackColor = true;
            this.btnGetMethodName.Click += new System.EventHandler(this.btnGetMethodName_Click);
            // 
            // listOfMethods
            // 
            this.listOfMethods.Location = new System.Drawing.Point(66, 142);
            this.listOfMethods.Name = "listOfMethods";
            this.listOfMethods.Size = new System.Drawing.Size(169, 360);
            this.listOfMethods.TabIndex = 3;
            this.listOfMethods.UseCompatibleStateImageBehavior = false;
            // 
            // listOfProperties
            // 
            this.listOfProperties.Location = new System.Drawing.Point(241, 142);
            this.listOfProperties.Name = "listOfProperties";
            this.listOfProperties.Size = new System.Drawing.Size(164, 360);
            this.listOfProperties.TabIndex = 4;
            this.listOfProperties.UseCompatibleStateImageBehavior = false;
            // 
            // listOfConstructors
            // 
            this.listOfConstructors.Location = new System.Drawing.Point(411, 142);
            this.listOfConstructors.Name = "listOfConstructors";
            this.listOfConstructors.Size = new System.Drawing.Size(157, 360);
            this.listOfConstructors.TabIndex = 5;
            this.listOfConstructors.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "List Of Methods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "List Of Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "List Of Constructors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listOfConstructors);
            this.Controls.Add(this.listOfProperties);
            this.Controls.Add(this.listOfMethods);
            this.Controls.Add(this.btnGetMethodName);
            this.Controls.Add(this.txtMethodName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Button btnGetMethodName;
        private System.Windows.Forms.ListView listOfMethods;
        private System.Windows.Forms.ListView listOfProperties;
        private System.Windows.Forms.ListView listOfConstructors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

