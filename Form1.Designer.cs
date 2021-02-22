
namespace Project_05
{
    partial class FormIceCreamShop
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
            this.groupBoxSelectCone = new System.Windows.Forms.GroupBox();
            this.labelShowPrice = new System.Windows.Forms.Label();
            this.buttonTotalPrice = new System.Windows.Forms.Button();
            this.groupBoxTopping = new System.Windows.Forms.GroupBox();
            this.checkBoxCherry = new System.Windows.Forms.CheckBox();
            this.checkBoxChoppedNuts = new System.Windows.Forms.CheckBox();
            this.checkBoxSprinkles = new System.Windows.Forms.CheckBox();
            this.groupBoxFlavor = new System.Windows.Forms.GroupBox();
            this.radioButtonStrawberry = new System.Windows.Forms.RadioButton();
            this.radioButtonVanilla = new System.Windows.Forms.RadioButton();
            this.radioButtonChocolate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonClearOrders = new System.Windows.Forms.Button();
            this.listBoxConeOrders = new System.Windows.Forms.ListBox();
            this.labelConeOrders = new System.Windows.Forms.Label();
            this.groupBoxSelectCone.SuspendLayout();
            this.groupBoxTopping.SuspendLayout();
            this.groupBoxFlavor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelectCone
            // 
            this.groupBoxSelectCone.Controls.Add(this.labelConeOrders);
            this.groupBoxSelectCone.Controls.Add(this.listBoxConeOrders);
            this.groupBoxSelectCone.Controls.Add(this.buttonClearOrders);
            this.groupBoxSelectCone.Controls.Add(this.buttonAddOrder);
            this.groupBoxSelectCone.Controls.Add(this.groupBoxTopping);
            this.groupBoxSelectCone.Controls.Add(this.groupBoxFlavor);
            this.groupBoxSelectCone.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelectCone.Name = "groupBoxSelectCone";
            this.groupBoxSelectCone.Size = new System.Drawing.Size(519, 221);
            this.groupBoxSelectCone.TabIndex = 0;
            this.groupBoxSelectCone.TabStop = false;
            this.groupBoxSelectCone.Text = "Select Ice Cream Cone";
            // 
            // labelShowPrice
            // 
            this.labelShowPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShowPrice.Location = new System.Drawing.Point(328, 29);
            this.labelShowPrice.Name = "labelShowPrice";
            this.labelShowPrice.Size = new System.Drawing.Size(164, 23);
            this.labelShowPrice.TabIndex = 3;
            this.labelShowPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTotalPrice
            // 
            this.buttonTotalPrice.Location = new System.Drawing.Point(19, 29);
            this.buttonTotalPrice.Name = "buttonTotalPrice";
            this.buttonTotalPrice.Size = new System.Drawing.Size(155, 23);
            this.buttonTotalPrice.TabIndex = 2;
            this.buttonTotalPrice.Text = "Total Price";
            this.buttonTotalPrice.UseVisualStyleBackColor = true;
            this.buttonTotalPrice.Click += new System.EventHandler(this.buttonTotalPrice_Click);
            // 
            // groupBoxTopping
            // 
            this.groupBoxTopping.Controls.Add(this.checkBoxCherry);
            this.groupBoxTopping.Controls.Add(this.checkBoxChoppedNuts);
            this.groupBoxTopping.Controls.Add(this.checkBoxSprinkles);
            this.groupBoxTopping.Location = new System.Drawing.Point(180, 19);
            this.groupBoxTopping.Name = "groupBoxTopping";
            this.groupBoxTopping.Size = new System.Drawing.Size(161, 121);
            this.groupBoxTopping.TabIndex = 1;
            this.groupBoxTopping.TabStop = false;
            this.groupBoxTopping.Text = "Toppings";
            // 
            // checkBoxCherry
            // 
            this.checkBoxCherry.AutoSize = true;
            this.checkBoxCherry.Location = new System.Drawing.Point(11, 87);
            this.checkBoxCherry.Name = "checkBoxCherry";
            this.checkBoxCherry.Size = new System.Drawing.Size(56, 17);
            this.checkBoxCherry.TabIndex = 2;
            this.checkBoxCherry.Text = "Cherry";
            this.checkBoxCherry.UseVisualStyleBackColor = true;
            // 
            // checkBoxChoppedNuts
            // 
            this.checkBoxChoppedNuts.AutoSize = true;
            this.checkBoxChoppedNuts.Location = new System.Drawing.Point(11, 52);
            this.checkBoxChoppedNuts.Name = "checkBoxChoppedNuts";
            this.checkBoxChoppedNuts.Size = new System.Drawing.Size(94, 17);
            this.checkBoxChoppedNuts.TabIndex = 1;
            this.checkBoxChoppedNuts.Text = "Chopped Nuts";
            this.checkBoxChoppedNuts.UseVisualStyleBackColor = true;
            // 
            // checkBoxSprinkles
            // 
            this.checkBoxSprinkles.AutoSize = true;
            this.checkBoxSprinkles.Location = new System.Drawing.Point(11, 19);
            this.checkBoxSprinkles.Name = "checkBoxSprinkles";
            this.checkBoxSprinkles.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSprinkles.TabIndex = 0;
            this.checkBoxSprinkles.Text = "Sprinkles";
            this.checkBoxSprinkles.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlavor
            // 
            this.groupBoxFlavor.Controls.Add(this.radioButtonStrawberry);
            this.groupBoxFlavor.Controls.Add(this.radioButtonVanilla);
            this.groupBoxFlavor.Controls.Add(this.radioButtonChocolate);
            this.groupBoxFlavor.Location = new System.Drawing.Point(19, 19);
            this.groupBoxFlavor.Name = "groupBoxFlavor";
            this.groupBoxFlavor.Size = new System.Drawing.Size(155, 121);
            this.groupBoxFlavor.TabIndex = 0;
            this.groupBoxFlavor.TabStop = false;
            this.groupBoxFlavor.Text = "Flavor";
            // 
            // radioButtonStrawberry
            // 
            this.radioButtonStrawberry.AutoSize = true;
            this.radioButtonStrawberry.Location = new System.Drawing.Point(11, 87);
            this.radioButtonStrawberry.Name = "radioButtonStrawberry";
            this.radioButtonStrawberry.Size = new System.Drawing.Size(75, 17);
            this.radioButtonStrawberry.TabIndex = 2;
            this.radioButtonStrawberry.TabStop = true;
            this.radioButtonStrawberry.Text = "Strawberry";
            this.radioButtonStrawberry.UseVisualStyleBackColor = true;
            // 
            // radioButtonVanilla
            // 
            this.radioButtonVanilla.AutoSize = true;
            this.radioButtonVanilla.Location = new System.Drawing.Point(11, 52);
            this.radioButtonVanilla.Name = "radioButtonVanilla";
            this.radioButtonVanilla.Size = new System.Drawing.Size(56, 17);
            this.radioButtonVanilla.TabIndex = 1;
            this.radioButtonVanilla.TabStop = true;
            this.radioButtonVanilla.Text = "Vanilla";
            this.radioButtonVanilla.UseVisualStyleBackColor = true;
            // 
            // radioButtonChocolate
            // 
            this.radioButtonChocolate.AutoSize = true;
            this.radioButtonChocolate.Location = new System.Drawing.Point(11, 19);
            this.radioButtonChocolate.Name = "radioButtonChocolate";
            this.radioButtonChocolate.Size = new System.Drawing.Size(73, 17);
            this.radioButtonChocolate.TabIndex = 0;
            this.radioButtonChocolate.TabStop = true;
            this.radioButtonChocolate.Text = "Chocolate";
            this.radioButtonChocolate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalPrice);
            this.groupBox1.Controls.Add(this.labelShowPrice);
            this.groupBox1.Controls.Add(this.buttonTotalPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(264, 34);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(19, 157);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(322, 47);
            this.buttonAddOrder.TabIndex = 6;
            this.buttonAddOrder.Text = "Add Ice Cream Cone Order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonClearOrders
            // 
            this.buttonClearOrders.Location = new System.Drawing.Point(347, 157);
            this.buttonClearOrders.Name = "buttonClearOrders";
            this.buttonClearOrders.Size = new System.Drawing.Size(151, 47);
            this.buttonClearOrders.TabIndex = 7;
            this.buttonClearOrders.Text = "Clear Ice Cream Cone Orders";
            this.buttonClearOrders.UseVisualStyleBackColor = true;
            this.buttonClearOrders.Click += new System.EventHandler(this.buttonClearOrders_Click);
            // 
            // listBoxConeOrders
            // 
            this.listBoxConeOrders.FormattingEnabled = true;
            this.listBoxConeOrders.Location = new System.Drawing.Point(347, 28);
            this.listBoxConeOrders.Name = "listBoxConeOrders";
            this.listBoxConeOrders.Size = new System.Drawing.Size(151, 108);
            this.listBoxConeOrders.TabIndex = 8;
            // 
            // labelConeOrders
            // 
            this.labelConeOrders.AutoSize = true;
            this.labelConeOrders.Location = new System.Drawing.Point(347, 12);
            this.labelConeOrders.Name = "labelConeOrders";
            this.labelConeOrders.Size = new System.Drawing.Size(117, 13);
            this.labelConeOrders.TabIndex = 9;
            this.labelConeOrders.Text = "Ice Cream Cone Orders";
            // 
            // FormIceCreamShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSelectCone);
            this.Name = "FormIceCreamShop";
            this.Text = "Ice Cream Shop";
            this.groupBoxSelectCone.ResumeLayout(false);
            this.groupBoxSelectCone.PerformLayout();
            this.groupBoxTopping.ResumeLayout(false);
            this.groupBoxTopping.PerformLayout();
            this.groupBoxFlavor.ResumeLayout(false);
            this.groupBoxFlavor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelectCone;
        private System.Windows.Forms.GroupBox groupBoxTopping;
        private System.Windows.Forms.CheckBox checkBoxCherry;
        private System.Windows.Forms.CheckBox checkBoxChoppedNuts;
        private System.Windows.Forms.CheckBox checkBoxSprinkles;
        private System.Windows.Forms.GroupBox groupBoxFlavor;
        private System.Windows.Forms.RadioButton radioButtonStrawberry;
        private System.Windows.Forms.RadioButton radioButtonVanilla;
        private System.Windows.Forms.RadioButton radioButtonChocolate;
        private System.Windows.Forms.Button buttonTotalPrice;
        private System.Windows.Forms.Label labelShowPrice;
        private System.Windows.Forms.Label labelConeOrders;
        private System.Windows.Forms.ListBox listBoxConeOrders;
        private System.Windows.Forms.Button buttonClearOrders;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTotalPrice;
    }
}

