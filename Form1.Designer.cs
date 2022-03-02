
namespace GifConverter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_Display = new System.Windows.Forms.PictureBox();
            this.pic_Frame = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Retrive = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.lbl_Frames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Display
            // 
            this.pic_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Display.Location = new System.Drawing.Point(12, 22);
            this.pic_Display.Name = "pic_Display";
            this.pic_Display.Size = new System.Drawing.Size(120, 120);
            this.pic_Display.TabIndex = 0;
            this.pic_Display.TabStop = false;
            // 
            // pic_Frame
            // 
            this.pic_Frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_Frame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Frame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Frame.Location = new System.Drawing.Point(12, 148);
            this.pic_Frame.Name = "pic_Frame";
            this.pic_Frame.Size = new System.Drawing.Size(120, 120);
            this.pic_Frame.TabIndex = 1;
            this.pic_Frame.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(139, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(392, 245);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(13, 310);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(119, 56);
            this.btn_Import.TabIndex = 3;
            this.btn_Import.Text = "Importar .gif";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Retrive
            // 
            this.btn_Retrive.Location = new System.Drawing.Point(139, 310);
            this.btn_Retrive.Name = "btn_Retrive";
            this.btn_Retrive.Size = new System.Drawing.Size(119, 56);
            this.btn_Retrive.TabIndex = 4;
            this.btn_Retrive.Text = "Convert .frame";
            this.btn_Retrive.UseVisualStyleBackColor = true;
            this.btn_Retrive.Click += new System.EventHandler(this.btn_Retrive_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(264, 309);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(267, 56);
            this.btn_Export.TabIndex = 5;
            this.btn_Export.Text = "Export ✅";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // lbl_Frames
            // 
            this.lbl_Frames.AutoSize = true;
            this.lbl_Frames.Location = new System.Drawing.Point(139, 275);
            this.lbl_Frames.Name = "lbl_Frames";
            this.lbl_Frames.Size = new System.Drawing.Size(88, 17);
            this.lbl_Frames.TabIndex = 6;
            this.lbl_Frames.Text = "Frames : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 392);
            this.Controls.Add(this.lbl_Frames);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Retrive);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pic_Frame);
            this.Controls.Add(this.pic_Display);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gif.Converte";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Display;
        private System.Windows.Forms.PictureBox pic_Frame;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Retrive;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label lbl_Frames;
    }
}

