namespace MsgRev
{
    partial class MsgRev
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uitbxRev = new Sunny.UI.UITextBox();
            this.uibtnClr = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uitbxRev
            // 
            this.uitbxRev.ButtonSymbol = 61761;
            this.uitbxRev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxRev.FillColor = System.Drawing.Color.White;
            this.uitbxRev.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxRev.Location = new System.Drawing.Point(27, 43);
            this.uitbxRev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxRev.Maximum = 2147483647D;
            this.uitbxRev.Minimum = -2147483648D;
            this.uitbxRev.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxRev.Multiline = true;
            this.uitbxRev.Name = "uitbxRev";
            this.uitbxRev.ShowScrollBar = true;
            this.uitbxRev.Size = new System.Drawing.Size(446, 287);
            this.uitbxRev.TabIndex = 1;
            this.uitbxRev.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uibtnClr
            // 
            this.uibtnClr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnClr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnClr.Location = new System.Drawing.Point(373, 369);
            this.uibtnClr.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnClr.Name = "uibtnClr";
            this.uibtnClr.Size = new System.Drawing.Size(100, 35);
            this.uibtnClr.TabIndex = 2;
            this.uibtnClr.Text = "Clear";
            this.uibtnClr.Click += new System.EventHandler(this.uibtnClr_Click);
            // 
            // MsgRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.uibtnClr);
            this.Controls.Add(this.uitbxRev);
            this.Name = "MsgRev";
            this.Text = "MsgRev";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox uitbxRev;
        private Sunny.UI.UIButton uibtnClr;
    }
}

