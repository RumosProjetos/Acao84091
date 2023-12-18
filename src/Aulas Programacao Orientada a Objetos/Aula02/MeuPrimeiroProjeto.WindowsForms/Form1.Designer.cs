namespace MeuPrimeiroProjeto.WindowsForms
{
    partial class Form1
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
            btnOlaMundo = new Button();
            btnAdeusMundo = new Button();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // btnOlaMundo
            // 
            btnOlaMundo.Location = new Point(158, 271);
            btnOlaMundo.Name = "btnOlaMundo";
            btnOlaMundo.Size = new Size(238, 59);
            btnOlaMundo.TabIndex = 0;
            btnOlaMundo.Text = "Olá mundo";
            btnOlaMundo.UseVisualStyleBackColor = true;
            btnOlaMundo.Click += btnOlaMundo_Click;
            btnOlaMundo.MouseHover += btnOlaMundo_MouseHover;
            btnOlaMundo.MouseUp += btnOlaMundo_MouseUp;
            // 
            // btnAdeusMundo
            // 
            btnAdeusMundo.Location = new Point(428, 271);
            btnAdeusMundo.Name = "btnAdeusMundo";
            btnAdeusMundo.Size = new Size(238, 59);
            btnAdeusMundo.TabIndex = 1;
            btnAdeusMundo.Text = "Adeus Mundo";
            btnAdeusMundo.UseVisualStyleBackColor = true;
            btnAdeusMundo.Click += btnAdeusMundo_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 36F);
            lblMensagem.Location = new Point(158, 111);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(194, 81);
            lblMensagem.TabIndex = 2;
            lblMensagem.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 535);
            Controls.Add(lblMensagem);
            Controls.Add(btnAdeusMundo);
            Controls.Add(btnOlaMundo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOlaMundo;
        private Button btnAdeusMundo;
        private Label lblMensagem;
    }
}
