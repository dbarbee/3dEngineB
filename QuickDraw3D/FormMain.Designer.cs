﻿using dbarbee.GraphicsEngine._2DCanvas.Doc;

namespace dbarbee.GraphicsEngine.QuickDraw3D
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraHorizontal = new System.Windows.Forms.HScrollBar();
            this.CameraVertical = new System.Windows.Forms.VScrollBar();
            this.canvas1 = new dbarbee.GraphicsEngine._2DCanvas.Doc.Canvas();
            this.button1 = new System.Windows.Forms.Button();
            this.CameraDistanceSb = new System.Windows.Forms.HScrollBar();
            this.ViewScreenDistanceSb = new System.Windows.Forms.HScrollBar();
            this.CameraHorizontalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.redrawToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewportToolStripMenuItem,
            this.cameraToolStripMenuItem,
            this.canvasToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // viewportToolStripMenuItem
            // 
            this.viewportToolStripMenuItem.Name = "viewportToolStripMenuItem";
            this.viewportToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.viewportToolStripMenuItem.Text = "Viewport...";
            this.viewportToolStripMenuItem.Click += new System.EventHandler(this.setupViewportToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cameraToolStripMenuItem.Text = "Camera...";
            this.cameraToolStripMenuItem.Click += new System.EventHandler(this.setupCameraToolStripMenuItem_Click);
            // 
            // canvasToolStripMenuItem
            // 
            this.canvasToolStripMenuItem.Name = "canvasToolStripMenuItem";
            this.canvasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.canvasToolStripMenuItem.Text = "Canvas..";
            this.canvasToolStripMenuItem.Click += new System.EventHandler(this.setupCanvasToolStripMenuItem_Click);
            // 
            // redrawToolStripMenuItem
            // 
            this.redrawToolStripMenuItem.Name = "redrawToolStripMenuItem";
            this.redrawToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.redrawToolStripMenuItem.Text = "Redraw!";
            this.redrawToolStripMenuItem.Click += new System.EventHandler(this.redrawToolStripMenuItem_Click);
            // 
            // CameraHorizontal
            // 
            this.CameraHorizontal.LargeChange = 15;
            this.CameraHorizontal.Location = new System.Drawing.Point(0, 596);
            this.CameraHorizontal.Maximum = 180;
            this.CameraHorizontal.Minimum = -180;
            this.CameraHorizontal.Name = "CameraHorizontal";
            this.CameraHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CameraHorizontal.Size = new System.Drawing.Size(567, 17);
            this.CameraHorizontal.TabIndex = 2;
            this.CameraHorizontal.ValueChanged += new System.EventHandler(this.CameraHorizontal_ValueChanged);
            // 
            // CameraVertical
            // 
            this.CameraVertical.LargeChange = 15;
            this.CameraVertical.Location = new System.Drawing.Point(567, 24);
            this.CameraVertical.Maximum = 180;
            this.CameraVertical.Minimum = -180;
            this.CameraVertical.Name = "CameraVertical";
            this.CameraVertical.Size = new System.Drawing.Size(17, 569);
            this.CameraVertical.TabIndex = 3;
            this.CameraVertical.ValueChanged += new System.EventHandler(this.CameraVertical_ValueChanged_1);
            // 
            // canvas1
            // 
            this.canvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas1.Location = new System.Drawing.Point(0, 24);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(567, 567);
            this.canvas1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 16);
            this.button1.TabIndex = 4;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CameraDistanceSb
            // 
            this.CameraDistanceSb.Location = new System.Drawing.Point(0, 627);
            this.CameraDistanceSb.Maximum = 280;
            this.CameraDistanceSb.Name = "CameraDistanceSb";
            this.CameraDistanceSb.Size = new System.Drawing.Size(567, 17);
            this.CameraDistanceSb.TabIndex = 5;
            this.CameraDistanceSb.Value = 140;
            this.CameraDistanceSb.ValueChanged += new System.EventHandler(this.CameraDistanceSb_ValueChanged);
            // 
            // ViewScreenDistanceSb
            // 
            this.ViewScreenDistanceSb.Location = new System.Drawing.Point(0, 654);
            this.ViewScreenDistanceSb.Maximum = 340;
            this.ViewScreenDistanceSb.Name = "ViewScreenDistanceSb";
            this.ViewScreenDistanceSb.Size = new System.Drawing.Size(567, 17);
            this.ViewScreenDistanceSb.TabIndex = 5;
            this.ViewScreenDistanceSb.Value = 170;
            this.ViewScreenDistanceSb.ValueChanged += new System.EventHandler(this.ViewScreenDistanceSb_ValueChanged);
            // 
            // CameraHorizontalToolTip
            // 
            this.CameraHorizontalToolTip.ToolTipTitle = "Camera Horizontal";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 680);
            this.Controls.Add(this.ViewScreenDistanceSb);
            this.Controls.Add(this.CameraDistanceSb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CameraVertical);
            this.Controls.Add(this.CameraHorizontal);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redrawToolStripMenuItem;
        private Canvas canvas1;
        private System.Windows.Forms.HScrollBar CameraHorizontal;
        private System.Windows.Forms.VScrollBar CameraVertical;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar CameraDistanceSb;
        private System.Windows.Forms.HScrollBar ViewScreenDistanceSb;
        private System.Windows.Forms.ToolTip CameraHorizontalToolTip;
    }
}

