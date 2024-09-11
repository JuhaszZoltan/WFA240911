namespace WFA240911
{
    partial class FrmMain
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
            tlpMain = new TableLayoutPanel();
            btnHello = new Button();
            tlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpMain.Controls.Add(btnHello, 1, 1);
            tlpMain.Location = new Point(12, 12);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpMain.Size = new Size(845, 418);
            tlpMain.TabIndex = 0;
            // 
            // btnHello
            // 
            btnHello.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnHello.Font = new Font("Segoe UI", 40F);
            btnHello.Location = new Point(87, 44);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(670, 328);
            btnHello.TabIndex = 0;
            btnHello.Text = "HeLLo, WoRLd! uwu";
            btnHello.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 442);
            Controls.Add(tlpMain);
            Name = "FrmMain";
            Text = "Gomb események";
            tlpMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Button btnHello;
    }
}
