namespace Catalogo_de_comercio
{
    partial class Catalogo
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.modificarArt = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.txtFiltroAv = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAv = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArt = new System.Windows.Forms.PictureBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.txtbFiltro = new System.Windows.Forms.TextBox();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(41, 467);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // modificarArt
            // 
            this.modificarArt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modificarArt.Location = new System.Drawing.Point(211, 467);
            this.modificarArt.Margin = new System.Windows.Forms.Padding(10);
            this.modificarArt.Name = "modificarArt";
            this.modificarArt.Size = new System.Drawing.Size(117, 23);
            this.modificarArt.TabIndex = 1;
            this.modificarArt.Text = "Modificar Articulo";
            this.modificarArt.UseVisualStyleBackColor = true;
            this.modificarArt.Click += new System.EventHandler(this.modificarArt_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(367, 467);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(38, 512);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(6);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 3;
            this.lblCampo.Text = "Campo";
            // 
            // txtFiltroAv
            // 
            this.txtFiltroAv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFiltroAv.Location = new System.Drawing.Point(663, 509);
            this.txtFiltroAv.Margin = new System.Windows.Forms.Padding(6);
            this.txtFiltroAv.Name = "txtFiltroAv";
            this.txtFiltroAv.Size = new System.Drawing.Size(135, 22);
            this.txtFiltroAv.TabIndex = 4;
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(308, 512);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(6);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 5;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltroAv
            // 
            this.lblFiltroAv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFiltroAv.AutoSize = true;
            this.lblFiltroAv.Location = new System.Drawing.Point(580, 512);
            this.lblFiltroAv.Margin = new System.Windows.Forms.Padding(6);
            this.lblFiltroAv.Name = "lblFiltroAv";
            this.lblFiltroAv.Size = new System.Drawing.Size(52, 16);
            this.lblFiltroAv.TabIndex = 6;
            this.lblFiltroAv.Text = "FiltroAv";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 40);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(727, 405);
            this.dgvArticulos.TabIndex = 9;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArt
            // 
            this.pbxArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxArt.Location = new System.Drawing.Point(745, 47);
            this.pbxArt.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.pbxArt.MaximumSize = new System.Drawing.Size(440, 390);
            this.pbxArt.MinimumSize = new System.Drawing.Size(440, 390);
            this.pbxArt.Name = "pbxArt";
            this.pbxArt.Size = new System.Drawing.Size(440, 390);
            this.pbxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArt.TabIndex = 10;
            this.pbxArt.TabStop = false;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltro.Location = new System.Drawing.Point(829, 509);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(6);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 13;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblfiltro
            // 
            this.lblfiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(190, 9);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(36, 16);
            this.lblfiltro.TabIndex = 12;
            this.lblfiltro.Text = "Filtro";
            // 
            // txtbFiltro
            // 
            this.txtbFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbFiltro.Location = new System.Drawing.Point(257, 6);
            this.txtbFiltro.Name = "txtbFiltro";
            this.txtbFiltro.Size = new System.Drawing.Size(241, 22);
            this.txtbFiltro.TabIndex = 11;
            this.txtbFiltro.TextChanged += new System.EventHandler(this.txtbFiltro_TextChanged);
            // 
            // cboxCampo
            // 
            this.cboxCampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(120, 508);
            this.cboxCampo.Margin = new System.Windows.Forms.Padding(6);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(157, 24);
            this.cboxCampo.TabIndex = 14;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(388, 508);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(6);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(161, 24);
            this.cboCriterio.TabIndex = 15;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 555);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboxCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.txtbFiltro);
            this.Controls.Add(this.pbxArt);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblFiltroAv);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.txtFiltroAv);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.modificarArt);
            this.Controls.Add(this.btnAgregar);
            this.MinimumSize = new System.Drawing.Size(1219, 602);
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button modificarArt;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.TextBox txtFiltroAv;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAv;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArt;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.TextBox txtbFiltro;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
    }
}

