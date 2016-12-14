﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suit
{
    public partial class kind_suit : Form
    {
        Form1 form;
        Suits suit;
        public kind_suit(Form1 f)
        {
            InitializeComponent();
            form = f;
        }
        public kind_suit(Suits f)
        {
            InitializeComponent();
            suit = f;
        }
        private void changeForm(string formType)
        {
            switch (formType)
            {
                case "add":
                    {
                        groupBox1.Visible = true;
                        groupBox2.Visible = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button4.Enabled = false;
                        break;
                    }
                case "change":
                    {
                        groupBox2.Visible = true;
                        groupBox1.Visible = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button4.Enabled = false;
                        break;
                    }
                case "start_form":
                    {
                        groupBox1.Visible = false;
                        groupBox2.Visible = false;
                        button3.Enabled = true;
                        button2.Enabled = true;
                        button4.Enabled = true;
                        break;
                    }
            }
        }
        private void kind_suit_Load(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //ok add
        private void button5_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //cancel add
        private void button6_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //ok change
        private void button7_Click(object sender, EventArgs e)
        {
            changeForm("start_form");

        }
        //cancel change
        private void button1_Click(object sender, EventArgs e)
        {
            changeForm("start_form");
        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            changeForm("add");
        }
        //change
        private void button3_Click(object sender, EventArgs e)
        {
            changeForm("change");
        }
        //delete
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void kind_suit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (form != null) form.Enabled = true;
            if (suit != null) suit.Enabled = true;
        }
    }
}
