namespace GitHubTest
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
      button1 = new Button();
      button2 = new Button();
      button3 = new Button();
      button4 = new Button();
      radioButton1 = new RadioButton();
      SuspendLayout();
      // 
      // button1
      // 
      button1.Location = new Point(139, 157);
      button1.Name = "button1";
      button1.Size = new Size(213, 41);
      button1.TabIndex = 0;
      button1.Text = "button1";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.Location = new Point(283, 325);
      button2.Name = "button2";
      button2.Size = new Size(94, 29);
      button2.TabIndex = 1;
      button2.Text = "button2";
      button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      button3.Location = new Point(553, 223);
      button3.Name = "button3";
      button3.Size = new Size(94, 29);
      button3.TabIndex = 2;
      button3.Text = "button3";
      button3.UseVisualStyleBackColor = true;
      button3.Click += button3_Click;
      // 
      // button4
      // 
      button4.Location = new Point(231, 48);
      button4.Name = "button4";
      button4.Size = new Size(75, 23);
      button4.TabIndex = 0;
      // 
      // radioButton1
      // 
      radioButton1.AutoSize = true;
      radioButton1.Location = new Point(469, 333);
      radioButton1.Name = "radioButton1";
      radioButton1.Size = new Size(117, 24);
      radioButton1.TabIndex = 3;
      radioButton1.TabStop = true;
      radioButton1.Text = "radioButton1";
      radioButton1.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(radioButton1);
      Controls.Add(button4);
      Controls.Add(button3);
      Controls.Add(button2);
      Controls.Add(button1);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private RadioButton radioButton1;
  }
}