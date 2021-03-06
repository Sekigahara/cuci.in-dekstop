﻿using Cuciin_Dekstop.Login;
using Cuciin_Dekstop.Dashboard;
using System;
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
using Velacro.UIElements.Basic;
using Cuciin_Dekstop.Util;

namespace Cuciin_Dekstop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MyWindow
    {
        private Page loginFrame;
        public MainWindow()
        {
            InitializeComponent();
            loginFrame = new LoginFrame();
            UtilProvider.initMainFrame(mainFrame);
            mainFrame.Navigate(loginFrame);
        }

    }
}
