namespace Assignment_3.Presentation;

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
        PlayerList = new System.Windows.Forms.ListBox();
        Name = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        TeamName = new System.Windows.Forms.Label();
        DetailsBtn = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // PlayerList
        // 
        PlayerList.FormattingEnabled = true;
        PlayerList.ItemHeight = 15;
        PlayerList.Location = new System.Drawing.Point(12, 12);
        PlayerList.Name = "PlayerList";
        PlayerList.Size = new System.Drawing.Size(146, 289);
        PlayerList.TabIndex = 1;
        // 
        // Name
        // 
        Name.AutoEllipsis = true;
        Name.Location = new System.Drawing.Point(175, 12);
        Name.Name = "Name";
        Name.Size = new System.Drawing.Size(156, 31);
        Name.TabIndex = 3;
        Name.Text = "Name";
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(174, 77);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(157, 179);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // TeamName
        // 
        TeamName.AutoEllipsis = true;
        TeamName.Location = new System.Drawing.Point(175, 43);
        TeamName.Name = "TeamName";
        TeamName.Size = new System.Drawing.Size(156, 31);
        TeamName.TabIndex = 5;
        TeamName.Text = "TeamName";
        // 
        // DetailsBtn
        // 
        DetailsBtn.Location = new System.Drawing.Point(174, 265);
        DetailsBtn.Name = "DetailsBtn";
        DetailsBtn.Size = new System.Drawing.Size(99, 36);
        DetailsBtn.TabIndex = 6;
        DetailsBtn.Text = "More Details";
        DetailsBtn.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(DetailsBtn);
        Controls.Add(TeamName);
        Controls.Add(Name);
        Controls.Add(pictureBox1);
        Controls.Add(PlayerList);
        Location = new System.Drawing.Point(15, 15);
        Text = "Details";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button DetailsBtn;

    private System.Windows.Forms.Label TeamName;

    private System.Windows.Forms.Label Name;
    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.ListBox PlayerList;

    #endregion
}