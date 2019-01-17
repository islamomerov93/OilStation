namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderTypeGbx = new System.Windows.Forms.GroupBox();
            this.moneyRbtn = new System.Windows.Forms.RadioButton();
            this.litreRbtn = new System.Windows.Forms.RadioButton();
            this.oilStationOveralCostGbx = new System.Windows.Forms.GroupBox();
            this.oilStationOverallCostLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.moneyTbx = new System.Windows.Forms.TextBox();
            this.litrePriceTbx = new System.Windows.Forms.TextBox();
            this.litresTbx = new System.Windows.Forms.TextBox();
            this.kindOfOilCbx = new System.Windows.Forms.ComboBox();
            this.litrePriceLbl = new System.Windows.Forms.Label();
            this.oilLbl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.americanoCbx = new System.Windows.Forms.CheckBox();
            this.cappuchinoCbx = new System.Windows.Forms.CheckBox();
            this.cococolaCbx = new System.Windows.Forms.CheckBox();
            this.hamburgerCbx = new System.Windows.Forms.CheckBox();
            this.hotdogCbx = new System.Windows.Forms.CheckBox();
            this.miniCafeOveralCostGbx = new System.Windows.Forms.GroupBox();
            this.miniCafeOverallCostLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.C_americanoTbx = new System.Windows.Forms.TextBox();
            this.C_cappuchinoTbx = new System.Windows.Forms.TextBox();
            this.C_cococolaTbx = new System.Windows.Forms.TextBox();
            this.C_hamburgerTbx = new System.Windows.Forms.TextBox();
            this.C_hotdogTbx = new System.Windows.Forms.TextBox();
            this.Q_americanoTbx = new System.Windows.Forms.TextBox();
            this.Q_cappuchinoTbx = new System.Windows.Forms.TextBox();
            this.Q_cococolaTbx = new System.Windows.Forms.TextBox();
            this.Q_hamburgerTbx = new System.Windows.Forms.TextBox();
            this.Q_hotdogTbx = new System.Windows.Forms.TextBox();
            this.OverallCostGbx = new System.Windows.Forms.GroupBox();
            this.overallCostLbl = new System.Windows.Forms.Label();
            this.moneyIbx = new System.Windows.Forms.PictureBox();
            this.printCheckBtn = new System.Windows.Forms.Button();
            this.overall = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.orderTypeGbx.SuspendLayout();
            this.oilStationOveralCostGbx.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.miniCafeOveralCostGbx.SuspendLayout();
            this.OverallCostGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyIbx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.orderTypeGbx);
            this.groupBox1.Controls.Add(this.oilStationOveralCostGbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.currencyLbl);
            this.groupBox1.Controls.Add(this.moneyTbx);
            this.groupBox1.Controls.Add(this.litrePriceTbx);
            this.groupBox1.Controls.Add(this.litresTbx);
            this.groupBox1.Controls.Add(this.kindOfOilCbx);
            this.groupBox1.Controls.Add(this.litrePriceLbl);
            this.groupBox1.Controls.Add(this.oilLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil station";
            // 
            // orderTypeGbx
            // 
            this.orderTypeGbx.Controls.Add(this.moneyRbtn);
            this.orderTypeGbx.Controls.Add(this.litreRbtn);
            this.orderTypeGbx.Enabled = false;
            this.orderTypeGbx.Location = new System.Drawing.Point(20, 114);
            this.orderTypeGbx.Name = "orderTypeGbx";
            this.orderTypeGbx.Size = new System.Drawing.Size(111, 86);
            this.orderTypeGbx.TabIndex = 0;
            this.orderTypeGbx.TabStop = false;
            // 
            // moneyRbtn
            // 
            this.moneyRbtn.AutoSize = true;
            this.moneyRbtn.Location = new System.Drawing.Point(7, 53);
            this.moneyRbtn.Name = "moneyRbtn";
            this.moneyRbtn.Size = new System.Drawing.Size(57, 17);
            this.moneyRbtn.TabIndex = 0;
            this.moneyRbtn.TabStop = true;
            this.moneyRbtn.Text = "Money";
            this.moneyRbtn.UseVisualStyleBackColor = true;
            this.moneyRbtn.CheckedChanged += new System.EventHandler(this.litreRbtn_CheckedChanged);
            // 
            // litreRbtn
            // 
            this.litreRbtn.AutoSize = true;
            this.litreRbtn.Location = new System.Drawing.Point(7, 20);
            this.litreRbtn.Name = "litreRbtn";
            this.litreRbtn.Size = new System.Drawing.Size(45, 17);
            this.litreRbtn.TabIndex = 0;
            this.litreRbtn.TabStop = true;
            this.litreRbtn.Text = "Litre";
            this.litreRbtn.UseVisualStyleBackColor = true;
            this.litreRbtn.CheckedChanged += new System.EventHandler(this.litreRbtn_CheckedChanged);
            // 
            // oilStationOveralCostGbx
            // 
            this.oilStationOveralCostGbx.BackColor = System.Drawing.Color.PaleTurquoise;
            this.oilStationOveralCostGbx.Controls.Add(this.oilStationOverallCostLbl);
            this.oilStationOveralCostGbx.Controls.Add(this.label3);
            this.oilStationOveralCostGbx.Location = new System.Drawing.Point(20, 209);
            this.oilStationOveralCostGbx.Name = "oilStationOveralCostGbx";
            this.oilStationOveralCostGbx.Size = new System.Drawing.Size(236, 86);
            this.oilStationOveralCostGbx.TabIndex = 0;
            this.oilStationOveralCostGbx.TabStop = false;
            this.oilStationOveralCostGbx.Text = "Overal cost";
            // 
            // oilStationOverallCostLbl
            // 
            this.oilStationOverallCostLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oilStationOverallCostLbl.Location = new System.Drawing.Point(11, 16);
            this.oilStationOverallCostLbl.Name = "oilStationOverallCostLbl";
            this.oilStationOverallCostLbl.Size = new System.Drawing.Size(184, 57);
            this.oilStationOverallCostLbl.TabIndex = 4;
            this.oilStationOverallCostLbl.Text = "0";
            this.oilStationOverallCostLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.oilStationOverallCostLbl.TextChanged += new System.EventHandler(this.oilStationOverallCostLbl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "AZN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AZN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "litre(s)";
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.Location = new System.Drawing.Point(237, 78);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(29, 13);
            this.currencyLbl.TabIndex = 3;
            this.currencyLbl.Text = "AZN";
            // 
            // moneyTbx
            // 
            this.moneyTbx.Enabled = false;
            this.moneyTbx.ForeColor = System.Drawing.Color.Silver;
            this.moneyTbx.Location = new System.Drawing.Point(144, 167);
            this.moneyTbx.Name = "moneyTbx";
            this.moneyTbx.Size = new System.Drawing.Size(89, 20);
            this.moneyTbx.TabIndex = 2;
            this.moneyTbx.Text = "cost of oil per litre";
            this.moneyTbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Q_hotdogTbx_MouseClick);
            this.moneyTbx.TextChanged += new System.EventHandler(this.moneyTbx_TextChanged);
            // 
            // litrePriceTbx
            // 
            this.litrePriceTbx.ForeColor = System.Drawing.Color.Gray;
            this.litrePriceTbx.Location = new System.Drawing.Point(88, 71);
            this.litrePriceTbx.Name = "litrePriceTbx";
            this.litrePriceTbx.ReadOnly = true;
            this.litrePriceTbx.Size = new System.Drawing.Size(145, 20);
            this.litrePriceTbx.TabIndex = 2;
            this.litrePriceTbx.Text = "cost of oil per litre";
            // 
            // litresTbx
            // 
            this.litresTbx.Enabled = false;
            this.litresTbx.ForeColor = System.Drawing.Color.Silver;
            this.litresTbx.Location = new System.Drawing.Point(144, 134);
            this.litresTbx.Name = "litresTbx";
            this.litresTbx.Size = new System.Drawing.Size(89, 20);
            this.litresTbx.TabIndex = 2;
            this.litresTbx.Text = "cost of oil per litre";
            this.litresTbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Q_hotdogTbx_MouseClick);
            this.litresTbx.TextChanged += new System.EventHandler(this.litresTbx_TextChanged);
            // 
            // kindOfOilCbx
            // 
            this.kindOfOilCbx.ForeColor = System.Drawing.Color.Black;
            this.kindOfOilCbx.FormattingEnabled = true;
            this.kindOfOilCbx.Location = new System.Drawing.Point(88, 35);
            this.kindOfOilCbx.Name = "kindOfOilCbx";
            this.kindOfOilCbx.Size = new System.Drawing.Size(145, 21);
            this.kindOfOilCbx.TabIndex = 0;
            this.kindOfOilCbx.Text = "Choose kind of oil";
            this.kindOfOilCbx.SelectedIndexChanged += new System.EventHandler(this.kindOfOilCbx_SelectedIndexChanged);
            // 
            // litrePriceLbl
            // 
            this.litrePriceLbl.AutoSize = true;
            this.litrePriceLbl.Location = new System.Drawing.Point(17, 71);
            this.litrePriceLbl.Name = "litrePriceLbl";
            this.litrePriceLbl.Size = new System.Drawing.Size(56, 13);
            this.litrePriceLbl.TabIndex = 0;
            this.litrePriceLbl.Text = "Litre/Price";
            // 
            // oilLbl
            // 
            this.oilLbl.AutoSize = true;
            this.oilLbl.Location = new System.Drawing.Point(17, 35);
            this.oilLbl.Name = "oilLbl";
            this.oilLbl.Size = new System.Drawing.Size(19, 13);
            this.oilLbl.TabIndex = 0;
            this.oilLbl.Text = "Oil";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox4.Controls.Add(this.americanoCbx);
            this.groupBox4.Controls.Add(this.cappuchinoCbx);
            this.groupBox4.Controls.Add(this.cococolaCbx);
            this.groupBox4.Controls.Add(this.hamburgerCbx);
            this.groupBox4.Controls.Add(this.hotdogCbx);
            this.groupBox4.Controls.Add(this.miniCafeOveralCostGbx);
            this.groupBox4.Controls.Add(this.C_americanoTbx);
            this.groupBox4.Controls.Add(this.C_cappuchinoTbx);
            this.groupBox4.Controls.Add(this.C_cococolaTbx);
            this.groupBox4.Controls.Add(this.C_hamburgerTbx);
            this.groupBox4.Controls.Add(this.C_hotdogTbx);
            this.groupBox4.Controls.Add(this.Q_americanoTbx);
            this.groupBox4.Controls.Add(this.Q_cappuchinoTbx);
            this.groupBox4.Controls.Add(this.Q_cococolaTbx);
            this.groupBox4.Controls.Add(this.Q_hamburgerTbx);
            this.groupBox4.Controls.Add(this.Q_hotdogTbx);
            this.groupBox4.Location = new System.Drawing.Point(309, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 305);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cafe-Go";
            // 
            // americanoCbx
            // 
            this.americanoCbx.AutoSize = true;
            this.americanoCbx.BackColor = System.Drawing.Color.PaleTurquoise;
            this.americanoCbx.Location = new System.Drawing.Point(20, 174);
            this.americanoCbx.Name = "americanoCbx";
            this.americanoCbx.Size = new System.Drawing.Size(76, 17);
            this.americanoCbx.TabIndex = 3;
            this.americanoCbx.Text = "Americano";
            this.americanoCbx.UseVisualStyleBackColor = false;
            this.americanoCbx.CheckedChanged += new System.EventHandler(this.hotdogCbx_CheckedChanged);
            // 
            // cappuchinoCbx
            // 
            this.cappuchinoCbx.AutoSize = true;
            this.cappuchinoCbx.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cappuchinoCbx.Location = new System.Drawing.Point(20, 140);
            this.cappuchinoCbx.Name = "cappuchinoCbx";
            this.cappuchinoCbx.Size = new System.Drawing.Size(83, 17);
            this.cappuchinoCbx.TabIndex = 3;
            this.cappuchinoCbx.Text = "Cappuchino";
            this.cappuchinoCbx.UseVisualStyleBackColor = false;
            this.cappuchinoCbx.CheckedChanged += new System.EventHandler(this.hotdogCbx_CheckedChanged);
            // 
            // cococolaCbx
            // 
            this.cococolaCbx.AutoSize = true;
            this.cococolaCbx.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cococolaCbx.Location = new System.Drawing.Point(20, 105);
            this.cococolaCbx.Name = "cococolaCbx";
            this.cococolaCbx.Size = new System.Drawing.Size(74, 17);
            this.cococolaCbx.TabIndex = 3;
            this.cococolaCbx.Text = "Coco-cola";
            this.cococolaCbx.UseVisualStyleBackColor = false;
            this.cococolaCbx.CheckedChanged += new System.EventHandler(this.hotdogCbx_CheckedChanged);
            // 
            // hamburgerCbx
            // 
            this.hamburgerCbx.AutoSize = true;
            this.hamburgerCbx.BackColor = System.Drawing.Color.PaleTurquoise;
            this.hamburgerCbx.Location = new System.Drawing.Point(20, 73);
            this.hamburgerCbx.Name = "hamburgerCbx";
            this.hamburgerCbx.Size = new System.Drawing.Size(78, 17);
            this.hamburgerCbx.TabIndex = 3;
            this.hamburgerCbx.Text = "Hamburger";
            this.hamburgerCbx.UseVisualStyleBackColor = false;
            this.hamburgerCbx.CheckedChanged += new System.EventHandler(this.hotdogCbx_CheckedChanged);
            // 
            // hotdogCbx
            // 
            this.hotdogCbx.AutoSize = true;
            this.hotdogCbx.BackColor = System.Drawing.Color.PaleTurquoise;
            this.hotdogCbx.Location = new System.Drawing.Point(20, 39);
            this.hotdogCbx.Name = "hotdogCbx";
            this.hotdogCbx.Size = new System.Drawing.Size(64, 17);
            this.hotdogCbx.TabIndex = 3;
            this.hotdogCbx.Text = "Hot-dog";
            this.hotdogCbx.UseVisualStyleBackColor = false;
            this.hotdogCbx.CheckedChanged += new System.EventHandler(this.hotdogCbx_CheckedChanged);
            // 
            // miniCafeOveralCostGbx
            // 
            this.miniCafeOveralCostGbx.BackColor = System.Drawing.Color.PaleTurquoise;
            this.miniCafeOveralCostGbx.Controls.Add(this.miniCafeOverallCostLbl);
            this.miniCafeOveralCostGbx.Controls.Add(this.label4);
            this.miniCafeOveralCostGbx.Location = new System.Drawing.Point(20, 209);
            this.miniCafeOveralCostGbx.Name = "miniCafeOveralCostGbx";
            this.miniCafeOveralCostGbx.Size = new System.Drawing.Size(236, 86);
            this.miniCafeOveralCostGbx.TabIndex = 0;
            this.miniCafeOveralCostGbx.TabStop = false;
            this.miniCafeOveralCostGbx.Text = "Overal cost";
            // 
            // miniCafeOverallCostLbl
            // 
            this.miniCafeOverallCostLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.miniCafeOverallCostLbl.Location = new System.Drawing.Point(16, 16);
            this.miniCafeOverallCostLbl.Name = "miniCafeOverallCostLbl";
            this.miniCafeOverallCostLbl.Size = new System.Drawing.Size(179, 57);
            this.miniCafeOverallCostLbl.TabIndex = 4;
            this.miniCafeOverallCostLbl.Text = "0";
            this.miniCafeOverallCostLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AZN";
            // 
            // C_americanoTbx
            // 
            this.C_americanoTbx.ForeColor = System.Drawing.Color.Silver;
            this.C_americanoTbx.Location = new System.Drawing.Point(160, 174);
            this.C_americanoTbx.Name = "C_americanoTbx";
            this.C_americanoTbx.ReadOnly = true;
            this.C_americanoTbx.Size = new System.Drawing.Size(45, 20);
            this.C_americanoTbx.TabIndex = 12;
            this.C_americanoTbx.Text = "cost";
            // 
            // C_cappuchinoTbx
            // 
            this.C_cappuchinoTbx.ForeColor = System.Drawing.Color.Silver;
            this.C_cappuchinoTbx.Location = new System.Drawing.Point(160, 140);
            this.C_cappuchinoTbx.Name = "C_cappuchinoTbx";
            this.C_cappuchinoTbx.ReadOnly = true;
            this.C_cappuchinoTbx.Size = new System.Drawing.Size(45, 20);
            this.C_cappuchinoTbx.TabIndex = 22;
            this.C_cappuchinoTbx.Text = "cost";
            // 
            // C_cococolaTbx
            // 
            this.C_cococolaTbx.ForeColor = System.Drawing.Color.Silver;
            this.C_cococolaTbx.Location = new System.Drawing.Point(160, 105);
            this.C_cococolaTbx.Name = "C_cococolaTbx";
            this.C_cococolaTbx.ReadOnly = true;
            this.C_cococolaTbx.Size = new System.Drawing.Size(45, 20);
            this.C_cococolaTbx.TabIndex = 2;
            this.C_cococolaTbx.Text = "cost";
            // 
            // C_hamburgerTbx
            // 
            this.C_hamburgerTbx.ForeColor = System.Drawing.Color.Silver;
            this.C_hamburgerTbx.Location = new System.Drawing.Point(160, 73);
            this.C_hamburgerTbx.Name = "C_hamburgerTbx";
            this.C_hamburgerTbx.ReadOnly = true;
            this.C_hamburgerTbx.Size = new System.Drawing.Size(45, 20);
            this.C_hamburgerTbx.TabIndex = 2;
            this.C_hamburgerTbx.Text = "cost";
            // 
            // C_hotdogTbx
            // 
            this.C_hotdogTbx.ForeColor = System.Drawing.Color.Silver;
            this.C_hotdogTbx.Location = new System.Drawing.Point(160, 39);
            this.C_hotdogTbx.Name = "C_hotdogTbx";
            this.C_hotdogTbx.ReadOnly = true;
            this.C_hotdogTbx.Size = new System.Drawing.Size(45, 20);
            this.C_hotdogTbx.TabIndex = 2;
            this.C_hotdogTbx.Text = "cost";
            // 
            // Q_americanoTbx
            // 
            this.Q_americanoTbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Q_americanoTbx.ForeColor = System.Drawing.Color.Silver;
            this.Q_americanoTbx.Location = new System.Drawing.Point(211, 174);
            this.Q_americanoTbx.Name = "Q_americanoTbx";
            this.Q_americanoTbx.ReadOnly = true;
            this.Q_americanoTbx.Size = new System.Drawing.Size(45, 20);
            this.Q_americanoTbx.TabIndex = 2;
            this.Q_americanoTbx.Text = "quantity";
            this.Q_americanoTbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Q_hotdogTbx_MouseClick);
            this.Q_americanoTbx.TextChanged += new System.EventHandler(this.Q_americanoTbx_TextChanged);
            // 
            // Q_cappuchinoTbx
            // 
            this.Q_cappuchinoTbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Q_cappuchinoTbx.ForeColor = System.Drawing.Color.Silver;
            this.Q_cappuchinoTbx.Location = new System.Drawing.Point(211, 140);
            this.Q_cappuchinoTbx.Name = "Q_cappuchinoTbx";
            this.Q_cappuchinoTbx.ReadOnly = true;
            this.Q_cappuchinoTbx.Size = new System.Drawing.Size(45, 20);
            this.Q_cappuchinoTbx.TabIndex = 2;
            this.Q_cappuchinoTbx.Text = "quantity";
            this.Q_cappuchinoTbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Q_hotdogTbx_MouseClick);
            this.Q_cappuchinoTbx.TextChanged += new System.EventHandler(this.Q_americanoTbx_TextChanged);
            // 
            // Q_cococolaTbx
            // 
            this.Q_cococolaTbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Q_cococolaTbx.ForeColor = System.Drawing.Color.Silver;
            this.Q_cococolaTbx.Location = new System.Drawing.Point(211, 105);
            this.Q_cococolaTbx.Name = "Q_cococolaTbx";
            this.Q_cococolaTbx.ReadOnly = true;
            this.Q_cococolaTbx.Size = new System.Drawing.Size(45, 20);
            this.Q_cococolaTbx.TabIndex = 2;
            this.Q_cococolaTbx.Text = "quantity";
            this.Q_cococolaTbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Q_hotdogTbx_MouseClick);
            this.Q_cococolaTbx.TextChanged += new System.EventHandler(this.Q_americanoTbx_TextChanged);
            // 
            // Q_hamburgerTbx
            // 
            this.Q_hamburgerTbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Q_hamburgerTbx.ForeColor = System.Drawing.Color.Silver;
            this.Q_hamburgerTbx.Location = new System.Drawing.Point(211, 73);
            this.Q_hamburgerTbx.Name = "Q_hamburgerTbx";
            this.Q_hamburgerTbx.ReadOnly = true;
            this.Q_hamburgerTbx.Size = new System.Drawing.Size(45, 20);
            this.Q_hamburgerTbx.TabIndex = 2;
            this.Q_hamburgerTbx.Text = "quantity";
            this.Q_hamburgerTbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Q_hotdogTbx_MouseClick);
            this.Q_hamburgerTbx.TextChanged += new System.EventHandler(this.Q_americanoTbx_TextChanged);
            // 
            // Q_hotdogTbx
            // 
            this.Q_hotdogTbx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Q_hotdogTbx.ForeColor = System.Drawing.Color.Silver;
            this.Q_hotdogTbx.Location = new System.Drawing.Point(211, 39);
            this.Q_hotdogTbx.Name = "Q_hotdogTbx";
            this.Q_hotdogTbx.ReadOnly = true;
            this.Q_hotdogTbx.Size = new System.Drawing.Size(45, 20);
            this.Q_hotdogTbx.TabIndex = 2;
            this.Q_hotdogTbx.Text = "quantity";
            this.Q_hotdogTbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Q_hotdogTbx_MouseClick);
            this.Q_hotdogTbx.TextChanged += new System.EventHandler(this.Q_americanoTbx_TextChanged);
            // 
            // OverallCostGbx
            // 
            this.OverallCostGbx.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OverallCostGbx.Controls.Add(this.overallCostLbl);
            this.OverallCostGbx.Controls.Add(this.moneyIbx);
            this.OverallCostGbx.Controls.Add(this.printCheckBtn);
            this.OverallCostGbx.Controls.Add(this.overall);
            this.OverallCostGbx.Location = new System.Drawing.Point(12, 324);
            this.OverallCostGbx.Name = "OverallCostGbx";
            this.OverallCostGbx.Size = new System.Drawing.Size(569, 86);
            this.OverallCostGbx.TabIndex = 0;
            this.OverallCostGbx.TabStop = false;
            this.OverallCostGbx.Text = "Overall cost";
            // 
            // overallCostLbl
            // 
            this.overallCostLbl.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallCostLbl.Location = new System.Drawing.Point(374, 20);
            this.overallCostLbl.Name = "overallCostLbl";
            this.overallCostLbl.Size = new System.Drawing.Size(128, 50);
            this.overallCostLbl.TabIndex = 8;
            this.overallCostLbl.Text = "0";
            this.overallCostLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // moneyIbx
            // 
            this.moneyIbx.BackgroundImage = global::WindowsFormsApp9.Properties.Resources.download;
            this.moneyIbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moneyIbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyIbx.Location = new System.Drawing.Point(7, 20);
            this.moneyIbx.Name = "moneyIbx";
            this.moneyIbx.Size = new System.Drawing.Size(100, 50);
            this.moneyIbx.TabIndex = 7;
            this.moneyIbx.TabStop = false;
            // 
            // printCheckBtn
            // 
            this.printCheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.printCheckBtn.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printCheckBtn.Location = new System.Drawing.Point(203, 17);
            this.printCheckBtn.Name = "printCheckBtn";
            this.printCheckBtn.Size = new System.Drawing.Size(165, 53);
            this.printCheckBtn.TabIndex = 6;
            this.printCheckBtn.Text = "Print check";
            this.printCheckBtn.UseVisualStyleBackColor = true;
            this.printCheckBtn.Click += new System.EventHandler(this.printCheckBtn_Click);
            this.printCheckBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.printCheckBtn_MouseClick);
            // 
            // overall
            // 
            this.overall.AutoSize = true;
            this.overall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overall.Location = new System.Drawing.Point(508, 52);
            this.overall.Name = "overall";
            this.overall.Size = new System.Drawing.Size(44, 20);
            this.overall.TabIndex = 3;
            this.overall.Text = "AZN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(593, 417);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OverallCostGbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ISLAM OIL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.orderTypeGbx.ResumeLayout(false);
            this.orderTypeGbx.PerformLayout();
            this.oilStationOveralCostGbx.ResumeLayout(false);
            this.oilStationOveralCostGbx.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.miniCafeOveralCostGbx.ResumeLayout(false);
            this.miniCafeOveralCostGbx.PerformLayout();
            this.OverallCostGbx.ResumeLayout(false);
            this.OverallCostGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyIbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox orderTypeGbx;
        private System.Windows.Forms.RadioButton moneyRbtn;
        private System.Windows.Forms.RadioButton litreRbtn;
        private System.Windows.Forms.GroupBox oilStationOveralCostGbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.TextBox moneyTbx;
        private System.Windows.Forms.TextBox litrePriceTbx;
        private System.Windows.Forms.TextBox litresTbx;
        private System.Windows.Forms.ComboBox kindOfOilCbx;
        private System.Windows.Forms.Label litrePriceLbl;
        private System.Windows.Forms.Label oilLbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox americanoCbx;
        private System.Windows.Forms.CheckBox cappuchinoCbx;
        private System.Windows.Forms.CheckBox cococolaCbx;
        private System.Windows.Forms.CheckBox hamburgerCbx;
        private System.Windows.Forms.CheckBox hotdogCbx;
        private System.Windows.Forms.GroupBox miniCafeOveralCostGbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox C_americanoTbx;
        private System.Windows.Forms.TextBox C_cappuchinoTbx;
        private System.Windows.Forms.TextBox C_cococolaTbx;
        private System.Windows.Forms.TextBox C_hamburgerTbx;
        private System.Windows.Forms.TextBox C_hotdogTbx;
        private System.Windows.Forms.TextBox Q_americanoTbx;
        private System.Windows.Forms.TextBox Q_cappuchinoTbx;
        private System.Windows.Forms.TextBox Q_cococolaTbx;
        private System.Windows.Forms.TextBox Q_hamburgerTbx;
        private System.Windows.Forms.TextBox Q_hotdogTbx;
        private System.Windows.Forms.GroupBox OverallCostGbx;
        private System.Windows.Forms.Label overall;
        private System.Windows.Forms.Button printCheckBtn;
        private System.Windows.Forms.Label overallCostLbl;
        private System.Windows.Forms.PictureBox moneyIbx;
        private System.Windows.Forms.Label oilStationOverallCostLbl;
        private System.Windows.Forms.Label miniCafeOverallCostLbl;
    }
}

