namespace AppConstrutores
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Concreto = new System.Windows.Forms.Button();
            this.argamassa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Concreto
            // 
            this.Concreto.BackColor = System.Drawing.Color.Transparent;
            this.Concreto.Location = new System.Drawing.Point(41, 73);
            this.Concreto.Name = "Concreto";
            this.Concreto.Size = new System.Drawing.Size(187, 44);
            this.Concreto.TabIndex = 0;
            this.Concreto.Text = "CONCRETO";
            this.Concreto.UseVisualStyleBackColor = false;
            this.Concreto.Click += new System.EventHandler(this.Concreto_Click);
            // 
            // argamassa
            // 
            this.argamassa.Location = new System.Drawing.Point(266, 73);
            this.argamassa.Name = "argamassa";
            this.argamassa.Size = new System.Drawing.Size(185, 43);
            this.argamassa.TabIndex = 1;
            this.argamassa.Text = "ARGAMASSA";
            this.argamassa.UseVisualStyleBackColor = true;
            this.argamassa.Click += new System.EventHandler(this.argamassa_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 161);
            this.Controls.Add(this.argamassa);
            this.Controls.Add(this.Concreto);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Concreto;
        private System.Windows.Forms.Button argamassa;
    }
}