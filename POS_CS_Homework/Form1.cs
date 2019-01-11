using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CS_Homework       //1.相同品項第二件6折。2.不同品項買三送一(送最低價者)
{
    public partial class Form1 : Form
    {
        double totalPrice = 0.0;    //總價
        double afterDiscountTotalPrice = 0.0;   //折扣後總價        
        int orderFormCount = 0;     //訂購單計數器      
        double[] arrayDiscount = new double[] { 10.0, -0.4, -1.0 };  //折扣陣列 {tbDiscount,第二件6折,買三送一}     

        struct Drink        //定義Drink結構
        {
            public string drinkNumber;      //編號
            public string drinkName;      //品名
            public double drinkPrice;      //價格
            public double drinkDiscountPrice;      //折扣價錢
            public double drinkTotalPrice;      //該項總價
            public int drinkCupQuantity;        //杯數          
        }

        Drink[] iiiDrink = new Drink[]      //建立Drink結構陣列及預設參數
        {                                   //編號，品名，價格，折扣金額，該項總價，杯數
            new Drink(){ drinkNumber = "iiiDrink001",drinkName="麥香紅茶",drinkPrice=35.0,drinkDiscountPrice=0.0,drinkTotalPrice=0.0,drinkCupQuantity=0 },   //[0]
            new Drink(){ drinkNumber = "iiiDrink002",drinkName="茉莉綠茶",drinkPrice=30.0,drinkDiscountPrice=0.0,drinkTotalPrice=0.0,drinkCupQuantity=0 },   //[1]
            new Drink(){ drinkNumber = "iiiDrink003",drinkName="珍珠奶茶",drinkPrice=45.0,drinkDiscountPrice=0.0,drinkTotalPrice=0.0,drinkCupQuantity=0 },   //[2]
            new Drink(){ drinkNumber = "iiiDrink004",drinkName="玫瑰花茶",drinkPrice=40.0,drinkDiscountPrice=0.0,drinkTotalPrice=0.0,drinkCupQuantity=0 },   //[3]
            new Drink(){ drinkNumber = "iiiDrink005",drinkName="現打西瓜汁",drinkPrice=55.0,drinkDiscountPrice=0.0,drinkTotalPrice=0.0,drinkCupQuantity=0 }   //[4]
        };

        List<int> shoppingCart = new List<int>();   //建立Drink結構的List購物車 
        SortedList<double, int> priceSort = new SortedList<double, int>();  //建立價格與索引值的SortedList
        //SortedList  表示索引鍵key與值value組配對的集合，這個集合按索引鍵排序，而且可以按索引鍵和索引存取。

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label[] lblDrink = new Label[] { lblDrink001, lblDrink002, lblDrink003, lblDrink004, lblDrink005 };     //品名Label陣列

            for(int i = 0; i <= lblDrink.GetUpperBound(0); i += 1)
            {
                lblDrink[i].Text = iiiDrink[i].drinkName;
            }

            Label[] lblDrinkPrice = new Label[] { lblDrinkPrice001, lblDrinkPrice002, lblDrinkPrice003, lblDrinkPrice004, lblDrinkPrice005 };   //價格Label陣列

            for (int i = 0; i <= lblDrink.GetUpperBound(0); i += 1)
            {
                lblDrinkPrice[i].Text = $"{iiiDrink[i].drinkPrice}";
            }
        }
        
        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            if (tbDiscount.Text != "")
            {
                bool ifNum = System.Double.TryParse(tbDiscount.Text, out arrayDiscount[0]);

                if (ifNum == true)
                {
                    if ((arrayDiscount[0] >= 0.0) && (arrayDiscount[0] <= 10.0))    
                    {
                        //合理折扣數
                    }
                    else
                    {
                        MessageBox.Show("折扣數輸入錯誤(0.0-10.0)");
                        tbDiscount.Text = "";
                        arrayDiscount[0] = 10.0;
                    }
                }
                else
                {
                    MessageBox.Show("折扣數輸入錯誤(0.0-10.0)");
                    tbDiscount.Text = "";
                    arrayDiscount[0] = 10.0;
                }
            }
            else
            {
                arrayDiscount[0] = 10.0;
            }

            calculatePrice();
        }

        private void btnCupQuantityReduce001_Click(object sender, EventArgs e)
        {
            iiiDrink[0].drinkCupQuantity -= 1;

            if (iiiDrink[0].drinkCupQuantity <= 0)
            {
                iiiDrink[0].drinkCupQuantity = 0;
                btnCupQuantityReduce001.Enabled = false;
            }

            tbCupQuantity001.Text = $"{iiiDrink[0].drinkCupQuantity}";
        }

        private void btnCupQuantityAdd001_Click(object sender, EventArgs e)
        {
            iiiDrink[0].drinkCupQuantity += 1;
            btnCupQuantityReduce001.Enabled = true;
            tbCupQuantity001.Text = $"{iiiDrink[0].drinkCupQuantity}";
        }

        private void tbCupQuantity001_TextChanged(object sender, EventArgs e)
        {
            if (tbCupQuantity001.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbCupQuantity001.Text, out iiiDrink[0].drinkCupQuantity);
                if ((ifNum == true) && (iiiDrink[0].drinkCupQuantity >= 0))
                {
                    //輸入正確
                    btnCupQuantityReduce001.Enabled = true;
                    bool ifContains = false;    //檢查購物車是否已有該物件
                    
                    for (int i = 0; i < shoppingCart.Count; i += 1)     //使用迴圈比對drinkNumber
                    {
                        if (shoppingCart[i] == 0)   //使用迴圈比對品項陣列的索引值[0]是否在shoppingCart裡
                        {
                            ifContains = true;
                        }
                    }
                    
                    if (ifContains == false)  
                    {
                        shoppingCart.Add(0);    //購物車增加品項陣列[0]的索引值
                    }                    
                    if (iiiDrink[0].drinkCupQuantity == 0)  //若數量為0，就從購物車刪除
                    {
                        iiiDrink[0].drinkDiscountPrice = 0.0;
                        iiiDrink[0].drinkTotalPrice = 0.0;
                        listElementRemove(shoppingCart, 0);                        
                    }
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCupQuantity001.Text = "";
                }
            }
            else
            {
                iiiDrink[0].drinkCupQuantity = 0;
                iiiDrink[0].drinkDiscountPrice = 0.0;
                iiiDrink[0].drinkTotalPrice = 0.0;
                listElementRemove(shoppingCart, 0); 
            }

            calculatePrice();
        }

        private void btnCupQuantityReduce002_Click(object sender, EventArgs e)
        {
            iiiDrink[1].drinkCupQuantity -= 1;

            if (iiiDrink[1].drinkCupQuantity <= 0)
            {
                iiiDrink[1].drinkCupQuantity = 0;
                btnCupQuantityReduce002.Enabled = false;
            }

            tbCupQuantity002.Text = $"{iiiDrink[1].drinkCupQuantity}";
        }

        private void btnCupQuantityAdd002_Click(object sender, EventArgs e)
        {
            iiiDrink[1].drinkCupQuantity += 1;
            btnCupQuantityReduce002.Enabled = true;
            tbCupQuantity002.Text = $"{iiiDrink[1].drinkCupQuantity}";
        }

        private void tbCupQuantity002_TextChanged(object sender, EventArgs e)
        {
            if (tbCupQuantity002.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbCupQuantity002.Text, out iiiDrink[1].drinkCupQuantity);
                if ((ifNum == true) && (iiiDrink[1].drinkCupQuantity >= 0))
                {
                    //輸入正確
                    btnCupQuantityReduce002.Enabled = true;
                    bool ifContains = false;    //檢查購物車是否已有該物件

                    for (int i = 0; i < shoppingCart.Count; i += 1)
                    {
                        if (shoppingCart[i] == 1)   //使用迴圈比對品項陣列的索引值[1]是否在shoppingCart裡
                        {
                            ifContains = true;
                        }
                    }

                    if (ifContains == false)
                    {
                        shoppingCart.Add(1);    //購物車增加品項陣列[1]的索引值
                    }
                    if (iiiDrink[1].drinkCupQuantity == 0)  //若數量為0，就從購物車刪除
                    {
                        iiiDrink[1].drinkDiscountPrice = 0.0;
                        iiiDrink[1].drinkTotalPrice = 0.0;
                        listElementRemove(shoppingCart, 1);
                    }
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCupQuantity002.Text = "";
                }
            }
            else
            {
                iiiDrink[1].drinkCupQuantity = 0;
                iiiDrink[1].drinkDiscountPrice = 0.0;
                iiiDrink[1].drinkTotalPrice = 0.0;
                listElementRemove(shoppingCart, 1);
            }

            calculatePrice();
        }

        private void btnCupQuantityReduce003_Click(object sender, EventArgs e)
        {
            iiiDrink[2].drinkCupQuantity -= 1;

            if (iiiDrink[2].drinkCupQuantity <= 0)
            {
                iiiDrink[2].drinkCupQuantity = 0;
                btnCupQuantityReduce003.Enabled = false;
            }

            tbCupQuantity003.Text = $"{iiiDrink[2].drinkCupQuantity}";
        }

        private void btnCupQuantityAdd003_Click(object sender, EventArgs e)
        {
            iiiDrink[2].drinkCupQuantity += 1;
            btnCupQuantityReduce003.Enabled = true;
            tbCupQuantity003.Text = $"{iiiDrink[2].drinkCupQuantity}";
        }

        private void tbCupQuantity003_TextChanged(object sender, EventArgs e)
        {
            if (tbCupQuantity003.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbCupQuantity003.Text, out iiiDrink[2].drinkCupQuantity);
                if ((ifNum == true) && (iiiDrink[2].drinkCupQuantity >= 0))
                {
                    //輸入正確
                    btnCupQuantityReduce003.Enabled = true;
                    bool ifContains = false;    //檢查購物車是否已有該物件

                    for (int i = 0; i < shoppingCart.Count; i += 1)
                    {
                        if (shoppingCart[i] == 2)   //使用迴圈比對品項陣列的索引值[2]是否在shoppingCart裡
                        {
                            ifContains = true;
                        }
                    }

                    if (ifContains == false)
                    {
                        shoppingCart.Add(2);    //購物車增加品項陣列[2]的索引值
                    }
                    if (iiiDrink[2].drinkCupQuantity == 0)  //若數量為0，就從購物車刪除
                    {
                        iiiDrink[2].drinkDiscountPrice = 0.0;
                        iiiDrink[2].drinkTotalPrice = 0.0;
                        listElementRemove(shoppingCart, 2);
                    }
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCupQuantity003.Text = "";
                }
            }
            else
            {
                iiiDrink[2].drinkCupQuantity = 0;
                iiiDrink[2].drinkDiscountPrice = 0.0;
                iiiDrink[2].drinkTotalPrice = 0.0;
                listElementRemove(shoppingCart, 2);
            }

            calculatePrice();
        }

        private void btnCupQuantityReduce004_Click(object sender, EventArgs e)
        {
            iiiDrink[3].drinkCupQuantity -= 1;

            if (iiiDrink[3].drinkCupQuantity <= 0)
            {
                iiiDrink[3].drinkCupQuantity = 0;
                btnCupQuantityReduce004.Enabled = false;
            }

            tbCupQuantity004.Text = $"{iiiDrink[3].drinkCupQuantity}";
        }

        private void btnCupQuantityAdd004_Click(object sender, EventArgs e)
        {
            iiiDrink[3].drinkCupQuantity += 1;
            btnCupQuantityReduce003.Enabled = true;
            tbCupQuantity004.Text = $"{iiiDrink[3].drinkCupQuantity}";
        }

        private void tbCupQuantity004_TextChanged(object sender, EventArgs e)
        {
            if (tbCupQuantity004.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbCupQuantity004.Text, out iiiDrink[3].drinkCupQuantity);
                if ((ifNum == true) && (iiiDrink[3].drinkCupQuantity >= 0))
                {
                    //輸入正確
                    btnCupQuantityReduce004.Enabled = true;
                    bool ifContains = false;    //檢查購物車是否已有該物件

                    for (int i = 0; i < shoppingCart.Count; i += 1)
                    {
                        if (shoppingCart[i] == 3)   //使用迴圈比對品項陣列的索引值[3]是否在shoppingCart裡
                        {
                            ifContains = true;
                        }
                    }

                    if (ifContains == false)
                    {
                        shoppingCart.Add(3);    //購物車增加品項陣列[3]的索引值
                    }
                    if (iiiDrink[3].drinkCupQuantity == 0)  //若數量為0，就從購物車刪除
                    {
                        iiiDrink[3].drinkDiscountPrice = 0.0;
                        iiiDrink[3].drinkTotalPrice = 0.0;
                        listElementRemove(shoppingCart, 3);
                    }
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCupQuantity004.Text = "";
                }
            }
            else
            {
                iiiDrink[3].drinkCupQuantity = 0;
                iiiDrink[3].drinkDiscountPrice = 0.0;
                iiiDrink[3].drinkTotalPrice = 0.0;
                listElementRemove(shoppingCart, 3);
            }

            calculatePrice();
        }

        private void btnCupQuantityReduce005_Click(object sender, EventArgs e)
        {
            iiiDrink[4].drinkCupQuantity -= 1;

            if (iiiDrink[4].drinkCupQuantity <= 0)
            {
                iiiDrink[4].drinkCupQuantity = 0;
                btnCupQuantityReduce005.Enabled = false;
            }

            tbCupQuantity005.Text = $"{iiiDrink[4].drinkCupQuantity}";
        }

        private void btnCupQuantityAdd005_Click(object sender, EventArgs e)
        {
            iiiDrink[4].drinkCupQuantity += 1;
            btnCupQuantityReduce005.Enabled = true;
            tbCupQuantity005.Text = $"{iiiDrink[4].drinkCupQuantity}";
        }

        private void tbCupQuantity005_TextChanged(object sender, EventArgs e)
        {
            if (tbCupQuantity005.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbCupQuantity005.Text, out iiiDrink[4].drinkCupQuantity);
                if ((ifNum == true) && (iiiDrink[4].drinkCupQuantity >= 0))
                {
                    //輸入正確
                    btnCupQuantityReduce005.Enabled = true;
                    bool ifContains = false;    //檢查購物車是否已有該物件

                    for (int i = 0; i < shoppingCart.Count; i += 1)
                    {
                        if (shoppingCart[i] == 4)   //使用迴圈比對品項陣列的索引值[4]是否在shoppingCart裡
                        {
                            ifContains = true;
                        }
                    }

                    if (ifContains == false)
                    {
                        shoppingCart.Add(4);    //購物車增加品項陣列[4]的索引值
                    }
                    if (iiiDrink[4].drinkCupQuantity == 0)  //若數量為0，就從購物車刪除
                    {
                        iiiDrink[4].drinkDiscountPrice = 0.0;
                        iiiDrink[4].drinkTotalPrice = 0.0;
                        listElementRemove(shoppingCart, 4);
                    }
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCupQuantity005.Text = "";
                }
            }
            else
            {
                iiiDrink[4].drinkCupQuantity = 0;
                iiiDrink[4].drinkDiscountPrice = 0.0;
                iiiDrink[4].drinkTotalPrice = 0.0;
                listElementRemove(shoppingCart, 4);
            }

            calculatePrice();
        }

        private void btnPrintOrderForm_Click(object sender, EventArgs e)
        {
            DialogResult drResult;      //MessageBox的回傳值為DialogResult型別
            drResult = MessageBox.Show("您確認送出訂購單?", "訂單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResult == DialogResult.No)
            {
                //不送出資料
            }
            else
            {
                orderFormCount += 1;
                string strOrder = "***** III冷飲店訂購單 *****\n\n";
                strOrder += $"訂單編號 : iiiDrink{DateTime.Now:yyyyMMdd}{orderFormCount:0000}\n";
                if (rbtnEvent01.Checked == true)
                {
                    strOrder += $"促銷活動 : {rbtnEvent01.Text}\n";
                }
                else if (rbtnEvent02.Checked == true)
                {
                    strOrder += $"促銷活動 : {rbtnEvent02.Text}\n";
                }
                strOrder += "------------------------------------\n";

                foreach(int i in shoppingCart)
                {
                    strOrder += $"{iiiDrink[i].drinkName} : {iiiDrink[i].drinkPrice} x {iiiDrink[i].drinkCupQuantity} = {iiiDrink[i].drinkTotalPrice}\n";
                    if (iiiDrink[i].drinkDiscountPrice < 0)
                    {
                        strOrder += $"{iiiDrink[i].drinkDiscountPrice}\n";
                    }
                }
                
                strOrder += "------------------------------------\n";
                if (arrayDiscount[0] < 10.0)
                {
                    strOrder += $"折扣數 {arrayDiscount[0]:F2}\n";
                }

                strOrder += $"訂單總價 {totalPrice:C}\n" +
                    $"折扣後總價 {afterDiscountTotalPrice:C}\n" +
                    $"{DateTime.Now:D}\n" +
                    $"{DateTime.Now:T}";

                MessageBox.Show(strOrder, "訂單明細", MessageBoxButtons.OK);
            }
        }

        private void cbEvent_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEvent.Checked == true)
            {
                gbEvent.Enabled = true;
                rbtnEvent01.Checked = true;
            }
            else
            {
                rbtnEvent01.Checked = false;
                rbtnEvent02.Checked = false;
                gbEvent.Enabled = false;

                foreach (int index in shoppingCart)
                {
                    iiiDrink[index].drinkDiscountPrice = 0.0;
                    iiiDrink[index].drinkTotalPrice = 0.0;
                }

                calculatePrice();
            }
        }

        private void rbtnEvent01_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEvent01.Checked == true)
            {
                foreach (int index in shoppingCart)
                {
                    iiiDrink[index].drinkDiscountPrice = 0.0;
                    iiiDrink[index].drinkTotalPrice = 0.0;
                }

                calculatePrice();
            }
        }

        private void rbtnEvent02_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEvent02.Checked == true)
            {
                foreach (int index in shoppingCart)
                {
                    iiiDrink[index].drinkDiscountPrice = 0.0;
                    iiiDrink[index].drinkTotalPrice = 0.0;
                }

                calculatePrice();
            }
        }

        void calculatePrice()      //void 表示此方法沒有回傳值，()內可設定欲傳入的參數
        {
            totalPrice = 0.0;
            afterDiscountTotalPrice = 0.0;
            
            foreach (int index in shoppingCart)     //購物車訂單總價-未折扣
            {
                iiiDrink[index].drinkTotalPrice = iiiDrink[index].drinkPrice * iiiDrink[index].drinkCupQuantity;
                totalPrice += iiiDrink[index].drinkTotalPrice;
            }

            if (cbEvent.Checked == true)    //促銷活動打勾時
            {                
                if (rbtnEvent01.Checked == true )    //同品項第二件6折
                {                 
                    int intQuotient = 0;    //商數 => 需要折扣的數量

                    foreach (int index in shoppingCart)
                    {
                        intQuotient = iiiDrink[index].drinkCupQuantity / 2;
                        iiiDrink[index].drinkDiscountPrice = iiiDrink[index].drinkPrice * intQuotient * arrayDiscount[1];       //個別品項的折扣金額(負值)
                    }

                }
                else if (rbtnEvent02.Checked == true)   //不同品項買三送一(共四杯，送最低價者)
                {
                    priceSort.Clear();      //將買三送一價格排序專用的SortedList內容清除，以避免再次計算買三送一時產生索引值被重複使用的例外錯誤

                    int intAllDrinkCupQuantity = 0;     //總杯數

                    foreach (int index in shoppingCart)
                    {
                        intAllDrinkCupQuantity += iiiDrink[index].drinkCupQuantity;
                    }

                    int intQuotient = intAllDrinkCupQuantity / 4;    //商數 => 需要折扣的數量 

                    //將購物車裡，所存放的索引值，其對應品項的價格與索引值加入資料型別為SortedList的priceSort。Key為價格(因為要以價格高低來排序)，Value為索引值。成員加入後，會自動由小到大排序
                    foreach (int index in shoppingCart)     
                    {
                        priceSort.Add(iiiDrink[index].drinkPrice, index);
                    }
                    
                    foreach (KeyValuePair<double, int> pS in priceSort)
                    {
                        if (intQuotient - iiiDrink[pS.Value].drinkCupQuantity >= 0)
                        {
                            iiiDrink[pS.Value].drinkDiscountPrice = iiiDrink[pS.Value].drinkPrice * iiiDrink[pS.Value].drinkCupQuantity * arrayDiscount[2];  //個別品項的折扣金額(負值)
                            intQuotient -= iiiDrink[pS.Value].drinkCupQuantity;
                        }
                        else if (intQuotient - iiiDrink[pS.Value].drinkCupQuantity < 0)
                        {
                            iiiDrink[pS.Value].drinkDiscountPrice = iiiDrink[pS.Value].drinkPrice * intQuotient * arrayDiscount[2];   //最後一個折扣品項的折扣金額(負值)
                            intQuotient = 0;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("請選擇促銷活動", "未選擇促銷活動", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                foreach (int index in shoppingCart)
                {
                    afterDiscountTotalPrice += iiiDrink[index].drinkTotalPrice + iiiDrink[index].drinkDiscountPrice;    //促銷折扣後總價
                }

                afterDiscountTotalPrice = afterDiscountTotalPrice * arrayDiscount[0] / 10.0;   //促銷折扣後總價再打折
            }
            else    //促銷活動未打勾時
            {
                gbEvent.Enabled = false;
                afterDiscountTotalPrice = totalPrice * arrayDiscount[0] / 10.0;
            }                        

            lblTotalPrice.Text = $"{totalPrice:C}";
            lblAfterDiscountTotalPrice.Text = $"{afterDiscountTotalPrice:C}";
        }

        void listElementRemove(List<int> ShoppingCart,int index)     //方法-刪除購物車裡的物件
        {
            if (ShoppingCart.Count > 0)     //ShoppingCart裡面有東西才執行
            {
                for (int i = 0; i < ShoppingCart.Count; i += 1)
                {
                    if (ShoppingCart[i] == index)
                    {
                        ShoppingCart.RemoveAt(i);
                    }
                }
            }            
        }
    }
}
