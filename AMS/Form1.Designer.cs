namespace AMS
{
    partial class AMS
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            lblTime = new Label();
            label5 = new Label();
            btnThem = new Button();
            label4 = new Label();
            btnSua = new Button();
            label6 = new Label();
            btnXoa = new Button();
            txtMa = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtSoHuu = new TextBox();
            txtTaiKhoan = new TextBox();
            panel2 = new Panel();
            dgTaiKhoan = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(txtMa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtSoHuu);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1239, 172);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F);
            label3.Location = new Point(234, 68);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 34;
            label3.Text = "Email";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(3, 31);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(183, 57);
            lblTime.TabIndex = 39;
            lblTime.Text = "00:00:00";
            lblTime.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F);
            label5.Location = new Point(559, 68);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 31;
            label5.Text = "Mật khẩu";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.AutoSize = true;
            btnThem.Font = new Font("Times New Roman", 15.75F);
            btnThem.Location = new Point(949, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(96, 37);
            btnThem.TabIndex = 36;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F);
            label4.Location = new Point(559, 23);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 32;
            label4.Text = "Tài khoản";
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.AutoSize = true;
            btnSua.Font = new Font("Times New Roman", 15.75F);
            btnSua.Location = new Point(949, 67);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(96, 37);
            btnSua.TabIndex = 37;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F);
            label6.Location = new Point(336, 124);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 33;
            label6.Text = "Sở hữu";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.AutoSize = true;
            btnXoa.Font = new Font("Times New Roman", 15.75F);
            btnXoa.Location = new Point(949, 110);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 37);
            btnXoa.TabIndex = 38;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtMa
            // 
            txtMa.Anchor = AnchorStyles.Top;
            txtMa.Font = new Font("Times New Roman", 15.75F);
            txtMa.Location = new Point(305, 20);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(210, 32);
            txtMa.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F);
            label2.Location = new Point(234, 23);
            label2.Name = "label2";
            label2.Size = new Size(37, 23);
            label2.TabIndex = 35;
            label2.Text = "Mã";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Font = new Font("Times New Roman", 15.75F);
            txtEmail.Location = new Point(305, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 32);
            txtEmail.TabIndex = 29;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Top;
            txtMatKhau.Font = new Font("Times New Roman", 15.75F);
            txtMatKhau.Location = new Point(657, 65);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(210, 32);
            txtMatKhau.TabIndex = 28;
            // 
            // txtSoHuu
            // 
            txtSoHuu.Anchor = AnchorStyles.Top;
            txtSoHuu.Font = new Font("Times New Roman", 15.75F);
            txtSoHuu.Location = new Point(434, 121);
            txtSoHuu.Name = "txtSoHuu";
            txtSoHuu.Size = new Size(363, 32);
            txtSoHuu.TabIndex = 30;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Anchor = AnchorStyles.Top;
            txtTaiKhoan.Font = new Font("Times New Roman", 15.75F);
            txtTaiKhoan.Location = new Point(657, 20);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(210, 32);
            txtTaiKhoan.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(1239, 416);
            panel2.TabIndex = 1;
            // 
            // dgTaiKhoan
            // 
            dgTaiKhoan.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTaiKhoan.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            dgTaiKhoan.Dock = DockStyle.Fill;
            dgTaiKhoan.EnableHeadersVisualStyles = false;
            dgTaiKhoan.Location = new Point(0, 0);
            dgTaiKhoan.Name = "dgTaiKhoan";
            dgTaiKhoan.RowTemplate.Height = 35;
            dgTaiKhoan.Size = new Size(1239, 416);
            dgTaiKhoan.TabIndex = 0;
            dgTaiKhoan.CellClick += dgTaiKhoan_CellClick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // AMS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 588);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AMS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách tài khoản";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label lblTime;
        private Label label5;
        private Button btnThem;
        private Label label4;
        private Button btnSua;
        private Label label6;
        private Button btnXoa;
        private TextBox txtMa;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtSoHuu;
        private TextBox txtTaiKhoan;
        private DataGridView dgTaiKhoan;
        private System.Windows.Forms.Timer timer1;
    }
}
