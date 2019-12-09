namespace BondYieldCalculator
{
    partial class Form1
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
            this.YTM = new System.Windows.Forms.NumericUpDown();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.Face = new System.Windows.Forms.NumericUpDown();
            this.Coupon = new System.Windows.Forms.NumericUpDown();
            this.Years = new System.Windows.Forms.NumericUpDown();
            this.GetYTM = new System.Windows.Forms.Button();
            this.GetPrice = new System.Windows.Forms.Button();
            this.FaceLabel = new System.Windows.Forms.Label();
            this.CouponLabel = new System.Windows.Forms.Label();
            this.YearsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.YTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Years)).BeginInit();
            this.SuspendLayout();
            // 
            // YTM
            // 
            this.YTM.DecimalPlaces = 10;
            this.YTM.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.YTM.Location = new System.Drawing.Point(422, 331);
            this.YTM.Margin = new System.Windows.Forms.Padding(4);
            this.YTM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.YTM.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.YTM.Name = "YTM";
            this.YTM.Size = new System.Drawing.Size(161, 31);
            this.YTM.TabIndex = 13;
            this.YTM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.YTM.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Price
            // 
            this.Price.DecimalPlaces = 7;
            this.Price.Location = new System.Drawing.Point(420, 233);
            this.Price.Margin = new System.Windows.Forms.Padding(4);
            this.Price.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.Price.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(160, 31);
            this.Price.TabIndex = 11;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Price.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Face
            // 
            this.Face.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Face.Location = new System.Drawing.Point(420, 88);
            this.Face.Margin = new System.Windows.Forms.Padding(4);
            this.Face.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(160, 31);
            this.Face.TabIndex = 9;
            this.Face.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Face.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Coupon
            // 
            this.Coupon.DecimalPlaces = 10;
            this.Coupon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Coupon.Location = new System.Drawing.Point(422, 148);
            this.Coupon.Margin = new System.Windows.Forms.Padding(4);
            this.Coupon.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Coupon.Name = "Coupon";
            this.Coupon.Size = new System.Drawing.Size(158, 31);
            this.Coupon.TabIndex = 10;
            this.Coupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Coupon.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Years
            // 
            this.Years.Location = new System.Drawing.Point(422, 30);
            this.Years.Margin = new System.Windows.Forms.Padding(4);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(158, 31);
            this.Years.TabIndex = 8;
            this.Years.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Years.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // GetYTM
            // 
            this.GetYTM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetYTM.Location = new System.Drawing.Point(188, 310);
            this.GetYTM.Margin = new System.Windows.Forms.Padding(4);
            this.GetYTM.Name = "GetYTM";
            this.GetYTM.Size = new System.Drawing.Size(138, 66);
            this.GetYTM.TabIndex = 17;
            this.GetYTM.Text = "Get YTM";
            this.GetYTM.UseVisualStyleBackColor = true;
            this.GetYTM.Click += new System.EventHandler(this.GetYTM_Click);
            // 
            // GetPrice
            // 
            this.GetPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetPrice.Location = new System.Drawing.Point(188, 212);
            this.GetPrice.Margin = new System.Windows.Forms.Padding(4);
            this.GetPrice.Name = "GetPrice";
            this.GetPrice.Size = new System.Drawing.Size(139, 66);
            this.GetPrice.TabIndex = 15;
            this.GetPrice.Text = "Get Price";
            this.GetPrice.UseVisualStyleBackColor = true;
            this.GetPrice.Click += new System.EventHandler(this.GetPrice_Click);
            // 
            // FaceLabel
            // 
            this.FaceLabel.AutoSize = true;
            this.FaceLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FaceLabel.Location = new System.Drawing.Point(214, 98);
            this.FaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FaceLabel.Name = "FaceLabel";
            this.FaceLabel.Size = new System.Drawing.Size(54, 21);
            this.FaceLabel.TabIndex = 16;
            this.FaceLabel.Text = "Face";
            // 
            // CouponLabel
            // 
            this.CouponLabel.AutoSize = true;
            this.CouponLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CouponLabel.Location = new System.Drawing.Point(214, 158);
            this.CouponLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CouponLabel.Name = "CouponLabel";
            this.CouponLabel.Size = new System.Drawing.Size(76, 21);
            this.CouponLabel.TabIndex = 14;
            this.CouponLabel.Text = "Coupon";
            // 
            // YearsLabel
            // 
            this.YearsLabel.AutoSize = true;
            this.YearsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.YearsLabel.Location = new System.Drawing.Point(214, 40);
            this.YearsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearsLabel.Name = "YearsLabel";
            this.YearsLabel.Size = new System.Drawing.Size(65, 21);
            this.YearsLabel.TabIndex = 12;
            this.YearsLabel.Text = "Years";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.YTM);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Face);
            this.Controls.Add(this.Coupon);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.GetYTM);
            this.Controls.Add(this.GetPrice);
            this.Controls.Add(this.FaceLabel);
            this.Controls.Add(this.CouponLabel);
            this.Controls.Add(this.YearsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "BondYieldCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.YTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Years)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown YTM;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown Face;
        private System.Windows.Forms.NumericUpDown Coupon;
        private System.Windows.Forms.NumericUpDown Years;
        private System.Windows.Forms.Button GetYTM;
        private System.Windows.Forms.Button GetPrice;
        private System.Windows.Forms.Label FaceLabel;
        private System.Windows.Forms.Label CouponLabel;
        private System.Windows.Forms.Label YearsLabel;
    }
}

