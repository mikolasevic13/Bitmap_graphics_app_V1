
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
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DUPLOsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.randimage_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DECODE_A = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox1, "To load the image into picturebox A, double click and follow the instructions. \r\n" +
        "");
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Location = new System.Drawing.Point(959, 520);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(291, 23);
            this.buttonSAVE.TabIndex = 2;
            this.buttonSAVE.Text = "SAVE B";
            this.toolTip1.SetToolTip(this.buttonSAVE, "Save image B to file.\r\n");
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.buttonSAVE_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(660, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(590, 460);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.toolTip3.SetToolTip(this.pictureBox2, "To load the image into picturebox B, double click and follow the instructions.\r\n");
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // DUPLOsave
            // 
            this.DUPLOsave.Location = new System.Drawing.Point(959, 549);
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
            this.label2.Location = new System.Drawing.Point(280, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(935, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 42);
            this.label3.TabIndex = 15;
            this.label3.Text = "B";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(959, 578);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(291, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "APPEND A & B images VERTICALLY";
            this.toolTip5.SetToolTip(this.button7, "Appends images A and B vertically and saves them to local file");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            // randimage_btn
            // 
            this.randimage_btn.Location = new System.Drawing.Point(17, 520);
            this.randimage_btn.Name = "randimage_btn";
            this.randimage_btn.Size = new System.Drawing.Size(291, 23);
            this.randimage_btn.TabIndex = 1;
            this.randimage_btn.Text = "Random image - INPUT IMAGE";
            this.randimage_btn.UseVisualStyleBackColor = true;
            this.randimage_btn.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 578);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 71);
            this.textBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ORIGINAL USER MESSAGE:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "CODE MESSAGE A to B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "DECODED USER MESSAGE:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(485, 578);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 71);
            this.textBox2.TabIndex = 22;
            // 
            // DECODE_A
            // 
            this.DECODE_A.Location = new System.Drawing.Point(799, 578);
            this.DECODE_A.Name = "DECODE_A";
            this.DECODE_A.Size = new System.Drawing.Size(133, 23);
            this.DECODE_A.TabIndex = 24;
            this.DECODE_A.Text = "DECODE image A";
            this.DECODE_A.UseVisualStyleBackColor = true;
            this.DECODE_A.Click += new System.EventHandler(this.DECODE_A_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 686);
            this.Controls.Add(this.DECODE_A);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DUPLOsave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.randimage_btn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "BITstring";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSAVE;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DUPLOsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Button randimage_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DECODE_A;
    }
}

