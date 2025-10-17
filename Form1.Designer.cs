namespace TicTacToe;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        button6 = new System.Windows.Forms.Button();
        button7 = new System.Windows.Forms.Button();
        button8 = new System.Windows.Forms.Button();
        button9 = new System.Windows.Forms.Button();
        button10 = new System.Windows.Forms.Button();
        timer1 = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.Cornsilk;
        label1.Cursor = System.Windows.Forms.Cursors.Default;
        label1.Font = new System.Drawing.Font("Broadway", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlText;
        label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
        label1.Location = new System.Drawing.Point(174, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(457, 42);
        label1.TabIndex = 0;
        label1.Text = "Tic Tac Toe Game by Jae Jackson";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
        label2.ForeColor = System.Drawing.Color.LimeGreen;
        label2.Location = new System.Drawing.Point(1, 9);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(133, 27);
        label2.TabIndex = 1;
        label2.Text = "Player Wins: ";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
        label3.ForeColor = System.Drawing.Color.Maroon;
        label3.Location = new System.Drawing.Point(663, 7);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(125, 27);
        label3.TabIndex = 2;
        label3.Text = "CPU Wins:";
        // 
        // button1
        // 
        button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)0)), ((int)((byte)64)));
        button1.FlatAppearance.BorderSize = 8;
        button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button1.ForeColor = System.Drawing.SystemColors.ControlText;
        button1.Location = new System.Drawing.Point(95, 89);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(187, 149);
        button1.TabIndex = 3;
        button1.Text = "?";
        button1.UseVisualStyleBackColor = true;
        button1.Click += PlayerClickButton;
        // 
        // button2
        // 
        button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button2.ForeColor = System.Drawing.SystemColors.ControlText;
        button2.Location = new System.Drawing.Point(315, 89);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(181, 149);
        button2.TabIndex = 4;
        button2.Text = "?";
        button2.UseVisualStyleBackColor = true;
        button2.Click += PlayerClickButton;
        // 
        // button3
        // 
        button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        button3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button3.ForeColor = System.Drawing.SystemColors.ControlText;
        button3.Location = new System.Drawing.Point(529, 89);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(192, 149);
        button3.TabIndex = 5;
        button3.Text = "?";
        button3.UseVisualStyleBackColor = true;
        button3.Click += PlayerClickButton;
        // 
        // button4
        // 
        button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        button4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button4.ForeColor = System.Drawing.SystemColors.ControlText;
        button4.Location = new System.Drawing.Point(529, 272);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(192, 149);
        button4.TabIndex = 8;
        button4.Text = "?";
        button4.UseVisualStyleBackColor = true;
        button4.Click += PlayerClickButton;
        // 
        // button5
        // 
        button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        button5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button5.ForeColor = System.Drawing.SystemColors.ControlText;
        button5.Location = new System.Drawing.Point(315, 272);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(181, 149);
        button5.TabIndex = 7;
        button5.Text = "?";
        button5.UseVisualStyleBackColor = true;
        button5.Click += PlayerClickButton;
        // 
        // button6
        // 
        button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        button6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button6.ForeColor = System.Drawing.SystemColors.ControlText;
        button6.Location = new System.Drawing.Point(95, 272);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(187, 149);
        button6.TabIndex = 6;
        button6.Text = "?";
        button6.UseVisualStyleBackColor = true;
        button6.Click += PlayerClickButton;
        // 
        // button7
        // 
        button7.BackColor = System.Drawing.SystemColors.Window;
        button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        button7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button7.ForeColor = System.Drawing.SystemColors.ControlText;
        button7.Location = new System.Drawing.Point(529, 455);
        button7.Name = "button7";
        button7.Size = new System.Drawing.Size(192, 149);
        button7.TabIndex = 11;
        button7.Text = "?";
        button7.UseVisualStyleBackColor = false;
        button7.Click += PlayerClickButton;
        // 
        // button8
        // 
        button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        button8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button8.ForeColor = System.Drawing.SystemColors.ControlText;
        button8.Location = new System.Drawing.Point(315, 455);
        button8.Name = "button8";
        button8.Size = new System.Drawing.Size(181, 149);
        button8.TabIndex = 10;
        button8.Text = "?";
        button8.UseVisualStyleBackColor = true;
        button8.Click += PlayerClickButton;
        // 
        // button9
        // 
        button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        button9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button9.ForeColor = System.Drawing.SystemColors.ControlText;
        button9.Location = new System.Drawing.Point(95, 455);
        button9.Name = "button9";
        button9.Size = new System.Drawing.Size(187, 149);
        button9.TabIndex = 9;
        button9.Text = "?";
        button9.UseVisualStyleBackColor = true;
        button9.Click += PlayerClickButton;
        // 
        // button10
        // 
        button10.BackColor = System.Drawing.Color.LightCyan;
        button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        button10.ForeColor = System.Drawing.SystemColors.MenuText;
        button10.Location = new System.Drawing.Point(296, 636);
        button10.Name = "button10";
        button10.Size = new System.Drawing.Size(199, 38);
        button10.TabIndex = 12;
        button10.Text = "Restart Game?";
        button10.UseVisualStyleBackColor = false;
        button10.Click += RestartGame;
        // 
        // timer1
        // 
        timer1.Interval = 1000;
        timer1.Tag = "CPUTimer";
        timer1.Tick += CPUmove;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Cornsilk;
        ClientSize = new System.Drawing.Size(815, 691);
        Controls.Add(button10);
        Controls.Add(button7);
        Controls.Add(button8);
        Controls.Add(button9);
        Controls.Add(button4);
        Controls.Add(button5);
        Controls.Add(button6);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        ShowIcon = false;
        Text = "Tic Tac Toe Game in C#!";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button10;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}