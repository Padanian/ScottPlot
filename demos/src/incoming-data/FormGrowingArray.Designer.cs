﻿namespace ScottPlotDemoIncomingData
{
    partial class FormGrowingArray
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
            this.timerNewData = new System.Windows.Forms.Timer(this.components);
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.cbIncoming = new System.Windows.Forms.CheckBox();
            this.timerUpdatePlot = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerNewData
            // 
            this.timerNewData.Enabled = true;
            this.timerNewData.Interval = 1;
            this.timerNewData.Tick += new System.EventHandler(this.TimerNewData_Tick);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(800, 450);
            this.formsPlot1.TabIndex = 0;
            // 
            // cbIncoming
            // 
            this.cbIncoming.AutoSize = true;
            this.cbIncoming.Checked = true;
            this.cbIncoming.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncoming.Location = new System.Drawing.Point(12, 12);
            this.cbIncoming.Name = "cbIncoming";
            this.cbIncoming.Size = new System.Drawing.Size(68, 17);
            this.cbIncoming.TabIndex = 1;
            this.cbIncoming.Text = "incoming";
            this.cbIncoming.UseVisualStyleBackColor = true;
            this.cbIncoming.CheckedChanged += new System.EventHandler(this.CbIncoming_CheckedChanged);
            // 
            // timerUpdatePlot
            // 
            this.timerUpdatePlot.Enabled = true;
            this.timerUpdatePlot.Interval = 20;
            this.timerUpdatePlot.Tick += new System.EventHandler(this.TimerUpdatePlot_Tick);
            // 
            // FormGrowingArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbIncoming);
            this.Controls.Add(this.formsPlot1);
            this.Name = "FormGrowingArray";
            this.Text = "ScottPlot Demo - Growing Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerNewData;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.CheckBox cbIncoming;
        private System.Windows.Forms.Timer timerUpdatePlot;
    }
}