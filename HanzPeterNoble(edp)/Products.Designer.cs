namespace HanzPeterNoble_edp_
{
    partial class Products
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
            view1 = new ListView();
            view2 = new ListView();
            add1 = new Button();
            rev1 = new Button();
            add2 = new Button();
            rev2 = new Button();
            product = new Label();
            food = new Label();
            drink = new Label();
            SuspendLayout();
            // 
            // view1
            // 
            view1.Location = new Point(68, 83);
            view1.Name = "view1";
            view1.Size = new Size(184, 146);
            view1.TabIndex = 0;
            view1.UseCompatibleStateImageBehavior = false;
            // 
            // view2
            // 
            view2.Location = new Point(322, 83);
            view2.Name = "view2";
            view2.Size = new Size(184, 146);
            view2.TabIndex = 1;
            view2.UseCompatibleStateImageBehavior = false;
            // 
            // add1
            // 
            add1.Location = new Point(68, 249);
            add1.Name = "add1";
            add1.Size = new Size(75, 23);
            add1.TabIndex = 2;
            add1.Text = "ADD";
            add1.UseVisualStyleBackColor = true;
            add1.Click += add1_Click;
            // 
            // rev1
            // 
            rev1.Location = new Point(177, 249);
            rev1.Name = "rev1";
            rev1.Size = new Size(75, 23);
            rev1.TabIndex = 3;
            rev1.Text = "REMOVE";
            rev1.UseVisualStyleBackColor = true;
            rev1.Click += rev1_Click;
            // 
            // add2
            // 
            add2.Location = new Point(322, 249);
            add2.Name = "add2";
            add2.Size = new Size(75, 23);
            add2.TabIndex = 4;
            add2.Text = "ADD";
            add2.UseVisualStyleBackColor = true;
            add2.Click += add2_Click;
            // 
            // rev2
            // 
            rev2.Location = new Point(431, 249);
            rev2.Name = "rev2";
            rev2.Size = new Size(75, 23);
            rev2.TabIndex = 5;
            rev2.Text = "REMOVE";
            rev2.UseVisualStyleBackColor = true; rev2.Click += rev2_Click;
            rev2.Click += rev2_Click;
            // product
            // 
            product.AutoSize = true;
            product.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            product.Location = new Point(237, 23);
            product.Name = "product";
            product.Size = new Size(108, 23);
            product.TabIndex = 6;
            product.Text = "PRODUCTS";
            // 
            // food
            // 
            food.AutoSize = true;
            food.Location = new Point(131, 65);
            food.Name = "food";
            food.Size = new Size(47, 15);
            food.TabIndex = 7;
            food.Text = "FOODS";
            // 
            // drink
            // 
            drink.AutoSize = true;
            drink.Location = new Point(392, 65);
            drink.Name = "drink";
            drink.Size = new Size(50, 15);
            drink.TabIndex = 8;
            drink.Text = "DRINKS";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 318);
            Controls.Add(drink);
            Controls.Add(food);
            Controls.Add(product);
            Controls.Add(rev2);
            Controls.Add(add2);
            Controls.Add(rev1);
            Controls.Add(add1);
            Controls.Add(view2);
            Controls.Add(view1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Products";
            Text = "Products";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView view1;
        private ListView view2;
        private Button add1;
        private Button rev1;
        private Button add2;
        private Button rev2;
        private Label product;
        private Label food;
        private Label drink;
    }
}