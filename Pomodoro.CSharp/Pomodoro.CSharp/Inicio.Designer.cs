namespace Pomodoro.CSharp
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            this.tmOne = new System.Windows.Forms.Timer(this.components);
            this.btnInicioTempo = new System.Windows.Forms.Button();
            this.lblInstru = new System.Windows.Forms.Label();
            this.lblInstru2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmOne
            // 
            this.tmOne.Interval = 4000;
            // 
            // btnInicioTempo
            // 
            this.btnInicioTempo.Location = new System.Drawing.Point(189, 333);
            this.btnInicioTempo.Name = "btnInicioTempo";
            this.btnInicioTempo.Size = new System.Drawing.Size(104, 23);
            this.btnInicioTempo.TabIndex = 0;
            this.btnInicioTempo.Text = "Iniciar Contagem";
            this.btnInicioTempo.UseVisualStyleBackColor = true;
            this.btnInicioTempo.Click += new System.EventHandler(this.btnInicioTempo_Click);
            // 
            // lblInstru
            // 
            this.lblInstru.AutoSize = true;
            this.lblInstru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstru.Location = new System.Drawing.Point(25, 234);
            this.lblInstru.Name = "lblInstru";
            this.lblInstru.Size = new System.Drawing.Size(457, 75);
            this.lblInstru.TabIndex = 1;
            this.lblInstru.Text = "Você terá 25 minutos para desenvolver seu estudo \r\n\r\nQuando se sentir pronto pode" +
    " clicar em iniciar .";
            // 
            // lblInstru2
            // 
            this.lblInstru2.AutoSize = true;
            this.lblInstru2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstru2.Location = new System.Drawing.Point(12, 24);
            this.lblInstru2.Name = "lblInstru2";
            this.lblInstru2.Size = new System.Drawing.Size(364, 40);
            this.lblInstru2.TabIndex = 2;
            this.lblInstru2.Text = "Antes de começar coloque o celular em silencioso \r\npara ter um melhor proveito .";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Verifica se não tem nada que ira te atrapalhar para fazer seus \r\nafazeres.";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInstru2);
            this.Controls.Add(this.lblInstru);
            this.Controls.Add(this.btnInicioTempo);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmOne;
        private System.Windows.Forms.Button btnInicioTempo;
        private System.Windows.Forms.Label lblInstru;
        private System.Windows.Forms.Label lblInstru2;
        private System.Windows.Forms.Label label1;
    }
}