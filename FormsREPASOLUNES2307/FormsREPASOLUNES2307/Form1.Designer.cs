
namespace FormsREPASOLUNES2307
{
    partial class Form1
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
            this.cbSEARCH = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.btnRESET = new System.Windows.Forms.Button();
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.txtIDCLIENTE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPELLIDOS = new System.Windows.Forms.TextBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnNEW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSEARCH
            // 
            this.cbSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSEARCH.FormattingEnabled = true;
            this.cbSEARCH.Items.AddRange(new object[] {
            "IDCLIENTE",
            "NOMBRE",
            "APELLIDOS"});
            this.cbSEARCH.Location = new System.Drawing.Point(13, 13);
            this.cbSEARCH.Name = "cbSEARCH";
            this.cbSEARCH.Size = new System.Drawing.Size(121, 24);
            this.cbSEARCH.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(159, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(344, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEARCH.Location = new System.Drawing.Point(529, 8);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(75, 27);
            this.btnSEARCH.TabIndex = 2;
            this.btnSEARCH.Text = "BUSCAR";
            this.btnSEARCH.UseVisualStyleBackColor = true;
            // 
            // btnRESET
            // 
            this.btnRESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRESET.Location = new System.Drawing.Point(635, 8);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(75, 27);
            this.btnRESET.TabIndex = 3;
            this.btnRESET.Text = "RESET";
            this.btnRESET.UseVisualStyleBackColor = true;
            // 
            // GridDatos
            // 
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(13, 54);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.Size = new System.Drawing.Size(490, 243);
            this.GridDatos.TabIndex = 4;
            // 
            // txtIDCLIENTE
            // 
            this.txtIDCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCLIENTE.Location = new System.Drawing.Point(626, 57);
            this.txtIDCLIENTE.Name = "txtIDCLIENTE";
            this.txtIDCLIENTE.Size = new System.Drawing.Size(177, 22);
            this.txtIDCLIENTE.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IDCLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOMBRE";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOMBRE.Location = new System.Drawing.Point(626, 98);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(177, 22);
            this.txtNOMBRE.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "APELLIDOS";
            // 
            // txtAPELLIDOS
            // 
            this.txtAPELLIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPELLIDOS.Location = new System.Drawing.Point(626, 142);
            this.txtAPELLIDOS.Name = "txtAPELLIDOS";
            this.txtAPELLIDOS.Size = new System.Drawing.Size(177, 22);
            this.txtAPELLIDOS.TabIndex = 9;
            // 
            // btnEXIT
            // 
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(741, 8);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(75, 27);
            this.btnEXIT.TabIndex = 11;
            this.btnEXIT.Text = "SALIR";
            this.btnEXIT.UseVisualStyleBackColor = true;
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Location = new System.Drawing.Point(681, 190);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(135, 27);
            this.btnADD.TabIndex = 12;
            this.btnADD.Text = "AGREGAR";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(529, 234);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(135, 27);
            this.btnDELETE.TabIndex = 13;
            this.btnDELETE.Text = "ELIMINAR";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Location = new System.Drawing.Point(681, 234);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(135, 27);
            this.btnUPDATE.TabIndex = 14;
            this.btnUPDATE.Text = "MODIFICAR";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnNEW
            // 
            this.btnNEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNEW.Location = new System.Drawing.Point(529, 190);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(135, 27);
            this.btnNEW.TabIndex = 15;
            this.btnNEW.Text = "NUEVO";
            this.btnNEW.UseVisualStyleBackColor = true;
            this.btnNEW.Click += new System.EventHandler(this.btnNEW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 308);
            this.Controls.Add(this.btnNEW);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAPELLIDOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDCLIENTE);
            this.Controls.Add(this.GridDatos);
            this.Controls.Add(this.btnRESET);
            this.Controls.Add(this.btnSEARCH);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSEARCH);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSEARCH;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.TextBox txtIDCLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPELLIDOS;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnNEW;
    }
}

