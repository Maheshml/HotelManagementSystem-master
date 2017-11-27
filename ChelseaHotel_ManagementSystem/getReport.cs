using BusinessLayer;
using DataAccessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;
using static System.DateTime;

namespace ChelseaHotel_ManagementSystem
{
    public partial class getReport : Form
    {

        mainContainer fc;
        private static IDataLayer DataLayer;
        private IModel Model = BusinessLayer.Model.GetInstance(DataLayer);

        public getReport(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            panel1.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel1.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel1.Height) / 2);

        }


        #region Generate Daily Report

        private static void dailyReport()
        {
            var doc = new Document();


            int addNum = 0;
            try
            {

                doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 25, 3);
                //Horizontal rule
                var p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                var wri = PdfWriter.GetInstance(doc, new FileStream("C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\Reports\\DailyReport\\dailyReport.pdf", FileMode.CreateNew));
                doc.Open();
                //add logo to the PDF document
                var Logo = iTextSharp.text.Image.GetInstance("C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\Reports\\DailyReport\\logo.jpg");
                Logo.ScalePercent(25f);
                Logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(Logo);
                //add title to the PDF document

                var pageTitle = new Paragraph("Daily Report")
                {
                    Alignment = Element.ALIGN_CENTER,
                    PaddingTop = 45
                };

                var titleFont = FontFactory.GetFont("Courier", 18, BaseColor.BLACK);
                pageTitle.Font = titleFont;
                doc.Add(pageTitle);


                doc.Add(p);

                var paragraphRevenueGenerated = new Paragraph("Revenue Generate:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(paragraphRevenueGenerated);

                doc.Add(p);
                var paragraphPeekTime = new Paragraph("Peek Time:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 450
                };
                doc.Add(paragraphPeekTime);

                doc.Add(p);



                var paragraphDownTime = new Paragraph("Down Time:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(paragraphDownTime);

                doc.Add(p);


                var numClients = new Paragraph("Number of Clients:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(numClients);

                doc.Add(p);



                var now = "Report Generated at: " + Now;




                var time = new Paragraph(now.ToString())
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(time);

            }
            catch (iTextSharp.text.BadElementException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close();
                doc = null;

            }

        }


        #endregion


        #region Generate Weekly Report 


        private static void weeklyReport()
        {
            var doc = new Document();
            Random rnd1 = new Random();
            Random rnd2 = new Random();


            try
            {

                doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 25, 3);
                //Horizontal rule
                var p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));

                var path = "C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\Reports\\WeeklyReport\\";
                var fileName = "WeeklyReport";
                var num = rnd1.NextDouble() + rnd1.Next(1, 20);
                var dateAndTime = DateTime.Now;
                var date = fileName + dateAndTime.Date;





                doc.Open();
                //add logo to the PDF document
                var Logo = iTextSharp.text.Image.GetInstance("C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\Reports\\DailyReport\\logo.jpg");
                Logo.ScalePercent(25f);
                Logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(Logo);
                //add title to the PDF document

                var pageTitle = new Paragraph("Daily Report")
                {
                    Alignment = Element.ALIGN_CENTER,
                    PaddingTop = 45
                };

                var titleFont = FontFactory.GetFont("Courier", 18, BaseColor.BLACK);
                pageTitle.Font = titleFont;
                doc.Add(pageTitle);


                doc.Add(p);

                var paragraphRevenueGenerated = new Paragraph("Revenue Generate:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(paragraphRevenueGenerated);

                doc.Add(p);
                var paragraphPeekTime = new Paragraph("Peek Time:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 450
                };
                doc.Add(paragraphPeekTime);

                doc.Add(p);



                var paragraphDownTime = new Paragraph("Down Time:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(paragraphDownTime);

                doc.Add(p);


                var numClients = new Paragraph("Number of Clients:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(numClients);

                doc.Add(p);



                var now = "Report Generated at: " + Now.ToString("yyyy-MM-dd HH:mm");
                var time = new Paragraph(now.ToString())
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(time);

            }
            catch (iTextSharp.text.BadElementException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close();
                doc = null;

            }

        }

        #endregion


        #region Generate Monthly Report
        private static void monthlyReport()
        {
            var doc = new Document();
            var date = Now;



            try
            {

                doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 25, 3);
                //Horizontal rule
                var p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                var wri = PdfWriter.GetInstance(doc, new FileStream("C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\Reports\\MontlyReport\\montly.pdf", FileMode.CreateNew));
                doc.Open();
                //add logo to the PDF document
                var Logo = iTextSharp.text.Image.GetInstance("C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\Reports\\DailyReport\\logo.jpg");
                Logo.ScalePercent(25f);
                Logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(Logo);
                //add title to the PDF document

                var pageTitle = new Paragraph("Daily Report")
                {
                    Alignment = Element.ALIGN_CENTER,
                    PaddingTop = 45
                };

                var titleFont = FontFactory.GetFont("Courier", 18, BaseColor.BLACK);
                pageTitle.Font = titleFont;
                doc.Add(pageTitle);


                doc.Add(p);

                var paragraphRevenueGenerated = new Paragraph("Revenue Generate:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(paragraphRevenueGenerated);

                doc.Add(p);
                var paragraphPeekTime = new Paragraph("Peek Time:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 450
                };
                doc.Add(paragraphPeekTime);

                doc.Add(p);



                var paragraphDownTime = new Paragraph("Down Time:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(paragraphDownTime);

                doc.Add(p);


                var numClients = new Paragraph("Number of Clients:")
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(numClients);

                doc.Add(p);



                var now = "Report Generated at: " + Now;




                var time = new Paragraph(now.ToString())
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 45
                };
                doc.Add(time);

            }
            catch (iTextSharp.text.BadElementException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close();
                doc = null;

            }

        }


        #endregion




        private void home_btn_Click(object sender, EventArgs e)
        {
            var restaurantKitchen = new DashboardKitchenManager(fc, Model);
            restaurantKitchen.Show();
            this.Hide();
        }

        

        private void dailyReport_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //daily report
                dailyReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Daily report To be completed in phase two");
            }


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void weeklyReport_btn_Click(object sender, EventArgs e)
        {
            try
            {
                weeklyReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Weekly report To be completed in phase two");
            }
        }

        private void monthlyReport_btn_Click(object sender, EventArgs e)
        {
            try
            {
                monthlyReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Monthly report To be completed in phase two");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Bespoke Report To be completed in phase two");

        }

    }
}
