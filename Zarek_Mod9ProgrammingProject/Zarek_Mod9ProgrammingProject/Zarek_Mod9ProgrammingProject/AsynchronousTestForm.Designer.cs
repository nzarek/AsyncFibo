namespace Zarek_Mod9ProgrammingProject
{
    partial class AsynchronousTestForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCalls = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(386, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Asynchronous Fibonacci Calls";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCalls
            // 
            this.lblCalls.AutoSize = true;
            this.lblCalls.Location = new System.Drawing.Point(13, 19);
            this.lblCalls.Name = "lblCalls";
            this.lblCalls.Size = new System.Drawing.Size(389, 17);
            this.lblCalls.TabIndex = 1;
            this.lblCalls.Text = "Calls to Fibonacci(46) and Fibonacci(45) in separate threads";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(16, 82);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(386, 161);
            this.txtOutput.TabIndex = 2;
            // 
            // AsynchronousTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 255);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblCalls);
            this.Controls.Add(this.btnStart);
            this.Name = "AsynchronousTestForm";
            this.Text = "Asynchronous Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCalls;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

