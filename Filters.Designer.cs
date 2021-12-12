namespace Columbus
{
    partial class Filters
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
            this.lbxFilters = new System.Windows.Forms.ListBox();
            this.cbxField = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxFilters
            // 
            this.lbxFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxFilters.FormattingEnabled = true;
            this.lbxFilters.Location = new System.Drawing.Point(0, 0);
            this.lbxFilters.Name = "lbxFilters";
            this.lbxFilters.Size = new System.Drawing.Size(367, 134);
            this.lbxFilters.TabIndex = 0;
            // 
            // cbxField
            // 
            this.cbxField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Items.AddRange(new object[] {
            "Pos",
            "Vlg",
            "Naam",
            "Mee",
            "Get",
            "Afstand",
            "Ringnr",
            "Zuiver",
            "Snelheid",
            "Punten"});
            this.cbxField.Location = new System.Drawing.Point(12, 189);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(145, 21);
            this.cbxField.TabIndex = 1;
            // 
            // cbxType
            // 
            this.cbxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "!="});
            this.cbxType.Location = new System.Drawing.Point(163, 189);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(42, 21);
            this.cbxType.TabIndex = 2;
            // 
            // tbxValue
            // 
            this.tbxValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxValue.Location = new System.Drawing.Point(211, 190);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(145, 20);
            this.tbxValue.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(0, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(367, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Regel Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regel Verwijderen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cbxField);
            this.Controls.Add(this.lbxFilters);
            this.Name = "Filters";
            this.Text = "Filters";
            this.Load += new System.EventHandler(this.Filters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFilters;
        private System.Windows.Forms.ComboBox cbxField;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
    }
}