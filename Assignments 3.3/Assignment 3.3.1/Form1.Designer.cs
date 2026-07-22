namespace Assignment_3._3._1;

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
        dataGridView1 = new DataGridView();
        cboMonth = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(30, 56);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(1011, 231);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // cboMonth
        // 
        cboMonth.FormattingEnabled = true;
        cboMonth.Location = new Point(30, 338);
        cboMonth.Name = "cboMonth";
        cboMonth.Size = new Size(182, 33);
        cboMonth.TabIndex = 1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1075, 774);
        Controls.Add(cboMonth);
        Controls.Add(dataGridView1);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private ComboBox cboMonth;
}
