namespace Ednevnik410b
{
    partial class Upisnica
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.Label();
            this.TxtGodina = new System.Windows.Forms.Label();
            this.TxtOdeljenje = new System.Windows.Forms.Label();
            this.TxtUcenik = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.godina = new System.Windows.Forms.ComboBox();
            this.odeljenje = new System.Windows.Forms.ComboBox();
            this.ucenik = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(13, 104);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(551, 263);
            this.datagrid.TabIndex = 0;
            this.datagrid.CurrentCellChanged += new System.EventHandler(this.DGridView_CurrentCellChanged);
            // 
            // TxtId
            // 
            this.TxtId.AutoSize = true;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(35, 9);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(27, 24);
            this.TxtId.TabIndex = 1;
            this.TxtId.Text = "ID";
            // 
            // TxtGodina
            // 
            this.TxtGodina.AutoSize = true;
            this.TxtGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGodina.Location = new System.Drawing.Point(137, 9);
            this.TxtGodina.Name = "TxtGodina";
            this.TxtGodina.Size = new System.Drawing.Size(71, 24);
            this.TxtGodina.TabIndex = 2;
            this.TxtGodina.Text = "Godina";
            // 
            // TxtOdeljenje
            // 
            this.TxtOdeljenje.AutoSize = true;
            this.TxtOdeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOdeljenje.Location = new System.Drawing.Point(268, 9);
            this.TxtOdeljenje.Name = "TxtOdeljenje";
            this.TxtOdeljenje.Size = new System.Drawing.Size(92, 24);
            this.TxtOdeljenje.TabIndex = 3;
            this.TxtOdeljenje.Text = "Odeljenje";
            // 
            // TxtUcenik
            // 
            this.TxtUcenik.AutoSize = true;
            this.TxtUcenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUcenik.Location = new System.Drawing.Point(398, 9);
            this.TxtUcenik.Name = "TxtUcenik";
            this.TxtUcenik.Size = new System.Drawing.Size(68, 24);
            this.TxtUcenik.TabIndex = 4;
            this.TxtUcenik.Text = "Ucenik";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(39, 36);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(92, 20);
            this.id.TabIndex = 5;
            // 
            // godina
            // 
            this.godina.FormattingEnabled = true;
            this.godina.Location = new System.Drawing.Point(141, 36);
            this.godina.Name = "godina";
            this.godina.Size = new System.Drawing.Size(120, 21);
            this.godina.TabIndex = 6;
            // 
            // odeljenje
            // 
            this.odeljenje.FormattingEnabled = true;
            this.odeljenje.Location = new System.Drawing.Point(272, 36);
            this.odeljenje.Name = "odeljenje";
            this.odeljenje.Size = new System.Drawing.Size(120, 21);
            this.odeljenje.TabIndex = 7;
            // 
            // ucenik
            // 
            this.ucenik.FormattingEnabled = true;
            this.ucenik.Location = new System.Drawing.Point(402, 35);
            this.ucenik.Name = "ucenik";
            this.ucenik.Size = new System.Drawing.Size(123, 21);
            this.ucenik.TabIndex = 8;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Control;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Location = new System.Drawing.Point(356, 62);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 35);
            this.delete.TabIndex = 9;
            this.delete.Text = "Obrisi";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.Control;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Location = new System.Drawing.Point(250, 63);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 35);
            this.update.TabIndex = 10;
            this.update.Text = "Ažuriraj";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.Control;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Location = new System.Drawing.Point(141, 63);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 35);
            this.add.TabIndex = 11;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // Upisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 374);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.ucenik);
            this.Controls.Add(this.odeljenje);
            this.Controls.Add(this.godina);
            this.Controls.Add(this.id);
            this.Controls.Add(this.TxtUcenik);
            this.Controls.Add(this.TxtOdeljenje);
            this.Controls.Add(this.TxtGodina);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.datagrid);
            this.Name = "Upisnica";
            this.Text = "Upisnica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Upisnica_FormClosed);
            this.Load += new System.EventHandler(this.Upisnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label TxtId;
        private System.Windows.Forms.Label TxtGodina;
        private System.Windows.Forms.Label TxtOdeljenje;
        private System.Windows.Forms.Label TxtUcenik;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox godina;
        private System.Windows.Forms.ComboBox odeljenje;
        private System.Windows.Forms.ComboBox ucenik;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
    }
}