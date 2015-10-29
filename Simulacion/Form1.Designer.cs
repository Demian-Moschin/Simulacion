namespace Simulacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUtilizacionServidor = new System.Windows.Forms.Label();
            this.lblTamañoPromedioCola = new System.Windows.Forms.Label();
            this.lblDemoraPromedio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graficosDeBarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relojVsClientesEnCloaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relojVsDemorasDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesAtendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colReloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientesEnCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroClientesEnSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientesAtendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTIOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcumuladorDemoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReloj,
            this.colTipoEvento,
            this.colTUE,
            this.colClientesEnCola,
            this.colNroClientesEnSistema,
            this.colClientesAtendidos,
            this.colTIOS,
            this.colAcumuladorDemoras});
            this.dataGridView1.Location = new System.Drawing.Point(11, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(888, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReiniciar.Location = new System.Drawing.Point(30, 264);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(143, 19);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Utilizacion del servidor................:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño promedio cola ..............:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Demora Promedio en el tiempo...:";
            // 
            // lblUtilizacionServidor
            // 
            this.lblUtilizacionServidor.AutoSize = true;
            this.lblUtilizacionServidor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizacionServidor.Location = new System.Drawing.Point(257, 63);
            this.lblUtilizacionServidor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUtilizacionServidor.Name = "lblUtilizacionServidor";
            this.lblUtilizacionServidor.Size = new System.Drawing.Size(50, 19);
            this.lblUtilizacionServidor.TabIndex = 5;
            this.lblUtilizacionServidor.Text = "label4";
            // 
            // lblTamañoPromedioCola
            // 
            this.lblTamañoPromedioCola.AutoSize = true;
            this.lblTamañoPromedioCola.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamañoPromedioCola.Location = new System.Drawing.Point(257, 97);
            this.lblTamañoPromedioCola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTamañoPromedioCola.Name = "lblTamañoPromedioCola";
            this.lblTamañoPromedioCola.Size = new System.Drawing.Size(50, 19);
            this.lblTamañoPromedioCola.TabIndex = 6;
            this.lblTamañoPromedioCola.Text = "label5";
            // 
            // lblDemoraPromedio
            // 
            this.lblDemoraPromedio.AutoSize = true;
            this.lblDemoraPromedio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemoraPromedio.Location = new System.Drawing.Point(257, 129);
            this.lblDemoraPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDemoraPromedio.Name = "lblDemoraPromedio";
            this.lblDemoraPromedio.Size = new System.Drawing.Size(50, 19);
            this.lblDemoraPromedio.TabIndex = 7;
            this.lblDemoraPromedio.Text = "label6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficosDeBarraToolStripMenuItem,
            this.medidasToolStripMenuItem,
            this.clientesAtendidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graficosDeBarraToolStripMenuItem
            // 
            this.graficosDeBarraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relojVsClientesEnCloaToolStripMenuItem,
            this.relojVsDemorasDeClientesToolStripMenuItem});
            this.graficosDeBarraToolStripMenuItem.Name = "graficosDeBarraToolStripMenuItem";
            this.graficosDeBarraToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.graficosDeBarraToolStripMenuItem.Text = "Graficos de barra";
            // 
            // relojVsClientesEnCloaToolStripMenuItem
            // 
            this.relojVsClientesEnCloaToolStripMenuItem.Name = "relojVsClientesEnCloaToolStripMenuItem";
            this.relojVsClientesEnCloaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.relojVsClientesEnCloaToolStripMenuItem.Text = "Reloj vs clientes en cloa";
            this.relojVsClientesEnCloaToolStripMenuItem.Click += new System.EventHandler(this.relojVsClientesEnCloaToolStripMenuItem_Click);
            // 
            // relojVsDemorasDeClientesToolStripMenuItem
            // 
            this.relojVsDemorasDeClientesToolStripMenuItem.Name = "relojVsDemorasDeClientesToolStripMenuItem";
            this.relojVsDemorasDeClientesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.relojVsDemorasDeClientesToolStripMenuItem.Text = "Reloj vs Demoras de clientes";
            this.relojVsDemorasDeClientesToolStripMenuItem.Click += new System.EventHandler(this.relojVsDemorasDeClientesToolStripMenuItem_Click);
            // 
            // medidasToolStripMenuItem
            // 
            this.medidasToolStripMenuItem.Name = "medidasToolStripMenuItem";
            this.medidasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.medidasToolStripMenuItem.Text = "Medidas ";
            // 
            // clientesAtendidosToolStripMenuItem
            // 
            this.clientesAtendidosToolStripMenuItem.Name = "clientesAtendidosToolStripMenuItem";
            this.clientesAtendidosToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.clientesAtendidosToolStripMenuItem.Text = "ClientesAtendidos";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDemoraPromedio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTamañoPromedioCola);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblUtilizacionServidor);
            this.groupBox1.Location = new System.Drawing.Point(376, 264);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(466, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte : medidas de la corrida";
            // 
            // colReloj
            // 
            this.colReloj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReloj.DataPropertyName = "colReloj";
            this.colReloj.HeaderText = "RELOJ";
            this.colReloj.Name = "colReloj";
            this.colReloj.ReadOnly = true;
            this.colReloj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReloj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.DataPropertyName = "colTipoEvento";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTipoEvento.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTipoEvento.HeaderText = "Tipo de evento";
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTUE
            // 
            this.colTUE.DataPropertyName = "colTUE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTUE.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTUE.HeaderText = "TUE";
            this.colTUE.Name = "colTUE";
            this.colTUE.ReadOnly = true;
            this.colTUE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colClientesEnCola
            // 
            this.colClientesEnCola.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colClientesEnCola.DataPropertyName = "colClientesEnCola";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colClientesEnCola.DefaultCellStyle = dataGridViewCellStyle3;
            this.colClientesEnCola.HeaderText = "Clientes en cola";
            this.colClientesEnCola.Name = "colClientesEnCola";
            this.colClientesEnCola.ReadOnly = true;
            this.colClientesEnCola.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNroClientesEnSistema
            // 
            this.colNroClientesEnSistema.DataPropertyName = "colNroClientesEnSistema";
            this.colNroClientesEnSistema.HeaderText = "ClientesEnSistema";
            this.colNroClientesEnSistema.Name = "colNroClientesEnSistema";
            // 
            // colClientesAtendidos
            // 
            this.colClientesAtendidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colClientesAtendidos.DataPropertyName = "colClientesAtendidos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colClientesAtendidos.DefaultCellStyle = dataGridViewCellStyle4;
            this.colClientesAtendidos.HeaderText = "ClientesAtendidos";
            this.colClientesAtendidos.Name = "colClientesAtendidos";
            this.colClientesAtendidos.ReadOnly = true;
            this.colClientesAtendidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTIOS
            // 
            this.colTIOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTIOS.DataPropertyName = "colTIOS";
            this.colTIOS.HeaderText = "TIOS";
            this.colTIOS.Name = "colTIOS";
            this.colTIOS.ReadOnly = true;
            this.colTIOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAcumuladorDemoras
            // 
            this.colAcumuladorDemoras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAcumuladorDemoras.DataPropertyName = "colAcumuladorDemoras";
            this.colAcumuladorDemoras.HeaderText = "AcumuladorDemoras";
            this.colAcumuladorDemoras.Name = "colAcumuladorDemoras";
            this.colAcumuladorDemoras.ReadOnly = true;
            this.colAcumuladorDemoras.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(910, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Simulacion 4\\ Lara ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUtilizacionServidor;
        private System.Windows.Forms.Label lblTamañoPromedioCola;
        private System.Windows.Forms.Label lblDemoraPromedio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graficosDeBarraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relojVsClientesEnCloaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relojVsDemorasDeClientesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem clientesAtendidosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientesEnCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroClientesEnSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientesAtendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTIOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcumuladorDemoras;

    }
}

