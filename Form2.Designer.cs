namespace Ado.NetDemo
{
	partial class Form2
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
			this.dgwProducts = new System.Windows.Forms.DataGridView();
			this.lblName = new System.Windows.Forms.Label();
			this.lbllUnitPRice = new System.Windows.Forms.Label();
			this.lblStockAmount = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblNameUpdate = new System.Windows.Forms.Label();
			this.txbStockAmountUpdate = new System.Windows.Forms.TextBox();
			this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
			this.txbUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.lblStockAmountUptade = new System.Windows.Forms.Label();
			this.txbNameUpdate = new System.Windows.Forms.TextBox();
			this.btnRemove = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProducts
			// 
			this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProducts.Location = new System.Drawing.Point(48, 17);
			this.dgwProducts.Name = "dgwProducts";
			this.dgwProducts.Size = new System.Drawing.Size(518, 116);
			this.dgwProducts.TabIndex = 0;
			this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(20, 16);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name";
			// 
			// lbllUnitPRice
			// 
			this.lbllUnitPRice.AutoSize = true;
			this.lbllUnitPRice.Location = new System.Drawing.Point(20, 65);
			this.lbllUnitPRice.Name = "lbllUnitPRice";
			this.lbllUnitPRice.Size = new System.Drawing.Size(53, 13);
			this.lbllUnitPRice.TabIndex = 2;
			this.lbllUnitPRice.Text = "Unit Price";
			// 
			// lblStockAmount
			// 
			this.lblStockAmount.AutoSize = true;
			this.lblStockAmount.Location = new System.Drawing.Point(20, 111);
			this.lblStockAmount.Name = "lblStockAmount";
			this.lblStockAmount.Size = new System.Drawing.Size(74, 13);
			this.lblStockAmount.TabIndex = 3;
			this.lblStockAmount.Text = "Stock Amount";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(106, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(99, 20);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(106, 62);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(99, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(106, 108);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(99, 20);
			this.textBox3.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.lblName);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.lbllUnitPRice);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.lblStockAmount);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(37, 171);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(348, 170);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add a Product";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(185, 134);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 27);
			this.button1.TabIndex = 8;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.Controls.Add(this.lblNameUpdate);
			this.groupBox2.Controls.Add(this.txbStockAmountUpdate);
			this.groupBox2.Controls.Add(this.lblUnitPriceUpdate);
			this.groupBox2.Controls.Add(this.txbUnitPriceUpdate);
			this.groupBox2.Controls.Add(this.lblStockAmountUptade);
			this.groupBox2.Controls.Add(this.txbNameUpdate);
			this.groupBox2.Location = new System.Drawing.Point(420, 171);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(348, 170);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Update a Product";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(185, 134);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 27);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblNameUpdate
			// 
			this.lblNameUpdate.AutoSize = true;
			this.lblNameUpdate.Location = new System.Drawing.Point(20, 16);
			this.lblNameUpdate.Name = "lblNameUpdate";
			this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
			this.lblNameUpdate.TabIndex = 1;
			this.lblNameUpdate.Text = "Name";
			// 
			// txbStockAmountUpdate
			// 
			this.txbStockAmountUpdate.Location = new System.Drawing.Point(106, 108);
			this.txbStockAmountUpdate.Name = "txbStockAmountUpdate";
			this.txbStockAmountUpdate.Size = new System.Drawing.Size(99, 20);
			this.txbStockAmountUpdate.TabIndex = 6;
			// 
			// lblUnitPriceUpdate
			// 
			this.lblUnitPriceUpdate.AutoSize = true;
			this.lblUnitPriceUpdate.Location = new System.Drawing.Point(20, 65);
			this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
			this.lblUnitPriceUpdate.Size = new System.Drawing.Size(53, 13);
			this.lblUnitPriceUpdate.TabIndex = 2;
			this.lblUnitPriceUpdate.Text = "Unit Price";
			// 
			// txbUnitPriceUpdate
			// 
			this.txbUnitPriceUpdate.Location = new System.Drawing.Point(106, 62);
			this.txbUnitPriceUpdate.Name = "txbUnitPriceUpdate";
			this.txbUnitPriceUpdate.Size = new System.Drawing.Size(99, 20);
			this.txbUnitPriceUpdate.TabIndex = 5;
			// 
			// lblStockAmountUptade
			// 
			this.lblStockAmountUptade.AutoSize = true;
			this.lblStockAmountUptade.Location = new System.Drawing.Point(20, 111);
			this.lblStockAmountUptade.Name = "lblStockAmountUptade";
			this.lblStockAmountUptade.Size = new System.Drawing.Size(74, 13);
			this.lblStockAmountUptade.TabIndex = 3;
			this.lblStockAmountUptade.Text = "Stock Amount";
			// 
			// txbNameUpdate
			// 
			this.txbNameUpdate.Location = new System.Drawing.Point(106, 13);
			this.txbNameUpdate.Name = "txbNameUpdate";
			this.txbNameUpdate.Size = new System.Drawing.Size(99, 20);
			this.txbNameUpdate.TabIndex = 4;
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(614, 89);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(111, 34);
			this.btnRemove.TabIndex = 9;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgwProducts);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwProducts;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lbllUnitPRice;
		private System.Windows.Forms.Label lblStockAmount;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblNameUpdate;
		private System.Windows.Forms.TextBox txbStockAmountUpdate;
		private System.Windows.Forms.Label lblUnitPriceUpdate;
		private System.Windows.Forms.TextBox txbUnitPriceUpdate;
		private System.Windows.Forms.Label lblStockAmountUptade;
		private System.Windows.Forms.TextBox txbNameUpdate;
		private System.Windows.Forms.Button btnRemove;
	}
}