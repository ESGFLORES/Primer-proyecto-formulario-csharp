
namespace Primer_proyecto_formulario_csharp
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
            this.btnGrupo = new System.Windows.Forms.Button();
            this.lblEduardoGarcia = new System.Windows.Forms.Label();
            this.lblMiguelRuiz = new System.Windows.Forms.Label();
            this.lblDimasRosales = new System.Windows.Forms.Label();
            this.lblKleverMontano = new System.Windows.Forms.Label();
            this.lblEmelyRodriguez = new System.Windows.Forms.Label();
            this.lblMiguelQuinteros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGrupo
            // 
            this.btnGrupo.Location = new System.Drawing.Point(142, 79);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(136, 23);
            this.btnGrupo.TabIndex = 6;
            this.btnGrupo.Text = "Mostrar Integrantes";
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEduardoGarcia
            // 
            this.lblEduardoGarcia.AutoSize = true;
            this.lblEduardoGarcia.Location = new System.Drawing.Point(81, 149);
            this.lblEduardoGarcia.Name = "lblEduardoGarcia";
            this.lblEduardoGarcia.Size = new System.Drawing.Size(19, 13);
            this.lblEduardoGarcia.TabIndex = 7;
            this.lblEduardoGarcia.Text = "¿?";
            // 
            // lblMiguelRuiz
            // 
            this.lblMiguelRuiz.AutoSize = true;
            this.lblMiguelRuiz.Location = new System.Drawing.Point(191, 149);
            this.lblMiguelRuiz.Name = "lblMiguelRuiz";
            this.lblMiguelRuiz.Size = new System.Drawing.Size(19, 13);
            this.lblMiguelRuiz.TabIndex = 9;
            this.lblMiguelRuiz.Text = "¿?";
            // 
            // lblDimasRosales
            // 
            this.lblDimasRosales.AutoSize = true;
            this.lblDimasRosales.Location = new System.Drawing.Point(303, 149);
            this.lblDimasRosales.Name = "lblDimasRosales";
            this.lblDimasRosales.Size = new System.Drawing.Size(19, 13);
            this.lblDimasRosales.TabIndex = 10;
            this.lblDimasRosales.Text = "¿?";
            // 
            // lblKleverMontano
            // 
            this.lblKleverMontano.AutoSize = true;
            this.lblKleverMontano.Location = new System.Drawing.Point(84, 234);
            this.lblKleverMontano.Name = "lblKleverMontano";
            this.lblKleverMontano.Size = new System.Drawing.Size(19, 13);
            this.lblKleverMontano.TabIndex = 11;
            this.lblKleverMontano.Text = "¿?";
            // 
            // lblEmelyRodriguez
            // 
            this.lblEmelyRodriguez.AutoSize = true;
            this.lblEmelyRodriguez.Location = new System.Drawing.Point(194, 233);
            this.lblEmelyRodriguez.Name = "lblEmelyRodriguez";
            this.lblEmelyRodriguez.Size = new System.Drawing.Size(19, 13);
            this.lblEmelyRodriguez.TabIndex = 12;
            this.lblEmelyRodriguez.Text = "¿?";
            this.lblEmelyRodriguez.Click += new System.EventHandler(this.lblEmelyRodriguez_Click);
            // 
            // lblMiguelQuinteros
            // 
            this.lblMiguelQuinteros.AutoSize = true;
            this.lblMiguelQuinteros.Location = new System.Drawing.Point(306, 234);
            this.lblMiguelQuinteros.Name = "lblMiguelQuinteros";
            this.lblMiguelQuinteros.Size = new System.Drawing.Size(19, 13);
            this.lblMiguelQuinteros.TabIndex = 13;
            this.lblMiguelQuinteros.Text = "¿?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.lblMiguelQuinteros);
            this.Controls.Add(this.lblEmelyRodriguez);
            this.Controls.Add(this.lblKleverMontano);
            this.Controls.Add(this.lblDimasRosales);
            this.Controls.Add(this.lblMiguelRuiz);
            this.Controls.Add(this.lblEduardoGarcia);
            this.Controls.Add(this.btnGrupo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.Label lblEduardoGarcia;
        private System.Windows.Forms.Label lblMiguelRuiz;
        private System.Windows.Forms.Label lblDimasRosales;
        private System.Windows.Forms.Label lblKleverMontano;
        private System.Windows.Forms.Label lblEmelyRodriguez;
        private System.Windows.Forms.Label lblMiguelQuinteros;
    }
}

