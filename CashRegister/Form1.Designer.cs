namespace CashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.chocolateLabel = new System.Windows.Forms.Label();
            this.gummyLabel = new System.Windows.Forms.Label();
            this.lollipopLabel = new System.Windows.Forms.Label();
            this.chocolateInput = new System.Windows.Forms.TextBox();
            this.lollipopInput = new System.Windows.Forms.TextBox();
            this.gummyInput = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.storeName = new System.Windows.Forms.Label();
            this.seperatorLabel = new System.Windows.Forms.Label();
            this.tenderLabel = new System.Windows.Forms.Label();
            this.tenderInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.recieptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // chocolateLabel
            // 
            this.chocolateLabel.AutoSize = true;
            this.chocolateLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocolateLabel.Location = new System.Drawing.Point(34, 126);
            this.chocolateLabel.Name = "chocolateLabel";
            this.chocolateLabel.Size = new System.Drawing.Size(182, 15);
            this.chocolateLabel.TabIndex = 4;
            this.chocolateLabel.Text = "Number of chocolate bars:";
            // 
            // gummyLabel
            // 
            this.gummyLabel.AutoSize = true;
            this.gummyLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gummyLabel.Location = new System.Drawing.Point(34, 201);
            this.gummyLabel.Name = "gummyLabel";
            this.gummyLabel.Size = new System.Drawing.Size(175, 15);
            this.gummyLabel.TabIndex = 5;
            this.gummyLabel.Text = "Number of gummy packets:";
            // 
            // lollipopLabel
            // 
            this.lollipopLabel.AutoSize = true;
            this.lollipopLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel.Location = new System.Drawing.Point(34, 164);
            this.lollipopLabel.Name = "lollipopLabel";
            this.lollipopLabel.Size = new System.Drawing.Size(147, 15);
            this.lollipopLabel.TabIndex = 6;
            this.lollipopLabel.Text = "Number of lollipops:";
            // 
            // chocolateInput
            // 
            this.chocolateInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocolateInput.Location = new System.Drawing.Point(220, 126);
            this.chocolateInput.Name = "chocolateInput";
            this.chocolateInput.Size = new System.Drawing.Size(75, 23);
            this.chocolateInput.TabIndex = 7;
            this.chocolateInput.Text = "0";
            // 
            // lollipopInput
            // 
            this.lollipopInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopInput.Location = new System.Drawing.Point(220, 164);
            this.lollipopInput.Name = "lollipopInput";
            this.lollipopInput.Size = new System.Drawing.Size(75, 23);
            this.lollipopInput.TabIndex = 8;
            this.lollipopInput.Text = "0";
            // 
            // gummyInput
            // 
            this.gummyInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gummyInput.Location = new System.Drawing.Point(220, 198);
            this.gummyInput.Name = "gummyInput";
            this.gummyInput.Size = new System.Drawing.Size(75, 23);
            this.gummyInput.TabIndex = 9;
            this.gummyInput.Text = "0";
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(37, 236);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(258, 30);
            this.totalButton.TabIndex = 10;
            this.totalButton.Text = "Calculate Totals";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(34, 274);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(261, 47);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(34, 341);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(261, 29);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(34, 305);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(261, 25);
            this.taxLabel.TabIndex = 13;
            this.taxLabel.Text = "Tax:";
            // 
            // storeName
            // 
            this.storeName.BackColor = System.Drawing.Color.LightPink;
            this.storeName.Cursor = System.Windows.Forms.Cursors.Default;
            this.storeName.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.storeName.Location = new System.Drawing.Point(0, 0);
            this.storeName.Name = "storeName";
            this.storeName.Size = new System.Drawing.Size(740, 66);
            this.storeName.TabIndex = 14;
            this.storeName.Text = "CANDY CORNER";
            this.storeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seperatorLabel
            // 
            this.seperatorLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seperatorLabel.Location = new System.Drawing.Point(34, 370);
            this.seperatorLabel.Name = "seperatorLabel";
            this.seperatorLabel.Size = new System.Drawing.Size(261, 10);
            this.seperatorLabel.TabIndex = 15;
            // 
            // tenderLabel
            // 
            this.tenderLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderLabel.Location = new System.Drawing.Point(34, 396);
            this.tenderLabel.Name = "tenderLabel";
            this.tenderLabel.Size = new System.Drawing.Size(261, 29);
            this.tenderLabel.TabIndex = 16;
            this.tenderLabel.Text = "Tendered:";
            // 
            // tenderInput
            // 
            this.tenderInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderInput.Location = new System.Drawing.Point(220, 393);
            this.tenderInput.Name = "tenderInput";
            this.tenderInput.Size = new System.Drawing.Size(75, 23);
            this.tenderInput.TabIndex = 17;
            this.tenderInput.Text = "0";
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(37, 428);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(258, 30);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(34, 477);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(261, 29);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change:";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(369, 129);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(322, 423);
            this.outputLabel.TabIndex = 20;
            // 
            // recieptButton
            // 
            this.recieptButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptButton.Location = new System.Drawing.Point(37, 522);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(258, 30);
            this.recieptButton.TabIndex = 22;
            this.recieptButton.Text = "Print Receipt";
            this.recieptButton.UseVisualStyleBackColor = true;
            this.recieptButton.Click += new System.EventHandler(this.RecieptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(401, 85);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(258, 30);
            this.newOrderButton.TabIndex = 23;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(34, 85);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(361, 33);
            this.errorLabel.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(737, 581);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.recieptButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderInput);
            this.Controls.Add(this.tenderLabel);
            this.Controls.Add(this.seperatorLabel);
            this.Controls.Add(this.storeName);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.gummyInput);
            this.Controls.Add(this.lollipopInput);
            this.Controls.Add(this.chocolateInput);
            this.Controls.Add(this.lollipopLabel);
            this.Controls.Add(this.gummyLabel);
            this.Controls.Add(this.chocolateLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chocolateLabel;
        private System.Windows.Forms.Label gummyLabel;
        private System.Windows.Forms.Label lollipopLabel;
        private System.Windows.Forms.TextBox chocolateInput;
        private System.Windows.Forms.TextBox lollipopInput;
        private System.Windows.Forms.TextBox gummyInput;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label storeName;
        private System.Windows.Forms.Label seperatorLabel;
        private System.Windows.Forms.Label tenderLabel;
        private System.Windows.Forms.TextBox tenderInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button recieptButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

