namespace AppConstrutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textaltarea = new System.Windows.Forms.TextBox();
            this.textaltvolume = new System.Windows.Forms.TextBox();
            this.textlargarea = new System.Windows.Forms.TextBox();
            this.textlarvolume = new System.Windows.Forms.TextBox();
            this.textcompvolume = new System.Windows.Forms.TextBox();
            this.labelresultarea = new System.Windows.Forms.Label();
            this.labelresultvolume = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnvolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textaltarea
            // 
            this.textaltarea.BackColor = System.Drawing.SystemColors.Window;
            this.textaltarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textaltarea.Location = new System.Drawing.Point(54, 120);
            this.textaltarea.Name = "textaltarea";
            this.textaltarea.Size = new System.Drawing.Size(207, 19);
            this.textaltarea.TabIndex = 0;
            // 
            // textaltvolume
            // 
            this.textaltvolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textaltvolume.Location = new System.Drawing.Point(338, 120);
            this.textaltvolume.Name = "textaltvolume";
            this.textaltvolume.Size = new System.Drawing.Size(205, 19);
            this.textaltvolume.TabIndex = 1;
            // 
            // textlargarea
            // 
            this.textlargarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textlargarea.Location = new System.Drawing.Point(54, 195);
            this.textlargarea.Name = "textlargarea";
            this.textlargarea.Size = new System.Drawing.Size(205, 19);
            this.textlargarea.TabIndex = 2;
            // 
            // textlarvolume
            // 
            this.textlarvolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textlarvolume.Location = new System.Drawing.Point(338, 195);
            this.textlarvolume.Name = "textlarvolume";
            this.textlarvolume.Size = new System.Drawing.Size(205, 19);
            this.textlarvolume.TabIndex = 3;
            // 
            // textcompvolume
            // 
            this.textcompvolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textcompvolume.Location = new System.Drawing.Point(336, 278);
            this.textcompvolume.Name = "textcompvolume";
            this.textcompvolume.Size = new System.Drawing.Size(205, 19);
            this.textcompvolume.TabIndex = 4;
            // 
            // labelresultarea
            // 
            this.labelresultarea.AutoSize = true;
            this.labelresultarea.BackColor = System.Drawing.Color.Transparent;
            this.labelresultarea.Location = new System.Drawing.Point(72, 441);
            this.labelresultarea.Name = "labelresultarea";
            this.labelresultarea.Size = new System.Drawing.Size(0, 20);
            this.labelresultarea.TabIndex = 5;
            // 
            // labelresultvolume
            // 
            this.labelresultvolume.AutoSize = true;
            this.labelresultvolume.BackColor = System.Drawing.Color.Transparent;
            this.labelresultvolume.Location = new System.Drawing.Point(355, 441);
            this.labelresultvolume.Name = "labelresultvolume";
            this.labelresultvolume.Size = new System.Drawing.Size(0, 20);
            this.labelresultvolume.TabIndex = 6;
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.Transparent;
            this.btnArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArea.Location = new System.Drawing.Point(54, 365);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(218, 46);
            this.btnArea.TabIndex = 7;
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnvolume
            // 
            this.btnvolume.BackColor = System.Drawing.Color.Transparent;
            this.btnvolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnvolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnvolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolume.Location = new System.Drawing.Point(336, 365);
            this.btnvolume.Name = "btnvolume";
            this.btnvolume.Size = new System.Drawing.Size(218, 46);
            this.btnvolume.TabIndex = 8;
            this.btnvolume.UseVisualStyleBackColor = false;
            this.btnvolume.Click += new System.EventHandler(this.btnvolume_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 519);
            this.Controls.Add(this.btnvolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.labelresultvolume);
            this.Controls.Add(this.labelresultarea);
            this.Controls.Add(this.textcompvolume);
            this.Controls.Add(this.textlarvolume);
            this.Controls.Add(this.textlargarea);
            this.Controls.Add(this.textaltvolume);
            this.Controls.Add(this.textaltarea);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "CALCULAR AREA / VOLUME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textaltarea;
        private System.Windows.Forms.TextBox textaltvolume;
        private System.Windows.Forms.TextBox textlargarea;
        private System.Windows.Forms.TextBox textlarvolume;
        private System.Windows.Forms.TextBox textcompvolume;
        private System.Windows.Forms.Label labelresultarea;
        private System.Windows.Forms.Label labelresultvolume;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnvolume;
    }
}