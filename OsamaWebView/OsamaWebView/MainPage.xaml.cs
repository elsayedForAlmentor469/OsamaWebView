using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HtmlRender
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Bind();
        }
        void Bind()
        {
            string str = "<html><head><title>HTML Elements Reference</title></head><body>"

 + "<h1>This is a heading</h1>"
 + "<p>This is a paragraph.</p>"
 + "<p>This is a paragraph.</p>"
 + "<p>This is a paragraph.</p>"
 + "<p>This is a paragraph.</p>"
 + "<p>This is a paragraph.</p>"
 + "<p>This is a paragraph.</p>"

 + "</body>"
 + "</html>";
            var htmSrc = new HtmlWebViewSource();
            htmSrc.Html = str;
            WbView.Source = htmSrc;
        }
        private void Btn_Clicked(object sender, EventArgs e)
        {
            try
            {
                var htmSrc = new HtmlWebViewSource();
                htmSrc.Html = txt.Text;
                WbView.Source = htmSrc;
            }
            catch (Exception)
            {


            }
        }

        private void Sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            try
            {
                /* var hght = Sld.Value;
                 WbView.HeightRequest = hght;
                */
            }
            catch (Exception)
            {


            }
        }
        void Resize(bool Max)
        {
            try
            {
                var hght = WbView.Height;
                if (Max)
                {
                    WbView.HeightRequest = hght + 50;
                }
                else
                {
                    WbView.HeightRequest = hght - 50;

                }
            }
            catch (Exception)
            {

            }
        }


        private void btnMinClick(object sender, EventArgs e)
        {
            Resize(false);

        }

        private void BtnMxclick(object sender, EventArgs e)
        {
            Resize(true);
        }

        private void BtnSrc_Clicked(object sender, EventArgs e)
        {
            try
            {
                WbView.Source = txt.Text;

            }
            catch (Exception Excep)
            {

            }
         }
    }
}
