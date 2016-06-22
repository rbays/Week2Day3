namespace MathsQuiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addLeft = new System.Windows.Forms.Label();
            this.addRight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addAnswer = new System.Windows.Forms.NumericUpDown();
            this.minusAnswer = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minusRight = new System.Windows.Forms.Label();
            this.minusLeft = new System.Windows.Forms.Label();
            this.multiplyAnswer = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.multiplyRight = new System.Windows.Forms.Label();
            this.multiplyLeft = new System.Windows.Forms.Label();
            this.divideAnswer = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.divideRight = new System.Windows.Forms.Label();
            this.divideLeft = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(293, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(140, 34);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "30 seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time remaining:";
            // 
            // addLeft
            // 
            this.addLeft.AutoSize = true;
            this.addLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLeft.Location = new System.Drawing.Point(84, 74);
            this.addLeft.Name = "addLeft";
            this.addLeft.Size = new System.Drawing.Size(24, 26);
            this.addLeft.TabIndex = 2;
            this.addLeft.Text = "?";
            // 
            // addRight
            // 
            this.addRight.AutoSize = true;
            this.addRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRight.Location = new System.Drawing.Point(224, 76);
            this.addRight.Name = "addRight";
            this.addRight.Size = new System.Drawing.Size(24, 26);
            this.addRight.TabIndex = 3;
            this.addRight.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // addAnswer
            // 
            this.addAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnswer.Location = new System.Drawing.Point(372, 74);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(61, 32);
            this.addAnswer.TabIndex = 2;
            this.addAnswer.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusAnswer
            // 
            this.minusAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusAnswer.Location = new System.Drawing.Point(372, 112);
            this.minusAnswer.Name = "minusAnswer";
            this.minusAnswer.Size = new System.Drawing.Size(61, 32);
            this.minusAnswer.TabIndex = 3;
            this.minusAnswer.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            // 
            // minusRight
            // 
            this.minusRight.AutoSize = true;
            this.minusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRight.Location = new System.Drawing.Point(224, 114);
            this.minusRight.Name = "minusRight";
            this.minusRight.Size = new System.Drawing.Size(24, 26);
            this.minusRight.TabIndex = 8;
            this.minusRight.Text = "?";
            // 
            // minusLeft
            // 
            this.minusLeft.AutoSize = true;
            this.minusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeft.Location = new System.Drawing.Point(84, 112);
            this.minusLeft.Name = "minusLeft";
            this.minusLeft.Size = new System.Drawing.Size(24, 26);
            this.minusLeft.TabIndex = 7;
            this.minusLeft.Text = "?";
            // 
            // multiplyAnswer
            // 
            this.multiplyAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyAnswer.Location = new System.Drawing.Point(372, 150);
            this.multiplyAnswer.Name = "multiplyAnswer";
            this.multiplyAnswer.Size = new System.Drawing.Size(61, 32);
            this.multiplyAnswer.TabIndex = 4;
            this.multiplyAnswer.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(160, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "×";
            // 
            // multiplyRight
            // 
            this.multiplyRight.AutoSize = true;
            this.multiplyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyRight.Location = new System.Drawing.Point(224, 152);
            this.multiplyRight.Name = "multiplyRight";
            this.multiplyRight.Size = new System.Drawing.Size(24, 26);
            this.multiplyRight.TabIndex = 13;
            this.multiplyRight.Text = "?";
            // 
            // multiplyLeft
            // 
            this.multiplyLeft.AutoSize = true;
            this.multiplyLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyLeft.Location = new System.Drawing.Point(84, 150);
            this.multiplyLeft.Name = "multiplyLeft";
            this.multiplyLeft.Size = new System.Drawing.Size(24, 26);
            this.multiplyLeft.TabIndex = 12;
            this.multiplyLeft.Text = "?";
            // 
            // divideAnswer
            // 
            this.divideAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideAnswer.Location = new System.Drawing.Point(372, 188);
            this.divideAnswer.Name = "divideAnswer";
            this.divideAnswer.Size = new System.Drawing.Size(61, 32);
            this.divideAnswer.TabIndex = 5;
            this.divideAnswer.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(288, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(160, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 26);
            this.label13.TabIndex = 19;
            this.label13.Text = "÷";
            // 
            // divideRight
            // 
            this.divideRight.AutoSize = true;
            this.divideRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideRight.Location = new System.Drawing.Point(224, 190);
            this.divideRight.Name = "divideRight";
            this.divideRight.Size = new System.Drawing.Size(24, 26);
            this.divideRight.TabIndex = 18;
            this.divideRight.Text = "?";
            // 
            // divideLeft
            // 
            this.divideLeft.AutoSize = true;
            this.divideLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideLeft.Location = new System.Drawing.Point(84, 188);
            this.divideLeft.Name = "divideLeft";
            this.divideLeft.Size = new System.Drawing.Size(24, 26);
            this.divideLeft.TabIndex = 17;
            this.divideLeft.Text = "?";
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(188, 273);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 30);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.divideAnswer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.divideRight);
            this.Controls.Add(this.divideLeft);
            this.Controls.Add(this.multiplyAnswer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.multiplyRight);
            this.Controls.Add(this.multiplyLeft);
            this.Controls.Add(this.minusAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusRight);
            this.Controls.Add(this.minusLeft);
            this.Controls.Add(this.addAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addRight);
            this.Controls.Add(this.addLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Name = "Form1";
            this.Text = "Maths Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.addAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addLeft;
        private System.Windows.Forms.Label addRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addAnswer;
        private System.Windows.Forms.NumericUpDown minusAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusRight;
        private System.Windows.Forms.Label minusLeft;
        private System.Windows.Forms.NumericUpDown multiplyAnswer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label multiplyRight;
        private System.Windows.Forms.Label multiplyLeft;
        private System.Windows.Forms.NumericUpDown divideAnswer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label divideRight;
        private System.Windows.Forms.Label divideLeft;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

