
namespace Bitmap_slika_meta1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPaint = new System.Windows.Forms.Button();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.blurbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7_CrveniNIVO = new System.Windows.Forms.Button();
            this.DUPLOsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox1, "To load the image into picturebox A, double click and follow the instructions. \r\n" +
        "");
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(660, 596);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(291, 23);
            this.btnPaint.TabIndex = 1;
            this.btnPaint.Text = "Paint Bullseye";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Location = new System.Drawing.Point(959, 596);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(291, 23);
            this.buttonSAVE.TabIndex = 2;
            this.buttonSAVE.Text = "SAVE B";
            this.toolTip1.SetToolTip(this.buttonSAVE, "Save image B to file.\r\n");
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.buttonSAVE_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "INVERSE FILTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(660, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(590, 460);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.toolTip3.SetToolTip(this.pictureBox2, "To load the image into picturebox B, double click and follow the instructions.\r\n");
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // blurbtn
            // 
            this.blurbtn.Location = new System.Drawing.Point(16, 596);
            this.blurbtn.Name = "blurbtn";
            this.blurbtn.Size = new System.Drawing.Size(291, 23);
            this.blurbtn.TabIndex = 5;
            this.blurbtn.Text = "Grayscale";
            this.blurbtn.UseVisualStyleBackColor = true;
            this.blurbtn.Click += new System.EventHandler(this.blurbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "CONTOUR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 625);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "GREEN filter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(311, 654);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(291, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "RED filter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 654);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(291, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "BLUE filter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(311, 683);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(291, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "AVERAGE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7_CrveniNIVO
            // 
            this.button7_CrveniNIVO.Location = new System.Drawing.Point(15, 683);
            this.button7_CrveniNIVO.Name = "button7_CrveniNIVO";
            this.button7_CrveniNIVO.Size = new System.Drawing.Size(291, 23);
            this.button7_CrveniNIVO.TabIndex = 11;
            this.button7_CrveniNIVO.Text = "RED LEVEL";
            this.button7_CrveniNIVO.UseVisualStyleBackColor = true;
            this.button7_CrveniNIVO.Click += new System.EventHandler(this.button7_CrveniNIVO_Click);
            // 
            // DUPLOsave
            // 
            this.DUPLOsave.Location = new System.Drawing.Point(959, 625);
            this.DUPLOsave.Name = "DUPLOsave";
            this.DUPLOsave.Size = new System.Drawing.Size(291, 23);
            this.DUPLOsave.TabIndex = 12;
            this.DUPLOsave.Text = "APPEND A & B images HORIZONTALLY";
            this.toolTip4.SetToolTip(this.DUPLOsave, "Appends images A and B horizontally and saves them to local file");
            this.DUPLOsave.UseVisualStyleBackColor = true;
            this.DUPLOsave.Click += new System.EventHandler(this.DUPLOsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(933, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 42);
            this.label3.TabIndex = 15;
            this.label3.Text = "B";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(959, 654);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(291, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "APPEND A & B images VERTICALLY";
            this.toolTip5.SetToolTip(this.button7, "Appends images A and B vertically and saves them to local file");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1228, 74);
            this.label1.TabIndex = 17;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipTitle = "LOAD IMAGE A";
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ToolTipTitle = "LOAD IMAGE B";
            // 
            // toolTip4
            // 
            this.toolTip4.ToolTipTitle = "APPEND A & B horizontally";
            // 
            // toolTip5
            // 
            this.toolTip5.ToolTipTitle = "APPEND A & B vertically";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DUPLOsave);
            this.Controls.Add(this.button7_CrveniNIVO);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.blurbtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Bitmap Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button buttonSAVE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button blurbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7_CrveniNIVO;
        private System.Windows.Forms.Button DUPLOsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}

