namespace Tutorial_1;

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
        tableLayoutPanel1 = new TableLayoutPanel();
        pictureBox1 = new PictureBox();
        checkBox1 = new CheckBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        checkedListBox1 = new CheckedListBox();
        flowLayoutPanel2 = new FlowLayoutPanel();
        ShowButton = new Button();
        clearButton = new Button();
        backgroundButton = new Button();
        closeButton = new Button();
        openFileDialog1 = new OpenFileDialog();
        colorDialog1 = new ColorDialog();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        flowLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
        tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
        tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
        tableLayoutPanel1.Controls.Add(checkedListBox1, 1, 2);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(970, 832);
        tableLayoutPanel1.TabIndex = 0;
        tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
        // 
        // pictureBox1
        // 
        pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Location = new Point(3, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(964, 724);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(3, 733);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(92, 29);
        checkBox1.TabIndex = 1;
        checkBox1.Text = "Stretch";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Location = new Point(3, 814);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(139, 15);
        flowLayoutPanel1.TabIndex = 3;
        // 
        // checkedListBox1
        // 
        checkedListBox1.FormattingEnabled = true;
        checkedListBox1.Location = new Point(148, 814);
        checkedListBox1.Name = "checkedListBox1";
        checkedListBox1.Size = new Size(8, 4);
        checkedListBox1.TabIndex = 2;
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.Controls.Add(ShowButton);
        flowLayoutPanel2.Controls.Add(clearButton);
        flowLayoutPanel2.Controls.Add(backgroundButton);
        flowLayoutPanel2.Controls.Add(closeButton);
        flowLayoutPanel2.Dock = DockStyle.Fill;
        flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
        flowLayoutPanel2.Location = new Point(148, 733);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new Size(819, 75);
        flowLayoutPanel2.TabIndex = 4;
        // 
        // ShowButton
        // 
        ShowButton.AutoSize = true;
        ShowButton.Location = new Point(677, 3);
        ShowButton.Name = "ShowButton";
        ShowButton.Size = new Size(139, 35);
        ShowButton.TabIndex = 0;
        ShowButton.Text = "Show a picture";
        ShowButton.UseVisualStyleBackColor = true;
        ShowButton.Click += button1_Click;
        // 
        // clearButton
        // 
        clearButton.AutoSize = true;
        clearButton.Location = new Point(521, 3);
        clearButton.Name = "clearButton";
        clearButton.Size = new Size(150, 35);
        clearButton.TabIndex = 1;
        clearButton.Text = "Clear the picture";
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += clearButton_Click;
        // 
        // backgroundButton
        // 
        backgroundButton.AutoSize = true;
        backgroundButton.Location = new Point(271, 3);
        backgroundButton.Name = "backgroundButton";
        backgroundButton.Size = new Size(244, 35);
        backgroundButton.TabIndex = 2;
        backgroundButton.Text = "Set the backgroun color";
        backgroundButton.UseVisualStyleBackColor = true;
        backgroundButton.Click += backgroundButton_Click;
        // 
        // closeButton
        // 
        closeButton.AutoSize = true;
        closeButton.Location = new Point(81, 3);
        closeButton.Name = "closeButton";
        closeButton.Size = new Size(184, 35);
        closeButton.TabIndex = 3;
        closeButton.Text = "Close";
        closeButton.UseVisualStyleBackColor = true;
        closeButton.Click += closeButton_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
        openFileDialog1.Title = "Select a picture file";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(970, 832);
        Controls.Add(tableLayoutPanel1);
        Name = "Form1";
        Text = "Picture Viewer";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        flowLayoutPanel2.ResumeLayout(false);
        flowLayoutPanel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private PictureBox pictureBox1;
    private CheckBox checkBox1;
    private CheckedListBox checkedListBox1;
    private FlowLayoutPanel flowLayoutPanel1;
    private FlowLayoutPanel flowLayoutPanel2;
    private Button ShowButton;
    private Button clearButton;
    private Button backgroundButton;
    private Button closeButton;
    private OpenFileDialog openFileDialog1;
    private ColorDialog colorDialog1;
}
