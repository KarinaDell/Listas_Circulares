namespace Listas_Circulares
{
    partial class frmRoute
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.bttnRemoveLast = new System.Windows.Forms.Button();
            this.bttnRemoveFirst = new System.Windows.Forms.Button();
            this.bttnList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.horaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.horaFin = new System.Windows.Forms.DateTimePicker();
            this.txtBaseInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(62, 48);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(76, 20);
            this.txtDuration.TabIndex = 1;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(310, 101);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(60, 26);
            this.bttnAdd.TabIndex = 2;
            this.bttnAdd.Text = "Agregar";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(310, 131);
            this.bttnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(60, 26);
            this.bttnSearch.TabIndex = 3;
            this.bttnSearch.Text = "Buscar";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // txtOutcome
            // 
            this.txtOutcome.Location = new System.Drawing.Point(11, 101);
            this.txtOutcome.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutcome.Multiline = true;
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.ReadOnly = true;
            this.txtOutcome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutcome.Size = new System.Drawing.Size(280, 218);
            this.txtOutcome.TabIndex = 7;
            // 
            // bttnRemoveLast
            // 
            this.bttnRemoveLast.Location = new System.Drawing.Point(310, 237);
            this.bttnRemoveLast.Margin = new System.Windows.Forms.Padding(2);
            this.bttnRemoveLast.Name = "bttnRemoveLast";
            this.bttnRemoveLast.Size = new System.Drawing.Size(60, 42);
            this.bttnRemoveLast.TabIndex = 4;
            this.bttnRemoveLast.Text = "Eliminar Ultimo";
            this.bttnRemoveLast.UseVisualStyleBackColor = true;
            this.bttnRemoveLast.Click += new System.EventHandler(this.bttnRemoveLast_Click);
            // 
            // bttnRemoveFirst
            // 
            this.bttnRemoveFirst.Location = new System.Drawing.Point(310, 191);
            this.bttnRemoveFirst.Margin = new System.Windows.Forms.Padding(2);
            this.bttnRemoveFirst.Name = "bttnRemoveFirst";
            this.bttnRemoveFirst.Size = new System.Drawing.Size(60, 42);
            this.bttnRemoveFirst.TabIndex = 5;
            this.bttnRemoveFirst.Text = "Eliminar Primero";
            this.bttnRemoveFirst.UseVisualStyleBackColor = true;
            this.bttnRemoveFirst.Click += new System.EventHandler(this.bttnRemoveFirst_Click);
            // 
            // bttnList
            // 
            this.bttnList.Location = new System.Drawing.Point(310, 161);
            this.bttnList.Margin = new System.Windows.Forms.Padding(2);
            this.bttnList.Name = "bttnList";
            this.bttnList.Size = new System.Drawing.Size(60, 26);
            this.bttnList.TabIndex = 6;
            this.bttnList.Text = "Listar";
            this.bttnList.UseVisualStyleBackColor = true;
            this.bttnList.Click += new System.EventHandler(this.bttnList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Duracion:";
            // 
            // horaInicio
            // 
            this.horaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaInicio.Location = new System.Drawing.Point(221, 41);
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.Size = new System.Drawing.Size(109, 20);
            this.horaInicio.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora final:";
            // 
            // horaFin
            // 
            this.horaFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaFin.Location = new System.Drawing.Point(221, 69);
            this.horaFin.Name = "horaFin";
            this.horaFin.Size = new System.Drawing.Size(109, 20);
            this.horaFin.TabIndex = 10;
            // 
            // txtBaseInicio
            // 
            this.txtBaseInicio.Location = new System.Drawing.Point(221, 15);
            this.txtBaseInicio.Name = "txtBaseInicio";
            this.txtBaseInicio.Size = new System.Drawing.Size(109, 20);
            this.txtBaseInicio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Base inicio:";
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(310, 284);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(60, 35);
            this.btnRuta.TabIndex = 12;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // frmRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 331);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtBaseInicio);
            this.Controls.Add(this.horaFin);
            this.Controls.Add(this.horaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnList);
            this.Controls.Add(this.bttnRemoveFirst);
            this.Controls.Add(this.bttnRemoveLast);
            this.Controls.Add(this.txtOutcome);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRoute";
            this.Text = "Ruta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.Button bttnRemoveLast;
        private System.Windows.Forms.Button bttnRemoveFirst;
        private System.Windows.Forms.Button bttnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker horaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker horaFin;
        private System.Windows.Forms.TextBox txtBaseInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRuta;
    }
}

