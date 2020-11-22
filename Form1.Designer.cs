namespace Pokedex
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
            this.searchInput = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.SexTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editPokemonBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.pokemonListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AmmountTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.searchInput.Location = new System.Drawing.Point(28, 122);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(144, 22);
            this.searchInput.TabIndex = 0;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(25, 99);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(115, 17);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search pokemon";
            this.labelSearch.Click += new System.EventHandler(this.labelSerachInput_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(180, 122);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(88, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(542, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(195, 22);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(542, 91);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(195, 22);
            this.levelTextBox.TabIndex = 4;
            this.levelTextBox.TextChanged += new System.EventHandler(this.levelTextBox_TextChanged);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(542, 144);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(195, 22);
            this.TypeTextBox.TabIndex = 5;
            this.TypeTextBox.TextChanged += new System.EventHandler(this.TypeTextBox_TextChanged);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(542, 198);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(195, 22);
            this.WeightTextBox.TabIndex = 6;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // SexTextBox
            // 
            this.SexTextBox.Location = new System.Drawing.Point(542, 252);
            this.SexTextBox.Name = "SexTextBox";
            this.SexTextBox.Size = new System.Drawing.Size(195, 22);
            this.SexTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pokemons stored on the pokedex";
            // 
            // editPokemonBtn
            // 
            this.editPokemonBtn.Location = new System.Drawing.Point(542, 397);
            this.editPokemonBtn.Name = "editPokemonBtn";
            this.editPokemonBtn.Size = new System.Drawing.Size(90, 43);
            this.editPokemonBtn.TabIndex = 15;
            this.editPokemonBtn.Text = "Edit pokemon";
            this.editPokemonBtn.UseVisualStyleBackColor = true;
            this.editPokemonBtn.Click += new System.EventHandler(this.editPokemonBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(294, 397);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(216, 43);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete pokemon";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pokemonListBox
            // 
            this.pokemonListBox.FormattingEnabled = true;
            this.pokemonListBox.ItemHeight = 16;
            this.pokemonListBox.Location = new System.Drawing.Point(294, 44);
            this.pokemonListBox.Name = "pokemonListBox";
            this.pokemonListBox.Size = new System.Drawing.Size(216, 340);
            this.pokemonListBox.TabIndex = 19;
            this.pokemonListBox.SelectedIndexChanged += new System.EventHandler(this.pokemonListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Create pokemon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 49);
            this.button2.TabIndex = 21;
            this.button2.Text = "Store data on JSON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ammount";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(542, 308);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(195, 22);
            this.PriceTextBox.TabIndex = 24;
            // 
            // AmmountTextBox
            // 
            this.AmmountTextBox.Location = new System.Drawing.Point(542, 360);
            this.AmmountTextBox.Name = "AmmountTextBox";
            this.AmmountTextBox.Size = new System.Drawing.Size(195, 22);
            this.AmmountTextBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Playbill", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(28, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 62);
            this.label9.TabIndex = 26;
            this.label9.Text = "POKEDEX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 455);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AmmountTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pokemonListBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editPokemonBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SexTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.searchInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox SexTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editPokemonBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox pokemonListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox AmmountTextBox;
        private System.Windows.Forms.Label label9;
    }
}

