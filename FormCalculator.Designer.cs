namespace BondYieldCalculator_CSharpGUI
{
    partial class FormCalculator
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
            this.panelBondPrice = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonCalcPrice = new System.Windows.Forms.Button();
            this.textBoxPriceRate = new System.Windows.Forms.TextBox();
            this.textBoxPriceFace = new System.Windows.Forms.TextBox();
            this.textBoxPriceYears = new System.Windows.Forms.TextBox();
            this.textBoxPriceCoupon = new System.Windows.Forms.TextBox();
            this.labelPriceFace = new System.Windows.Forms.Label();
            this.labelPriceRate = new System.Windows.Forms.Label();
            this.labelPriceYears = new System.Windows.Forms.Label();
            this.labelPriceCoupon = new System.Windows.Forms.Label();
            this.labelBondPrice = new System.Windows.Forms.Label();
            this.panelBondYield = new System.Windows.Forms.Panel();
            this.yield = new System.Windows.Forms.Label();
            this.labelYield = new System.Windows.Forms.Label();
            this.buttonCalcYield = new System.Windows.Forms.Button();
            this.textBoxYieldPrice = new System.Windows.Forms.TextBox();
            this.textBoxYieldFace = new System.Windows.Forms.TextBox();
            this.textBoxYieldYears = new System.Windows.Forms.TextBox();
            this.textBoxYieldCoupon = new System.Windows.Forms.TextBox();
            this.labelYieldFace = new System.Windows.Forms.Label();
            this.labelYieldPrice = new System.Windows.Forms.Label();
            this.labelYieldYears = new System.Windows.Forms.Label();
            this.labelYieldCoupon = new System.Windows.Forms.Label();
            this.labelBondYield = new System.Windows.Forms.Label();
            this.panelBondPrice.SuspendLayout();
            this.panelBondYield.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBondPrice
            // 
            this.panelBondPrice.Controls.Add(this.price);
            this.panelBondPrice.Controls.Add(this.labelPrice);
            this.panelBondPrice.Controls.Add(this.buttonCalcPrice);
            this.panelBondPrice.Controls.Add(this.textBoxPriceRate);
            this.panelBondPrice.Controls.Add(this.textBoxPriceFace);
            this.panelBondPrice.Controls.Add(this.textBoxPriceYears);
            this.panelBondPrice.Controls.Add(this.textBoxPriceCoupon);
            this.panelBondPrice.Controls.Add(this.labelPriceFace);
            this.panelBondPrice.Controls.Add(this.labelPriceRate);
            this.panelBondPrice.Controls.Add(this.labelPriceYears);
            this.panelBondPrice.Controls.Add(this.labelPriceCoupon);
            this.panelBondPrice.Controls.Add(this.labelBondPrice);
            this.panelBondPrice.Location = new System.Drawing.Point(12, 12);
            this.panelBondPrice.Name = "panelBondPrice";
            this.panelBondPrice.Size = new System.Drawing.Size(137, 204);
            this.panelBondPrice.TabIndex = 23;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(10, 173);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 17);
            this.price.TabIndex = 32;
            this.price.Text = "N/A";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.SystemColors.Control;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(10, 156);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 17);
            this.labelPrice.TabIndex = 30;
            this.labelPrice.Text = "Price";
            // 
            // buttonCalcPrice
            // 
            this.buttonCalcPrice.Location = new System.Drawing.Point(13, 116);
            this.buttonCalcPrice.Name = "buttonCalcPrice";
            this.buttonCalcPrice.Size = new System.Drawing.Size(108, 23);
            this.buttonCalcPrice.TabIndex = 29;
            this.buttonCalcPrice.Text = "Calculate";
            this.buttonCalcPrice.UseVisualStyleBackColor = true;
            this.buttonCalcPrice.Click += new System.EventHandler(this.buttonCalcPrice_Click);
            // 
            // textBoxPriceRate
            // 
            this.textBoxPriceRate.Location = new System.Drawing.Point(60, 90);
            this.textBoxPriceRate.Name = "textBoxPriceRate";
            this.textBoxPriceRate.Size = new System.Drawing.Size(61, 20);
            this.textBoxPriceRate.TabIndex = 28;
            this.textBoxPriceRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // textBoxPriceFace
            // 
            this.textBoxPriceFace.Location = new System.Drawing.Point(60, 67);
            this.textBoxPriceFace.Name = "textBoxPriceFace";
            this.textBoxPriceFace.Size = new System.Drawing.Size(61, 20);
            this.textBoxPriceFace.TabIndex = 27;
            this.textBoxPriceFace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // textBoxPriceYears
            // 
            this.textBoxPriceYears.Location = new System.Drawing.Point(60, 44);
            this.textBoxPriceYears.Name = "textBoxPriceYears";
            this.textBoxPriceYears.Size = new System.Drawing.Size(61, 20);
            this.textBoxPriceYears.TabIndex = 26;
            this.textBoxPriceYears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // textBoxPriceCoupon
            // 
            this.textBoxPriceCoupon.Location = new System.Drawing.Point(60, 21);
            this.textBoxPriceCoupon.Name = "textBoxPriceCoupon";
            this.textBoxPriceCoupon.Size = new System.Drawing.Size(61, 20);
            this.textBoxPriceCoupon.TabIndex = 25;
            this.textBoxPriceCoupon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // labelPriceFace
            // 
            this.labelPriceFace.AutoSize = true;
            this.labelPriceFace.Location = new System.Drawing.Point(23, 70);
            this.labelPriceFace.Name = "labelPriceFace";
            this.labelPriceFace.Size = new System.Drawing.Size(31, 13);
            this.labelPriceFace.TabIndex = 24;
            this.labelPriceFace.Text = "Face";
            // 
            // labelPriceRate
            // 
            this.labelPriceRate.AutoSize = true;
            this.labelPriceRate.Location = new System.Drawing.Point(24, 93);
            this.labelPriceRate.Name = "labelPriceRate";
            this.labelPriceRate.Size = new System.Drawing.Size(30, 13);
            this.labelPriceRate.TabIndex = 23;
            this.labelPriceRate.Text = "Rate";
            // 
            // labelPriceYears
            // 
            this.labelPriceYears.AutoSize = true;
            this.labelPriceYears.Location = new System.Drawing.Point(20, 47);
            this.labelPriceYears.Name = "labelPriceYears";
            this.labelPriceYears.Size = new System.Drawing.Size(34, 13);
            this.labelPriceYears.TabIndex = 22;
            this.labelPriceYears.Text = "Years";
            // 
            // labelPriceCoupon
            // 
            this.labelPriceCoupon.AutoSize = true;
            this.labelPriceCoupon.Location = new System.Drawing.Point(10, 24);
            this.labelPriceCoupon.Name = "labelPriceCoupon";
            this.labelPriceCoupon.Size = new System.Drawing.Size(44, 13);
            this.labelPriceCoupon.TabIndex = 21;
            this.labelPriceCoupon.Text = "Coupon";
            // 
            // labelBondPrice
            // 
            this.labelBondPrice.AutoSize = true;
            this.labelBondPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelBondPrice.Location = new System.Drawing.Point(24, 0);
            this.labelBondPrice.Name = "labelBondPrice";
            this.labelBondPrice.Size = new System.Drawing.Size(87, 17);
            this.labelBondPrice.TabIndex = 20;
            this.labelBondPrice.Text = "Bond Price";
            // 
            // panelBondYield
            // 
            this.panelBondYield.Controls.Add(this.yield);
            this.panelBondYield.Controls.Add(this.labelYield);
            this.panelBondYield.Controls.Add(this.buttonCalcYield);
            this.panelBondYield.Controls.Add(this.textBoxYieldPrice);
            this.panelBondYield.Controls.Add(this.textBoxYieldFace);
            this.panelBondYield.Controls.Add(this.textBoxYieldYears);
            this.panelBondYield.Controls.Add(this.textBoxYieldCoupon);
            this.panelBondYield.Controls.Add(this.labelYieldFace);
            this.panelBondYield.Controls.Add(this.labelYieldPrice);
            this.panelBondYield.Controls.Add(this.labelYieldYears);
            this.panelBondYield.Controls.Add(this.labelYieldCoupon);
            this.panelBondYield.Controls.Add(this.labelBondYield);
            this.panelBondYield.Location = new System.Drawing.Point(165, 12);
            this.panelBondYield.Name = "panelBondYield";
            this.panelBondYield.Size = new System.Drawing.Size(137, 204);
            this.panelBondYield.TabIndex = 30;
            // 
            // yield
            // 
            this.yield.AutoSize = true;
            this.yield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yield.Location = new System.Drawing.Point(11, 173);
            this.yield.Name = "yield";
            this.yield.Size = new System.Drawing.Size(31, 17);
            this.yield.TabIndex = 33;
            this.yield.Text = "N/A";
            // 
            // labelYield
            // 
            this.labelYield.AutoSize = true;
            this.labelYield.BackColor = System.Drawing.SystemColors.Control;
            this.labelYield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYield.Location = new System.Drawing.Point(11, 156);
            this.labelYield.Name = "labelYield";
            this.labelYield.Size = new System.Drawing.Size(44, 17);
            this.labelYield.TabIndex = 31;
            this.labelYield.Text = "Yield";
            // 
            // buttonCalcYield
            // 
            this.buttonCalcYield.Location = new System.Drawing.Point(14, 116);
            this.buttonCalcYield.Name = "buttonCalcYield";
            this.buttonCalcYield.Size = new System.Drawing.Size(108, 23);
            this.buttonCalcYield.TabIndex = 29;
            this.buttonCalcYield.Text = "Calculate";
            this.buttonCalcYield.UseVisualStyleBackColor = true;
            this.buttonCalcYield.Click += new System.EventHandler(this.buttonCalcYield_Click);
            // 
            // textBoxYieldPrice
            // 
            this.textBoxYieldPrice.Location = new System.Drawing.Point(61, 90);
            this.textBoxYieldPrice.Name = "textBoxYieldPrice";
            this.textBoxYieldPrice.Size = new System.Drawing.Size(61, 20);
            this.textBoxYieldPrice.TabIndex = 28;
            this.textBoxYieldPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // textBoxYieldFace
            // 
            this.textBoxYieldFace.Location = new System.Drawing.Point(61, 67);
            this.textBoxYieldFace.Name = "textBoxYieldFace";
            this.textBoxYieldFace.Size = new System.Drawing.Size(61, 20);
            this.textBoxYieldFace.TabIndex = 27;
            this.textBoxYieldFace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // textBoxYieldYears
            // 
            this.textBoxYieldYears.Location = new System.Drawing.Point(61, 44);
            this.textBoxYieldYears.Name = "textBoxYieldYears";
            this.textBoxYieldYears.Size = new System.Drawing.Size(61, 20);
            this.textBoxYieldYears.TabIndex = 26;
            this.textBoxYieldYears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // textBoxYieldCoupon
            // 
            this.textBoxYieldCoupon.Location = new System.Drawing.Point(61, 21);
            this.textBoxYieldCoupon.Name = "textBoxYieldCoupon";
            this.textBoxYieldCoupon.Size = new System.Drawing.Size(61, 20);
            this.textBoxYieldCoupon.TabIndex = 25;
            this.textBoxYieldCoupon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // labelYieldFace
            // 
            this.labelYieldFace.AutoSize = true;
            this.labelYieldFace.Location = new System.Drawing.Point(24, 70);
            this.labelYieldFace.Name = "labelYieldFace";
            this.labelYieldFace.Size = new System.Drawing.Size(31, 13);
            this.labelYieldFace.TabIndex = 24;
            this.labelYieldFace.Text = "Face";
            // 
            // labelYieldPrice
            // 
            this.labelYieldPrice.AutoSize = true;
            this.labelYieldPrice.Location = new System.Drawing.Point(25, 93);
            this.labelYieldPrice.Name = "labelYieldPrice";
            this.labelYieldPrice.Size = new System.Drawing.Size(31, 13);
            this.labelYieldPrice.TabIndex = 23;
            this.labelYieldPrice.Text = "Price";
            // 
            // labelYieldYears
            // 
            this.labelYieldYears.AutoSize = true;
            this.labelYieldYears.Location = new System.Drawing.Point(21, 47);
            this.labelYieldYears.Name = "labelYieldYears";
            this.labelYieldYears.Size = new System.Drawing.Size(34, 13);
            this.labelYieldYears.TabIndex = 22;
            this.labelYieldYears.Text = "Years";
            // 
            // labelYieldCoupon
            // 
            this.labelYieldCoupon.AutoSize = true;
            this.labelYieldCoupon.Location = new System.Drawing.Point(11, 24);
            this.labelYieldCoupon.Name = "labelYieldCoupon";
            this.labelYieldCoupon.Size = new System.Drawing.Size(44, 13);
            this.labelYieldCoupon.TabIndex = 21;
            this.labelYieldCoupon.Text = "Coupon";
            // 
            // labelBondYield
            // 
            this.labelBondYield.AutoSize = true;
            this.labelBondYield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelBondYield.Location = new System.Drawing.Point(25, 0);
            this.labelBondYield.Name = "labelBondYield";
            this.labelBondYield.Size = new System.Drawing.Size(86, 17);
            this.labelBondYield.TabIndex = 20;
            this.labelBondYield.Text = "Bond Yield";
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(314, 228);
            this.Controls.Add(this.panelBondYield);
            this.Controls.Add(this.panelBondPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chimera Investment Corporation";
            this.panelBondPrice.ResumeLayout(false);
            this.panelBondPrice.PerformLayout();
            this.panelBondYield.ResumeLayout(false);
            this.panelBondYield.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBondPrice;
        private System.Windows.Forms.Button buttonCalcPrice;
        private System.Windows.Forms.TextBox textBoxPriceRate;
        private System.Windows.Forms.TextBox textBoxPriceFace;
        private System.Windows.Forms.TextBox textBoxPriceYears;
        private System.Windows.Forms.TextBox textBoxPriceCoupon;
        private System.Windows.Forms.Label labelPriceFace;
        private System.Windows.Forms.Label labelPriceRate;
        private System.Windows.Forms.Label labelPriceYears;
        private System.Windows.Forms.Label labelPriceCoupon;
        private System.Windows.Forms.Label labelBondPrice;
        private System.Windows.Forms.Panel panelBondYield;
        private System.Windows.Forms.Button buttonCalcYield;
        private System.Windows.Forms.TextBox textBoxYieldPrice;
        private System.Windows.Forms.TextBox textBoxYieldFace;
        private System.Windows.Forms.TextBox textBoxYieldYears;
        private System.Windows.Forms.TextBox textBoxYieldCoupon;
        private System.Windows.Forms.Label labelYieldFace;
        private System.Windows.Forms.Label labelYieldPrice;
        private System.Windows.Forms.Label labelYieldYears;
        private System.Windows.Forms.Label labelYieldCoupon;
        private System.Windows.Forms.Label labelBondYield;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelYield;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label yield;
    }
}

