namespace homework_2
{
    partial class pokemon
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.NationalLabel = new System.Windows.Forms.Label();
            this.SpeciesLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.JapaneseLabel = new System.Windows.Forms.Label();
            this.NationalTextBox = new System.Windows.Forms.TextBox();
            this.SpeciesTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.JapaneseTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NationalLabel
            // 
            this.NationalLabel.AutoSize = true;
            this.NationalLabel.Location = new System.Drawing.Point(28, 13);
            this.NationalLabel.Name = "NationalLabel";
            this.NationalLabel.Size = new System.Drawing.Size(47, 12);
            this.NationalLabel.TabIndex = 0;
            this.NationalLabel.Text = "National:";
            // 
            // SpeciesLabel
            // 
            this.SpeciesLabel.AutoSize = true;
            this.SpeciesLabel.Location = new System.Drawing.Point(28, 51);
            this.SpeciesLabel.Name = "SpeciesLabel";
            this.SpeciesLabel.Size = new System.Drawing.Size(42, 12);
            this.SpeciesLabel.TabIndex = 1;
            this.SpeciesLabel.Text = "Species:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(28, 89);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(39, 12);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height:";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(28, 127);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(42, 12);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "Weight:";
            // 
            // JapaneseLabel
            // 
            this.JapaneseLabel.AutoSize = true;
            this.JapaneseLabel.Location = new System.Drawing.Point(28, 165);
            this.JapaneseLabel.Name = "JapaneseLabel";
            this.JapaneseLabel.Size = new System.Drawing.Size(48, 12);
            this.JapaneseLabel.TabIndex = 4;
            this.JapaneseLabel.Text = "Japanese:";
            // 
            // NationalTextBox
            // 
            this.NationalTextBox.Location = new System.Drawing.Point(172, 13);
            this.NationalTextBox.Name = "NationalTextBox";
            this.NationalTextBox.Size = new System.Drawing.Size(113, 22);
            this.NationalTextBox.TabIndex = 5;
            // 
            // SpeciesTextBox
            // 
            this.SpeciesTextBox.Location = new System.Drawing.Point(172, 51);
            this.SpeciesTextBox.Name = "SpeciesTextBox";
            this.SpeciesTextBox.Size = new System.Drawing.Size(113, 22);
            this.SpeciesTextBox.TabIndex = 6;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(172, 89);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(113, 22);
            this.HeightTextBox.TabIndex = 7;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(172, 127);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(113, 22);
            this.WeightTextBox.TabIndex = 8;
            // 
            // JapaneseTextBox
            // 
            this.JapaneseTextBox.Location = new System.Drawing.Point(172, 165);
            this.JapaneseTextBox.Name = "JapaneseTextBox";
            this.JapaneseTextBox.Size = new System.Drawing.Size(113, 22);
            this.JapaneseTextBox.TabIndex = 9;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(280, 248);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(104, 39);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 338);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.JapaneseTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.SpeciesTextBox);
            this.Controls.Add(this.NationalTextBox);
            this.Controls.Add(this.JapaneseLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.SpeciesLabel);
            this.Controls.Add(this.NationalLabel);
            this.Name = "pokemon";
            this.Text = "pokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NationalLabel;
        private System.Windows.Forms.Label SpeciesLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label JapaneseLabel;
        private System.Windows.Forms.TextBox NationalTextBox;
        private System.Windows.Forms.TextBox SpeciesTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox JapaneseTextBox;
        private System.Windows.Forms.Button OKButton;
    }
}

