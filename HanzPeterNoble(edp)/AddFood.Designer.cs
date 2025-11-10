using System.Windows.Forms;

namespace HanzPeterNoble_edp_
{
    partial class AddFood
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
            insert = new TextBox();
            addf = new Label();
            label2 = new Label();
            add = new Button();
            SuspendLayout();
            // 
            // insert
            // 
            insert.Location = new Point(76, 85);
            insert.Name = "insert";
            insert.Size = new Size(99, 23);
            insert.TabIndex = 0;
            // 
            // addf
            // 
            addf.AutoSize = true;
            addf.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addf.Location = new Point(76, 43);
            addf.Name = "addf";
            addf.Size = new Size(99, 22);
            addf.TabIndex = 1;
            addf.Text = "ADD FOOD";
            // 
            // label2
            // 
            label2 = new Label();
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(230, 20); 
            label2.TabIndex = 2;
            label2.Text = "";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(90, 177);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 3;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += Add_Click;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 256);
            Controls.Add(add);
            Controls.Add(label2);
            Controls.Add(addf);
            Controls.Add(insert);
            Name = "AddFood";
            Text = "AddFood";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TextBox insert;
        private Label addf;
        private Label label2;
        private Button add;
    }
}