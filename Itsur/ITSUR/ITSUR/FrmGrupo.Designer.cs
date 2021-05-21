
namespace ITSUR
{
    partial class FrmGrupo
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
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveGrupo = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.pnlId = new System.Windows.Forms.Panel();
            this.cklDias = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlId.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(52, 11);
            this.txtIdGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(91, 20);
            this.txtIdGrupo.TabIndex = 0;
            this.txtIdGrupo.TextChanged += new System.EventHandler(this.txtIdGrupo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave Grupo";
            // 
            // txtClaveGrupo
            // 
            this.txtClaveGrupo.Location = new System.Drawing.Point(127, 115);
            this.txtClaveGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClaveGrupo.MaxLength = 4;
            this.txtClaveGrupo.Name = "txtClaveGrupo";
            this.txtClaveGrupo.Size = new System.Drawing.Size(126, 20);
            this.txtClaveGrupo.TabIndex = 3;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(127, 142);
            this.txtCupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(126, 20);
            this.txtCupo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cupo";
            // 
            // cboCarrera
            // 
            this.cboCarrera.DisplayMember = "Nombre";
            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(127, 56);
            this.cboCarrera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(216, 21);
            this.cboCarrera.TabIndex = 12;
            this.cboCarrera.ValueMember = "claveCarrera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Carrera";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(127, 264);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 27);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 264);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 27);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Materia";
            // 
            // cboMateria
            // 
            this.cboMateria.DisplayMember = "Nombre";
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(127, 87);
            this.cboMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(216, 21);
            this.cboMateria.TabIndex = 17;
            this.cboMateria.ValueMember = "claveCarrera";
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.label1);
            this.pnlId.Controls.Add(this.txtIdGrupo);
            this.pnlId.Location = new System.Drawing.Point(74, 9);
            this.pnlId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(176, 37);
            this.pnlId.TabIndex = 19;
            // 
            // cklDias
            // 
            this.cklDias.FormattingEnabled = true;
            this.cklDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.cklDias.Location = new System.Drawing.Point(127, 170);
            this.cklDias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cklDias.Name = "cklDias";
            this.cklDias.Size = new System.Drawing.Size(168, 79);
            this.cklDias.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Días asignados";
            // 
            // cboHorario
            // 
            this.cboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cboHorario.Location = new System.Drawing.Point(314, 194);
            this.cboHorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(92, 21);
            this.cboHorario.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Horario";
            // 
            // FrmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 322);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboHorario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cklDias);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.txtCupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClaveGrupo);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGrupo";
            this.Text = "Grupo";
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveGrupo;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.CheckedListBox cklDias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.Label label6;
    }
}