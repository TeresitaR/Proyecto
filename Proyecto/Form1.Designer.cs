namespace Proyecto
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
            this.Playlist = new System.Windows.Forms.ListBox();
            this.Metadatos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Playlist
            // 
            this.Playlist.FormattingEnabled = true;
            this.Playlist.Items.AddRange(new object[] {
            "Canción                      Duración",
            "A mi                               3:54",
            "Demasiado                    3:10",
            "Amuleto                         3:12",
            "Rock N Roll                   5:01",
            "Poesía Venenosa          3:26",
            "Tu De Que Vas              3:46",
            "Mientes                          3:43",
            "Yo Quisiera                    3:36",
            "Cada beso                     3:51",
            "Aire                                4:16"});
            this.Playlist.Location = new System.Drawing.Point(60, 56);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(166, 173);
            this.Playlist.TabIndex = 0;
            this.Playlist.SelectedIndexChanged += new System.EventHandler(this.Playlist_SelectedIndexChanged);
            // 
            // Metadatos
            // 
            this.Metadatos.Location = new System.Drawing.Point(248, 56);
            this.Metadatos.Multiline = true;
            this.Metadatos.Name = "Metadatos";
            this.Metadatos.Size = new System.Drawing.Size(137, 71);
            this.Metadatos.TabIndex = 1;
            this.Metadatos.Text = "\r\n";
            this.Metadatos.TextChanged += new System.EventHandler(this.Metadatos_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "|<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Metadatos);
            this.Controls.Add(this.Playlist);
            this.Name = "Form1";
            this.Text = "Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.TextBox Metadatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

