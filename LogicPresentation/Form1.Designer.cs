namespace LogicPresentation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddExpressionButton = new System.Windows.Forms.Button();
            this.ExpressionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpressionList = new System.Windows.Forms.ListBox();
            this.VariableList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ForceCalculateExpressionsButton = new System.Windows.Forms.Button();
            this.NotCalculatedExpressions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ForceCalculateExpressionsButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AddExpressionButton);
            this.groupBox1.Controls.Add(this.ExpressionTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ExpressionList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expressions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddExpressionButton
            // 
            this.AddExpressionButton.Location = new System.Drawing.Point(150, 43);
            this.AddExpressionButton.Name = "AddExpressionButton";
            this.AddExpressionButton.Size = new System.Drawing.Size(126, 23);
            this.AddExpressionButton.TabIndex = 3;
            this.AddExpressionButton.Text = "Add Epression";
            this.AddExpressionButton.UseVisualStyleBackColor = true;
            this.AddExpressionButton.Click += new System.EventHandler(this.AddExpressionButton_Click);
            // 
            // ExpressionTextBox
            // 
            this.ExpressionTextBox.Location = new System.Drawing.Point(150, 16);
            this.ExpressionTextBox.Name = "ExpressionTextBox";
            this.ExpressionTextBox.Size = new System.Drawing.Size(126, 20);
            this.ExpressionTextBox.TabIndex = 2;
            this.ExpressionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExpressionTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter you expression here";
            // 
            // ExpressionList
            // 
            this.ExpressionList.FormattingEnabled = true;
            this.ExpressionList.Location = new System.Drawing.Point(9, 72);
            this.ExpressionList.Name = "ExpressionList";
            this.ExpressionList.Size = new System.Drawing.Size(167, 186);
            this.ExpressionList.TabIndex = 0;
            // 
            // VariableList
            // 
            this.VariableList.FormattingEnabled = true;
            this.VariableList.Location = new System.Drawing.Point(6, 50);
            this.VariableList.Name = "VariableList";
            this.VariableList.Size = new System.Drawing.Size(145, 212);
            this.VariableList.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NotCalculatedExpressions);
            this.groupBox2.Controls.Add(this.ResultLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.VariableList);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 340);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(9, 274);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Variables";
            // 
            // ForceCalculateExpressionsButton
            // 
            this.ForceCalculateExpressionsButton.Location = new System.Drawing.Point(9, 264);
            this.ForceCalculateExpressionsButton.Name = "ForceCalculateExpressionsButton";
            this.ForceCalculateExpressionsButton.Size = new System.Drawing.Size(126, 23);
            this.ForceCalculateExpressionsButton.TabIndex = 6;
            this.ForceCalculateExpressionsButton.Text = "Force Calculate";
            this.ForceCalculateExpressionsButton.UseVisualStyleBackColor = true;
            this.ForceCalculateExpressionsButton.Click += new System.EventHandler(this.ForceCalculateExpressionsButton_Click);
            // 
            // NotCalculatedExpressions
            // 
            this.NotCalculatedExpressions.FormattingEnabled = true;
            this.NotCalculatedExpressions.Location = new System.Drawing.Point(157, 50);
            this.NotCalculatedExpressions.Name = "NotCalculatedExpressions";
            this.NotCalculatedExpressions.Size = new System.Drawing.Size(145, 212);
            this.NotCalculatedExpressions.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Not Calculated Expressions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Logic Presentation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ExpressionList;
        private System.Windows.Forms.Button AddExpressionButton;
        private System.Windows.Forms.TextBox ExpressionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox VariableList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ForceCalculateExpressionsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox NotCalculatedExpressions;

    }
}

