namespace HanzPeterNoble_edp_
{
    partial class RemoveDrinks
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
            rev = new Button();
            label2 = new Label();
            revf = new Label();
            insert = new TextBox();
            SuspendLayout();
            // 
            // rev
            // 
            rev.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rev.Location = new Point(96, 199);
            rev.Name = "rev";
            rev.Size = new Size(77, 23);
            rev.TabIndex = 11;
            rev.Text = "REMOVE";
            rev.UseVisualStyleBackColor = true;
            rev.Click += rev_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(32, 156);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // revf
            // 
            revf.AutoSize = true;
            revf.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            revf.Location = new Point(58, 57);
            revf.Name = "revf";
            revf.Size = new Size(154, 22);
            revf.TabIndex = 9;
            revf.Text = "REMOVE DRINKS";
            // 
            // insert
            // 
            insert.Location = new Point(84, 107);
            insert.Name = "insert";
            insert.Size = new Size(99, 23);
            insert.TabIndex = 8;
            // 
            // RemoveDrinks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 278);
            Controls.Add(rev);
            Controls.Add(label2);
            Controls.Add(revf);
            Controls.Add(insert);
            Name = "RemoveDrinks";
            Text = "RemoveDrinks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rev;
        private Label label2;
        private Label revf;
        private TextBox insert;
    }
}