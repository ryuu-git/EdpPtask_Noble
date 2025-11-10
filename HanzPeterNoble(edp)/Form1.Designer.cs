namespace HanzPeterNoble_edp_
{
    partial class Form1
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
            view = new Button();
            order = new Button();
            SuspendLayout();
            // 
            // view
            // 
            view.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            view.Location = new Point(52, 68);
            view.Name = "view";
            view.Size = new Size(139, 51);
            view.TabIndex = 0;
            view.Text = "VIEW PRODUCT";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // order
            // 
            order.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order.Location = new Point(52, 156);
            order.Name = "order";
            order.Size = new Size(139, 51);
            order.TabIndex = 1;
            order.Text = "ORDERS";
            order.UseVisualStyleBackColor = true;
            order.Click += order_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 272);
            Controls.Add(order);
            Controls.Add(view);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button view;
        private Button order;
    }
}
