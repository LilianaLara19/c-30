namespace listview2
{
    partial class rbtfrutas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstvalimentos = new System.Windows.Forms.ListView();
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.gbgrupos = new System.Windows.Forms.GroupBox();
            this.rdbtnFrutas = new System.Windows.Forms.RadioButton();
            this.rdbtnCarnes = new System.Windows.Forms.RadioButton();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.gbgrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvalimentos
            // 
            this.lstvalimentos.HideSelection = false;
            this.lstvalimentos.Location = new System.Drawing.Point(1, -1);
            this.lstvalimentos.Name = "lstvalimentos";
            this.lstvalimentos.Size = new System.Drawing.Size(373, 234);
            this.lstvalimentos.TabIndex = 0;
            this.lstvalimentos.UseCompatibleStateImageBehavior = false;
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(12, 262);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(100, 20);
            this.txtelemento.TabIndex = 1;
            this.txtelemento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbgrupos
            // 
            this.gbgrupos.Controls.Add(this.rdbtnCarnes);
            this.gbgrupos.Controls.Add(this.btnadicionar);
            this.gbgrupos.Controls.Add(this.rdbtnFrutas);
            this.gbgrupos.Location = new System.Drawing.Point(174, 239);
            this.gbgrupos.Name = "gbgrupos";
            this.gbgrupos.Size = new System.Drawing.Size(200, 100);
            this.gbgrupos.TabIndex = 2;
            this.gbgrupos.TabStop = false;
            this.gbgrupos.Text = "grupos";
            this.gbgrupos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbtnFrutas
            // 
            this.rdbtnFrutas.AutoSize = true;
            this.rdbtnFrutas.Checked = true;
            this.rdbtnFrutas.Location = new System.Drawing.Point(6, 24);
            this.rdbtnFrutas.Name = "rdbtnFrutas";
            this.rdbtnFrutas.Size = new System.Drawing.Size(51, 17);
            this.rdbtnFrutas.TabIndex = 3;
            this.rdbtnFrutas.TabStop = true;
            this.rdbtnFrutas.Text = "frutas";
            this.rdbtnFrutas.UseVisualStyleBackColor = true;
            // 
            // rdbtnCarnes
            // 
            this.rdbtnCarnes.AutoSize = true;
            this.rdbtnCarnes.Location = new System.Drawing.Point(6, 53);
            this.rdbtnCarnes.Name = "rdbtnCarnes";
            this.rdbtnCarnes.Size = new System.Drawing.Size(58, 17);
            this.rdbtnCarnes.TabIndex = 3;
            this.rdbtnCarnes.TabStop = true;
            this.rdbtnCarnes.Text = "Carnes";
            this.rdbtnCarnes.UseVisualStyleBackColor = true;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(92, 24);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 4;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // rbtfrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbgrupos);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.lstvalimentos);
            this.Name = "rbtfrutas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.rbtfrutas_Load);
            this.gbgrupos.ResumeLayout(false);
            this.gbgrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvalimentos;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.GroupBox gbgrupos;
        private System.Windows.Forms.RadioButton rdbtnFrutas;
        private System.Windows.Forms.RadioButton rdbtnCarnes;
        private System.Windows.Forms.Button btnadicionar;
    }
}

