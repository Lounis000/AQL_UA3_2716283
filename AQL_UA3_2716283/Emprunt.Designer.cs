namespace AQL_UA3_2716283
{
    partial class Emprunt
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();

            // button1
            button1.Location = new Point(293, 95);
            button1.Name = "button1";
            button1.Size = new Size(200, 44);
            button1.TabIndex = 0;
            button1.Text = "Ajouter Un Emprunt";
            button1.UseVisualStyleBackColor = true;

            // button2
            button2.Location = new Point(293, 145);
            button2.Name = "button2";
            button2.Size = new Size(200, 44);
            button2.TabIndex = 1;
            button2.Text = "Modifier Un Emprunt";
            button2.UseVisualStyleBackColor = true;

            // button3
            button3.Location = new Point(293, 195);
            button3.Name = "button3";
            button3.Size = new Size(200, 44);
            button3.TabIndex = 2;
            button3.Text = "Afficher les emprunts";
            button3.UseVisualStyleBackColor = true;

            // button4
            button4.Location = new Point(293, 245);
            button4.Name = "button4";
            button4.Size = new Size(200, 44);
            button4.TabIndex = 3;
            button4.Text = "Supprimer Un Emprunt";
            button4.UseVisualStyleBackColor = true;

            // Emprunt
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Emprunt";
            Text = "Emprunt";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
