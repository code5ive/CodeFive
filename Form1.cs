using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Net;

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

            // Button for searching
            Button searchButton = new Button();
            searchButton.Text = "Search";
            searchButton.Location = new System.Drawing.Point(133, 174); // Adjust position as needed
            searchButton.Size = new System.Drawing.Size(280, 160); // Adjust size as needed
            searchButton.Click += new EventHandler(SearchButton_Click);
            this.Controls.Add(searchButton);

            // Button to upload a PDF
            Button uploadPdfButton = new Button();
            uploadPdfButton.Text = "Upload PDF";
            uploadPdfButton.Location = new System.Drawing.Point(629, 174); // Adjust position as needed
            uploadPdfButton.Size = new System.Drawing.Size(280, 160); // Adjust size as needed
            uploadPdfButton.Click += new EventHandler(UploadPdfButton_Click);
            this.Controls.Add(uploadPdfButton);

            // Button to export a report
            Button exportReportButton = new Button();
            exportReportButton.Text = "Export Report";
            exportReportButton.Location = new System.Drawing.Point(629, 442); // Adjust position as needed
            exportReportButton.Size = new System.Drawing.Size(280, 160); // Adjust size as needed
            exportReportButton.Click += new EventHandler(ExportReportButton_Click);
            this.Controls.Add(exportReportButton);

            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 804);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }









        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }


        private void OpenPdfButton_Click(object sender, EventArgs e)
        {
            // Code to open a PDF file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"; // Filter to only show PDF files
            openFileDialog.Title = "Open PDF File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Open the PDF file with the default PDF reader
                    System.Diagnostics.Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while opening the file: " + ex.Message);
                }
            }
        }

        private List<string> vendorNames = new List<string>
{
    "Company A",
    "Vendor B",
    "Enterprise C",
    
};

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Code for the search functionality
            string searchTerm = GetUserInput().ToLower();

            // Search the vendor list for names that contain the search term
            var searchResults = vendorNames.Where(vendor => vendor.ToLower().Contains(searchTerm)).ToList();

            // If there are results, join them into a single string to show in the MessageBox
            if (searchResults.Any())
            {
                string resultString = string.Join(Environment.NewLine, searchResults);
                MessageBox.Show("Search results:\n" + resultString);
            }
            else
            {
                MessageBox.Show("No results found.");
            }
        }

        private string GetUserInput()
        {
            
            return "Test"; 
        }

        private void UploadPdfButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"; // Set the file type to PDF
            saveFileDialog.DefaultExt = "pdf"; 
            saveFileDialog.AddExtension = true; // Ensure the file extension is added

            // for checking  if the user clicked the save button
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = saveFileDialog.FileName;

                // Here will  save the file. it will  just show the file path
                MessageBox.Show("Save file at: " + filePath);

               
            }
        }

        private void ExportReportButton_Click(object sender, EventArgs e)
        {
            // Code to export a report
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt"; // Change this if you need a different format
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Generates  report data here. 
                string reportData = "This is an example report content.";

                try
                {
                    File.WriteAllText(saveFileDialog.FileName, reportData);
                    MessageBox.Show("Report exported successfully to " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while exporting the report: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}