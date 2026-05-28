namespace Supermercado
{
    partial class FormNota
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
            txtNota = new TextBox();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(12, 36);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.ScrollBars = ScrollBars.Vertical;
            txtNota.Size = new Size(408, 485);
            txtNota.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(108, 554);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(188, 41);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // FormNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 620);
            Controls.Add(btnFechar);
            Controls.Add(txtNota);
            Name = "FormNota";
            Text = "FormNota";
            Load += FormNota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota;
        private Button btnFechar;
    }
}