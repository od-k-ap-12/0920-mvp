﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920_mvp
{
    public partial class Form1 : Form, IListView
    {
        public string PersonName
        {
            get { return textBoxName?.Text; }
            set { textBoxName.Text = value; }
        }

        public string PersonAge
        {
            get { return textBoxAge?.Text; }
            set { textBoxAge.Text = value; }
        }

        public string NameSearch
        {
            get { return textBoxSearch?.Text; }
            set { textBoxSearch.Text = value; }
        }

        public string People
        {
            get { return listBoxAllPeople?.Text; }
            set { listBoxAllPeople.Text = value; }
        }

        public event EventHandler<EventArgs> SaveEvent;
        public event EventHandler<EventArgs> ShowAllEvent;
        public event EventHandler<EventArgs> SearchEvent;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAllEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
