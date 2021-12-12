namespace Columbus
{
    partial class Ctrl_Race
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxRace = new System.Windows.Forms.ListView();
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.next = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inFlight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ringNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.points = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbxRace
            // 
            this.lbxRace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.position,
            this.next,
            this.name,
            this.inFlight,
            this.mark,
            this.distance,
            this.ringNumber,
            this.arrivalTime,
            this.speed,
            this.points});
            this.lbxRace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxRace.HideSelection = false;
            this.lbxRace.Location = new System.Drawing.Point(0, 0);
            this.lbxRace.Name = "lbxRace";
            this.lbxRace.Size = new System.Drawing.Size(1276, 643);
            this.lbxRace.TabIndex = 0;
            this.lbxRace.UseCompatibleStateImageBehavior = false;
            this.lbxRace.View = System.Windows.Forms.View.Details;
            // 
            // position
            // 
            this.position.Text = "Pos";
            // 
            // next
            // 
            this.next.Text = "Vlg";
            // 
            // name
            // 
            this.name.Text = "Naam";
            this.name.Width = 141;
            // 
            // inFlight
            // 
            this.inFlight.Text = "Mee";
            // 
            // mark
            // 
            this.mark.Text = "Get";
            // 
            // distance
            // 
            this.distance.Text = "Afstand";
            this.distance.Width = 104;
            // 
            // ringNumber
            // 
            this.ringNumber.Text = "Ringnr";
            // 
            // arrivalTime
            // 
            this.arrivalTime.Text = "Zuiver";
            this.arrivalTime.Width = 153;
            // 
            // speed
            // 
            this.speed.Text = "Snelheid";
            this.speed.Width = 107;
            // 
            // points
            // 
            this.points.Text = "Punten";
            // 
            // Ctrl_Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbxRace);
            this.Name = "Ctrl_Race";
            this.Size = new System.Drawing.Size(1276, 643);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lbxRace;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.ColumnHeader next;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader inFlight;
        private System.Windows.Forms.ColumnHeader mark;
        private System.Windows.Forms.ColumnHeader distance;
        private System.Windows.Forms.ColumnHeader ringNumber;
        private System.Windows.Forms.ColumnHeader arrivalTime;
        private System.Windows.Forms.ColumnHeader speed;
        private System.Windows.Forms.ColumnHeader points;
    }
}
