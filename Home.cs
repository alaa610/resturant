using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public class Product
        {
            public double unitPrice;
            public double totalPrice;
            public string productName;
            public Product(double unitPrice, string productName)
            {
                this.unitPrice = unitPrice;
                this.productName = productName;
            }
        }

        public void AddToRecipt(Product p)
        {
            ReceiptTb.AppendText($"\t{p.productName}:\t" + "$" + p.totalPrice + Environment.NewLine);
            Subtotal = Subtotal + p.totalPrice;
            Subtotallbl.Text = "" + Subtotal;
        }
        public void AddOne(TextBox tb)
        {
            try
            {
                if (tb.Enabled == true && Convert.ToDouble(tb.Text) < 99)
                {
                    tb.Text = " " + (Convert.ToDouble(tb.Text) + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DecreaseOne(TextBox tb)
        {
            try
            {
                if (tb.Enabled && Convert.ToDouble(tb.Text) > 0)
                {
                    tb.Text = " " + (Convert.ToDouble(tb.Text) - 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RemoveNegative(TextBox tb)
        {
            if (double.TryParse(tb.Text, out double value))
            {
                if (value < 0) tb.Text = value.ToString().TrimStart('-');


            }

        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
     
        

        

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "  0 ";
            }
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          Datelbl.Text=DateTime.Now.ToLongDateString();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(FriesCb.Checked== true) 
            {
             FriesTb.Enabled = true;
            }
            if(FriesCb.Checked== false)
            {
                FriesTb.Enabled= false;
                FriesTb.Text = "  0 ";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "  0 ";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "  0 ";
            }
        }

        private void PizzaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PizzaCb.Checked == true)
            {
                PizzaTb.Enabled = true;
            }
            if (PizzaCb.Checked == false)
            {
                PizzaTb.Enabled = false;
                PizzaTb.Text = "  0 ";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "  0 ";
            }
        }

        private void RoastBeefCb_CheckedChanged(object sender, EventArgs e)
        {
            if (RoastBeefCb.Checked == true)
            {
                RoastBeefTb.Enabled = true;
            }
            if (RoastBeefCb.Checked == false)
            {
                RoastBeefTb.Enabled = false;
                RoastBeefTb.Text = "  0 ";
            }
        }

        private void LasagneCb_CheckedChanged(object sender, EventArgs e)
        {
            if (LasagneCb.Checked == true)
            {
                LasagneTb.Enabled = true;
            }
            if (LasagneCb.Checked == false)
            {
                LasagneTb.Enabled = false;
                LasagneTb.Text = "  0 ";
            }
        }
        

        private void Closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Declare Products and thier prices 
        // food 
        Product fries = new Product(5, "Fries");
        Product burger = new Product(12, "Burger");
        Product salad = new Product(5, "Salad");
        Product pizza = new Product(13, "Pizza");
        Product chicken = new Product(15, "Chicken");
        Product roastBeef = new Product(8, "Roast Beef");
        Product lasagne = new Product(9, "Lasagne");
        // drinks
        Product tea = new Product(2, "Tea");
        Product cola = new Product(4, "Cola");
        Product espresso = new Product(4, "Ecpresso");
        Product iceCoffe = new Product(5, "Ice Coffe");
        Product mocha = new Product(7, "Mocha");
        Product chocolate = new Product(8, "Chocolate");
        Product orange = new Product(9, "Orange");



        

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "  0 ";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "  0 ";
            }
        }

        private void EspressoCb_CheckedChanged(object sender, EventArgs e)
        {
            if (EspressoCb.Checked == true)
            {
                EspressoTb.Enabled = true;
            }
            if (EspressoCb.Checked == false)
            {
                EspressoTb.Enabled = false;
                EspressoTb.Text = "  0 ";
            }
        }

        private void IceCoffeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (IceCoffeCb.Checked == true)
            {
                IceCoffeTb.Enabled = true;
            }
            if (IceCoffeCb.Checked == false)
            {
                IceCoffeTb.Enabled = false;
                IceCoffeTb.Text = "  0 ";
            }
        }

        private void MochaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (MochaCb.Checked == true)
            {
                MochaTb.Enabled = true;
            }
            if (MochaCb.Checked == false)
            {
                MochaTb.Enabled = false;
                MochaTb.Text = "  0 ";
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "  0 ";
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
       

        // food add and dec bottons
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddOne(FriesTb);

        }

        private void burgerAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(BurgerTb);
        }

        private void saladAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(SaladTb);
        }

        private void pizzaAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(PizzaTb);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AddOne(ChickenTb);
        }

        private void RbeefAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(RoastBeefTb);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddOne(LasagneTb);
        }

        private void friesSubBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(FriesTb);
        }

        private void burgerDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(BurgerTb);
        }

        private void saladDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(SaladTb);
        }

        private void pizzaDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(PizzaTb);
        }

        private void chickenDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(ChickenTb);
        }

        private void rbeefDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(RoastBeefTb);
        }

        private void lasagneDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(LasagneTb);
        }

        private void RbeefAddBtn_Click_1(object sender, EventArgs e)
        {
            AddOne(RoastBeefTb);
        }

        private void lasagneAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(LasagneTb);
        }
        // drinks add and dec bottons
        private void teaAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(TeaTb);
        }

        private void colaAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(ColaTb);
        }

        private void espressoAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(EspressoTb);
        }

        private void icecoffeAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(IceCoffeTb);
        }

        private void mochaAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(MochaTb);
        }

        private void chocolateAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(ChocolateTb);
        }

        private void orangeAddBtn_Click(object sender, EventArgs e)
        {
            AddOne(OrangeTb);
        }

        private void teaDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(TeaTb);
        }

        private void colaDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(ColaTb);
        }

        private void expressoDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(EspressoTb);
        }

        private void icecoffeDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(IceCoffeTb);
        }

        private void mochaDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(MochaTb);
        }

        private void chocolateDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(ChocolateTb);
        }

        private void orangeDecBtn_Click(object sender, EventArgs e)
        {
            DecreaseOne(OrangeTb);
        }
        private void textBox1_TextChanged(object sender, EventArgs e) // FriesTb
        {
            RemoveNegative(FriesTb);
        }
        private void BurgerTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(BurgerTb);
        }

        private void SaladTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(SaladTb);
        }
        private void PizzaTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(PizzaTb);
        }
        private void ChickenTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(ChickenTb);
        }
        private void RoastBeefTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(RoastBeefTb);
        }
        private void TeaTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(TeaTb);
        }

        private void ColaTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(ColaTb);
        }

        private void EspressoTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(EspressoTb);
        }

        private void IceCoffeTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(IceCoffeTb);
        }

        private void MochaTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(MochaTb);
        }

        private void ChocolateTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(ChocolateTb);
        }

        private void LasagneTb_TextChanged(object sender, EventArgs e)
        {
            RemoveNegative(LasagneTb);
        }
        private void textBox8_TextChanged(object sender, EventArgs e) //  OrangeTb
        {
            RemoveNegative(OrangeTb);
        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text + "Subtotal" + Subtotallbl.Text + "Tax: " + taxlbl.Text + "Grand Total " + Grdtotallbl.Text,new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // resetBtn
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            PizzaCb.Checked = false;
            ChickenCb.Checked = false;
            RoastBeefCb.Checked = false;
            LasagneCb.Checked = false;
            TeaCb.Checked = false;
            ColaCb.Checked = false;
            EspressoCb.Checked = false;
            IceCoffeCb.Checked = false;
            MochaCb.Checked = false;
            ChocolateCb.Checked = false;
            OrangeCb.Checked = false;

        }

        private void Subtotallbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Declare variable to hold total price
        double Subtotal = 0,tax,grdtotal;
        private void button2_Click(object sender, EventArgs e) //addBtn
        {
           
            try // checks if the text is int 
            {
                fries.totalPrice = fries.unitPrice * Convert.ToDouble(FriesTb.Text); 
                burger.totalPrice = burger.unitPrice * Convert.ToDouble(BurgerTb.Text); 
                salad.totalPrice = salad.unitPrice * Convert.ToDouble(SaladTb.Text); 
                pizza.totalPrice = pizza.unitPrice * Convert.ToDouble(PizzaTb.Text); 
                chicken.totalPrice = chicken.unitPrice * Convert.ToDouble(ChickenTb.Text); 
                roastBeef.totalPrice = roastBeef.unitPrice * Convert.ToDouble(RoastBeefTb.Text); 
                lasagne.totalPrice = lasagne.unitPrice * Convert.ToDouble(LasagneTb.Text); ;
                tea.totalPrice = tea.unitPrice * Convert.ToDouble(TeaTb.Text); 
                cola.totalPrice = cola.unitPrice * Convert.ToDouble(ColaTb.Text); 
                espresso.totalPrice = espresso.unitPrice * Convert.ToDouble(EspressoTb.Text); 
                iceCoffe.totalPrice = iceCoffe.unitPrice * Convert.ToDouble(IceCoffeTb.Text); 
                mocha.totalPrice = mocha.unitPrice * Convert.ToDouble(MochaTb.Text); 
                chocolate.totalPrice = chocolate.unitPrice * Convert.ToDouble(ChocolateTb.Text); 
                orange.totalPrice = orange.unitPrice * Convert.ToDouble(OrangeTb.Text); 

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message); // displays a message if not int
            }
            
            //now add product on the receipt
            ReceiptTb.Clear();
            Subtotal = 0;
            tax = 0;
            grdtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tFASTFOOD RESTAURENT\t\t"+Datelbl.Text+Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t***********************"+Environment.NewLine);

            
            if(FriesCb.Checked == true)
            {
                AddToRecipt(fries);

            }
            
            if (BurgerCb.Checked == true)
            {
                AddToRecipt( burger);

            }
          
            if (SaladCb.Checked == true)
            {
                AddToRecipt(salad);
                

            }
            if (PizzaCb.Checked == true)
            {
                AddToRecipt(pizza);
                

            }
            if (ChickenCb.Checked == true)
            {
                AddToRecipt(chicken);
                
            }
            if (RoastBeefCb.Checked == true)
            {
                AddToRecipt(roastBeef);
                
            }
            if (LasagneCb.Checked == true)
            {
                AddToRecipt(lasagne);
                

            }

            // do the same for the drinks 

            if (TeaCb.Checked == true)
            {
                AddToRecipt(tea);
                

            }
            if (ColaCb.Checked == true)
            {
                AddToRecipt(cola);
                

            }

            if (EspressoCb.Checked == true)
            {
                AddToRecipt(espresso);
                

            }
            if (IceCoffeCb.Checked == true)
            {
                AddToRecipt(iceCoffe);
                
            }
            if (MochaCb.Checked == true)
            {
                AddToRecipt(mocha);
                
            }

            if (ChocolateCb.Checked == true)
            {
                AddToRecipt(chocolate);
                
            }

            if (OrangeCb.Checked == true)
            {
                AddToRecipt(orange);
               
            }

            tax = Subtotal * 0.16;
            grdtotal= Subtotal + tax;
            taxlbl.Text = tax + "$";
            Grdtotallbl.Text = grdtotal + "$";

          


        }

        private void changePricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Closelbl_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePricesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
              if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Datelbl_Click_1(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
