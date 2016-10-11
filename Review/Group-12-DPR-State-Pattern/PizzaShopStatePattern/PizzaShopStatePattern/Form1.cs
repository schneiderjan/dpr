using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PizzaShopStatePattern
{
    public partial class Form1 : Form
    {

        String pizzaName = "";
        Pizza pizza;
        
        public Form1()
        {
            InitializeComponent();
            selectionLb.Items.AddRange(typeof(PizzaNames).GetEnumNames());
            GatherTimer.Interval = 2000;
            CookTimer.Interval = 2500;
            PackTimer.Interval = 1000;
            DeliverTimer.Interval = 3000;            
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if(pizzaName != "")
            {
                pizza = new Pizza(pizzaName);
                GatherTimer.Start();
                setLabel();
            }
            else
            {
                MessageBox.Show("Please select a pizza");
            }
        }

        private void selectionLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectionLb.SelectedItem != null)
            {
                pizzaName = selectionLb.SelectedItem.ToString();
            }
        }

        private void GatherTimer_Tick_1(object sender, EventArgs e)
        {
            processLb.Items.Add(pizza.Gather());
            setLabel();
            GatherTimer.Stop();
            CookTimer.Start();
        }

        private void CookTimer_Tick(object sender, EventArgs e)
        {
            processLb.Items.Add(pizza.Cook());
            setLabel();
            CookTimer.Stop();
            PackTimer.Start();
        }

        private void PackTimer_Tick(object sender, EventArgs e)
        {
            processLb.Items.Add(pizza.Pack());
            setLabel();
            PackTimer.Stop();
            DeliverTimer.Start();
        }

        private void DeliverTimer_Tick(object sender, EventArgs e)
        {
            processLb.Items.Add(pizza.Deliver());
            label2.Text = "Order complete";
            DeliverTimer.Stop();
        }

        void setLabel()
        {
            label2.Text = "";
            if(pizza.getState().GetType() == typeof(ProductGatheringState))
            {
                label2.Text = "Gathering ingridients";
            }
            else if (pizza.getState().GetType() == typeof(CookingState))
            {
                label2.Text = "Cooking pizza";
            }
            else if (pizza.getState().GetType() == typeof(PackingState))
            {
                label2.Text = "Packing pizza";
            }
            else if (pizza.getState().GetType() == typeof(DeliveryState))
            {
                label2.Text = "Delivering Pizza";
            }
            
        }

    }
}
