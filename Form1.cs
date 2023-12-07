namespace CodeFive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            // Button to open a PDF
            Button openPdfButton = new Button();
            openPdfButton.Text = "Open PDF";
            openPdfButton.Location = new System.Drawing.Point(133, 442); // Adjust position as needed
            openPdfButton.Size = new System.Drawing.Size(280, 160); // Adjust size as needed
            openPdfButton.Click += new EventHandler(OpenPdfButton_Click);
            this.Controls.Add(openPdfButton);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}