namespace WindowsFormsApp1
{
    partial class Form_rechercer
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
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Liste_des_Livres = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Filtres_de_Recherche = new System.Windows.Forms.CheckedListBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableauDeBordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adhérentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adhérentToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.AjouterUneCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Impact", 25F);
            this.Title.Location = new System.Drawing.Point(400, 50);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(191, 42);
            this.Title.TabIndex = 10;
            this.Title.Text = "BiblioFusion";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox1.Location = new System.Drawing.Point(125, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(754, 30);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Rechercher un produit";
            // 
            // Liste_des_Livres
            // 
            this.Liste_des_Livres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Liste_des_Livres.FormattingEnabled = true;
            this.Liste_des_Livres.ItemHeight = 25;
            this.Liste_des_Livres.Location = new System.Drawing.Point(385, 156);
            this.Liste_des_Livres.Name = "Liste_des_Livres";
            this.Liste_des_Livres.Size = new System.Drawing.Size(589, 529);
            this.Liste_des_Livres.TabIndex = 13;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(956, 156);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 529);
            this.vScrollBar1.TabIndex = 15;
            // 
            // Filtres_de_Recherche
            // 
            this.Filtres_de_Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Filtres_de_Recherche.FormattingEnabled = true;
            this.Filtres_de_Recherche.Location = new System.Drawing.Point(32, 156);
            this.Filtres_de_Recherche.Name = "Filtres_de_Recherche";
            this.Filtres_de_Recherche.Size = new System.Drawing.Size(322, 529);
            this.Filtres_de_Recherche.TabIndex = 16;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(337, 156);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 529);
            this.vScrollBar2.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableauDeBordToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.scannerToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.connexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1007, 35);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableauDeBordToolStripMenuItem
            // 
            this.tableauDeBordToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableauDeBordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tableauDeBordToolStripMenuItem.Name = "tableauDeBordToolStripMenuItem";
            this.tableauDeBordToolStripMenuItem.Size = new System.Drawing.Size(132, 25);
            this.tableauDeBordToolStripMenuItem.Text = "Tableau de bord";
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            // 
            // scannerToolStripMenuItem
            // 
            this.scannerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adhérentToolStripMenuItem1,
            this.livreToolStripMenuItem1});
            this.scannerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.scannerToolStripMenuItem.Name = "scannerToolStripMenuItem";
            this.scannerToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.scannerToolStripMenuItem.Text = "Scanner";
            // 
            // adhérentToolStripMenuItem1
            // 
            this.adhérentToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livreToolStripMenuItem3,
            this.livreToolStripMenuItem4,
            this.jeuToolStripMenuItem2});
            this.adhérentToolStripMenuItem1.Name = "adhérentToolStripMenuItem1";
            this.adhérentToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.adhérentToolStripMenuItem1.Text = "Smartphone";
            // 
            // livreToolStripMenuItem3
            // 
            this.livreToolStripMenuItem3.Name = "livreToolStripMenuItem3";
            this.livreToolStripMenuItem3.Size = new System.Drawing.Size(144, 26);
            this.livreToolStripMenuItem3.Text = "Adhérent";
            // 
            // livreToolStripMenuItem4
            // 
            this.livreToolStripMenuItem4.Name = "livreToolStripMenuItem4";
            this.livreToolStripMenuItem4.Size = new System.Drawing.Size(144, 26);
            this.livreToolStripMenuItem4.Text = "Livre";
            // 
            // jeuToolStripMenuItem2
            // 
            this.jeuToolStripMenuItem2.Name = "jeuToolStripMenuItem2";
            this.jeuToolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.jeuToolStripMenuItem2.Text = "Jeu";
            // 
            // livreToolStripMenuItem1
            // 
            this.livreToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adhérentToolStripMenuItem3,
            this.livreToolStripMenuItem5,
            this.jeuToolStripMenuItem3});
            this.livreToolStripMenuItem1.Name = "livreToolStripMenuItem1";
            this.livreToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.livreToolStripMenuItem1.Text = "Scannette";
            // 
            // adhérentToolStripMenuItem3
            // 
            this.adhérentToolStripMenuItem3.Name = "adhérentToolStripMenuItem3";
            this.adhérentToolStripMenuItem3.Size = new System.Drawing.Size(144, 26);
            this.adhérentToolStripMenuItem3.Text = "Adhérent";
            // 
            // livreToolStripMenuItem5
            // 
            this.livreToolStripMenuItem5.Name = "livreToolStripMenuItem5";
            this.livreToolStripMenuItem5.Size = new System.Drawing.Size(144, 26);
            this.livreToolStripMenuItem5.Text = "Livre";
            // 
            // jeuToolStripMenuItem3
            // 
            this.jeuToolStripMenuItem3.Name = "jeuToolStripMenuItem3";
            this.jeuToolStripMenuItem3.Size = new System.Drawing.Size(144, 26);
            this.jeuToolStripMenuItem3.Text = "Jeu";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem5,
            this.toolStripMenuItem7,
            this.AjouterUneCatégorieToolStripMenuItem,
            this.supprimerUneCatégorieToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem6.Text = "Ajouter adhérent";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem5.Text = "Ajouter jeu";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem7.Text = "Ajouter livre";
            // 
            // AjouterUneCatégorieToolStripMenuItem
            // 
            this.AjouterUneCatégorieToolStripMenuItem.Name = "AjouterUneCatégorieToolStripMenuItem";
            this.AjouterUneCatégorieToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.AjouterUneCatégorieToolStripMenuItem.Text = "Ajouter une catégorie";
            // 
            // supprimerUneCatégorieToolStripMenuItem
            // 
            this.supprimerUneCatégorieToolStripMenuItem.Name = "supprimerUneCatégorieToolStripMenuItem";
            this.supprimerUneCatégorieToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.supprimerUneCatégorieToolStripMenuItem.Text = "Supprimer une catégorie";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.connexionToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.connexionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.connexionToolStripMenuItem.Text = "Déconnexion";
            // 
            // Form_rechercer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.Filtres_de_Recherche);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Liste_des_Livres);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Title);
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form_rechercer";
            this.Text = "BiblioFusion - rechercher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Liste_des_Livres;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.CheckedListBox Filtres_de_Recherche;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tableauDeBordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adhérentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adhérentToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem AjouterUneCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
    }
}