using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        double total, discount, amount, kdvamount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            // KDV : calculated on the discounted price
            int piece;
            piece = Convert.ToInt16(TxtPiece.Text);            
            amount = (piece * 8);
            double kdv = 0.18;

            // Piece < 10 if no discount
            if ( piece < 10 )
            {
                total = piece * 8;
            }
            
            // Piece >= 10 if %20 Discount
            if ( piece >= 10 && piece <= 19 )
            {
                discount = (piece * 8 * 0.20);
                total = amount - discount;               

            }
            // Piece >= 20 if %40 Discount 
            if (piece >=20 && piece <= 29)
            {
                discount = (piece * 8 *0.40);
                total = amount - discount;               

            }
            // Piece >= 30 if %50 Discount   
            if ( piece >=30 ) 
            {
                discount = (piece * 8 * 0.50);
                total = amount - discount;                

            }
            kdvamount = 0;
            kdvamount += total * kdv;
            total += kdvamount;

           TxtKDV.Text = kdvamount.ToString("0.00");
           TxtDiscount.Text = discount.ToString();
           TxtAmount.Text = amount.ToString();
           TxtTotal.Text = total.ToString("0.00");


        }
    }
}
