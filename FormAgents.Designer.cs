namespace project_E
{
    partial class FormAgents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgents));
            this.Name = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.Label();
            this.SurName = new System.Windows.Forms.Label();
            this.DealShare = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxDealShare = new System.Windows.Forms.TextBox();
            this.listViewAgents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фами = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(68, 146);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(29, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Имя";
            // 
            // SecondName
            // 
            this.SecondName.AutoSize = true;
            this.SecondName.Location = new System.Drawing.Point(68, 224);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(54, 13);
            this.SecondName.TabIndex = 1;
            this.SecondName.Text = "Отчество";
            // 
            // SurName
            // 
            this.SurName.AutoSize = true;
            this.SurName.Location = new System.Drawing.Point(70, 185);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(56, 13);
            this.SurName.TabIndex = 2;
            this.SurName.Text = "Фамилия";
            // 
            // DealShare
            // 
            this.DealShare.AutoSize = true;
            this.DealShare.Location = new System.Drawing.Point(68, 263);
            this.DealShare.Name = "DealShare";
            this.DealShare.Size = new System.Drawing.Size(58, 13);
            this.DealShare.TabIndex = 3;
            this.DealShare.Text = "Комиссия";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(71, 162);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(71, 201);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(140, 20);
            this.textBoxSurName.TabIndex = 5;
            this.textBoxSurName.TextChanged += new System.EventHandler(this.textBoxSurName_TextChanged);
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(71, 240);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(140, 20);
            this.textBoxSecondName.TabIndex = 6;
            this.textBoxSecondName.TextChanged += new System.EventHandler(this.textBoxSecondName_TextChanged);
            // 
            // textBoxDealShare
            // 
            this.textBoxDealShare.Location = new System.Drawing.Point(71, 279);
            this.textBoxDealShare.Name = "textBoxDealShare";
            this.textBoxDealShare.Size = new System.Drawing.Size(140, 20);
            this.textBoxDealShare.TabIndex = 7;
            this.textBoxDealShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDealShare_KeyPress);
            // 
            // listViewAgents
            // 
            this.listViewAgents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.Фами,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewAgents.FullRowSelect = true;
            this.listViewAgents.GridLines = true;
            this.listViewAgents.HideSelection = false;
            this.listViewAgents.Location = new System.Drawing.Point(276, 21);
            this.listViewAgents.MultiSelect = false;
            this.listViewAgents.Name = "listViewAgents";
            this.listViewAgents.Size = new System.Drawing.Size(322, 361);
            this.listViewAgents.TabIndex = 8;
            this.listViewAgents.UseCompatibleStateImageBehavior = false;
            this.listViewAgents.View = System.Windows.Forms.View.Details;
            this.listViewAgents.SelectedIndexChanged += new System.EventHandler(this.listViewAgents_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // Фами
            // 
            this.Фами.Text = "Фамилия";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Отчество";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Комиссия";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 403);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 48);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(243, 403);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(200, 48);
            this.buttonChange.TabIndex = 10;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(472, 403);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 48);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewAgents);
            this.Controls.Add(this.textBoxDealShare);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.DealShare);
            this.Controls.Add(this.SurName);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.Name);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Риелторы";
            this.Load += new System.EventHandler(this.FormAgents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label SecondName;
        private System.Windows.Forms.Label SurName;
        private System.Windows.Forms.Label DealShare;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxDealShare;
        private System.Windows.Forms.ListView listViewAgents;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Фами;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}