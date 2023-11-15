namespace bekeszabolcsDoga11._15
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
            lbl1 = new Label();
            textB1 = new TextBox();
            btn1 = new Button();
            lbl2 = new Label();
            piroslbl = new Label();
            zoldlbl = new Label();
            keklbl = new Label();
            elso = new TextBox();
            masodik = new TextBox();
            osszeadas = new Button();
            kivonas = new Button();
            osztas = new Button();
            szorzas = new Button();
            label1 = new Label();
            eredmeny = new TextBox();
            szamolj = new Button();
            kilepes = new Button();
            alaph = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(43, 42);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(31, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Név:";
            // 
            // textB1
            // 
            textB1.Location = new Point(80, 39);
            textB1.Name = "textB1";
            textB1.Size = new Size(152, 23);
            textB1.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(238, 39);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 23);
            btn1.TabIndex = 2;
            btn1.Text = "Köszönj!";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lbl2
            // 
            lbl2.BackColor = Color.Yellow;
            lbl2.Font = new Font("Rockwell Extra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(43, 82);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(285, 35);
            lbl2.TabIndex = 3;
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // piroslbl
            // 
            piroslbl.BackColor = Color.Red;
            piroslbl.Location = new Point(456, 39);
            piroslbl.Name = "piroslbl";
            piroslbl.Size = new Size(61, 55);
            piroslbl.TabIndex = 4;
            piroslbl.Text = "piros";
            piroslbl.Click += piroslbl_Click;
            // 
            // zoldlbl
            // 
            zoldlbl.BackColor = Color.Lime;
            zoldlbl.Location = new Point(537, 39);
            zoldlbl.Name = "zoldlbl";
            zoldlbl.Size = new Size(56, 55);
            zoldlbl.TabIndex = 5;
            zoldlbl.Text = "zöld";
            zoldlbl.Click += zoldlbl_Click;
            // 
            // keklbl
            // 
            keklbl.BackColor = Color.DeepSkyBlue;
            keklbl.Location = new Point(616, 39);
            keklbl.Name = "keklbl";
            keklbl.Size = new Size(63, 55);
            keklbl.TabIndex = 6;
            keklbl.Text = "kék";
            keklbl.Click += keklbl_Click;
            // 
            // elso
            // 
            elso.Location = new Point(56, 153);
            elso.Multiline = true;
            elso.Name = "elso";
            elso.Size = new Size(63, 46);
            elso.TabIndex = 7;
            // 
            // masodik
            // 
            masodik.Location = new Point(238, 153);
            masodik.Multiline = true;
            masodik.Name = "masodik";
            masodik.Size = new Size(64, 46);
            masodik.TabIndex = 8;
            // 
            // osszeadas
            // 
            osszeadas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            osszeadas.Location = new Point(147, 150);
            osszeadas.Name = "osszeadas";
            osszeadas.Size = new Size(29, 26);
            osszeadas.TabIndex = 9;
            osszeadas.Text = "+";
            osszeadas.UseVisualStyleBackColor = true;
            osszeadas.Click += osszeadas_Click;
            // 
            // kivonas
            // 
            kivonas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kivonas.Location = new Point(182, 150);
            kivonas.Name = "kivonas";
            kivonas.Size = new Size(29, 26);
            kivonas.TabIndex = 9;
            kivonas.Text = "-";
            kivonas.UseVisualStyleBackColor = true;
            // 
            // osztas
            // 
            osztas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            osztas.Location = new Point(182, 182);
            osztas.Name = "osztas";
            osztas.Size = new Size(29, 26);
            osztas.TabIndex = 9;
            osztas.Text = "/";
            osztas.UseVisualStyleBackColor = true;
            // 
            // szorzas
            // 
            szorzas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            szorzas.Location = new Point(147, 182);
            szorzas.Name = "szorzas";
            szorzas.Size = new Size(29, 26);
            szorzas.TabIndex = 9;
            szorzas.Text = "*";
            szorzas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Rockwell Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(308, 168);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 10;
            label1.Text = "=";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eredmeny
            // 
            eredmeny.Location = new Point(369, 153);
            eredmeny.Multiline = true;
            eredmeny.Name = "eredmeny";
            eredmeny.Size = new Size(306, 46);
            eredmeny.TabIndex = 11;
            eredmeny.TextAlign = HorizontalAlignment.Center;
            // 
            // szamolj
            // 
            szamolj.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            szamolj.Location = new Point(43, 223);
            szamolj.Name = "szamolj";
            szamolj.Size = new Size(636, 44);
            szamolj.TabIndex = 12;
            szamolj.Text = "Számolj!";
            szamolj.UseVisualStyleBackColor = true;
            // 
            // kilepes
            // 
            kilepes.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kilepes.ForeColor = Color.Red;
            kilepes.Location = new Point(494, 273);
            kilepes.Name = "kilepes";
            kilepes.Size = new Size(185, 55);
            kilepes.TabIndex = 13;
            kilepes.Text = "Kilépés";
            kilepes.UseVisualStyleBackColor = true;
            // 
            // alaph
            // 
            alaph.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            alaph.ForeColor = Color.RoyalBlue;
            alaph.Location = new Point(303, 273);
            alaph.Name = "alaph";
            alaph.Size = new Size(185, 55);
            alaph.TabIndex = 13;
            alaph.Text = "Alaphelyzet";
            alaph.UseVisualStyleBackColor = true;
            alaph.Click += alaph_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 345);
            Controls.Add(alaph);
            Controls.Add(kilepes);
            Controls.Add(szamolj);
            Controls.Add(eredmeny);
            Controls.Add(label1);
            Controls.Add(osztas);
            Controls.Add(kivonas);
            Controls.Add(szorzas);
            Controls.Add(osszeadas);
            Controls.Add(masodik);
            Controls.Add(elso);
            Controls.Add(keklbl);
            Controls.Add(zoldlbl);
            Controls.Add(piroslbl);
            Controls.Add(lbl2);
            Controls.Add(btn1);
            Controls.Add(textB1);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "WFA dolgozat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox textB1;
        private Button btn1;
        private Label lbl2;
        private Label piroslbl;
        private Label zoldlbl;
        private Label keklbl;
        private TextBox elso;
        private TextBox masodik;
        private Button osszeadas;
        private Button kivonas;
        private Button osztas;
        private Button szorzas;
        private Label label1;
        private TextBox eredmeny;
        private Button szamolj;
        private Button kilepes;
        private Button alaph;
    }
}