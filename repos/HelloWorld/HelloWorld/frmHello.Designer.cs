namespace HelloWorld
{
    partial class frmHello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHello));
            this.lblGreeting = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNamePrompt = new System.Windows.Forms.Label();
            this.btnGreet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.BackColor = System.Drawing.Color.Navy;
            this.lblGreeting.Font = new System.Drawing.Font("Berlin Sans FB Demi", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Yellow;
            this.lblGreeting.Location = new System.Drawing.Point(446, 34);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(321, 98);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello World";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(446, 237);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(321, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblNamePrompt
            // 
            this.lblNamePrompt.AutoSize = true;
            this.lblNamePrompt.BackColor = System.Drawing.Color.LightGray;
            this.lblNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.lblNamePrompt.Location = new System.Drawing.Point(538, 177);
            this.lblNamePrompt.Name = "lblNamePrompt";
            this.lblNamePrompt.Size = new System.Drawing.Size(154, 18);
            this.lblNamePrompt.TabIndex = 2;
            this.lblNamePrompt.Text = "What is Your Name?";
            // 
            // btnGreet
            // 
            this.btnGreet.Location = new System.Drawing.Point(563, 296);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(106, 41);
            this.btnGreet.TabIndex = 3;
            this.btnGreet.Text = "&Greet me";
            this.btnGreet.UseVisualStyleBackColor = true;
            this.btnGreet.Click += new System.EventHandler(this.btnGreet_Click);
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1139, 388);
            this.Controls.Add(this.btnGreet);
            this.Controls.Add(this.lblNamePrompt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGreeting);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHello";
            this.Text = "My first C# Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNamePrompt;
        private System.Windows.Forms.Button btnGreet;
    }
}

