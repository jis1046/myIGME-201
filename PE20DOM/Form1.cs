using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20DOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);


            // if you want to use example.html from a local folder (saved in c:\temp for example):
            //this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            foreach (HtmlElement htmlElement1 in htmlElementCollection)
            {
                htmlElement1.InnerHtml = "<h1>My UFO Page</h1>";
            }



            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            if (htmlElementCollection.Count >= 1)
            {
                htmlElement = htmlElementCollection[0];
                htmlElement.InnerText = "My UFO Info";
            }

            if (htmlElementCollection.Count >= 2)
            {
                htmlElement = htmlElementCollection[1];
                htmlElement.InnerText = "My UFO Pictures";
            }

            if (htmlElementCollection.Count >= 3)
            {
                htmlElement = htmlElementCollection[2];
                htmlElement.InnerText = "";
            }

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("body");
            foreach (HtmlElement htmlElement1 in htmlElementCollection)
            {
                htmlElement1.Style = "font-family: sans-serif; color: #b30000";
                
            }

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            if (htmlElementCollection.Count >= 1)
            {
                htmlElement = htmlElementCollection[0];
                htmlElement.InnerHtml = "Report your UFO sighting here: <a href = \'http://www.nuforc.org' > www.nuforc.org </a>";
                htmlElement.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44";
                
            }

            if (htmlElementCollection.Count >= 2)
            {
                htmlElement = htmlElementCollection[1];
                htmlElement.InnerText = "";
            }

            if (htmlElementCollection.Count >= 3)
            {
                htmlElement = htmlElementCollection[2];
                htmlElement.InnerHtml = "<img src= 'https://www.seti.org/sites/default/files/styles/original/public/2018-06/ufo-560px.jpg?itok=esJYv_RK' alt = UFO>";
            }



            

            htmlElement = webBrowser.Document.CreateElement("footer");
            htmlElement.InnerHtml = "&copy; 2023 Josh Samuel";

            webBrowser.Document.Body.AppendChild(htmlElement);





        }
    }
}
