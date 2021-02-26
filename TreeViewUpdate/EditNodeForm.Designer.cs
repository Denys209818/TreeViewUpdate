
namespace TreeViewUpdate
{
    partial class EditNodeForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbParents = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(13, 69);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Назва";
            this.txtName.Size = new System.Drawing.Size(366, 41);
            this.txtName.TabIndex = 0;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMain.Location = new System.Drawing.Point(101, 13);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(189, 28);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Редагування ноди";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(101, 256);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(189, 63);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Змінити";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbParents
            // 
            this.cbParents.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbParents.FormattingEnabled = true;
            this.cbParents.Location = new System.Drawing.Point(13, 147);
            this.cbParents.Name = "cbParents";
            this.cbParents.Size = new System.Drawing.Size(366, 43);
            this.cbParents.TabIndex = 3;
            // 
            // EditNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 341);
            this.Controls.Add(this.cbParents);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.txtName);
            this.Name = "EditNodeForm";
            this.Text = "Редагування ноди";
            this.Load += new System.EventHandler(this.EditNodeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbParents;
    }
}