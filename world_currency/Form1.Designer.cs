
namespace world_currency
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbobx_currency_number = new System.Windows.Forms.ComboBox();
            this.lbl_currency_number = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.cmbobx_country = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.rdobtn_country_name = new System.Windows.Forms.RadioButton();
            this.rdo_currency_number = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this._flag = new System.Windows.Forms.DataGridViewImageColumn();
            this.CurrencyData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banknote_f = new System.Windows.Forms.DataGridViewImageColumn();
            this.banknote_b = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbobx_currency_number
            // 
            this.cmbobx_currency_number.FormattingEnabled = true;
            this.cmbobx_currency_number.Items.AddRange(new object[] {
            "008",
            "012",
            "032",
            "036",
            "044",
            "048",
            "050",
            "051",
            "052",
            "060",
            "064",
            "068",
            "072",
            "084",
            "090",
            "096",
            "104",
            "108",
            "116",
            "124",
            "132",
            "136",
            "144",
            "152",
            "156",
            "170",
            "174",
            "188",
            "191",
            "192",
            "203",
            "208",
            "214",
            "222",
            "230",
            "232",
            "238",
            "242",
            "262",
            "270",
            "292",
            "320",
            "324",
            "328",
            "332",
            "340",
            "344",
            "348",
            "352",
            "356",
            "360",
            "364",
            "368",
            "376",
            "388",
            "392",
            "398",
            "400",
            "404",
            "408",
            "410",
            "414",
            "417",
            "418",
            "422",
            "426",
            "430",
            "434",
            "446",
            "454",
            "458",
            "462",
            "480",
            "484",
            "496",
            "498",
            "504",
            "512",
            "516",
            "524",
            "532",
            "532",
            "533",
            "548",
            "554",
            "558",
            "566",
            "578",
            "586",
            "590",
            "598",
            "600",
            "604",
            "608",
            "634",
            "643",
            "646",
            "682",
            "690",
            "694",
            "702",
            "704",
            "706",
            "710",
            "728",
            "748",
            "752",
            "756",
            "760",
            "764",
            "776",
            "780",
            "784",
            "788",
            "800",
            "807",
            "818",
            "826",
            "834",
            "840",
            "840",
            "858",
            "860",
            "882",
            "886",
            "901",
            "926",
            "927",
            "928",
            "929",
            "930",
            "931",
            "932",
            "933",
            "934",
            "936",
            "938",
            "940",
            "941",
            "943",
            "944",
            "946",
            "947",
            "948",
            "949",
            "950",
            "951",
            "952",
            "953",
            "955",
            "956",
            "957",
            "958",
            "959",
            "960",
            "961",
            "962",
            "963",
            "964",
            "965",
            "967",
            "968",
            "969",
            "970",
            "971",
            "972",
            "973",
            "975",
            "976",
            "977",
            "978",
            "979",
            "980",
            "981",
            "984",
            "985",
            "986",
            "990",
            "994",
            "997",
            "999"});
            this.cmbobx_currency_number.Location = new System.Drawing.Point(243, 16);
            this.cmbobx_currency_number.Name = "cmbobx_currency_number";
            this.cmbobx_currency_number.Size = new System.Drawing.Size(454, 21);
            this.cmbobx_currency_number.TabIndex = 2;
            // 
            // lbl_currency_number
            // 
            this.lbl_currency_number.AutoSize = true;
            this.lbl_currency_number.Location = new System.Drawing.Point(93, 18);
            this.lbl_currency_number.Name = "lbl_currency_number";
            this.lbl_currency_number.Size = new System.Drawing.Size(142, 13);
            this.lbl_currency_number.TabIndex = 3;
            this.lbl_currency_number.Text = "Choose by Currency Number";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(93, 17);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(96, 13);
            this.lbl_country.TabIndex = 5;
            this.lbl_country.Text = "Choose by Country";
            // 
            // cmbobx_country
            // 
            this.cmbobx_country.FormattingEnabled = true;
            this.cmbobx_country.Items.AddRange(new object[] {
            "AFGHANISTAN",
            "ÅLAND ISLANDS",
            "ALBANIA",
            "ALGERIA",
            "AMERICAN SAMOA",
            "ANDORRA",
            "ANGOLA",
            "ANGUILLA",
            "ANTIGUA AND BARBUDA",
            "ARGENTINA",
            "ARMENIA",
            "ARUBA",
            "AUSTRALIA",
            "AUSTRIA",
            "AZERBAIJAN",
            "BAHAMAS (THE)",
            "BAHRAIN",
            "BANGLADESH",
            "BARBADOS",
            "BELARUS",
            "BELGIUM",
            "BELIZE",
            "BENIN",
            "BERMUDA",
            "BHUTAN",
            "BHUTAN",
            "BOLIVIA (PLURINATIONAL STATE OF)",
            "BOLIVIA (PLURINATIONAL STATE OF)",
            "BONAIRE SINT EUSTATIUS AND SABA",
            "BOSNIA AND HERZEGOVINA",
            "BOTSWANA",
            "BOUVET ISLAND",
            "BRAZIL",
            "BRITISH INDIAN OCEAN TERRITORY (THE)",
            "BRUNEI DARUSSALAM",
            "BULGARIA",
            "BURKINA FASO",
            "BURUNDI",
            "CABO VERDE",
            "CAMBODIA",
            "CAMEROON",
            "CANADA",
            "CAYMAN ISLANDS (THE)",
            "CENTRAL AFRICAN REPUBLIC (THE)",
            "CHAD",
            "CHILE",
            "CHILE",
            "CHINA",
            "CHRISTMAS ISLAND",
            "COCOS (KEELING) ISLANDS (THE)",
            "COLOMBIA",
            "COLOMBIA",
            "COMOROS (THE)",
            "CONGO (THE DEMOCRATIC REPUBLIC OF THE)",
            "CONGO (THE)",
            "COOK ISLANDS (THE)",
            "COSTA RICA",
            "CÔTE D\'IVOIRE",
            "CROATIA",
            "CUBA",
            "CUBA",
            "CURAÇAO",
            "CYPRUS",
            "CZECHIA",
            "DENMARK",
            "DJIBOUTI",
            "DOMINICA",
            "DOMINICAN REPUBLIC (THE)",
            "ECUADOR",
            "EGYPT",
            "EL SALVADOR",
            "EL SALVADOR",
            "EQUATORIAL GUINEA",
            "ERITREA",
            "ESTONIA",
            "ESWATINI",
            "ETHIOPIA",
            "EUROPEAN UNION",
            "FALKLAND ISLANDS (THE) [MALVINAS]",
            "FAROE ISLANDS (THE)",
            "FIJI",
            "FINLAND",
            "FRANCE",
            "FRENCH GUIANA",
            "FRENCH POLYNESIA",
            "FRENCH SOUTHERN TERRITORIES (THE)",
            "GABON",
            "GAMBIA (THE)",
            "GEORGIA",
            "GERMANY",
            "GHANA",
            "GIBRALTAR",
            "GREECE",
            "GREENLAND",
            "GRENADA",
            "GUADELOUPE",
            "GUAM",
            "GUATEMALA",
            "GUERNSEY",
            "GUINEA",
            "GUINEA-BISSAU",
            "GUYANA",
            "HAITI",
            "HAITI",
            "HEARD ISLAND AND McDONALD ISLANDS",
            "HOLY SEE (THE)",
            "HONDURAS",
            "HONG KONG",
            "HUNGARY",
            "ICELAND",
            "INDIA",
            "INDONESIA",
            "INTERNATIONAL MONETARY FUND (IMF) ",
            "IRAN (ISLAMIC REPUBLIC OF)",
            "IRAQ",
            "IRELAND",
            "ISLE OF MAN",
            "ISRAEL",
            "ITALY",
            "JAMAICA",
            "JAPAN",
            "JERSEY",
            "JORDAN",
            "KAZAKHSTAN",
            "KENYA",
            "KIRIBATI",
            "KOREA (THE DEMOCRATIC PEOPLE’S REPUBLIC OF)",
            "KOREA (THE REPUBLIC OF)",
            "KUWAIT",
            "KYRGYZSTAN",
            "LAO PEOPLE’S DEMOCRATIC REPUBLIC (THE)",
            "LATVIA",
            "LEBANON",
            "LESOTHO",
            "LESOTHO",
            "LIBERIA",
            "LIBYA",
            "LIECHTENSTEIN",
            "LITHUANIA",
            "LUXEMBOURG",
            "MACAO",
            "NORTH MACEDONIA",
            "MADAGASCAR",
            "MALAWI",
            "MALAYSIA",
            "MALDIVES",
            "MALI",
            "MALTA",
            "MARSHALL ISLANDS (THE)",
            "MARTINIQUE",
            "MAURITANIA",
            "MAURITIUS",
            "MAYOTTE",
            "MEMBER COUNTRIES OF THE AFRICAN DEVELOPMENT BANK GROUP",
            "MEXICO",
            "MEXICO",
            "MICRONESIA (FEDERATED STATES OF)",
            "MOLDOVA (THE REPUBLIC OF)",
            "MONACO",
            "MONGOLIA",
            "MONTENEGRO",
            "MONTSERRAT",
            "MOROCCO",
            "MOZAMBIQUE",
            "MYANMAR",
            "NAMIBIA",
            "NAMIBIA",
            "NAURU",
            "NEPAL",
            "NETHERLANDS (THE)",
            "NEW CALEDONIA",
            "NEW ZEALAND",
            "NICARAGUA",
            "NIGER (THE)",
            "NIGERIA",
            "NIUE",
            "NORFOLK ISLAND",
            "NORTHERN MARIANA ISLANDS (THE)",
            "NORWAY",
            "OMAN",
            "PAKISTAN",
            "PALAU",
            "PALESTINE STATE OF",
            "PANAMA",
            "PANAMA",
            "PAPUA NEW GUINEA",
            "PARAGUAY",
            "PERU",
            "PHILIPPINES (THE)",
            "PITCAIRN",
            "POLAND",
            "PORTUGAL",
            "PUERTO RICO",
            "QATAR",
            "RÉUNION",
            "ROMANIA",
            "RUSSIAN FEDERATION (THE)",
            "RWANDA",
            "SAINT BARTHÉLEMY",
            "SAINT HELENA; ASCENSION AND TRISTAN DA CUNHA",
            "SAINT KITTS AND NEVIS",
            "SAINT LUCIA",
            "SAINT MARTIN (FRENCH PART)",
            "SAINT PIERRE AND MIQUELON",
            "SAINT VINCENT AND THE GRENADINES",
            "SAMOA",
            "SAN MARINO",
            "SAO TOME AND PRINCIPE",
            "SAUDI ARABIA",
            "SENEGAL",
            "SERBIA",
            "SEYCHELLES",
            "SIERRA LEONE",
            "SINGAPORE",
            "SINT MAARTEN (DUTCH PART)",
            "SISTEMA UNITARIO DE COMPENSACION REGIONAL DE PAGOS \"SUCRE\"",
            "SLOVAKIA",
            "SLOVENIA",
            "SOLOMON ISLANDS",
            "SOMALIA",
            "SOUTH AFRICA",
            "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS",
            "SOUTH SUDAN",
            "SPAIN",
            "SRI LANKA",
            "SUDAN (THE)",
            "SURINAME",
            "SVALBARD AND JAN MAYEN",
            "SWEDEN",
            "SWITZERLAND",
            "SWITZERLAND",
            "SWITZERLAND",
            "SYRIAN ARAB REPUBLIC",
            "TAIWAN (PROVINCE OF CHINA)",
            "TAJIKISTAN",
            "THAILAND",
            "TIMOR-LESTE",
            "TOGO",
            "TOKELAU",
            "TONGA",
            "TRINIDAD AND TOBAGO",
            "TUNISIA",
            "TURKEY",
            "TURKMENISTAN",
            "TURKS AND CAICOS ISLANDS (THE)",
            "TUVALU",
            "UGANDA",
            "UKRAINE",
            "UNITED ARAB EMIRATES (THE)",
            "UNITED KINGDOM OF GREAT BRITAIN AND NORTHERN IRELAND (THE)",
            "UNITED REPUBLIC OF TANZANIA",
            "UNITED STATES MINOR OUTLYING ISLANDS (THE)",
            "UNITED STATES OF AMERICA (THE)",
            "UNITED STATES OF AMERICA (THE)",
            "URUGUAY",
            "URUGUAY",
            "URUGUAY",
            "UZBEKISTAN",
            "VANUATU",
            "VENEZUELA (BOLIVARIAN REPUBLIC OF)",
            "VENEZUELA (BOLIVARIAN REPUBLIC OF)",
            "VIET NAM",
            "VIRGIN ISLANDS (BRITISH)",
            "VIRGIN ISLANDS (U.S.)",
            "WALLIS AND FUTUNA",
            "WESTERN SAHARA",
            "YEMEN",
            "ZAMBIA",
            "ZIMBABWE",
            "ZZ01_Bond Markets Unit European_EURCO",
            "ZZ02_Bond Markets Unit European_EMU-6",
            "ZZ03_Bond Markets Unit European_EUA-9",
            "ZZ04_Bond Markets Unit European_EUA-17",
            "ZZ06_Testing_Code",
            "ZZ07_No_Currency",
            "ZZ08_Gold",
            "ZZ09_Palladium",
            "ZZ10_Platinum",
            "ZZ11_Silver"});
            this.cmbobx_country.Location = new System.Drawing.Point(243, 16);
            this.cmbobx_country.Name = "cmbobx_country";
            this.cmbobx_country.Size = new System.Drawing.Size(454, 21);
            this.cmbobx_country.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select how you want to choose via:";
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(22, 28);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(138, 72);
            this.btn_find.TabIndex = 9;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // rdobtn_country_name
            // 
            this.rdobtn_country_name.AutoSize = true;
            this.rdobtn_country_name.Checked = true;
            this.rdobtn_country_name.Location = new System.Drawing.Point(9, 15);
            this.rdobtn_country_name.Margin = new System.Windows.Forms.Padding(2);
            this.rdobtn_country_name.Name = "rdobtn_country_name";
            this.rdobtn_country_name.Size = new System.Drawing.Size(99, 20);
            this.rdobtn_country_name.TabIndex = 10;
            this.rdobtn_country_name.TabStop = true;
            this.rdobtn_country_name.Text = "Country Name";
            this.rdobtn_country_name.UseVisualStyleBackColor = true;
            this.rdobtn_country_name.CheckedChanged += new System.EventHandler(this.rdobtn_country_name_CheckedChanged);
            // 
            // rdo_currency_number
            // 
            this.rdo_currency_number.AutoSize = true;
            this.rdo_currency_number.Location = new System.Drawing.Point(112, 14);
            this.rdo_currency_number.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_currency_number.Name = "rdo_currency_number";
            this.rdo_currency_number.Size = new System.Drawing.Size(114, 20);
            this.rdo_currency_number.TabIndex = 11;
            this.rdo_currency_number.Text = "Currency Number";
            this.rdo_currency_number.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_currency_number);
            this.groupBox1.Controls.Add(this.rdobtn_country_name);
            this.groupBox1.Location = new System.Drawing.Point(384, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 36);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 571);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 425);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgv_data);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(988, 425);
            this.panel6.TabIndex = 0;
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.AllowUserToDeleteRows = false;
            this.dgv_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._flag,
            this.CurrencyData,
            this.banknote_f,
            this.banknote_b});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_data.Location = new System.Drawing.Point(0, 0);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.ReadOnly = true;
            this.dgv_data.RowHeadersWidth = 62;
            this.dgv_data.Size = new System.Drawing.Size(988, 425);
            this.dgv_data.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 134);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.04738F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.95262F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(988, 134);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_find);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(803, 3);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel2.SetRowSpan(this.panel3, 2);
            this.panel3.Size = new System.Drawing.Size(182, 128);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(794, 61);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_country);
            this.panel5.Controls.Add(this.cmbobx_currency_number);
            this.panel5.Controls.Add(this.cmbobx_country);
            this.panel5.Controls.Add(this.lbl_currency_number);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(794, 61);
            this.panel5.TabIndex = 2;
            // 
            // _flag
            // 
            this._flag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._flag.HeaderText = "Flag";
            this._flag.MinimumWidth = 8;
            this._flag.Name = "_flag";
            this._flag.ReadOnly = true;
            this._flag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CurrencyData
            // 
            this.CurrencyData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CurrencyData.HeaderText = "Currency Data";
            this.CurrencyData.MinimumWidth = 8;
            this.CurrencyData.Name = "CurrencyData";
            this.CurrencyData.ReadOnly = true;
            this.CurrencyData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // banknote_f
            // 
            this.banknote_f.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.banknote_f.HeaderText = "Banknote Front";
            this.banknote_f.MinimumWidth = 8;
            this.banknote_f.Name = "banknote_f";
            this.banknote_f.ReadOnly = true;
            this.banknote_f.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // banknote_b
            // 
            this.banknote_b.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.banknote_b.HeaderText = "Banknote Back";
            this.banknote_b.MinimumWidth = 8;
            this.banknote_b.Name = "banknote_b";
            this.banknote_b.ReadOnly = true;
            this.banknote_b.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "World Currency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbobx_currency_number;
        private System.Windows.Forms.Label lbl_currency_number;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.ComboBox cmbobx_country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.RadioButton rdobtn_country_name;
        private System.Windows.Forms.RadioButton rdo_currency_number;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewImageColumn _flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyData;
        private System.Windows.Forms.DataGridViewImageColumn banknote_f;
        private System.Windows.Forms.DataGridViewImageColumn banknote_b;
    }
}

