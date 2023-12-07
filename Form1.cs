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
    }
}