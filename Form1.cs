﻿
/*Name: Somaly Ngov
 * CIT Number: CIT237518
 * Date: 01/05/2020
 * Software: Microsoft Visual Studio 2019 Community Edition 
 * Platform: Microsoft Windows 10 Professional 64-bit 
 * Purpose:This programm will show you the comparision of two array to the text box
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comparator_on_a_1D_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int[] first = { 1, 2, 3, 4, 5 };
        int[] second = { 1, 2, 3, 4, 5 };

        private void btnSort_Click(object sender, EventArgs e)
        {


            if (checkEquality(first, second))
            {
                txtResult.Text = "Both arrays are equal";
            }
            else
            {
                txtResult.Text = "Both arrays are not equal";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Fill array with raw unsorted data
            foreach (int g in first)
                lstResult.Items.Add(Convert.ToString(g));
            foreach (int a in second)
                lstResult2.Items.Add(Convert.ToString(a));
        }

        public static bool checkEquality<T>(T[] first, T[] second)
        {
            return first.SequenceEqual(second);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
