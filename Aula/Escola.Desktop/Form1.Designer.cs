using Escola.Desktop.Components;

namespace Escola.Desktop
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new PrimaryButton(components);
            primaryButton1 = new PrimaryButton(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(153, 21);
            label1.Name = "label1";
            label1.Size = new Size(466, 86);
            label1.TabIndex = 0;
            label1.Text = "Escola Desktop";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(70, 212);
            button1.Name = "button1";
            button1.Size = new Size(225, 75);
            button1.TabIndex = 1;
            button1.Text = "Listar Alunos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // primaryButton1
            // 
            primaryButton1.BackColor = Color.DarkBlue;
            primaryButton1.Font = new Font("Arial", 12F, FontStyle.Bold);
            primaryButton1.ForeColor = Color.White;
            primaryButton1.Location = new Point(70, 289);
            primaryButton1.Name = "primaryButton1";
            primaryButton1.Size = new Size(225, 75);
            primaryButton1.TabIndex = 2;
            primaryButton1.Text = "Cadastrar Aluno";
            primaryButton1.UseVisualStyleBackColor = false;
            primaryButton1.Click += primaryButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(primaryButton1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PrimaryButton button1;
        private PrimaryButton primaryButton1;
    }
}
