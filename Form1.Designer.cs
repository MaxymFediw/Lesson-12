namespace Lesson_12
{
    partial class Lesson12
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
            this.lbltem = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnFinalPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltem
            // 
            this.lbltem.AutoSize = true;
            this.lbltem.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltem.Location = new System.Drawing.Point(23, 41);
            this.lbltem.Name = "lbltem";
            this.lbltem.Size = new System.Drawing.Size(94, 13);
            this.lbltem.TabIndex = 0;
            this.lbltem.Text = "Enter Item Name:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(140, 86);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(140, 61);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(140, 38);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(120, 20);
            this.txtItem.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(23, 68);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Enter A Price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(23, 93);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(97, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Number Of Items:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(23, 156);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(62, 13);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "Final Price:";
            // 
            // btnFinalPrice
            // 
            this.btnFinalPrice.BackColor = System.Drawing.Color.Azure;
            this.btnFinalPrice.Font = new System.Drawing.Font("Nirmala Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinalPrice.Location = new System.Drawing.Point(26, 112);
            this.btnFinalPrice.Name = "btnFinalPrice";
            this.btnFinalPrice.Size = new System.Drawing.Size(234, 41);
            this.btnFinalPrice.TabIndex = 7;
            this.btnFinalPrice.Text = "Calculate Final Price";
            this.btnFinalPrice.UseVisualStyleBackColor = false;
            this.btnFinalPrice.Click += new System.EventHandler(this.btnFinalPrice_Click);
            // 
            // Lesson12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(287, 192);
            this.Controls.Add(this.btnFinalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbltem);
            this.Name = "Lesson12";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnFinalPrice;
    }
}

