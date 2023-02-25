namespace Sidekick.View.Mixer
{
    partial class MixerUserControl
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
            this.appAudioListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rootPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.ColumnCount = 2;
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.76923F));
            this.rootPanel.Controls.Add(this.appAudioListPanel, 1, 0);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.RowCount = 1;
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rootPanel.Size = new System.Drawing.Size(546, 452);
            this.rootPanel.TabIndex = 0;
            // 
            // appAudioListPanel
            // 
            this.appAudioListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appAudioListPanel.Location = new System.Drawing.Point(108, 3);
            this.appAudioListPanel.Name = "appAudioListPanel";
            this.appAudioListPanel.Size = new System.Drawing.Size(435, 446);
            this.appAudioListPanel.TabIndex = 0;
            // 
            // MixerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rootPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "MixerUserControl";
            this.Size = new System.Drawing.Size(546, 452);
            this.rootPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel rootPanel;
        private FlowLayoutPanel appAudioListPanel;
    }
}
