namespace Glider7DataMergeTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseScienceButton = new System.Windows.Forms.Button();
            this.browseFlightButton = new System.Windows.Forms.Button();
            this.sciencePathBox = new System.Windows.Forms.TextBox();
            this.flightPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveOutputDialog = new System.Windows.Forms.SaveFileDialog();
            this.mergeButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browseScienceButton);
            this.groupBox1.Controls.Add(this.browseFlightButton);
            this.groupBox1.Controls.Add(this.sciencePathBox);
            this.groupBox1.Controls.Add(this.flightPathBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data File Paths";
            // 
            // browseScienceButton
            // 
            this.browseScienceButton.Location = new System.Drawing.Point(286, 44);
            this.browseScienceButton.Name = "browseScienceButton";
            this.browseScienceButton.Size = new System.Drawing.Size(75, 23);
            this.browseScienceButton.TabIndex = 4;
            this.browseScienceButton.Text = "Browse...";
            this.browseScienceButton.UseVisualStyleBackColor = true;
            this.browseScienceButton.Click += new System.EventHandler(this.browseScienceButton_Click);
            // 
            // browseFlightButton
            // 
            this.browseFlightButton.Location = new System.Drawing.Point(286, 18);
            this.browseFlightButton.Name = "browseFlightButton";
            this.browseFlightButton.Size = new System.Drawing.Size(75, 23);
            this.browseFlightButton.TabIndex = 4;
            this.browseFlightButton.Text = "Browse...";
            this.browseFlightButton.UseVisualStyleBackColor = true;
            this.browseFlightButton.Click += new System.EventHandler(this.browseFlightButton_Click);
            // 
            // sciencePathBox
            // 
            this.sciencePathBox.Location = new System.Drawing.Point(62, 46);
            this.sciencePathBox.Name = "sciencePathBox";
            this.sciencePathBox.ReadOnly = true;
            this.sciencePathBox.Size = new System.Drawing.Size(199, 20);
            this.sciencePathBox.TabIndex = 3;
            // 
            // flightPathBox
            // 
            this.flightPathBox.Location = new System.Drawing.Point(62, 20);
            this.flightPathBox.Name = "flightPathBox";
            this.flightPathBox.ReadOnly = true;
            this.flightPathBox.Size = new System.Drawing.Size(199, 20);
            this.flightPathBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Science:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight:";
            // 
            // dataFileDialog
            // 
            this.dataFileDialog.DefaultExt = "ssv";
            this.dataFileDialog.FileName = "openFileDialog1";
            this.dataFileDialog.Filter = "\"Space Separated Value|*.ssv|All Files|*.*\"";
            // 
            // saveOutputDialog
            // 
            this.saveOutputDialog.DefaultExt = "ssv";
            this.saveOutputDialog.Filter = "Space Separated Value|*.ssv|All Files|*.*";
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(13, 98);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(366, 23);
            this.mergeButton.TabIndex = 1;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 134);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Glider v7 Data Files Merge Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button browseScienceButton;
        private System.Windows.Forms.Button browseFlightButton;
        private System.Windows.Forms.TextBox sciencePathBox;
        private System.Windows.Forms.TextBox flightPathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dataFileDialog;
        private System.Windows.Forms.SaveFileDialog saveOutputDialog;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

