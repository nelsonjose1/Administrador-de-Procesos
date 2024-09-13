namespace TaskManager
{
    partial class RunTarea
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
            this.abrir = new System.Windows.Forms.Label();
            this.txtEjecutar = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abrir
            // 
            this.abrir.AutoSize = true;
            this.abrir.Location = new System.Drawing.Point(39, 36);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(28, 13);
            this.abrir.TabIndex = 0;
            this.abrir.Text = "Abrir";
            // 
            // txtEjecutar
            // 
            this.txtEjecutar.Location = new System.Drawing.Point(118, 33);
            this.txtEjecutar.Name = "txtEjecutar";
            this.txtEjecutar.Size = new System.Drawing.Size(455, 20);
            this.txtEjecutar.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEjecutar.Location = new System.Drawing.Point(251, 98);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // RunTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 199);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtEjecutar);
            this.Controls.Add(this.abrir);
            this.Name = "RunTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RunTarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abrir;
        private System.Windows.Forms.TextBox txtEjecutar;
        private System.Windows.Forms.Button btnEjecutar;
    }
}