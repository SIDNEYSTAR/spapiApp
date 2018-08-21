using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace spapiApp
{
    public partial class frmInput : Form
    {
        public frmInput()
        {
            InitializeComponent();
        }

        public frmInput(int idx)
        {
            InitializeComponent();
            
            switch (idx)
            {
                case  1:
                    this.Text = "Add Order";
                    if (Spcommon.S_Prot == 8080)
                    {
                        this.label19.Visible = false;
                        this.txtInputAccNo.Visible = false;
                    }
                    else
                    {
                        this.label19.Visible = true;
                        this.txtInputAccNo.Visible = true;
                        if (Spcommon.acc_no != "")
                        {
                            txtInputAccNo.Enabled = false;
                            txtInputAccNo.Text = Spcommon.acc_no;
                        }
                    }

                    this.grbOrderAdd.Location = new System.Drawing.Point(5, 1);
                    grbOrderAdd.Visible = true;
                    break;
                case 2:
                    this.Text = "Del Order";
                    if (Spcommon.S_Prot == 8080)
                    {
                        this.label20.Visible = false;
                        this.txtInputAccDel.Visible = false;
                    }
                    else
                    {
                        this.label20.Visible = true;
                        this.txtInputAccDel.Visible = true;
                        if (Spcommon.acc_no != "")
                        {
                            txtInputAccDel.Enabled = false;
                            txtInputAccDel.Text = Spcommon.acc_no;
                        }
                    }
                    this.grbOrderDel.Location = new System.Drawing.Point(5, 1);
                    grbOrderDel.Visible = true;
                    btnOrderDel.Text = "Del Order";
                    btnOrderDel.Tag = 1;
                    break;
                case 3:
                    this.Text = "Change Order";
                    if (Spcommon.S_Prot == 8080)
                    {
                        this.label21.Visible = false;
                        this.txtInputAccChg.Visible = false;
                    }
                    else
                    {
                        this.label21.Visible = true;
                        this.txtInputAccChg.Visible = true;
                        if (Spcommon.acc_no != "")
                        {
                            txtInputAccChg.Enabled = false;
                            txtInputAccChg.Text = Spcommon.acc_no;
                        }
                    }
                    this.grbOrderChange.Location = new System.Drawing.Point(5, 1);
                    grbOrderChange.Visible = true;
                    break;
                case 4:
                    this.Text = "Search Pos";
                    this.grbPos.Location = new System.Drawing.Point(5, 1);
                    grbPos.Visible = true;
                    break;
                case 5:
                    this.Text = "Search Clear Trade";
                    this.grbTrade.Location = new System.Drawing.Point(5, 1);
                    grbTrade.Visible = true;
                    break;
                case 6:
                    this.Text = "Sub Price";
                    this.grbPriceSubscribe.Location = new System.Drawing.Point(5, 1);
                    btnPriceSubscribe.Text = "Subscribe";
                    grbPriceSubscribe.Visible = true;
                    btnPriceSubscribe.Tag = 1;
                    break;
                case 7:
                    this.Text = "Search Price";
                    this.grbPriceByProd.Location = new System.Drawing.Point(5, 1);
                    grbPriceByProd.Visible = true;
                    btnPriceByProd.Tag = 1;
                    break;
                case 8:
                    this.Text = "Remove Price Update";
                    this.grbPriceSubscribe.Location = new System.Drawing.Point(5, 1);
                    grbPriceSubscribe.Visible = true;
                    btnPriceSubscribe.Text = "Remove Price Update";
                    btnPriceSubscribe.Tag = 0;
                    break;
                case 9:
                    this.Text = "Ticker";
                    this.grbPriceSubscribe.Location = new System.Drawing.Point(5, 1);
                    grbPriceSubscribe.Visible = true;
                    btnPriceSubscribe.Text = "Sub Ticker";
                    btnPriceSubscribe.Tag = 2;
                    break;
                case 10:
                    this.Text = "Ticker";
                    this.grbPriceSubscribe.Location = new System.Drawing.Point(5, 1);
                    grbPriceSubscribe.Visible = true;         
                    btnPriceSubscribe.Text = "Remove Ticker";
                    btnPriceSubscribe.Tag = 3;
                    break;
                case 11:
                    this.Text = "Search Bal";      
                    this.grbPriceSubscribe.Location = new System.Drawing.Point(5, 1);
                    grbPriceSubscribe.Visible = true;
                    btnPriceSubscribe.Text = "Search Bal";
                    btnPriceSubscribe.Tag = 4;
                    lblcommon.Text = "Ccy:";
                    break;
                case 12:
                    this.Text = "Connection Status";
                    this.grbConnStatus.Location = new System.Drawing.Point(5, 1);
                    this.grbConnStatus.Visible = true;
                    break;
                    
               case 13:
                    this.Text = "Set Order Activate or Inactivate";
                    if (Spcommon.S_Prot == 8080)
                    {
                        this.label22.Visible = false;
                        this.txtInputAccAct.Visible = false;
                    }
                    else
                    {
                        this.label22.Visible = true;
                        this.txtInputAccAct.Visible = true;
                        if (Spcommon.acc_no != "")
                        {
                            txtInputAccAct.Enabled = false;
                            txtInputAccAct.Text = Spcommon.acc_no;
                        }

                    }
                    btnOrderinactive.Tag = 1;
                    this.grbInactive.Location = new System.Drawing.Point(5, 1);
                    this.grbInactive.Visible = true;
                    break;
               case 14:
                    this.Text = "Search Instrument Info";
                    this.grbPriceByProd.Location = new System.Drawing.Point(5, 1);
                    grbPriceByProd.Visible = true;
                    this.lblPriceByCode.Text = "Instrument Code:";
                    btnPriceByProd.Tag = 2;
                    break;
               case 15:
                    this.Text = "Search Product Info";
                    this.grbPriceByProd.Location = new System.Drawing.Point(5, 1);
                    grbPriceByProd.Visible = true;
                    this.lblPriceByCode.Text = "Product Code:";
                    btnPriceByProd.Tag = 3;
                    break;
               case 16:
                    this.Text = "User Change Password";
                    this.grbOrderDel.Location = new System.Drawing.Point(5, 1);
                    grbOrderDel.Visible = true;
                    this.label4.Text  = "old password:";
                    this.label14.Text = "new password:";
                    btnOrderDel.Text = "Change";
                    btnOrderDel.Tag = 2;
                    break;
               case 17:
                    this.Text = "Load Product Info List By Code";
                    this.grbPriceByProd.Location = new System.Drawing.Point(5, 1);
                    grbPriceByProd.Visible = true;
                    this.lblPriceByCode.Text = "Inst Code:";
                    btnPriceByProd.Tag = 4;
                    btnPriceByProd.Text = "Load";
                    break;
               case 18:
                    this.Text = "Account Access";
                    this.grbPriceByProd.Location = new System.Drawing.Point(5, 1);
                    grbPriceByProd.Visible = true;
                    this.lblPriceByCode.Text = "Account:";
                    btnPriceByProd.Tag = 5;
                    btnPriceByProd.Text = "Access";
                    break;
               case 19:
                    this.Text = "Order Count";                    
                    this.label22.Visible = false;
                    this.txtInputAccAct.Visible = false;
                    txtOrderInactiveId.Visible = false;
                    label16.Visible = false;
                    radioButton.Text = "All";
                    radioButton2.Text = "Input Acc No";
                    btnOrderinactive.Text = "Count";
                    btnOrderinactive.Tag = 2;
                    this.grbInactive.Location = new System.Drawing.Point(5, 1);
                    this.grbInactive.Visible = true;
                    break;
               
            }
        }

        public bool IsValid(string text, string title,int flag)
        {
            if (text.Length == 0)
            {
                MessageBox.Show(title + " Invalid!");
                return false;
            }


            if (flag == 1)
            {             
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (!Char.IsNumber(text[i]))
                        {
                            MessageBox.Show(title + "Input Error!");
                            return false;
                        }
                    }              
            }
            else if (flag == 2)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!Char.IsNumber(text[i]) && text[i]!='.')
                    {
                        MessageBox.Show(title + "Input Error!");
                        return false;
                    }
                }  
            }
            return true;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (!IsValid(txtProdCode.Text, "Product Code", 0)) return;
            if (!IsValid(txtQty.Text, "Qty", 1)) return;
            if (!IsValid(txtPrice.Text, "Price", 2)) return;
            AddOrder('B');
            this.Close();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (!IsValid(txtProdCode.Text, "Product Code", 0)) return;
            if (!IsValid(txtQty.Text, "Qty", 1)) return;
            if (!IsValid(txtPrice.Text, "Price", 2)) return;
            AddOrder('S');
            this.Close();
        }

        public void AddOrder(char buy_sell)
        {
            if (Spcommon.S_Prot == 8081) Spcommon.ord_acc_no = this.txtInputAccNo.Text;
            Spcommon.APIDLL.R_SPAPI_AddOrder(buy_sell, txtPrice.Text, txtProdCode.Text, txtQty.Text, txtAddClOrderId.Text);
        }

        private void btnOrderDel_Click(object sender, EventArgs e)
        {
            
            
            if (Convert.ToInt32(btnOrderDel.Tag) == 1)
            {
                if (!IsValid(txtDelOrderId.Text, "Order Id", 1)) return;
                if (!IsValid(txtDelProdCode.Text, "Product Code", 0)) return;
                if (Spcommon.S_Prot == 8081) Spcommon.ord_acc_no = this.txtInputAccDel.Text;
                Spcommon.APIDLL.R_SPAPI_DeleteOrder(txtDelOrderId.Text, txtDelProdCode.Text);
            }
            else if (Convert.ToInt32(btnOrderDel.Tag) == 2)
            {
                if (!IsValid(txtDelOrderId.Text, "old password", 0)) return;
                if (!IsValid(txtDelProdCode.Text, "new password", 0)) return;
                Spcommon.APIDLL.R_SPAPI_ChangePassword(txtDelOrderId.Text, txtDelProdCode.Text);
            }
            this.Close();
        }

        private void btnOrderChange_Click(object sender, EventArgs e)
        {
            if (!IsValid(txtChangeId.Text, "Order Id", 1)) return;
            if (!IsValid(txtChangePrice.Text, "Price", 2)) return;
            if (Spcommon.S_Prot == 8081) Spcommon.ord_acc_no = this.txtInputAccChg.Text;
            Spcommon.APIDLL.R_SPAPI_ChangeOrder(txtChangeId.Text, txtChangePrice.Text, txtChangeClOrderId.Text);
            this.Close();
        }

        private void btnPosByProd_Click(object sender, EventArgs e)
        {
            if (!IsValid(txtPosProdCode.Text, "Product Code", 0)) return;
            Spcommon.APIDLL.R_SPAPI_GetPosByProduct(txtPosProdCode.Text);
            this.Close();
        }

        private void btnTradeById_Click(object sender, EventArgs e)
        {
            if (!IsValid(txtTradeOrderNo.Text, "Order Id", 1)) return;
            if (!IsValid(txtTradeId.Text, "Trade Id", 1)) return;
            Spcommon.APIDLL.R_SPAPI_GetTradeByTradeNo(txtTradeOrderNo.Text, txtTradeId.Text);
            this.Close();
        }

        private void btnPriceSubscribe_Click(object sender, EventArgs e)
        {
            if (!IsValid(txtPriceProd.Text, Convert.ToInt32(btnPriceSubscribe.Tag) < 4 ? "Product Code" : "Ccy Type", 0)) return;
            if (Convert.ToInt32(btnPriceSubscribe.Tag) == 1)
                Spcommon.APIDLL.R_SPAPI_SubscribePrice(txtPriceProd.Text, 1);
            else if (Convert.ToInt32(btnPriceSubscribe.Tag) == 0)
                Spcommon.APIDLL.R_SPAPI_SubscribePrice(txtPriceProd.Text, 0);
            else if (Convert.ToInt32(btnPriceSubscribe.Tag) == 2)
                Spcommon.APIDLL.R_SPAPI_SubscribeTicker(txtPriceProd.Text, 1);
            else if (Convert.ToInt32(btnPriceSubscribe.Tag) == 3)
                Spcommon.APIDLL.R_SPAPI_SubscribeTicker(txtPriceProd.Text, 0);
            else if (Convert.ToInt32(btnPriceSubscribe.Tag) == 4)
                Spcommon.APIDLL.R_SPAPI_GetAccBalByCurrency(txtPriceProd.Text);

            this.Close();
        }

        private void btnPriceByProd_Click(object sender, EventArgs e)
        {
            if (!IsValid(txtPriceByProd.Text, "Product Code", 0)) return;
            if (Convert.ToInt32(btnPriceByProd.Tag) == 1)
                Spcommon.APIDLL.R_SPAPI_GetPriceByCode(txtPriceByProd.Text);
            else if (Convert.ToInt32(btnPriceByProd.Tag) == 2)
                Spcommon.APIDLL.R_SPAPI_GetInstrumentByCode(txtPriceByProd.Text);
            else if (Convert.ToInt32(btnPriceByProd.Tag) == 3)
                Spcommon.APIDLL.R_SPAPI_GetProductByCode(txtPriceByProd.Text);
            else if (Convert.ToInt32(btnPriceByProd.Tag) == 4)
                Spcommon.APIDLL.R_SPAPI_LoadProductInfoListByCode(txtPriceByProd.Text);
            else if (Convert.ToInt32(btnPriceByProd.Tag) == 5)
                Spcommon.APIDLL.R_SPAPI_AccountLogin(txtPriceByProd.Text);
            this.Close();
        }

        private void btnConnStatus_Click(object sender, EventArgs e)
        {
            if (!IsValid(txtConnStatusCode.Text, "Connection Id", 1)) return;
            Spcommon.APIDLL.GetLoginStatus(Convert.ToInt16(txtConnStatusCode.Text));
            this.Close();
        }

        private void btnOrderinactive_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btnOrderinactive.Tag) == 1)
            {
                if (!IsValid(txtOrderInactiveId.Text, "Order Id", 1)) return;
                if (Spcommon.S_Prot == 8081) Spcommon.ord_acc_no = this.txtInputAccAct.Text;
                Spcommon.APIDLL.SetOrderInactive(txtOrderInactiveId.Text, radioButton.Checked != true);
            }
            else if (Convert.ToInt32(btnOrderinactive.Tag) == 2)
            {
                if (Spcommon.S_Prot == 8081)
                {
                    if (radioButton2.Checked)Spcommon.ord_acc_no = this.txtInputAccAct.Text;
                    if (radioButton.Checked) Spcommon.ord_acc_no = "***";
                }
                Spcommon.APIDLL.R_SPAPI_GetOrderCount();
            }
            this.Close();
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            if (Spcommon.S_Prot == 8081)
            {
                if (radioButton.Checked)
                {
                    this.txtInputAccAct.Visible = false;
                    this.label22.Visible = false;
                }
                if (radioButton2.Checked)
                {
                    this.txtInputAccAct.Visible = true;
                    this.label22.Visible = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            Spcommon.Add_Order_Time = currentTime.Millisecond;
            if (Spcommon.S_Prot == 8081) Spcommon.ord_acc_no = this.txtInputAccNo.Text;
            Spcommon.APIDLL.R_SPAPI_AddOrder('B', txtPrice.Text, txtProdCode.Text, txtQty.Text, txtAddClOrderId.Text);
        

            //timer1.Enabled = true;
        }



    }
}
