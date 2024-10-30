namespace TempEarthPredition
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
            label1 = new Label();
            textBoxYear = new TextBox();
            buttonPredict = new Button();
            label2 = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter Year:";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(23, 57);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(316, 26);
            textBoxYear.TabIndex = 1;
            // 
            // buttonPredict
            // 
            buttonPredict.BackColor = Color.White;
            buttonPredict.FlatStyle = FlatStyle.Flat;
            buttonPredict.Location = new Point(23, 128);
            buttonPredict.Name = "buttonPredict";
            buttonPredict.Size = new Size(316, 38);
            buttonPredict.TabIndex = 2;
            buttonPredict.Text = "Predict";
            buttonPredict.UseVisualStyleBackColor = false;
            buttonPredict.Click += buttonPredict_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(23, 185);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 0;
            label2.Text = "Temp - C";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(23, 211);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(316, 26);
            textBoxResult.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 263);
            Controls.Add(buttonPredict);
            Controls.Add(textBoxResult);
            Controls.Add(label2);
            Controls.Add(textBoxYear);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxYear;
        private Button buttonPredict;
        private Label label2;
        private TextBox textBoxResult;
    }
}
