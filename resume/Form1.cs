
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.Json;
using System.IO;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using Newtonsoft.Json;
using PdfSharp.Drawing.Layout;

namespace resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String personal = (@"C:\Users\PC16\source\repos\resume\resume\\information.json");
            String Jsoner = File.ReadAllText(personal);
            var resumer = JsonConvert.DeserializeObject<model>(Jsoner);

            string FirstName = resumer.FirstName;
            string LastName = resumer.LastName;
            string Address = resumer.Address;
            string City = resumer.City;
            string ZipCode = resumer.ZipCode;
            string Country = resumer.Country;
            string Birthdate = resumer.Birthdate;
            string MaritalStatus = resumer.MaritalStatus;
            string Email = resumer.Email;
            string Phone = resumer.Phone;
            string Telephone = resumer.Telephone;
            string Province = resumer.Province;


            string High = resumer.High;
            string School = resumer.School;
            string CityH = resumer.CityH;
            string CountryH = resumer.CountryH;
            string Start = resumer.Start;
            string End = resumer.End;


            string SchoolH = resumer.SchoolH;
            string CitySH = resumer.CitySH;
            string CountrySH = resumer.CountrySH;
            string StartSH = resumer.StartSH;
            string EndSH = resumer.EndSH;
            string strand = resumer.strand;


            string SchoolC = resumer.SchoolC;
            string CityC = resumer.CityC;
            string CountryC = resumer.CountryC;
            string StartC = resumer.StartC;
            string EndC = resumer.EndC;

            string course = resumer.course;
            string degree = resumer.degree;

            string Job = resumer.Job;
            string DescriptionE = resumer.DescriptionE;
            string JobF = resumer.JobF;
            string DescriptionF = resumer.DescriptionF;

            textBox1.Text = "FirstName:" + resumer.FirstName;
            textBox2.Text = "LastName:" + resumer.LastName;
            textBox3.Text = "Address:" + resumer.Address;
            textBox4.Text = "City: " + resumer.City;
            textBox11.Text = "Province: " + resumer.Province;
            ZipCode = textBox5.Text = "Zip Code: " + resumer.ZipCode;
            Country = textBox6.Text =  resumer.Country;
            Birthdate = dateTimePicker1.Text = resumer.Birthdate;
            MaritalStatus = textBox9.Text = "Martial Status:" + resumer.MaritalStatus;
            Email = textBox7.Text = "Email:" + resumer.Email;
            Phone = textBox8.Text = "Phone Number: " + resumer.Phone;
            Telephone = textBox32.Text = "Telephone Number " + resumer.Telephone;


            School = textBox17.Text = "High School: " + resumer.School;
            CityH = textBox16.Text = "City: " + resumer.CityH;
            CountryH = textBox15.Text = "Country: " + resumer.CountryH;
            Start = textBox14.Text = resumer.Start;
            End = textBox13.Text = resumer.End;


            SchoolH = textBox23.Text = "Senior High School: " + resumer.SchoolH;
            CitySH = textBox22.Text = "City: " + resumer.CitySH;
            CountrySH = textBox21.Text = "Country: " + resumer.CountrySH;
            StartSH = textBox20.Text = resumer.StartSH;
            EndSH = textBox19.Text = resumer.EndSH;
            strand = textBox10.Text = "Strand: " + resumer.strand;


            SchoolC = textBox31.Text = "College:" + resumer.SchoolC;
            CityC = textBox30.Text = "City: " + resumer.CitySH;
            CountryC = textBox29.Text = "Country: " + resumer.CountrySH;
            StartC = textBox28.Text =  resumer.StartC;
            EndC = textBox27.Text = resumer.End;
            course = textBox25.Text = "Course:" + resumer.course;
            degree = textBox24.Text = "Degree:" + resumer.degree;


            Job = textBox35.Text = "Job: " + resumer.Job;
            DescriptionE = textBox34.Text = resumer.DescriptionE;
            JobF = textBox37.Text = "Job: " + resumer.JobF;
            DescriptionF = textBox36.Text = resumer.DescriptionF;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"Desktop\Resume";
                saveFileDialog.FileName = LastName + " " + FirstName + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    PdfDocument pdf = new PdfDocument();
                    PdfPage page = pdf.AddPage();
                    pdf.Info.Title = LastName + "" + "Resume";


                    XGraphics graph = XGraphics.FromPdfPage(page);

                    XFont bigtext = new XFont("Times New Roman", 20, XFontStyle.Bold);
                    XFont smalltext = new XFont("Times New Roman", 15, XFontStyle.Regular);
                    XFont Tittletext = new XFont("Times New Roman", 30, XFontStyle.Bold);

                    XPen pen = new XPen(XColors.Black, 20);
                    XPen linerleft = new XPen(XColors.Black, 1); ;
                    XPen linerright = new XPen(XColors.Black, 1);

                    XTextFormatter tf = new XTextFormatter(graph);
                    



                    graph.DrawRoundedRectangle(XBrushes.Crimson, 0, 0, page.Width.Point, page.Height.Point, 30, 20);
                    graph.DrawRoundedRectangle(XBrushes.Crimson, 200, 50, page.Width.Point, page.Height.Point, 100, 100);
                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    XPen Line = new XPen(XColors.White, 2);
                    XPen NewLine = new XPen(XColors.White, 3);
                    XPen Pen = new XPen(XColors.White, 20);

                    graph.DrawRoundedRectangle(XBrushes.SkyBlue, 0, 0, page.Width.Point, page.Height.Point, 0, 0);

                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    int marginleft = 30;
                    int initialleft = 200;
                    int marginright = 400;
                    int initialmiddle = 200;

                    graph.DrawString(FirstName + " " + LastName, Tittletext, XBrushes.White, new XRect(marginleft, initialleft - 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("Personal Information", bigtext, XBrushes.White, new XRect(marginleft, initialleft - 70, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ;
                    graph.DrawRectangle(Line, marginleft, initialleft  -45, 150, 1);
                    graph.DrawString(Address + "," + City + "," + Province + "," + Country, smalltext, XBrushes.White, new XRect(marginleft, initialleft - 40, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("Birthdate: " + Birthdate, smalltext, XBrushes.White, new XRect(marginleft, initialleft -20 , page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(MaritalStatus, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 0, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Email, smalltext, XBrushes.White, new XRect(marginleft, initialleft +20 , page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Phone, smalltext, XBrushes.White, new XRect(marginleft, initialleft +40, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Telephone, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("Educational Background", bigtext, XBrushes.White, new XRect(marginleft, initialleft + 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawRectangle(Line, marginleft, initialleft + 125, 150, 1);
                    graph.DrawString("High School", bigtext, XBrushes.White, new XRect(marginleft, initialleft + 140, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(School, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 160, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CityH, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 180, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CountryH, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 200, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Start + "-" + End, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 220, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    
                    graph.DrawString("Senior High School", bigtext, XBrushes.White, new XRect(marginleft, initialleft + 240, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(School, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 260, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CityH, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 280, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CountryH, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 300, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(StartSH + "-" + EndSH, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 320, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(strand, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 340, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                    graph.DrawString("College", bigtext, XBrushes.White, new XRect(marginleft, initialleft + 360, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(School, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 380, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CityH, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 400, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CountryC, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 420, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(course, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 440, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(degree, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 460, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(StartC + "-" + EndC, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 480, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("Work Experience", bigtext, XBrushes.White, new XRect(marginleft, initialleft + 500, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawRectangle(Line, marginleft, initialleft + 525, 150, 1);
                    graph.DrawString(Job, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 645, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(DescriptionE, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 660, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(JobF, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 680, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(DescriptionF, smalltext, XBrushes.White, new XRect(marginleft, initialleft + 700, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                    pdf.Save(saveFileDialog.FileName);
                    Application.Exit();

                }
            }
        }

        public class Wer
        {
            public string FirstName;
            public string LastName;
            public string Address;
            public string City;
            public string ZipCode;
            public string Country;
            public string Birthdate;
            public string MaritalStatus;
            public string Email;
            public string Phone;
            public string Telephone;
            public string Province;


            public string Objective;

            public string Summary;


            public string High;
            public string School;
            public string CityH;
            public string CountryH;
            public string Start;
            public string End;


            public string SchoolH;
            public string CitySH;
            public string CountrySH;
            public string StartSH;
            public string EndSH;
            public string strand;



            public string SchoolC;
            public string CityC;
            public string CountryC;
            public string StartC;
            public string EndC;
            public string course;
            public string degree;



            public string Job;
            public string DescriptionE;
            public string JobF;
            public string DescriptionF;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Wer p1 = new Wer()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Address = textBox3.Text,
                City = textBox4.Text,
                Province = textBox11.Text,
                ZipCode = textBox5.Text,
                Country = textBox6.Text,
                Birthdate = dateTimePicker1.Text,
                MaritalStatus = textBox9.Text,
                Email = textBox7.Text,
                Phone = textBox8.Text,
                Telephone = textBox32.Text,


                School = textBox17.Text,
                CityH = textBox16.Text,
                CountryH = textBox15.Text,
                Start = textBox14.Text,
                End = textBox13.Text,


                SchoolH = textBox23.Text,
                CitySH = textBox22.Text,
                CountrySH = textBox21.Text,
                StartSH = textBox20.Text,
                EndSH = textBox19.Text,
                strand = textBox10.Text,


                SchoolC = textBox31.Text,
                CityC = textBox30.Text,
                CountryC = textBox29.Text,
                StartC = textBox28.Text,
                EndC = textBox27.Text,
                course = textBox25.Text,
                degree = textBox24.Text,


                Job = textBox35.Text,
                DescriptionE = textBox34.Text,
                JobF = textBox37.Text,
                DescriptionF = textBox36.Text,
            };
            string json = JsonConvert.SerializeObject(p1,Formatting.Indented);

            File.WriteAllText(@"C:\Users\PC16\source\repos\resume\resume\\information.json",json);
          

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
    }

}