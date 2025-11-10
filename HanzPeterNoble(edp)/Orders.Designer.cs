namespace HanzPeterNoble_edp_
{
    partial class Orders
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
            title = new Label();
            food = new Label();
            drink = new Label();
            order = new Button();
            SuspendLayout();
            // 
            // view1
            // 
            view1.Location = new Point(26, 101);
            view1.Name = "view1";
            view1.Size = new Size(142, 179);
            view1.TabIndex = 0;
            view1.UseCompatibleStateImageBehavior = false;
            // 
            // view2
            // 
            view2.Location = new Point(218, 101);
            view2.Name = "view2";
            view2.Size = new Size(142, 179);
            view2.TabIndex = 1;
            view2.UseCompatibleStateImageBehavior = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(152, 30);
            title.Name = "title";
            title.Size = new Size(83, 23);
            title.TabIndex = 2;
            title.Text = "ORDERS";
            // 
            // food
            // 
            food.AutoSize = true;
            food.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food.Location = new Point(76, 83);
            food.Name = "food";
            food.Size = new Size(40, 15);
            food.TabIndex = 3;
            food.Text = "FOOD";
            // 
            // drink
            // 
            drink.AutoSize = true;
            drink.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            drink.Location = new Point(264, 83);
            drink.Name = "drink";
            drink.Size = new Size(50, 15);
            drink.TabIndex = 4;
            drink.Text = "DRINKS";
            // 
            // order
            // 
            order.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order.Location = new Point(113, 324);
            order.Name = "order";
            order.Size = new Size(159, 23);
            order.TabIndex = 5;
            order.Text = "ORDER";
            order.UseVisualStyleBackColor = true;
            order.Click += order_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 378);
            Controls.Add(order);
            Controls.Add(drink);
            Controls.Add(food);
            Controls.Add(title);
            Controls.Add(view2);
            Controls.Add(view1);
            Name = "Orders";
            Text = "Orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView view1;
        private ListView view2;
        private Label title;
        private Label food;
        private Label drink;
        private Button order;
    }
}