﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HtmlAgilityPack;

namespace HTMLParser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string uri = "http://www.bbc.com/";

            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDocument = htmlWeb.Load(uri);

            var temp = htmlDocument.DocumentNode.Descendants("div").Count();
            var temp2 = htmlDocument
                .DocumentNode
                .Descendants("a")
                .Where(p => p.Attributes.Contains("rev") && p.Attributes["rev"].Value.Contains("mostpopular-read|headline")).Select(p => p.InnerText).ToList();
            var temp3 = htmlDocument.DocumentNode.SelectNodes("//*[@id=\"most_popular_tabs_read\"]");
        }
    }
}
