using DelegatesSortGui.Data;
using Exercise_DelegatesAndSortGUI.Model;

namespace Exercise_DelegatesAndSortGUI
{
    public partial class ListPage
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 361);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "GAMERS";
            // 
            // button1
            // 
            button1.Location = new Point(463, 121);
            button1.Name = "button1";
            button1.Size = new Size(194, 29);
            button1.TabIndex = 2;
            button1.Text = "Sort By Name";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(463, 205);
            button2.Name = "button2";
            button2.Size = new Size(194, 29);
            button2.TabIndex = 3;
            button2.Text = "Sort By Highscore";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ListPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ListPage";
            Text = "Form1";
            Load += ListPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void ListPage_Load(object sender, EventArgs e)
        {
            GamerData gamerData = new GamerData();
            foreach (Gamer myGamer in gamerData.FetchGamers())
            {
                textBox1.Text += myGamer.ToString() + Environment.NewLine;
            }
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}
