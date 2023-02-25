namespace Sidekick.View
{
    partial class MainForm
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
            this.rootPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clockUserControl = new Sidekick.View.ClockUserControl();
            this.rootPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.ColumnCount = 2;
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootPanel.Controls.Add(this.clockUserControl, 0, 0);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.RowCount = 1;
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootPanel.Size = new System.Drawing.Size(800, 450);
            this.rootPanel.TabIndex = 0;
            // 
            // clockUserControl
            // 
            this.clockUserControl.BackColor = System.Drawing.Color.Transparent;
            this.clockUserControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clockUserControl.Location = new System.Drawing.Point(3, 411);
            this.clockUserControl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.clockUserControl.Name = "clockUserControl";
            this.clockUserControl.Size = new System.Drawing.Size(73, 29);
            this.clockUserControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rootPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.rootPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel rootPanel;
        private ClockUserControl clockUserControl;
    }
}