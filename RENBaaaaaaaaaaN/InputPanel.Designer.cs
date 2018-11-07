namespace RENBaaaaaaaaaaN
{
    partial class InputPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startWithLabel = new System.Windows.Forms.Label();
            this.startWithUpDown = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stepLabel = new System.Windows.Forms.Label();
            this.stepUpDown = new System.Windows.Forms.NumericUpDown();
            this.executeButton = new System.Windows.Forms.Button();
            this.topToBottomRadioButton = new System.Windows.Forms.RadioButton();
            this.leftToRightRadioButton = new System.Windows.Forms.RadioButton();
            this.sortDirectionGroup = new System.Windows.Forms.GroupBox();
            this.usageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startWithUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepUpDown)).BeginInit();
            this.sortDirectionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // startWithLabel
            // 
            this.startWithLabel.AutoSize = true;
            this.startWithLabel.Location = new System.Drawing.Point(24, 102);
            this.startWithLabel.Name = "startWithLabel";
            this.startWithLabel.Size = new System.Drawing.Size(31, 15);
            this.startWithLabel.TabIndex = 0;
            this.startWithLabel.Text = "開始";
            // 
            // startWithUpDown
            // 
            this.startWithUpDown.Location = new System.Drawing.Point(111, 98);
            this.startWithUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startWithUpDown.Name = "startWithUpDown";
            this.startWithUpDown.Size = new System.Drawing.Size(73, 23);
            this.startWithUpDown.TabIndex = 1;
            this.startWithUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(24, 136);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(41, 15);
            this.stepLabel.TabIndex = 3;
            this.stepLabel.Text = "ステップ";
            // 
            // stepUpDown
            // 
            this.stepUpDown.Location = new System.Drawing.Point(111, 132);
            this.stepUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stepUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepUpDown.Name = "stepUpDown";
            this.stepUpDown.Size = new System.Drawing.Size(73, 23);
            this.stepUpDown.TabIndex = 4;
            this.stepUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(27, 283);
            this.executeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(87, 29);
            this.executeButton.TabIndex = 5;
            this.executeButton.Text = "連番を設定";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // topToBottomRadioButton
            // 
            this.topToBottomRadioButton.AutoSize = true;
            this.topToBottomRadioButton.Checked = true;
            this.topToBottomRadioButton.Location = new System.Drawing.Point(16, 28);
            this.topToBottomRadioButton.Name = "topToBottomRadioButton";
            this.topToBottomRadioButton.Size = new System.Drawing.Size(77, 19);
            this.topToBottomRadioButton.TabIndex = 6;
            this.topToBottomRadioButton.TabStop = true;
            this.topToBottomRadioButton.Text = "上から下へ";
            this.topToBottomRadioButton.UseVisualStyleBackColor = true;
            // 
            // leftToRightRadioButton
            // 
            this.leftToRightRadioButton.AutoSize = true;
            this.leftToRightRadioButton.Location = new System.Drawing.Point(16, 53);
            this.leftToRightRadioButton.Name = "leftToRightRadioButton";
            this.leftToRightRadioButton.Size = new System.Drawing.Size(77, 19);
            this.leftToRightRadioButton.TabIndex = 7;
            this.leftToRightRadioButton.TabStop = true;
            this.leftToRightRadioButton.Text = "左から右へ";
            this.leftToRightRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortDirectionGroup
            // 
            this.sortDirectionGroup.Controls.Add(this.topToBottomRadioButton);
            this.sortDirectionGroup.Controls.Add(this.leftToRightRadioButton);
            this.sortDirectionGroup.Location = new System.Drawing.Point(27, 176);
            this.sortDirectionGroup.Name = "sortDirectionGroup";
            this.sortDirectionGroup.Size = new System.Drawing.Size(157, 88);
            this.sortDirectionGroup.TabIndex = 8;
            this.sortDirectionGroup.TabStop = false;
            this.sortDirectionGroup.Text = "連番設定順";
            // 
            // usageLabel
            // 
            this.usageLabel.AutoSize = true;
            this.usageLabel.Location = new System.Drawing.Point(3, 24);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new System.Drawing.Size(223, 15);
            this.usageLabel.TabIndex = 9;
            this.usageLabel.Text = "選択されたオートシェイプに連番を設定します。";
            // 
            // InputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usageLabel);
            this.Controls.Add(this.sortDirectionGroup);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.stepUpDown);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.startWithUpDown);
            this.Controls.Add(this.startWithLabel);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InputPanel";
            this.Size = new System.Drawing.Size(223, 428);
            ((System.ComponentModel.ISupportInitialize)(this.startWithUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepUpDown)).EndInit();
            this.sortDirectionGroup.ResumeLayout(false);
            this.sortDirectionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startWithLabel;
        private System.Windows.Forms.NumericUpDown startWithUpDown;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.NumericUpDown stepUpDown;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.RadioButton topToBottomRadioButton;
        private System.Windows.Forms.RadioButton leftToRightRadioButton;
        private System.Windows.Forms.GroupBox sortDirectionGroup;
        private System.Windows.Forms.Label usageLabel;
    }
}
