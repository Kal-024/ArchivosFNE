namespace FlujoNetoSinFinanciamiento
{
    partial class FNE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNE));
            this.dgvFNE = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInversion = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtInflacion = new System.Windows.Forms.TextBox();
            this.txtVS = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtVPN = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtIdentifc = new System.Windows.Forms.TextBox();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFNE
            // 
            this.dgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFNE.Location = new System.Drawing.Point(322, 66);
            this.dgvFNE.Name = "dgvFNE";
            this.dgvFNE.Size = new System.Drawing.Size(755, 430);
            this.dgvFNE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "FLUJO NETO SIN FINANCIAMIENTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1231, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "INVERSIÓN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PLAZO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "TASA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "INFLACIÓN (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "VALOR DE SALVAMENTO";
            // 
            // txtInversion
            // 
            this.txtInversion.Location = new System.Drawing.Point(82, 107);
            this.txtInversion.Name = "txtInversion";
            this.txtInversion.Size = new System.Drawing.Size(210, 20);
            this.txtInversion.TabIndex = 8;
            this.txtInversion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInversion_KeyPress);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(82, 300);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(210, 20);
            this.txtPlazo.TabIndex = 9;
            this.txtPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlazo_KeyPress);
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(82, 357);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(210, 20);
            this.txtTasa.TabIndex = 10;
            this.txtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTasa_KeyPress);
            // 
            // txtInflacion
            // 
            this.txtInflacion.Location = new System.Drawing.Point(82, 418);
            this.txtInflacion.Name = "txtInflacion";
            this.txtInflacion.Size = new System.Drawing.Size(210, 20);
            this.txtInflacion.TabIndex = 11;
            this.txtInflacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInflacion_KeyPress);
            // 
            // txtVS
            // 
            this.txtVS.Location = new System.Drawing.Point(82, 476);
            this.txtVS.Name = "txtVS";
            this.txtVS.Size = new System.Drawing.Size(210, 20);
            this.txtVS.TabIndex = 12;
            this.txtVS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVS_KeyPress);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(371, 502);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(210, 44);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.txtVPN);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.txtIdentifc);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(696, 502);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 43);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "VPN";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtVPN
            // 
            this.txtVPN.Location = new System.Drawing.Point(84, 3);
            this.txtVPN.Name = "txtVPN";
            this.txtVPN.Size = new System.Drawing.Size(100, 20);
            this.txtVPN.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(190, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "PR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtIdentifc
            // 
            this.txtIdentifc.Location = new System.Drawing.Point(271, 3);
            this.txtIdentifc.Name = "txtIdentifc";
            this.txtIdentifc.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifc.TabIndex = 3;
            // 
            // txtEgresos
            // 
            this.txtEgresos.Location = new System.Drawing.Point(82, 236);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(210, 20);
            this.txtEgresos.TabIndex = 15;
            this.txtEgresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEgresos_KeyPress);
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(82, 170);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(210, 20);
            this.txtIngresos.TabIndex = 16;
            this.txtIngresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIngresos_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "EGRESOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "INGRESOS";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(12, 532);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 19;
            // 
            // FNE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 557);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.txtEgresos);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtVS);
            this.Controls.Add(this.txtInflacion);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.txtInversion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFNE);
            this.Name = "FNE";
            this.Text = ".....";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFNE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInversion;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtInflacion;
        private System.Windows.Forms.TextBox txtVS;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtVPN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtIdentifc;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtId;
    }
}

