
namespace ADMBifa.View
{
    partial class ListagemColaboradores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procurar";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(65, 28);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(723, 20);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.AllowUserToAddRows = false;
            this.dgvColaboradores.AllowUserToDeleteRows = false;
            this.dgvColaboradores.AllowUserToOrderColumns = true;
            this.dgvColaboradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Location = new System.Drawing.Point(15, 55);
            this.dgvColaboradores.MultiSelect = false;
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.ReadOnly = true;
            this.dgvColaboradores.Size = new System.Drawing.Size(768, 385);
            this.dgvColaboradores.TabIndex = 2;
            // 
            // ListagemColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.dgvColaboradores);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label1);
            this.Name = "ListagemColaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Procurados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvColaboradores;
    }
}