namespace Sidekick.View.Impl
{
    partial class ClockUserControl
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
            this.rootPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.rootPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.ColumnCount = 1;
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootPanel.Controls.Add(this.timeLabel, 0, 0);
            this.rootPanel.Controls.Add(this.dateLabel, 0, 1);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.RowCount = 2;
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootPanel.Size = new System.Drawing.Size(93, 37);
            this.rootPanel.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.timeLabel.Location = new System.Drawing.Point(25, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 16);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "00:00";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dateLabel.Location = new System.Drawing.Point(7, 16);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(79, 16);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "01.01.0001";
            // 
            // ClockUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rootPanel);
            this.Name = "ClockUserControl";
            this.Size = new System.Drawing.Size(93, 37);
            this.rootPanel.ResumeLayout(false);
            this.rootPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel rootPanel;
        private Label timeLabel;
        private Label dateLabel;
    }
}
