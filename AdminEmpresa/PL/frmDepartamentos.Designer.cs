
namespace AdminEmpresa.PL
{
    partial class frmDepartamentos
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
            this.txtID_Departamento = new System.Windows.Forms.TextBox();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarDepartamento = new System.Windows.Forms.Button();
            this.btnModificarDepartamento = new System.Windows.Forms.Button();
            this.btnBorrarDepartamento = new System.Windows.Forms.Button();
            this.btnCancelarDepartamento = new System.Windows.Forms.Button();
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID_Departamento
            // 
            this.txtID_Departamento.Location = new System.Drawing.Point(16, 30);
            this.txtID_Departamento.Name = "txtID_Departamento";
            this.txtID_Departamento.Size = new System.Drawing.Size(100, 20);
            this.txtID_Departamento.TabIndex = 1;
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(144, 30);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(248, 20);
            this.txtNombreDepartamento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE DEL DEPARTAMENTO:";
            // 
            // btnAgregarDepartamento
            // 
            this.btnAgregarDepartamento.Location = new System.Drawing.Point(16, 57);
            this.btnAgregarDepartamento.Name = "btnAgregarDepartamento";
            this.btnAgregarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDepartamento.TabIndex = 4;
            this.btnAgregarDepartamento.Text = "AGREGAR";
            this.btnAgregarDepartamento.UseVisualStyleBackColor = true;
            this.btnAgregarDepartamento.Click += new System.EventHandler(this.btnAgregarDepartamento_Click);
            // 
            // btnModificarDepartamento
            // 
            this.btnModificarDepartamento.Location = new System.Drawing.Point(101, 56);
            this.btnModificarDepartamento.Name = "btnModificarDepartamento";
            this.btnModificarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnModificarDepartamento.TabIndex = 5;
            this.btnModificarDepartamento.Text = "MODIFICAR";
            this.btnModificarDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnBorrarDepartamento
            // 
            this.btnBorrarDepartamento.Location = new System.Drawing.Point(198, 56);
            this.btnBorrarDepartamento.Name = "btnBorrarDepartamento";
            this.btnBorrarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarDepartamento.TabIndex = 6;
            this.btnBorrarDepartamento.Text = "BORRAR";
            this.btnBorrarDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnCancelarDepartamento
            // 
            this.btnCancelarDepartamento.Location = new System.Drawing.Point(299, 57);
            this.btnCancelarDepartamento.Name = "btnCancelarDepartamento";
            this.btnCancelarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDepartamento.TabIndex = 7;
            this.btnCancelarDepartamento.Text = "CANCELAR";
            this.btnCancelarDepartamento.UseVisualStyleBackColor = true;
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Location = new System.Drawing.Point(13, 101);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.Size = new System.Drawing.Size(379, 212);
            this.dgvDepartamento.TabIndex = 8;
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 325);
            this.Controls.Add(this.dgvDepartamento);
            this.Controls.Add(this.btnCancelarDepartamento);
            this.Controls.Add(this.btnBorrarDepartamento);
            this.Controls.Add(this.btnModificarDepartamento);
            this.Controls.Add(this.btnAgregarDepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Controls.Add(this.txtID_Departamento);
            this.Controls.Add(this.label1);
            this.Name = "frmDepartamentos";
            this.Text = "frmDepartamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_Departamento;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarDepartamento;
        private System.Windows.Forms.Button btnModificarDepartamento;
        private System.Windows.Forms.Button btnBorrarDepartamento;
        private System.Windows.Forms.Button btnCancelarDepartamento;
        private System.Windows.Forms.DataGridView dgvDepartamento;
    }
}