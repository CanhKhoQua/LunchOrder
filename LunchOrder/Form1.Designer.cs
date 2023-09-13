namespace LunchOrder
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
            gbxMainCourse = new System.Windows.Forms.GroupBox();
            rdbSalad = new System.Windows.Forms.RadioButton();
            rdbPizza = new System.Windows.Forms.RadioButton();
            rdbBurger = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtOrderTotal = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtSalesTax = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnPlaceOrder = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            checkFries = new System.Windows.Forms.CheckBox();
            checkSauce = new System.Windows.Forms.CheckBox();
            checkVeg = new System.Windows.Forms.CheckBox();
            gbxMainCourse.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(rdbSalad);
            gbxMainCourse.Controls.Add(rdbPizza);
            gbxMainCourse.Controls.Add(rdbBurger);
            gbxMainCourse.Location = new System.Drawing.Point(39, 23);
            gbxMainCourse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            gbxMainCourse.Size = new System.Drawing.Size(182, 131);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // rdbSalad
            // 
            rdbSalad.AutoSize = true;
            rdbSalad.Location = new System.Drawing.Point(25, 86);
            rdbSalad.Name = "rdbSalad";
            rdbSalad.Size = new System.Drawing.Size(116, 24);
            rdbSalad.TabIndex = 2;
            rdbSalad.Text = "Salad - $4.95";
            rdbSalad.UseVisualStyleBackColor = true;
            rdbSalad.CheckedChanged += rdbSalad_CheckedChanged;
            // 
            // rdbPizza
            // 
            rdbPizza.AutoSize = true;
            rdbPizza.Location = new System.Drawing.Point(25, 56);
            rdbPizza.Name = "rdbPizza";
            rdbPizza.Size = new System.Drawing.Size(113, 24);
            rdbPizza.TabIndex = 1;
            rdbPizza.Text = "Pizza - $5.95";
            rdbPizza.UseVisualStyleBackColor = true;
            rdbPizza.CheckedChanged += rdnPizza_CheckedChanged;
            // 
            // rdbBurger
            // 
            rdbBurger.AutoSize = true;
            rdbBurger.Checked = true;
            rdbBurger.Location = new System.Drawing.Point(25, 26);
            rdbBurger.Name = "rdbBurger";
            rdbBurger.Size = new System.Drawing.Size(155, 24);
            rdbBurger.TabIndex = 0;
            rdbBurger.TabStop = true;
            rdbBurger.Text = "Hamburger - $6.95";
            rdbBurger.UseVisualStyleBackColor = true;
            rdbBurger.CheckedChanged += rdbBurger_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(39, 177);
            groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox2.Size = new System.Drawing.Size(297, 153);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new System.Drawing.Point(128, 101);
            txtOrderTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new System.Drawing.Size(121, 27);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(32, 105);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new System.Drawing.Point(128, 67);
            txtSalesTax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new System.Drawing.Size(121, 27);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(32, 71);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new System.Drawing.Point(128, 31);
            txtSubtotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(121, 27);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(49, 35);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new System.Drawing.Point(366, 191);
            btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new System.Drawing.Size(89, 33);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(366, 296);
            btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(89, 33);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkFries);
            groupBox1.Controls.Add(checkSauce);
            groupBox1.Controls.Add(checkVeg);
            groupBox1.Location = new System.Drawing.Point(242, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(250, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add-on items ($.75/each)";
            // 
            // checkFries
            // 
            checkFries.AutoSize = true;
            checkFries.Location = new System.Drawing.Point(24, 90);
            checkFries.Name = "checkFries";
            checkFries.Size = new System.Drawing.Size(106, 24);
            checkFries.TabIndex = 2;
            checkFries.Text = "French fries";
            checkFries.UseVisualStyleBackColor = true;
            checkFries.CheckedChanged += checkFries_CheckedChanged;
            // 
            // checkSauce
            // 
            checkSauce.AutoSize = true;
            checkSauce.Location = new System.Drawing.Point(24, 60);
            checkSauce.Name = "checkSauce";
            checkSauce.Size = new System.Drawing.Size(219, 24);
            checkSauce.TabIndex = 1;
            checkSauce.Text = "Ketchup, mustard, and mayo";
            checkSauce.UseVisualStyleBackColor = true;
            checkSauce.CheckedChanged += checkSauce_CheckedChanged;
            // 
            // checkVeg
            // 
            checkVeg.AutoSize = true;
            checkVeg.Location = new System.Drawing.Point(24, 32);
            checkVeg.Name = "checkVeg";
            checkVeg.Size = new System.Drawing.Size(215, 24);
            checkVeg.TabIndex = 0;
            checkVeg.Text = "Lettuce, tomato, and onions";
            checkVeg.UseVisualStyleBackColor = true;
            checkVeg.CheckedChanged += checkVeg_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(495, 365);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Lunch Order - Loc Nguyen";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdbSalad;
        private System.Windows.Forms.RadioButton rdbPizza;
        private System.Windows.Forms.RadioButton rdbBurger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkFries;
        private System.Windows.Forms.CheckBox checkSauce;
        private System.Windows.Forms.CheckBox checkVeg;
    }
}

