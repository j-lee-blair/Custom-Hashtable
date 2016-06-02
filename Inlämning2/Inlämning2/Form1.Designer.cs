namespace Inlämning2
{
    partial class Form1
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
            this.txt_Box_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Box_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Trans = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Box_Translate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Box_Value = new System.Windows.Forms.TextBox();
            this.lbl_Element_Count = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Box_Key
            // 
            this.txt_Box_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Key.Location = new System.Drawing.Point(261, 53);
            this.txt_Box_Key.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Box_Key.Name = "txt_Box_Key";
            this.txt_Box_Key.Size = new System.Drawing.Size(272, 38);
            this.txt_Box_Key.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Key";
            // 
            // txt_Box_Add
            // 
            this.txt_Box_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Add.Location = new System.Drawing.Point(16, 214);
            this.txt_Box_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Box_Add.Name = "txt_Box_Add";
            this.txt_Box_Add.Size = new System.Drawing.Size(184, 39);
            this.txt_Box_Add.TabIndex = 2;
            this.txt_Box_Add.Text = "Add";
            this.txt_Box_Add.UseVisualStyleBackColor = true;
            this.txt_Box_Add.Click += new System.EventHandler(this.txt_Box_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(205, 215);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(184, 38);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Trans
            // 
            this.btn_Trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trans.Location = new System.Drawing.Point(396, 215);
            this.btn_Trans.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Trans.Name = "btn_Trans";
            this.btn_Trans.Size = new System.Drawing.Size(184, 38);
            this.btn_Trans.TabIndex = 4;
            this.btn_Trans.Text = "Translate";
            this.btn_Trans.UseVisualStyleBackColor = true;
            this.btn_Trans.Click += new System.EventHandler(this.btn_Trans_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Box_Translate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Box_Value);
            this.panel1.Controls.Add(this.lbl_Element_Count);
            this.panel1.Controls.Add(this.lbl_info);
            this.panel1.Controls.Add(this.txt_Box_Add);
            this.panel1.Controls.Add(this.btn_Remove);
            this.panel1.Controls.Add(this.btn_Trans);
            this.panel1.Location = new System.Drawing.Point(13, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 278);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Translate";
            // 
            // txt_Box_Translate
            // 
            this.txt_Box_Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Translate.Location = new System.Drawing.Point(248, 149);
            this.txt_Box_Translate.Name = "txt_Box_Translate";
            this.txt_Box_Translate.Size = new System.Drawing.Size(272, 38);
            this.txt_Box_Translate.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Value";
            // 
            // txt_Box_Value
            // 
            this.txt_Box_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Value.Location = new System.Drawing.Point(248, 86);
            this.txt_Box_Value.Name = "txt_Box_Value";
            this.txt_Box_Value.Size = new System.Drawing.Size(272, 38);
            this.txt_Box_Value.TabIndex = 9;
            // 
            // lbl_Element_Count
            // 
            this.lbl_Element_Count.AutoSize = true;
            this.lbl_Element_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Element_Count.Location = new System.Drawing.Point(554, 4);
            this.lbl_Element_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Element_Count.Name = "lbl_Element_Count";
            this.lbl_Element_Count.Size = new System.Drawing.Size(0, 20);
            this.lbl_Element_Count.TabIndex = 6;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(425, 4);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(129, 20);
            this.lbl_info.TabIndex = 5;
            this.lbl_info.Text = "Elements in list:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Box_Key);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Hash Table";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Box_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txt_Box_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Trans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Element_Count;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txt_Box_Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Box_Translate;
    }
}

