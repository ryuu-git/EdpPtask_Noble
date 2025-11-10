namespace HanzPeterNoble_edp_
{
    partial class AddDrinks
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
            add = new Button();
            label2 = new Label();
            addd = new Label();
            insert = new TextBox();
            SuspendLayout();
            // 
            // add
            // 
            add.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(77, 184);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 7;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addd
            // 
            addd.AutoSize = true;
            addd.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addd.Location = new Point(53, 40);
            addd.Name = "addd";
            addd.Size = new Size(118, 22);
            addd.TabIndex = 5;
            addd.Text = "ADD DRINKS";
            // 
            // insert
            // 
            insert.Location = new Point(63, 94);
            insert.Name = "insert";
            insert.Size = new Size(99, 23);
            insert.TabIndex = 4;
            // 
            // AddDrinks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 284);
            Controls.Add(add);
            Controls.Add(label2);
            Controls.Add(addd);
            Controls.Add(insert);
            Name = "AddDrinks";
            Text = "AddDrinks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private Label label2;
        private Label addd;
        private TextBox insert;
    }
}