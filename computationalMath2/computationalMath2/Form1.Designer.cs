
namespace computationalMath2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ErrorBox = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxTrapezoid = new System.Windows.Forms.TextBox();
            this.textBoxSimpson = new System.Windows.Forms.TextBox();
            this.textBoxNewton = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeTextBoxT = new System.Windows.Forms.TextBox();
            this.timeTextBoxS = new System.Windows.Forms.TextBox();
            this.timeTextBoxN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorBox
            // 
            this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorBox.Location = new System.Drawing.Point(12, 12);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(120, 34);
            this.ErrorBox.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(624, 375);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(160, 42);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxTrapezoid
            // 
            this.textBoxTrapezoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTrapezoid.Location = new System.Drawing.Point(31, 315);
            this.textBoxTrapezoid.Name = "textBoxTrapezoid";
            this.textBoxTrapezoid.Size = new System.Drawing.Size(122, 34);
            this.textBoxTrapezoid.TabIndex = 3;
            // 
            // textBoxSimpson
            // 
            this.textBoxSimpson.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSimpson.Location = new System.Drawing.Point(187, 315);
            this.textBoxSimpson.Name = "textBoxSimpson";
            this.textBoxSimpson.Size = new System.Drawing.Size(122, 34);
            this.textBoxSimpson.TabIndex = 4;
            // 
            // textBoxNewton
            // 
            this.textBoxNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewton.Location = new System.Drawing.Point(344, 315);
            this.textBoxNewton.Name = "textBoxNewton";
            this.textBoxNewton.Size = new System.Drawing.Size(122, 34);
            this.textBoxNewton.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Трапеция";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(182, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Симпсона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(355, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ньютон";
            // 
            // timeTextBoxT
            // 
            this.timeTextBoxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTextBoxT.Location = new System.Drawing.Point(31, 377);
            this.timeTextBoxT.Margin = new System.Windows.Forms.Padding(4);
            this.timeTextBoxT.Name = "timeTextBoxT";
            this.timeTextBoxT.Size = new System.Drawing.Size(124, 34);
            this.timeTextBoxT.TabIndex = 12;
            // 
            // timeTextBoxS
            // 
            this.timeTextBoxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTextBoxS.Location = new System.Drawing.Point(187, 377);
            this.timeTextBoxS.Margin = new System.Windows.Forms.Padding(4);
            this.timeTextBoxS.Name = "timeTextBoxS";
            this.timeTextBoxS.Size = new System.Drawing.Size(127, 34);
            this.timeTextBoxS.TabIndex = 13;
            // 
            // timeTextBoxN
            // 
            this.timeTextBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTextBoxN.Location = new System.Drawing.Point(344, 377);
            this.timeTextBoxN.Margin = new System.Windows.Forms.Padding(4);
            this.timeTextBoxN.Name = "timeTextBoxN";
            this.timeTextBoxN.Size = new System.Drawing.Size(133, 34);
            this.timeTextBoxN.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(501, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Время ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(501, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Значение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timeTextBoxN);
            this.Controls.Add(this.timeTextBoxS);
            this.Controls.Add(this.timeTextBoxT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewton);
            this.Controls.Add(this.textBoxSimpson);
            this.Controls.Add(this.textBoxTrapezoid);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.ErrorBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ErrorBox;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxTrapezoid;
        private System.Windows.Forms.TextBox textBoxSimpson;
        private System.Windows.Forms.TextBox textBoxNewton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeTextBoxT;
        private System.Windows.Forms.TextBox timeTextBoxS;
        private System.Windows.Forms.TextBox timeTextBoxN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

