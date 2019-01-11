namespace POS_CS_Homework
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrintOrderForm = new System.Windows.Forms.Button();
            this.lblAfterDiscountTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCupQuantityReduce005 = new System.Windows.Forms.Button();
            this.btnCupQuantityAdd005 = new System.Windows.Forms.Button();
            this.btnCupQuantityReduce004 = new System.Windows.Forms.Button();
            this.btnCupQuantityAdd004 = new System.Windows.Forms.Button();
            this.btnCupQuantityReduce003 = new System.Windows.Forms.Button();
            this.btnCupQuantityAdd003 = new System.Windows.Forms.Button();
            this.btnCupQuantityReduce002 = new System.Windows.Forms.Button();
            this.btnCupQuantityAdd002 = new System.Windows.Forms.Button();
            this.btnCupQuantityReduce001 = new System.Windows.Forms.Button();
            this.btnCupQuantityAdd001 = new System.Windows.Forms.Button();
            this.tbCupQuantity005 = new System.Windows.Forms.TextBox();
            this.tbCupQuantity004 = new System.Windows.Forms.TextBox();
            this.tbCupQuantity003 = new System.Windows.Forms.TextBox();
            this.tbCupQuantity002 = new System.Windows.Forms.TextBox();
            this.tbCupQuantity001 = new System.Windows.Forms.TextBox();
            this.lblDrinkPrice005 = new System.Windows.Forms.Label();
            this.lblDrinkPrice004 = new System.Windows.Forms.Label();
            this.lblDrinkPrice003 = new System.Windows.Forms.Label();
            this.lblDrinkPrice002 = new System.Windows.Forms.Label();
            this.lblDrinkPrice001 = new System.Windows.Forms.Label();
            this.lblDrink005 = new System.Windows.Forms.Label();
            this.lblDrink004 = new System.Windows.Forms.Label();
            this.lblDrink003 = new System.Windows.Forms.Label();
            this.lblDrink002 = new System.Windows.Forms.Label();
            this.lblDrink001 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEvent = new System.Windows.Forms.GroupBox();
            this.rbtnEvent02 = new System.Windows.Forms.RadioButton();
            this.rbtnEvent01 = new System.Windows.Forms.RadioButton();
            this.cbEvent = new System.Windows.Forms.CheckBox();
            this.gbEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintOrderForm
            // 
            this.btnPrintOrderForm.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrintOrderForm.Location = new System.Drawing.Point(701, 312);
            this.btnPrintOrderForm.Name = "btnPrintOrderForm";
            this.btnPrintOrderForm.Size = new System.Drawing.Size(218, 113);
            this.btnPrintOrderForm.TabIndex = 69;
            this.btnPrintOrderForm.Text = "列印訂購單";
            this.btnPrintOrderForm.UseVisualStyleBackColor = true;
            this.btnPrintOrderForm.Click += new System.EventHandler(this.btnPrintOrderForm_Click);
            // 
            // lblAfterDiscountTotalPrice
            // 
            this.lblAfterDiscountTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblAfterDiscountTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAfterDiscountTotalPrice.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAfterDiscountTotalPrice.Location = new System.Drawing.Point(475, 392);
            this.lblAfterDiscountTotalPrice.Name = "lblAfterDiscountTotalPrice";
            this.lblAfterDiscountTotalPrice.Size = new System.Drawing.Size(189, 33);
            this.lblAfterDiscountTotalPrice.TabIndex = 68;
            this.lblAfterDiscountTotalPrice.Text = "0.0";
            this.lblAfterDiscountTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPrice.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(475, 250);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(189, 33);
            this.lblTotalPrice.TabIndex = 67;
            this.lblTotalPrice.Text = "0.0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Yellow;
            this.label16.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(475, 356);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 21);
            this.label16.TabIndex = 66;
            this.label16.Text = "訂單折扣後總價";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Yellow;
            this.label15.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(475, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 21);
            this.label15.TabIndex = 65;
            this.label15.Text = "訂單總價";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbDiscount.Location = new System.Drawing.Point(475, 108);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(76, 33);
            this.tbDiscount.TabIndex = 64;
            this.tbDiscount.TextChanged += new System.EventHandler(this.tbDiscount_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Yellow;
            this.label14.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(475, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 21);
            this.label14.TabIndex = 63;
            this.label14.Text = "折扣數(x.x折)";
            // 
            // btnCupQuantityReduce005
            // 
            this.btnCupQuantityReduce005.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityReduce005.Location = new System.Drawing.Point(262, 392);
            this.btnCupQuantityReduce005.Name = "btnCupQuantityReduce005";
            this.btnCupQuantityReduce005.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityReduce005.TabIndex = 62;
            this.btnCupQuantityReduce005.Text = "-";
            this.btnCupQuantityReduce005.UseVisualStyleBackColor = true;
            this.btnCupQuantityReduce005.Click += new System.EventHandler(this.btnCupQuantityReduce005_Click);
            // 
            // btnCupQuantityAdd005
            // 
            this.btnCupQuantityAdd005.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityAdd005.Location = new System.Drawing.Point(379, 392);
            this.btnCupQuantityAdd005.Name = "btnCupQuantityAdd005";
            this.btnCupQuantityAdd005.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityAdd005.TabIndex = 61;
            this.btnCupQuantityAdd005.Text = "+";
            this.btnCupQuantityAdd005.UseVisualStyleBackColor = true;
            this.btnCupQuantityAdd005.Click += new System.EventHandler(this.btnCupQuantityAdd005_Click);
            // 
            // btnCupQuantityReduce004
            // 
            this.btnCupQuantityReduce004.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityReduce004.Location = new System.Drawing.Point(262, 321);
            this.btnCupQuantityReduce004.Name = "btnCupQuantityReduce004";
            this.btnCupQuantityReduce004.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityReduce004.TabIndex = 60;
            this.btnCupQuantityReduce004.Text = "-";
            this.btnCupQuantityReduce004.UseVisualStyleBackColor = true;
            this.btnCupQuantityReduce004.Click += new System.EventHandler(this.btnCupQuantityReduce004_Click);
            // 
            // btnCupQuantityAdd004
            // 
            this.btnCupQuantityAdd004.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityAdd004.Location = new System.Drawing.Point(379, 321);
            this.btnCupQuantityAdd004.Name = "btnCupQuantityAdd004";
            this.btnCupQuantityAdd004.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityAdd004.TabIndex = 59;
            this.btnCupQuantityAdd004.Text = "+";
            this.btnCupQuantityAdd004.UseVisualStyleBackColor = true;
            this.btnCupQuantityAdd004.Click += new System.EventHandler(this.btnCupQuantityAdd004_Click);
            // 
            // btnCupQuantityReduce003
            // 
            this.btnCupQuantityReduce003.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityReduce003.Location = new System.Drawing.Point(262, 250);
            this.btnCupQuantityReduce003.Name = "btnCupQuantityReduce003";
            this.btnCupQuantityReduce003.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityReduce003.TabIndex = 58;
            this.btnCupQuantityReduce003.Text = "-";
            this.btnCupQuantityReduce003.UseVisualStyleBackColor = true;
            this.btnCupQuantityReduce003.Click += new System.EventHandler(this.btnCupQuantityReduce003_Click);
            // 
            // btnCupQuantityAdd003
            // 
            this.btnCupQuantityAdd003.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityAdd003.Location = new System.Drawing.Point(379, 250);
            this.btnCupQuantityAdd003.Name = "btnCupQuantityAdd003";
            this.btnCupQuantityAdd003.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityAdd003.TabIndex = 57;
            this.btnCupQuantityAdd003.Text = "+";
            this.btnCupQuantityAdd003.UseVisualStyleBackColor = true;
            this.btnCupQuantityAdd003.Click += new System.EventHandler(this.btnCupQuantityAdd003_Click);
            // 
            // btnCupQuantityReduce002
            // 
            this.btnCupQuantityReduce002.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityReduce002.Location = new System.Drawing.Point(262, 179);
            this.btnCupQuantityReduce002.Name = "btnCupQuantityReduce002";
            this.btnCupQuantityReduce002.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityReduce002.TabIndex = 56;
            this.btnCupQuantityReduce002.Text = "-";
            this.btnCupQuantityReduce002.UseVisualStyleBackColor = true;
            this.btnCupQuantityReduce002.Click += new System.EventHandler(this.btnCupQuantityReduce002_Click);
            // 
            // btnCupQuantityAdd002
            // 
            this.btnCupQuantityAdd002.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityAdd002.Location = new System.Drawing.Point(379, 179);
            this.btnCupQuantityAdd002.Name = "btnCupQuantityAdd002";
            this.btnCupQuantityAdd002.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityAdd002.TabIndex = 55;
            this.btnCupQuantityAdd002.Text = "+";
            this.btnCupQuantityAdd002.UseVisualStyleBackColor = true;
            this.btnCupQuantityAdd002.Click += new System.EventHandler(this.btnCupQuantityAdd002_Click);
            // 
            // btnCupQuantityReduce001
            // 
            this.btnCupQuantityReduce001.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityReduce001.Location = new System.Drawing.Point(262, 108);
            this.btnCupQuantityReduce001.Name = "btnCupQuantityReduce001";
            this.btnCupQuantityReduce001.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityReduce001.TabIndex = 54;
            this.btnCupQuantityReduce001.Text = "-";
            this.btnCupQuantityReduce001.UseVisualStyleBackColor = true;
            this.btnCupQuantityReduce001.Click += new System.EventHandler(this.btnCupQuantityReduce001_Click);
            // 
            // btnCupQuantityAdd001
            // 
            this.btnCupQuantityAdd001.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupQuantityAdd001.Location = new System.Drawing.Point(379, 108);
            this.btnCupQuantityAdd001.Name = "btnCupQuantityAdd001";
            this.btnCupQuantityAdd001.Size = new System.Drawing.Size(38, 33);
            this.btnCupQuantityAdd001.TabIndex = 53;
            this.btnCupQuantityAdd001.Text = "+";
            this.btnCupQuantityAdd001.UseVisualStyleBackColor = true;
            this.btnCupQuantityAdd001.Click += new System.EventHandler(this.btnCupQuantityAdd001_Click);
            // 
            // tbCupQuantity005
            // 
            this.tbCupQuantity005.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCupQuantity005.Location = new System.Drawing.Point(306, 392);
            this.tbCupQuantity005.Name = "tbCupQuantity005";
            this.tbCupQuantity005.Size = new System.Drawing.Size(67, 33);
            this.tbCupQuantity005.TabIndex = 52;
            this.tbCupQuantity005.TextChanged += new System.EventHandler(this.tbCupQuantity005_TextChanged);
            // 
            // tbCupQuantity004
            // 
            this.tbCupQuantity004.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCupQuantity004.Location = new System.Drawing.Point(306, 321);
            this.tbCupQuantity004.Name = "tbCupQuantity004";
            this.tbCupQuantity004.Size = new System.Drawing.Size(67, 33);
            this.tbCupQuantity004.TabIndex = 51;
            this.tbCupQuantity004.TextChanged += new System.EventHandler(this.tbCupQuantity004_TextChanged);
            // 
            // tbCupQuantity003
            // 
            this.tbCupQuantity003.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCupQuantity003.Location = new System.Drawing.Point(306, 250);
            this.tbCupQuantity003.Name = "tbCupQuantity003";
            this.tbCupQuantity003.Size = new System.Drawing.Size(67, 33);
            this.tbCupQuantity003.TabIndex = 50;
            this.tbCupQuantity003.TextChanged += new System.EventHandler(this.tbCupQuantity003_TextChanged);
            // 
            // tbCupQuantity002
            // 
            this.tbCupQuantity002.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCupQuantity002.Location = new System.Drawing.Point(306, 179);
            this.tbCupQuantity002.Name = "tbCupQuantity002";
            this.tbCupQuantity002.Size = new System.Drawing.Size(67, 33);
            this.tbCupQuantity002.TabIndex = 49;
            this.tbCupQuantity002.TextChanged += new System.EventHandler(this.tbCupQuantity002_TextChanged);
            // 
            // tbCupQuantity001
            // 
            this.tbCupQuantity001.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCupQuantity001.Location = new System.Drawing.Point(306, 108);
            this.tbCupQuantity001.Name = "tbCupQuantity001";
            this.tbCupQuantity001.Size = new System.Drawing.Size(67, 33);
            this.tbCupQuantity001.TabIndex = 48;
            this.tbCupQuantity001.TextChanged += new System.EventHandler(this.tbCupQuantity001_TextChanged);
            // 
            // lblDrinkPrice005
            // 
            this.lblDrinkPrice005.AutoSize = true;
            this.lblDrinkPrice005.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrinkPrice005.Location = new System.Drawing.Point(178, 395);
            this.lblDrinkPrice005.Name = "lblDrinkPrice005";
            this.lblDrinkPrice005.Size = new System.Drawing.Size(32, 21);
            this.lblDrinkPrice005.TabIndex = 47;
            this.lblDrinkPrice005.Text = "40";
            // 
            // lblDrinkPrice004
            // 
            this.lblDrinkPrice004.AutoSize = true;
            this.lblDrinkPrice004.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrinkPrice004.Location = new System.Drawing.Point(178, 324);
            this.lblDrinkPrice004.Name = "lblDrinkPrice004";
            this.lblDrinkPrice004.Size = new System.Drawing.Size(32, 21);
            this.lblDrinkPrice004.TabIndex = 46;
            this.lblDrinkPrice004.Text = "35";
            // 
            // lblDrinkPrice003
            // 
            this.lblDrinkPrice003.AutoSize = true;
            this.lblDrinkPrice003.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrinkPrice003.Location = new System.Drawing.Point(178, 253);
            this.lblDrinkPrice003.Name = "lblDrinkPrice003";
            this.lblDrinkPrice003.Size = new System.Drawing.Size(32, 21);
            this.lblDrinkPrice003.TabIndex = 45;
            this.lblDrinkPrice003.Text = "30";
            // 
            // lblDrinkPrice002
            // 
            this.lblDrinkPrice002.AutoSize = true;
            this.lblDrinkPrice002.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrinkPrice002.Location = new System.Drawing.Point(178, 182);
            this.lblDrinkPrice002.Name = "lblDrinkPrice002";
            this.lblDrinkPrice002.Size = new System.Drawing.Size(32, 21);
            this.lblDrinkPrice002.TabIndex = 44;
            this.lblDrinkPrice002.Text = "25";
            // 
            // lblDrinkPrice001
            // 
            this.lblDrinkPrice001.AutoSize = true;
            this.lblDrinkPrice001.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrinkPrice001.Location = new System.Drawing.Point(178, 111);
            this.lblDrinkPrice001.Name = "lblDrinkPrice001";
            this.lblDrinkPrice001.Size = new System.Drawing.Size(32, 21);
            this.lblDrinkPrice001.TabIndex = 43;
            this.lblDrinkPrice001.Text = "20";
            // 
            // lblDrink005
            // 
            this.lblDrink005.AutoSize = true;
            this.lblDrink005.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrink005.Location = new System.Drawing.Point(55, 395);
            this.lblDrink005.Name = "lblDrink005";
            this.lblDrink005.Size = new System.Drawing.Size(76, 21);
            this.lblDrink005.TabIndex = 42;
            this.lblDrink005.Text = "西瓜汁";
            // 
            // lblDrink004
            // 
            this.lblDrink004.AutoSize = true;
            this.lblDrink004.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrink004.Location = new System.Drawing.Point(55, 324);
            this.lblDrink004.Name = "lblDrink004";
            this.lblDrink004.Size = new System.Drawing.Size(54, 21);
            this.lblDrink004.TabIndex = 41;
            this.lblDrink004.Text = "花茶";
            // 
            // lblDrink003
            // 
            this.lblDrink003.AutoSize = true;
            this.lblDrink003.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrink003.Location = new System.Drawing.Point(55, 253);
            this.lblDrink003.Name = "lblDrink003";
            this.lblDrink003.Size = new System.Drawing.Size(54, 21);
            this.lblDrink003.TabIndex = 40;
            this.lblDrink003.Text = "奶茶";
            // 
            // lblDrink002
            // 
            this.lblDrink002.AutoSize = true;
            this.lblDrink002.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrink002.Location = new System.Drawing.Point(55, 182);
            this.lblDrink002.Name = "lblDrink002";
            this.lblDrink002.Size = new System.Drawing.Size(54, 21);
            this.lblDrink002.TabIndex = 39;
            this.lblDrink002.Text = "綠茶";
            // 
            // lblDrink001
            // 
            this.lblDrink001.AutoSize = true;
            this.lblDrink001.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrink001.Location = new System.Drawing.Point(55, 111);
            this.lblDrink001.Name = "lblDrink001";
            this.lblDrink001.Size = new System.Drawing.Size(54, 21);
            this.lblDrink001.TabIndex = 38;
            this.lblDrink001.Text = "紅茶";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(301, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "數量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(178, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "售價";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "品名";
            // 
            // gbEvent
            // 
            this.gbEvent.Controls.Add(this.rbtnEvent02);
            this.gbEvent.Controls.Add(this.rbtnEvent01);
            this.gbEvent.Enabled = false;
            this.gbEvent.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbEvent.Location = new System.Drawing.Point(701, 98);
            this.gbEvent.Name = "gbEvent";
            this.gbEvent.Size = new System.Drawing.Size(218, 146);
            this.gbEvent.TabIndex = 70;
            this.gbEvent.TabStop = false;
            // 
            // rbtnEvent02
            // 
            this.rbtnEvent02.AutoSize = true;
            this.rbtnEvent02.Location = new System.Drawing.Point(6, 78);
            this.rbtnEvent02.Name = "rbtnEvent02";
            this.rbtnEvent02.Size = new System.Drawing.Size(187, 23);
            this.rbtnEvent02.TabIndex = 1;
            this.rbtnEvent02.TabStop = true;
            this.rbtnEvent02.Text = "不同品項買三送一";
            this.rbtnEvent02.UseVisualStyleBackColor = true;
            this.rbtnEvent02.CheckedChanged += new System.EventHandler(this.rbtnEvent02_CheckedChanged);
            // 
            // rbtnEvent01
            // 
            this.rbtnEvent01.AutoSize = true;
            this.rbtnEvent01.Location = new System.Drawing.Point(6, 35);
            this.rbtnEvent01.Name = "rbtnEvent01";
            this.rbtnEvent01.Size = new System.Drawing.Size(177, 23);
            this.rbtnEvent01.TabIndex = 0;
            this.rbtnEvent01.TabStop = true;
            this.rbtnEvent01.Text = "同品項第二件6折";
            this.rbtnEvent01.UseVisualStyleBackColor = true;
            this.rbtnEvent01.CheckedChanged += new System.EventHandler(this.rbtnEvent01_CheckedChanged);
            // 
            // cbEvent
            // 
            this.cbEvent.AutoSize = true;
            this.cbEvent.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbEvent.Location = new System.Drawing.Point(701, 72);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(117, 25);
            this.cbEvent.TabIndex = 71;
            this.cbEvent.Text = "促銷活動";
            this.cbEvent.UseVisualStyleBackColor = true;
            this.cbEvent.CheckedChanged += new System.EventHandler(this.cbEvent_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(963, 469);
            this.Controls.Add(this.cbEvent);
            this.Controls.Add(this.gbEvent);
            this.Controls.Add(this.btnPrintOrderForm);
            this.Controls.Add(this.lblAfterDiscountTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCupQuantityReduce005);
            this.Controls.Add(this.btnCupQuantityAdd005);
            this.Controls.Add(this.btnCupQuantityReduce004);
            this.Controls.Add(this.btnCupQuantityAdd004);
            this.Controls.Add(this.btnCupQuantityReduce003);
            this.Controls.Add(this.btnCupQuantityAdd003);
            this.Controls.Add(this.btnCupQuantityReduce002);
            this.Controls.Add(this.btnCupQuantityAdd002);
            this.Controls.Add(this.btnCupQuantityReduce001);
            this.Controls.Add(this.btnCupQuantityAdd001);
            this.Controls.Add(this.tbCupQuantity005);
            this.Controls.Add(this.tbCupQuantity004);
            this.Controls.Add(this.tbCupQuantity003);
            this.Controls.Add(this.tbCupQuantity002);
            this.Controls.Add(this.tbCupQuantity001);
            this.Controls.Add(this.lblDrinkPrice005);
            this.Controls.Add(this.lblDrinkPrice004);
            this.Controls.Add(this.lblDrinkPrice003);
            this.Controls.Add(this.lblDrinkPrice002);
            this.Controls.Add(this.lblDrinkPrice001);
            this.Controls.Add(this.lblDrink005);
            this.Controls.Add(this.lblDrink004);
            this.Controls.Add(this.lblDrink003);
            this.Controls.Add(this.lblDrink002);
            this.Controls.Add(this.lblDrink001);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEvent.ResumeLayout(false);
            this.gbEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintOrderForm;
        private System.Windows.Forms.Label lblAfterDiscountTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCupQuantityReduce005;
        private System.Windows.Forms.Button btnCupQuantityAdd005;
        private System.Windows.Forms.Button btnCupQuantityReduce004;
        private System.Windows.Forms.Button btnCupQuantityAdd004;
        private System.Windows.Forms.Button btnCupQuantityReduce003;
        private System.Windows.Forms.Button btnCupQuantityAdd003;
        private System.Windows.Forms.Button btnCupQuantityReduce002;
        private System.Windows.Forms.Button btnCupQuantityAdd002;
        private System.Windows.Forms.Button btnCupQuantityReduce001;
        private System.Windows.Forms.Button btnCupQuantityAdd001;
        private System.Windows.Forms.TextBox tbCupQuantity005;
        private System.Windows.Forms.TextBox tbCupQuantity004;
        private System.Windows.Forms.TextBox tbCupQuantity003;
        private System.Windows.Forms.TextBox tbCupQuantity002;
        private System.Windows.Forms.TextBox tbCupQuantity001;
        private System.Windows.Forms.Label lblDrinkPrice005;
        private System.Windows.Forms.Label lblDrinkPrice004;
        private System.Windows.Forms.Label lblDrinkPrice003;
        private System.Windows.Forms.Label lblDrinkPrice002;
        private System.Windows.Forms.Label lblDrinkPrice001;
        private System.Windows.Forms.Label lblDrink005;
        private System.Windows.Forms.Label lblDrink004;
        private System.Windows.Forms.Label lblDrink003;
        private System.Windows.Forms.Label lblDrink002;
        private System.Windows.Forms.Label lblDrink001;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEvent;
        private System.Windows.Forms.CheckBox cbEvent;
        private System.Windows.Forms.RadioButton rbtnEvent02;
        private System.Windows.Forms.RadioButton rbtnEvent01;
    }
}

