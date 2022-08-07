namespace Subscription_Tracker
{
    partial class SubscriptionTracker
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
            this.layout_Main = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numud_Prime = new System.Windows.Forms.NumericUpDown();
            this.numud_TierOne = new System.Windows.Forms.NumericUpDown();
            this.numud_TierTwo = new System.Windows.Forms.NumericUpDown();
            this.numud_TierThree = new System.Windows.Forms.NumericUpDown();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_Connected = new System.Windows.Forms.Label();
            this.layout_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Prime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_TierOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_TierTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_TierThree)).BeginInit();
            this.SuspendLayout();
            // 
            // layout_Main
            // 
            this.layout_Main.ColumnCount = 2;
            this.layout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.layout_Main.Controls.Add(this.label1, 0, 0);
            this.layout_Main.Controls.Add(this.label2, 0, 1);
            this.layout_Main.Controls.Add(this.label3, 0, 2);
            this.layout_Main.Controls.Add(this.label4, 0, 3);
            this.layout_Main.Controls.Add(this.numud_Prime, 1, 0);
            this.layout_Main.Controls.Add(this.numud_TierOne, 1, 1);
            this.layout_Main.Controls.Add(this.numud_TierTwo, 1, 2);
            this.layout_Main.Controls.Add(this.numud_TierThree, 1, 3);
            this.layout_Main.Controls.Add(this.btn_Connect, 0, 4);
            this.layout_Main.Controls.Add(this.lbl_Connected, 1, 4);
            this.layout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Main.Location = new System.Drawing.Point(0, 0);
            this.layout_Main.Name = "layout_Main";
            this.layout_Main.RowCount = 5;
            this.layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Main.Size = new System.Drawing.Size(378, 147);
            this.layout_Main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twitch Prime Value";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tier One Value";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tier Two Value";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tier Three Value";
            // 
            // numud_Prime
            // 
            this.numud_Prime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numud_Prime.Location = new System.Drawing.Point(129, 3);
            this.numud_Prime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numud_Prime.Name = "numud_Prime";
            this.numud_Prime.Size = new System.Drawing.Size(246, 23);
            this.numud_Prime.TabIndex = 4;
            this.numud_Prime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numud_TierOne
            // 
            this.numud_TierOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numud_TierOne.Location = new System.Drawing.Point(129, 32);
            this.numud_TierOne.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numud_TierOne.Name = "numud_TierOne";
            this.numud_TierOne.Size = new System.Drawing.Size(246, 23);
            this.numud_TierOne.TabIndex = 4;
            this.numud_TierOne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numud_TierTwo
            // 
            this.numud_TierTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numud_TierTwo.Location = new System.Drawing.Point(129, 61);
            this.numud_TierTwo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numud_TierTwo.Name = "numud_TierTwo";
            this.numud_TierTwo.Size = new System.Drawing.Size(246, 23);
            this.numud_TierTwo.TabIndex = 4;
            this.numud_TierTwo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numud_TierThree
            // 
            this.numud_TierThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numud_TierThree.Location = new System.Drawing.Point(129, 90);
            this.numud_TierThree.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numud_TierThree.Name = "numud_TierThree";
            this.numud_TierThree.Size = new System.Drawing.Size(246, 23);
            this.numud_TierThree.TabIndex = 4;
            this.numud_TierThree.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // btn_Connect
            // 
            this.btn_Connect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Connect.Location = new System.Drawing.Point(48, 120);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "&Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // lbl_Connected
            // 
            this.lbl_Connected.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Connected.AutoSize = true;
            this.lbl_Connected.Location = new System.Drawing.Point(129, 124);
            this.lbl_Connected.Name = "lbl_Connected";
            this.lbl_Connected.Size = new System.Drawing.Size(88, 15);
            this.lbl_Connected.TabIndex = 6;
            this.lbl_Connected.Text = "Not Connected";
            // 
            // SubscriptionTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 147);
            this.Controls.Add(this.layout_Main);
            this.Name = "SubscriptionTracker";
            this.Text = "Subscription Points Tracker";
            this.layout_Main.ResumeLayout(false);
            this.layout_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_Prime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_TierOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_TierTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_TierThree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel layout_Main;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numud_Prime;
        private NumericUpDown numud_TierOne;
        private NumericUpDown numud_TierTwo;
        private NumericUpDown numud_TierThree;
        private Button btn_Connect;
        private Label lbl_Connected;
    }
}