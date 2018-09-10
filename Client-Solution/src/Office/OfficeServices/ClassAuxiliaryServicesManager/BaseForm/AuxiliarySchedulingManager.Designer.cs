namespace OfficeServices
{
    partial class AuxiliarySchedulingManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuxiliarySchedulingManager));
            this.ctlManagerAux = new RemoteClient.ControlSubjectSchedulingManager();
            this.lblRecordDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctlManagerAux
            // 
            this.ctlManagerAux.BackColor = System.Drawing.Color.Transparent;
            this.ctlManagerAux.Location = new System.Drawing.Point(752, 111);
            this.ctlManagerAux.Name = "ctlManagerAux";
            this.ctlManagerAux.Size = new System.Drawing.Size(255, 282);
            this.ctlManagerAux.TabIndex = 1;
            // 
            // lblRecordDate
            // 
            this.lblRecordDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRecordDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRecordDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecordDate.Location = new System.Drawing.Point(0, 701);
            this.lblRecordDate.Name = "lblRecordDate";
            this.lblRecordDate.Size = new System.Drawing.Size(1018, 13);
            this.lblRecordDate.TabIndex = 12;
            this.lblRecordDate.Text = "label1";
            this.lblRecordDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AuxiliarySchedulingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1018, 714);
            this.Controls.Add(this.lblRecordDate);
            this.Controls.Add(this.ctlManagerAux);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuxiliarySchedulingManager";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private RemoteClient.ControlSubjectSchedulingManager ctlManagerAux;
        private System.Windows.Forms.Label lblRecordDate;
    }
}