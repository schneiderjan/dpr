namespace PizzaShopStatePattern
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
            this.processLb = new System.Windows.Forms.ListBox();
            this.selectionLb = new System.Windows.Forms.ListBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.GatherTimer = new System.Windows.Forms.Timer(this.components);
            this.CookTimer = new System.Windows.Forms.Timer(this.components);
            this.PackTimer = new System.Windows.Forms.Timer(this.components);
            this.DeliverTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processLb
            // 
            this.processLb.FormattingEnabled = true;
            this.processLb.Location = new System.Drawing.Point(212, 61);
            this.processLb.Name = "processLb";
            this.processLb.Size = new System.Drawing.Size(494, 459);
            this.processLb.TabIndex = 0;
            // 
            // selectionLb
            // 
            this.selectionLb.FormattingEnabled = true;
            this.selectionLb.Location = new System.Drawing.Point(12, 61);
            this.selectionLb.Name = "selectionLb";
            this.selectionLb.Size = new System.Drawing.Size(185, 472);
            this.selectionLb.TabIndex = 1;
            this.selectionLb.SelectedIndexChanged += new System.EventHandler(this.selectionLb_SelectedIndexChanged);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(12, 539);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(185, 33);
            this.orderBtn.TabIndex = 2;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // GatherTimer
            // 
            this.GatherTimer.Tick += new System.EventHandler(this.GatherTimer_Tick_1);
            // 
            // CookTimer
            // 
            this.CookTimer.Tick += new System.EventHandler(this.CookTimer_Tick);
            // 
            // PackTimer
            // 
            this.PackTimer.Tick += new System.EventHandler(this.PackTimer_Tick);
            // 
            // DeliverTimer
            // 
            this.DeliverTimer.Tick += new System.EventHandler(this.DeliverTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(207, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(292, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pizza Selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(207, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order process";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.selectionLb);
            this.Controls.Add(this.processLb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox processLb;
        private System.Windows.Forms.ListBox selectionLb;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Timer GatherTimer;
        private System.Windows.Forms.Timer CookTimer;
        private System.Windows.Forms.Timer PackTimer;
        private System.Windows.Forms.Timer DeliverTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

