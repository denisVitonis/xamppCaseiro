namespace xampCaseiro
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStatusApache;
        private Label lblStatusMySQL;
        private Label lblStatusPHP;
        private Button btnStartApache;
        private Button btnStopApache;
        private Button btnStartMySQL;
        private Button btnStopMySQL;
        private Button btnStartPHP;
        private Button btnStopPHP;

        private void InitializeComponent()
        {
            lblStatusApache = new Label();
            lblStatusMySQL = new Label();
            lblStatusPHP = new Label();
            btnStartApache = new Button();
            btnStopApache = new Button();
            btnStartMySQL = new Button();
            btnStopMySQL = new Button();
            btnStartPHP = new Button();
            btnStopPHP = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblStatusApache
            // 
            lblStatusApache.AutoSize = true;
            lblStatusApache.Location = new Point(338, 122);
            lblStatusApache.Name = "lblStatusApache";
            lblStatusApache.Size = new Size(110, 20);
            lblStatusApache.TabIndex = 0;
            lblStatusApache.Text = "Status Apache: ";
            // 
            // lblStatusMySQL
            // 
            lblStatusMySQL.AutoSize = true;
            lblStatusMySQL.Location = new Point(338, 181);
            lblStatusMySQL.Name = "lblStatusMySQL";
            lblStatusMySQL.Size = new Size(106, 20);
            lblStatusMySQL.TabIndex = 1;
            lblStatusMySQL.Text = "Status MySQL: ";
            // 
            // lblStatusPHP
            // 
            lblStatusPHP.AutoSize = true;
            lblStatusPHP.Location = new Point(338, 242);
            lblStatusPHP.Name = "lblStatusPHP";
            lblStatusPHP.Size = new Size(87, 20);
            lblStatusPHP.TabIndex = 2;
            lblStatusPHP.Text = "Status PHP: ";
            // 
            // btnStartApache
            // 
            btnStartApache.Location = new Point(12, 112);
            btnStartApache.Name = "btnStartApache";
            btnStartApache.Size = new Size(123, 41);
            btnStartApache.TabIndex = 3;
            btnStartApache.Text = "Iniciar Apache";
            btnStartApache.UseVisualStyleBackColor = true;
            btnStartApache.Click += btnStartApache_Click;
            // 
            // btnStopApache
            // 
            btnStopApache.Location = new Point(162, 112);
            btnStopApache.Name = "btnStopApache";
            btnStopApache.Size = new Size(123, 41);
            btnStopApache.TabIndex = 4;
            btnStopApache.Text = "Parar Apache";
            btnStopApache.UseVisualStyleBackColor = true;
            btnStopApache.Click += btnStopApache_Click;
            // 
            // btnStartMySQL
            // 
            btnStartMySQL.Location = new Point(12, 171);
            btnStartMySQL.Name = "btnStartMySQL";
            btnStartMySQL.Size = new Size(123, 41);
            btnStartMySQL.TabIndex = 5;
            btnStartMySQL.Text = "Iniciar MySQL";
            btnStartMySQL.UseVisualStyleBackColor = true;
            btnStartMySQL.Click += btnStartMySQL_Click;
            // 
            // btnStopMySQL
            // 
            btnStopMySQL.Location = new Point(162, 171);
            btnStopMySQL.Name = "btnStopMySQL";
            btnStopMySQL.Size = new Size(123, 41);
            btnStopMySQL.TabIndex = 6;
            btnStopMySQL.Text = "Parar MySQL";
            btnStopMySQL.UseVisualStyleBackColor = true;
            btnStopMySQL.Click += btnStopMySQL_Click;
            // 
            // btnStartPHP
            // 
            btnStartPHP.Location = new Point(12, 232);
            btnStartPHP.Name = "btnStartPHP";
            btnStartPHP.Size = new Size(123, 41);
            btnStartPHP.TabIndex = 7;
            btnStartPHP.Text = "Iniciar PHP";
            btnStartPHP.UseVisualStyleBackColor = true;
            btnStartPHP.Click += btnStartPHP_Click;
            // 
            // btnStopPHP
            // 
            btnStopPHP.Location = new Point(162, 232);
            btnStopPHP.Name = "btnStopPHP";
            btnStopPHP.Size = new Size(123, 41);
            btnStopPHP.TabIndex = 8;
            btnStopPHP.Text = "Parar PHP";
            btnStopPHP.UseVisualStyleBackColor = true;
            btnStopPHP.Click += btnStopPHP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fiserv_Logo_svg;
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(554, 339);
            Controls.Add(pictureBox1);
            Controls.Add(btnStopPHP);
            Controls.Add(btnStartPHP);
            Controls.Add(btnStopMySQL);
            Controls.Add(btnStartMySQL);
            Controls.Add(btnStopApache);
            Controls.Add(btnStartApache);
            Controls.Add(lblStatusPHP);
            Controls.Add(lblStatusMySQL);
            Controls.Add(lblStatusApache);
            Name = "Form1";
            Text = "Status dos Serviços";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
    }
}
