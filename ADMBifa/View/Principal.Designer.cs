
namespace ADMBifa
{
    partial class FormPrincipal
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
            this.btnCadastarColaborador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastarColaborador
            // 
            this.btnCadastarColaborador.Location = new System.Drawing.Point(19, 26);
            this.btnCadastarColaborador.Name = "btnCadastarColaborador";
            this.btnCadastarColaborador.Size = new System.Drawing.Size(144, 34);
            this.btnCadastarColaborador.TabIndex = 0;
            this.btnCadastarColaborador.Text = "Cadastrar Colaborador";
            this.btnCadastarColaborador.UseVisualStyleBackColor = true;
            this.btnCadastarColaborador.Click += new System.EventHandler(this.btnCadastarColaborador_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastarColaborador);
            this.Name = "FormPrincipal";
            this.Text = "ADMBifa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastarColaborador;
    }
}

