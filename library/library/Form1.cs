﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_library_kckcDataSet_genre.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this._library_kckcDataSet_genre.Genre);
            // TODO: This line of code loads data into the '_library_kckcDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this._library_kckcDataSet.Author);
            // TODO: This line of code loads data into the '_library_kckcDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this._library_kckcDataSet.Book);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Book = new Book();

            Book.AddBook(textBox_title.Text, Convert.ToInt32(comboBox_genre.SelectedValue), textBox_publisher.Text);

            
        }

    }
}
