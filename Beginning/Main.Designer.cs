namespace Beginning
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnMy = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.cBDo = new System.Windows.Forms.ComboBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnSeries = new System.Windows.Forms.Button();
            this.tBSeriesE = new System.Windows.Forms.TextBox();
            this.tBSeriesY = new System.Windows.Forms.TextBox();
            this.tBSeriesT = new System.Windows.Forms.TextBox();
            this.lblSeries = new System.Windows.Forms.Label();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeSeries = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnDeleteSeries = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnNewSeries = new System.Windows.Forms.Button();
            this.tBtitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(539, 12);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.Size = new System.Drawing.Size(712, 485);
            this.dataGV.TabIndex = 0;
            this.dataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellContentClick);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHello.Location = new System.Drawing.Point(116, 12);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(149, 20);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Добро пожаловать, ";
            this.lblHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMy
            // 
            this.btnMy.AutoSize = true;
            this.btnMy.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnMy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMy.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMy.Location = new System.Drawing.Point(17, 84);
            this.btnMy.Name = "btnMy";
            this.btnMy.Size = new System.Drawing.Size(163, 32);
            this.btnMy.TabIndex = 2;
            this.btnMy.Text = "Мои сериалы";
            this.btnMy.UseVisualStyleBackColor = false;
            this.btnMy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAll.Location = new System.Drawing.Point(17, 47);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(163, 32);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "Все сериалы";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(309, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChange
            // 
            this.btnChange.AutoSize = true;
            this.btnChange.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.Location = new System.Drawing.Point(17, 122);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(163, 32);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Редактировать";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cBDo
            // 
            this.cBDo.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBDo.FormattingEnabled = true;
            this.cBDo.Items.AddRange(new object[] {
            "Добавить сериал",
            "Редактировать сериал",
            "Удалить сериал"});
            this.cBDo.Location = new System.Drawing.Point(201, 50);
            this.cBDo.Name = "cBDo";
            this.cBDo.Size = new System.Drawing.Size(312, 28);
            this.cBDo.TabIndex = 7;
            this.cBDo.Visible = false;
            this.cBDo.SelectedIndexChanged += new System.EventHandler(this.cBDo_SelectedIndexChanged);
            // 
            // btnDo
            // 
            this.btnDo.AutoSize = true;
            this.btnDo.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDo.Location = new System.Drawing.Point(294, 119);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(127, 32);
            this.btnDo.TabIndex = 8;
            this.btnDo.Text = "Применить";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Visible = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnSeries);
            this.pnlAdmin.Controls.Add(this.tBSeriesE);
            this.pnlAdmin.Controls.Add(this.tBSeriesY);
            this.pnlAdmin.Controls.Add(this.tBSeriesT);
            this.pnlAdmin.Controls.Add(this.lblSeries);
            this.pnlAdmin.Controls.Add(this.btnAllUsers);
            this.pnlAdmin.Controls.Add(this.label2);
            this.pnlAdmin.Controls.Add(this.btnChangeSeries);
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.btnChangePass);
            this.pnlAdmin.Controls.Add(this.btnDeleteUser);
            this.pnlAdmin.Controls.Add(this.btnDeleteSeries);
            this.pnlAdmin.Controls.Add(this.btnNewUser);
            this.pnlAdmin.Controls.Add(this.btnNewSeries);
            this.pnlAdmin.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlAdmin.Location = new System.Drawing.Point(10, 193);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(523, 266);
            this.pnlAdmin.TabIndex = 9;
            this.pnlAdmin.Visible = false;
            this.pnlAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSeries
            // 
            this.btnSeries.AutoSize = true;
            this.btnSeries.Location = new System.Drawing.Point(7, 218);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(206, 30);
            this.btnSeries.TabIndex = 18;
            this.btnSeries.Text = "Ок";
            this.btnSeries.UseVisualStyleBackColor = true;
            this.btnSeries.Visible = false;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // tBSeriesE
            // 
            this.tBSeriesE.Location = new System.Drawing.Point(96, 187);
            this.tBSeriesE.Name = "tBSeriesE";
            this.tBSeriesE.Size = new System.Drawing.Size(117, 25);
            this.tBSeriesE.TabIndex = 17;
            this.tBSeriesE.Text = "Кол-во серий";
            this.tBSeriesE.Visible = false;
            // 
            // tBSeriesY
            // 
            this.tBSeriesY.Location = new System.Drawing.Point(7, 187);
            this.tBSeriesY.Name = "tBSeriesY";
            this.tBSeriesY.Size = new System.Drawing.Size(83, 25);
            this.tBSeriesY.TabIndex = 16;
            this.tBSeriesY.Text = "Год";
            this.tBSeriesY.Visible = false;
            // 
            // tBSeriesT
            // 
            this.tBSeriesT.Location = new System.Drawing.Point(7, 156);
            this.tBSeriesT.Name = "tBSeriesT";
            this.tBSeriesT.Size = new System.Drawing.Size(206, 25);
            this.tBSeriesT.TabIndex = 15;
            this.tBSeriesT.Text = "Название";
            this.tBSeriesT.Visible = false;
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(3, 133);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(65, 20);
            this.lblSeries.TabIndex = 14;
            this.lblSeries.Text = "Сериал:";
            this.lblSeries.Visible = false;
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.AutoSize = true;
            this.btnAllUsers.Location = new System.Drawing.Point(279, 121);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(212, 32);
            this.btnAllUsers.TabIndex = 13;
            this.btnAllUsers.Text = "Список всех пользователей";
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(275, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Работа с пользователями:";
            // 
            // btnChangeSeries
            // 
            this.btnChangeSeries.AutoSize = true;
            this.btnChangeSeries.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeSeries.Location = new System.Drawing.Point(7, 53);
            this.btnChangeSeries.Name = "btnChangeSeries";
            this.btnChangeSeries.Size = new System.Drawing.Size(206, 32);
            this.btnChangeSeries.TabIndex = 7;
            this.btnChangeSeries.Text = "Изменение данных";
            this.btnChangeSeries.UseVisualStyleBackColor = true;
            this.btnChangeSeries.Click += new System.EventHandler(this.btnChangeSeries_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Работа со списоком сериалов:";
            // 
            // btnChangePass
            // 
            this.btnChangePass.AutoSize = true;
            this.btnChangePass.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePass.Location = new System.Drawing.Point(278, 53);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(212, 32);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Изменение пароля";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AutoSize = true;
            this.btnDeleteUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteUser.Location = new System.Drawing.Point(278, 87);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(212, 32);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Удаление пользователя";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDeleteSeries
            // 
            this.btnDeleteSeries.AutoSize = true;
            this.btnDeleteSeries.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSeries.Location = new System.Drawing.Point(7, 86);
            this.btnDeleteSeries.Name = "btnDeleteSeries";
            this.btnDeleteSeries.Size = new System.Drawing.Size(206, 32);
            this.btnDeleteSeries.TabIndex = 3;
            this.btnDeleteSeries.Text = "Удаление";
            this.btnDeleteSeries.UseVisualStyleBackColor = true;
            this.btnDeleteSeries.Click += new System.EventHandler(this.btnDeleteSeries_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.AutoSize = true;
            this.btnNewUser.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewUser.Location = new System.Drawing.Point(278, 20);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(212, 32);
            this.btnNewUser.TabIndex = 1;
            this.btnNewUser.Text = "Новый пользователь";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNewSeries
            // 
            this.btnNewSeries.AutoSize = true;
            this.btnNewSeries.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewSeries.Location = new System.Drawing.Point(7, 20);
            this.btnNewSeries.Name = "btnNewSeries";
            this.btnNewSeries.Size = new System.Drawing.Size(206, 32);
            this.btnNewSeries.TabIndex = 0;
            this.btnNewSeries.Text = "Добавление новых";
            this.btnNewSeries.UseVisualStyleBackColor = true;
            this.btnNewSeries.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tBtitle
            // 
            this.tBtitle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBtitle.Location = new System.Drawing.Point(201, 87);
            this.tBtitle.Name = "tBtitle";
            this.tBtitle.Size = new System.Drawing.Size(312, 25);
            this.tBtitle.TabIndex = 10;
            this.tBtitle.Visible = false;
            this.tBtitle.TextChanged += new System.EventHandler(this.tBtitle_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1263, 509);
            this.Controls.Add(this.tBtitle);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.cBDo);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnMy);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.dataGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnMy;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cBDo;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnNewSeries;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnDeleteSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBtitle;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.TextBox tBSeriesE;
        private System.Windows.Forms.TextBox tBSeriesY;
        private System.Windows.Forms.TextBox tBSeriesT;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Button btnSeries;
    }
}