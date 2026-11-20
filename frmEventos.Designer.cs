namespace frmPracticasEventos
{
    partial class frmEventos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            lblEstado = new Label();
            label3 = new Label();
            txtNumeros = new TextBox();
            panelImagen = new Panel();
            btnTemporizador = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 33);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 0;
            label1.Text = "Prueba de eventos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 91);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 1;
            label2.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(55, 137);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 28);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Click";
            lblEstado.Click += lblEstado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 178);
            label3.Name = "label3";
            label3.Size = new Size(293, 28);
            label3.TabIndex = 3;
            label3.Text = "Ingrese solamentes numeros: ";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(55, 222);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(293, 41);
            txtNumeros.TabIndex = 4;
            txtNumeros.KeyPress += txtNumeros_KeyPress;
            // 
            // panelImagen
            // 
            panelImagen.Location = new Point(55, 269);
            panelImagen.Name = "panelImagen";
            panelImagen.Size = new Size(468, 217);
            panelImagen.TabIndex = 5;
            panelImagen.DragDrop += panel1_DragDrop;
            panelImagen.DragEnter += panel1_DragEnter;
            // 
            // btnTemporizador
            // 
            btnTemporizador.Location = new Point(178, 492);
            btnTemporizador.Name = "btnTemporizador";
            btnTemporizador.Size = new Size(265, 37);
            btnTemporizador.TabIndex = 6;
            btnTemporizador.Text = "Iniciar Temporizador";
            btnTemporizador.UseVisualStyleBackColor = true;
            btnTemporizador.Click += btnTemporizador_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(178, 551);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(88, 28);
            lblTiempo.TabIndex = 7;
            lblTiempo.Text = "Tiempo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 588);
            Controls.Add(lblTiempo);
            Controls.Add(btnTemporizador);
            Controls.Add(panelImagen);
            Controls.Add(txtNumeros);
            Controls.Add(label3);
            Controls.Add(lblEstado);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblEstado;
        private Label label3;
        private TextBox txtNumeros;
        private Panel panelImagen;
        private Button btnTemporizador;
        private System.Windows.Forms.Timer timer1;
        private Label lblTiempo;
    }
}
