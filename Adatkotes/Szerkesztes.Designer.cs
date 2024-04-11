namespace Adatkotes
{
    partial class Szerkesztes
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            countryname = new TextBox();
            bindingSource1 = new BindingSource(components);
            population = new TextBox();
            area = new TextBox();
            ok = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "CountryName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Area in km2";
            // 
            // countryname
            // 
            countryname.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            countryname.Location = new Point(12, 32);
            countryname.Name = "countryname";
            countryname.Size = new Size(194, 23);
            countryname.TabIndex = 3;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // population
            // 
            population.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            population.Location = new Point(12, 76);
            population.Name = "population";
            population.Size = new Size(194, 23);
            population.TabIndex = 4;
            // 
            // area
            // 
            area.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            area.Location = new Point(12, 117);
            area.Name = "area";
            area.Size = new Size(194, 23);
            area.TabIndex = 5;
            // 
            // ok
            // 
            ok.Location = new Point(67, 158);
            ok.Name = "ok";
            ok.Size = new Size(75, 23);
            ok.TabIndex = 6;
            ok.Text = "Ok";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // Szerkesztes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 205);
            Controls.Add(ok);
            Controls.Add(area);
            Controls.Add(population);
            Controls.Add(countryname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Szerkesztes";
            Text = "Szerkesztes";
            Load += Szerkesztes_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox countryname;
        private TextBox population;
        private TextBox area;
        private Button ok;
        private BindingSource bindingSource1;
    }
}