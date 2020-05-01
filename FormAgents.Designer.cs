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
            this.Name = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.Label();
            this.SurName = new System.Windows.Forms.Label();
            this.DealShare = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxDealShare = new System.Windows.Forms.TextBox();
            this.listViewAgents = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(117, 50);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(29, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Имя";
            // 
            // SecondName
            // 
            this.SecondName.AutoSize = true;
            this.SecondName.Location = new System.Drawing.Point(117, 128);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(54, 13);
            this.SecondName.TabIndex = 1;
            this.SecondName.Text = "Отчество";
            // 
            // SurName
            // 
            this.SurName.AutoSize = true;
            this.SurName.Location = new System.Drawing.Point(119, 89);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(56, 13);
            this.SurName.TabIndex = 2;
            this.SurName.Text = "Фамилия";
            // 
            // DealShare
            // 
            this.DealShare.AutoSize = true;
            this.DealShare.Location = new System.Drawing.Point(117, 167);
            this.DealShare.Name = "DealShare";
            this.DealShare.Size = new System.Drawing.Size(58, 13);
            this.DealShare.TabIndex = 3;
            this.DealShare.Text = "Комиссия";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(120, 105);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurName.TabIndex = 5;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(120, 144);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondName.TabIndex = 6;
            // 
            // textBoxDealShare
            // 
            this.textBoxDealShare.Location = new System.Drawing.Point(120, 183);
            this.textBoxDealShare.Name = "textBoxDealShare";
            this.textBoxDealShare.Size = new System.Drawing.Size(100, 20);
            this.textBoxDealShare.TabIndex = 7;
            // 
            // listViewAgents
            // 
            this.listViewAgents.HideSelection = false;
            this.listViewAgents.Location = new System.Drawing.Point(264, 66);
            this.listViewAgents.Name = "listViewAgents";
            this.listViewAgents.Size = new System.Drawing.Size(462, 137);
            this.listViewAgents.TabIndex = 8;
            this.listViewAgents.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(345, 321);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(446, 321);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 10;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(550, 321);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // FormAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}