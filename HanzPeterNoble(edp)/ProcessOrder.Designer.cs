namespace HanzPeterNoble_edp_
{
    partial class ProcessOrder
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
            insert2 = new TextBox();
            names = new TextBox();
            view = new ListView();
            add = new Button();
            rev = new Button();
            pay = new Button();
            print = new Button();
            title = new Label();
            total = new Label();
            payment = new Label();
            change = new Label();
            name = new Label();
            SuspendLayout();
            // 
            // insert
            // 
            insert.Location = new Point(34, 62);
            insert.Name = "insert";
            insert.Size = new Size(100, 23);
            insert.TabIndex = 0;
            // 
            // insert2
            // 
            insert2.Location = new Point(123, 278);
            insert2.Name = "insert2";
            insert2.Size = new Size(50, 23);
            insert2.TabIndex = 1;
            // 
            // names
            // 
            names.Location = new Point(108, 339);
            names.Name = "names";
            names.Size = new Size(108, 23);
            names.TabIndex = 2;
            // 
            // view
            // 
            view.Location = new Point(60, 97);
            view.Name = "view";
            view.Size = new Size(151, 144);
            view.TabIndex = 3;
            view.UseCompatibleStateImageBehavior = false;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(140, 61);
            add.Name = "add";
            add.Size = new Size(41, 23);
            add.TabIndex = 4;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // rev
            // 
            rev.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rev.Location = new Point(187, 62);
            rev.Name = "rev";
            rev.Size = new Size(63, 23);
            rev.TabIndex = 5;
            rev.Text = "REMOVE";
            rev.UseVisualStyleBackColor = true;
            rev.Click += rev_Click;
            // 
            // pay
            // 
            pay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pay.Location = new Point(179, 278);
            pay.Name = "pay";
            pay.Size = new Size(37, 23);
            pay.TabIndex = 6;
            pay.Text = "PAY";
            pay.UseVisualStyleBackColor = true;
            // 
            // print
            // 
            print.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            print.Location = new Point(60, 385);
            print.Name = "print";
            print.Size = new Size(151, 23);
            print.TabIndex = 7;
            print.Text = "PRINT";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(60, 19);
            title.Name = "title";
            title.Size = new Size(156, 22);
            title.TabIndex = 8;
            title.Text = "PROCESS ORDER";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(60, 254);
            total.Name = "total";
            total.Size = new Size(36, 15);
            total.TabIndex = 9;
            total.Text = "Total:";
            // 
            // payment
            // 
            payment.AutoSize = true;
            payment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment.Location = new Point(60, 281);
            payment.Name = "payment";
            payment.Size = new Size(57, 15);
            payment.TabIndex = 10;
            payment.Text = "Payment:";
            // 
            // change
            // 
            change.AutoSize = true;
            change.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            change.Location = new Point(60, 310);
            change.Name = "change";
            change.Size = new Size(50, 15);
            change.TabIndex = 11;
            change.Text = "Change:";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(60, 342);
            name.Name = "name";
            name.Size = new Size(42, 15);
            name.TabIndex = 12;
            name.Text = "Name:";
            // 
            // ProcessOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 450);
            Controls.Add(name);
            Controls.Add(change);
            Controls.Add(payment);
            Controls.Add(total);
            Controls.Add(title);
            Controls.Add(print);
            Controls.Add(pay);
            Controls.Add(rev);
            Controls.Add(add);
            Controls.Add(view);
            Controls.Add(names);
            Controls.Add(insert2);
            Controls.Add(insert);
            Name = "ProcessOrder";
            Text = "ProcessOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox insert;
        private TextBox insert2;
        private TextBox names;
        private ListView view;
        private Button add;
        private Button rev;
        private Button pay;
        private Button print;
        private Label title;
        private Label total;
        private Label payment;
        private Label change;
        private Label name;
    }
}