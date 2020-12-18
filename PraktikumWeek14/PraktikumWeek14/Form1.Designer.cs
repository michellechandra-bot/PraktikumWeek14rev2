namespace PraktikumWeek14
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonUrutkan = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(83, 87);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(73, 29);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(88, 143);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(378, 26);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReverse.Location = new System.Drawing.Point(88, 197);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(171, 33);
            this.buttonReverse.TabIndex = 2;
            this.buttonReverse.Text = "REVERSE";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonUrutkan
            // 
            this.buttonUrutkan.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUrutkan.Location = new System.Drawing.Point(300, 197);
            this.buttonUrutkan.Name = "buttonUrutkan";
            this.buttonUrutkan.Size = new System.Drawing.Size(160, 32);
            this.buttonUrutkan.TabIndex = 3;
            this.buttonUrutkan.Text = "URUTKAN";
            this.buttonUrutkan.UseVisualStyleBackColor = true;
            this.buttonUrutkan.Click += new System.EventHandler(this.buttonUrutkan_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(84, 304);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(76, 24);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonUrutkan);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonUrutkan;
        private System.Windows.Forms.Label labelOutput;
    }
}

