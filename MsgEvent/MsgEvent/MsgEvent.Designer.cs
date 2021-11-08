namespace MsgEvent
{
    partial class MsgEvent
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
            this.uitbxSend = new Sunny.UI.UITextBox();
            this.uibtnSend = new Sunny.UI.UIButton();
            this.uibtnEvent = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uitbxSend
            // 
            this.uitbxSend.ButtonSymbol = 61761;
            this.uitbxSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxSend.FillColor = System.Drawing.Color.White;
            this.uitbxSend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxSend.Location = new System.Drawing.Point(27, 43);
            this.uitbxSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxSend.Maximum = 2147483647D;
            this.uitbxSend.Minimum = -2147483648D;
            this.uitbxSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxSend.Multiline = true;
            this.uitbxSend.Name = "uitbxSend";
            this.uitbxSend.ShowScrollBar = true;
            this.uitbxSend.Size = new System.Drawing.Size(446, 287);
            this.uitbxSend.TabIndex = 0;
            this.uitbxSend.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uibtnSend
            // 
            this.uibtnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnSend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnSend.Location = new System.Drawing.Point(373, 369);
            this.uibtnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnSend.Name = "uibtnSend";
            this.uibtnSend.Size = new System.Drawing.Size(100, 35);
            this.uibtnSend.TabIndex = 1;
            this.uibtnSend.Text = "Send";
            this.uibtnSend.Click += new System.EventHandler(this.uibtnSend_Click);
            // 
            // uibtnEvent
            // 
            this.uibtnEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnEvent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnEvent.Location = new System.Drawing.Point(27, 369);
            this.uibtnEvent.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnEvent.Name = "uibtnEvent";
            this.uibtnEvent.Size = new System.Drawing.Size(100, 35);
            this.uibtnEvent.TabIndex = 2;
            this.uibtnEvent.Text = "Event";
            this.uibtnEvent.Click += new System.EventHandler(this.uibtnEvent_Click);
            // 
            // MsgEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.uibtnEvent);
            this.Controls.Add(this.uibtnSend);
            this.Controls.Add(this.uitbxSend);
            this.Name = "MsgEvent";
            this.Text = "MsgEvent";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox uitbxSend;
        private Sunny.UI.UIButton uibtnSend;
        private Sunny.UI.UIButton uibtnEvent;
    }
}

