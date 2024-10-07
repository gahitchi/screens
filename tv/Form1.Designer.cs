namespace tv
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
            nextChannel = new Button();
            prevChannel = new Button();
            volUp = new Button();
            tv1_on = new Button();
            volDown = new Button();
            tv1_off = new Button();
            tv1Screen = new PictureBox();
            channel = new Label();
            channelValue = new Label();
            volume = new Label();
            volumeValue = new Label();
            tv2_volValue = new Label();
            tv2_vol = new Label();
            tv2_chValue = new Label();
            tv2_ch = new Label();
            tv2Screen = new PictureBox();
            tv2_off = new Button();
            tv2_volDown = new Button();
            tv2_on = new Button();
            tv2_volUp = new Button();
            tv2_prevCh = new Button();
            tv2_nxtCh = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)tv1Screen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tv2Screen).BeginInit();
            SuspendLayout();
            // 
            // nextChannel
            // 
            nextChannel.Location = new Point(55, 85);
            nextChannel.Name = "nextChannel";
            nextChannel.Size = new Size(108, 76);
            nextChannel.TabIndex = 0;
            nextChannel.Text = "next channel";
            nextChannel.UseVisualStyleBackColor = true;
            nextChannel.Click += nextChannel_Click;
            // 
            // prevChannel
            // 
            prevChannel.Location = new Point(55, 288);
            prevChannel.Name = "prevChannel";
            prevChannel.Size = new Size(108, 76);
            prevChannel.TabIndex = 1;
            prevChannel.Text = "previous channel";
            prevChannel.UseVisualStyleBackColor = true;
            prevChannel.Click += prevChannel_Click;
            // 
            // volUp
            // 
            volUp.Location = new Point(514, 85);
            volUp.Name = "volUp";
            volUp.Size = new Size(108, 76);
            volUp.TabIndex = 2;
            volUp.Text = "volume up";
            volUp.UseVisualStyleBackColor = true;
            volUp.Click += volUp_Click;
            // 
            // tv1_on
            // 
            tv1_on.Location = new Point(235, 312);
            tv1_on.Name = "tv1_on";
            tv1_on.Size = new Size(94, 29);
            tv1_on.TabIndex = 3;
            tv1_on.Text = "on";
            tv1_on.UseVisualStyleBackColor = true;
            tv1_on.Click += tv1_on_Click;
            // 
            // volDown
            // 
            volDown.Location = new Point(514, 288);
            volDown.Name = "volDown";
            volDown.Size = new Size(108, 76);
            volDown.TabIndex = 4;
            volDown.Text = "volume down";
            volDown.UseVisualStyleBackColor = true;
            volDown.Click += volDown_Click;
            // 
            // tv1_off
            // 
            tv1_off.Location = new Point(353, 312);
            tv1_off.Name = "tv1_off";
            tv1_off.Size = new Size(94, 29);
            tv1_off.TabIndex = 5;
            tv1_off.Text = "off";
            tv1_off.UseVisualStyleBackColor = true;
            tv1_off.Click += tv1_off_Click;
            // 
            // tv1Screen
            // 
            tv1Screen.BorderStyle = BorderStyle.FixedSingle;
            tv1Screen.Location = new Point(202, 148);
            tv1Screen.Name = "tv1Screen";
            tv1Screen.Size = new Size(269, 147);
            tv1Screen.TabIndex = 6;
            tv1Screen.TabStop = false;
            // 
            // channel
            // 
            channel.AutoSize = true;
            channel.Location = new Point(235, 113);
            channel.Name = "channel";
            channel.Size = new Size(63, 20);
            channel.TabIndex = 7;
            channel.Text = "channel:";
            // 
            // channelValue
            // 
            channelValue.AutoSize = true;
            channelValue.Location = new Point(293, 113);
            channelValue.Name = "channelValue";
            channelValue.Size = new Size(17, 20);
            channelValue.TabIndex = 8;
            channelValue.Text = "0";
            // 
            // volume
            // 
            volume.AutoSize = true;
            volume.Location = new Point(353, 113);
            volume.Name = "volume";
            volume.Size = new Size(61, 20);
            volume.TabIndex = 9;
            volume.Text = "volume:";
            // 
            // volumeValue
            // 
            volumeValue.AutoSize = true;
            volumeValue.Location = new Point(408, 113);
            volumeValue.Name = "volumeValue";
            volumeValue.Size = new Size(17, 20);
            volumeValue.TabIndex = 10;
            volumeValue.Text = "0";
            // 
            // tv2_volValue
            // 
            tv2_volValue.AutoSize = true;
            tv2_volValue.Location = new Point(1304, 113);
            tv2_volValue.Name = "tv2_volValue";
            tv2_volValue.Size = new Size(17, 20);
            tv2_volValue.TabIndex = 21;
            tv2_volValue.Text = "0";
            // 
            // tv2_vol
            // 
            tv2_vol.AutoSize = true;
            tv2_vol.Location = new Point(1249, 113);
            tv2_vol.Name = "tv2_vol";
            tv2_vol.Size = new Size(61, 20);
            tv2_vol.TabIndex = 20;
            tv2_vol.Text = "volume:";
            // 
            // tv2_chValue
            // 
            tv2_chValue.AutoSize = true;
            tv2_chValue.Location = new Point(1189, 113);
            tv2_chValue.Name = "tv2_chValue";
            tv2_chValue.Size = new Size(17, 20);
            tv2_chValue.TabIndex = 19;
            tv2_chValue.Text = "0";
            // 
            // tv2_ch
            // 
            tv2_ch.AutoSize = true;
            tv2_ch.Location = new Point(1131, 113);
            tv2_ch.Name = "tv2_ch";
            tv2_ch.Size = new Size(63, 20);
            tv2_ch.TabIndex = 18;
            tv2_ch.Text = "channel:";
            // 
            // tv2Screen
            // 
            tv2Screen.BorderStyle = BorderStyle.FixedSingle;
            tv2Screen.Location = new Point(1098, 148);
            tv2Screen.Name = "tv2Screen";
            tv2Screen.Size = new Size(269, 147);
            tv2Screen.TabIndex = 17;
            tv2Screen.TabStop = false;
            // 
            // tv2_off
            // 
            tv2_off.Location = new Point(1249, 312);
            tv2_off.Name = "tv2_off";
            tv2_off.Size = new Size(94, 29);
            tv2_off.TabIndex = 16;
            tv2_off.Text = "off";
            tv2_off.UseVisualStyleBackColor = true;
            tv2_off.Click += tv2_off_Click;
            // 
            // tv2_volDown
            // 
            tv2_volDown.Location = new Point(1410, 288);
            tv2_volDown.Name = "tv2_volDown";
            tv2_volDown.Size = new Size(108, 76);
            tv2_volDown.TabIndex = 15;
            tv2_volDown.Text = "volume down";
            tv2_volDown.UseVisualStyleBackColor = true;
            tv2_volDown.Click += tv2_volDown_Click;
            // 
            // tv2_on
            // 
            tv2_on.Location = new Point(1131, 312);
            tv2_on.Name = "tv2_on";
            tv2_on.Size = new Size(94, 29);
            tv2_on.TabIndex = 14;
            tv2_on.Text = "on";
            tv2_on.UseVisualStyleBackColor = true;
            tv2_on.Click += tv2_on_Click;
            // 
            // tv2_volUp
            // 
            tv2_volUp.Location = new Point(1410, 85);
            tv2_volUp.Name = "tv2_volUp";
            tv2_volUp.Size = new Size(108, 76);
            tv2_volUp.TabIndex = 13;
            tv2_volUp.Text = "volume up";
            tv2_volUp.UseVisualStyleBackColor = true;
            tv2_volUp.Click += button4_Click;
            // 
            // tv2_prevCh
            // 
            tv2_prevCh.Location = new Point(951, 288);
            tv2_prevCh.Name = "tv2_prevCh";
            tv2_prevCh.Size = new Size(108, 76);
            tv2_prevCh.TabIndex = 12;
            tv2_prevCh.Text = "previous channel";
            tv2_prevCh.UseVisualStyleBackColor = true;
            tv2_prevCh.Click += tv2_prevCh_Click;
            // 
            // tv2_nxtCh
            // 
            tv2_nxtCh.Location = new Point(951, 85);
            tv2_nxtCh.Name = "tv2_nxtCh";
            tv2_nxtCh.Size = new Size(108, 76);
            tv2_nxtCh.TabIndex = 11;
            tv2_nxtCh.Text = "next channel";
            tv2_nxtCh.UseVisualStyleBackColor = true;
            tv2_nxtCh.Click += button6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 38);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 22;
            label5.Text = "tv 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1215, 38);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 23;
            label6.Text = "tv 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 400);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tv2_volValue);
            Controls.Add(tv2_vol);
            Controls.Add(tv2_chValue);
            Controls.Add(tv2_ch);
            Controls.Add(tv2Screen);
            Controls.Add(tv2_off);
            Controls.Add(tv2_volDown);
            Controls.Add(tv2_on);
            Controls.Add(tv2_volUp);
            Controls.Add(tv2_prevCh);
            Controls.Add(tv2_nxtCh);
            Controls.Add(volumeValue);
            Controls.Add(volume);
            Controls.Add(channelValue);
            Controls.Add(channel);
            Controls.Add(tv1Screen);
            Controls.Add(tv1_off);
            Controls.Add(volDown);
            Controls.Add(tv1_on);
            Controls.Add(volUp);
            Controls.Add(prevChannel);
            Controls.Add(nextChannel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tv1Screen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tv2Screen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextChannel;
        private Button prevChannel;
        private Button volUp;
        private Button tv1_on;
        private Button volDown;
        private Button tv1_off;
        private PictureBox tv1Screen;
        private Label channel;
        private Label channelValue;
        private Label volume;
        private Label volumeValue;
        private Label tv2_volValue;
        private Label tv2_vol;
        private Label tv2_chValue;
        private Label tv2_ch;
        private PictureBox tv2Screen;
        private Button tv2_off;
        private Button tv2_volDown;
        private Button tv2_on;
        private Button tv2_volUp;
        private Button tv2_prevCh;
        private Button tv2_nxtCh;
        private Label label5;
        private Label label6;
    }
}
