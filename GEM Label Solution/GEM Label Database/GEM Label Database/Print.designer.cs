namespace GEM_Label_Database
{
    partial class PrintWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintWindow));
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.Postcode = new System.Windows.Forms.TextBox();
            this.AddressLine3 = new System.Windows.Forms.TextBox();
            this.AddressLine2 = new System.Windows.Forms.TextBox();
            this.AddressLine1 = new System.Windows.Forms.TextBox();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.ProductDesc = new System.Windows.Forms.TextBox();
            this.GemCode = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.ServiceLevel = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.QtShip = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.StateCounty = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.NextPanel = new System.Windows.Forms.Panel();
            this.PrevPanel = new System.Windows.Forms.Panel();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.MaximizePanel = new System.Windows.Forms.Panel();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.EditLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PrintPanel = new System.Windows.Forms.Panel();
            this.PrintLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.PrintAllPanel = new System.Windows.Forms.Panel();
            this.PrintAllLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.CustomerPLabel = new System.Windows.Forms.Label();
            this.AddressLine1PLabel = new System.Windows.Forms.Label();
            this.AddressLine2PLabel = new System.Windows.Forms.Label();
            this.AddressLine3PLabel = new System.Windows.Forms.Label();
            this.CityPLabel = new System.Windows.Forms.Label();
            this.PostcodePLabel = new System.Windows.Forms.Label();
            this.OrderIDPLabel = new System.Windows.Forms.Label();
            this.LabelPreviewPanel = new System.Windows.Forms.Panel();
            this.DeliveredByImage = new System.Windows.Forms.Panel();
            this.BlackBorderPanel = new System.Windows.Forms.Panel();
            this.SearchCategory = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.HSplitter = new GEM_Label_Database.MouseTransparentPanel();
            this.Logo = new GEM_Label_Database.MouseTransparentPanel();
            this.WTitleLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.Records = new GEM_Label_Database.MouseTransparentLabel();
            this.Record = new GEM_Label_Database.MouseTransparentLabel();
            this.LabelPreview = new GEM_Label_Database.MouseTransparentLabel();
            this.mouseTransparentLabel1 = new GEM_Label_Database.MouseTransparentLabel();
            this.PriceLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.ServiceLevelLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.WeightLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.DeliveryLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.QtToShipLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.GemCodeLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.ProductDescriptionLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.ProductDetailsLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.OrderIDLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.CustomerDetailsLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.PostcodeLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.CountryLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.StateCountyLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.CityLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.AddressLine3Label = new GEM_Label_Database.MouseTransparentLabel();
            this.AddressLine2Label = new GEM_Label_Database.MouseTransparentLabel();
            this.AddressLine1Label = new GEM_Label_Database.MouseTransparentLabel();
            this.CustomerNameLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.EditPanel.SuspendLayout();
            this.PrintPanel.SuspendLayout();
            this.PrintAllPanel.SuspendLayout();
            this.LabelPreviewPanel.SuspendLayout();
            this.BlackBorderPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(113, 91);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Size = new System.Drawing.Size(156, 13);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.CustomerName.LostFocus += new System.EventHandler(this.Lost_Focus);
            // 
            // Postcode
            // 
            this.Postcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Postcode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postcode.Location = new System.Drawing.Point(113, 273);
            this.Postcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Postcode.Name = "Postcode";
            this.Postcode.ReadOnly = true;
            this.Postcode.Size = new System.Drawing.Size(98, 13);
            this.Postcode.TabIndex = 7;
            this.Postcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.Postcode.LostFocus += new System.EventHandler(this.Lost_Focus);
            // 
            // AddressLine3
            // 
            this.AddressLine3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressLine3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine3.Location = new System.Drawing.Point(113, 169);
            this.AddressLine3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressLine3.Name = "AddressLine3";
            this.AddressLine3.ReadOnly = true;
            this.AddressLine3.Size = new System.Drawing.Size(156, 13);
            this.AddressLine3.TabIndex = 3;
            this.AddressLine3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.AddressLine3.LostFocus += new System.EventHandler(this.Lost_Focus);
            // 
            // AddressLine2
            // 
            this.AddressLine2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressLine2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine2.Location = new System.Drawing.Point(113, 143);
            this.AddressLine2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressLine2.Name = "AddressLine2";
            this.AddressLine2.ReadOnly = true;
            this.AddressLine2.Size = new System.Drawing.Size(156, 13);
            this.AddressLine2.TabIndex = 2;
            this.AddressLine2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.AddressLine2.LostFocus += new System.EventHandler(this.Lost_Focus);
            // 
            // AddressLine1
            // 
            this.AddressLine1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressLine1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine1.Location = new System.Drawing.Point(113, 117);
            this.AddressLine1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressLine1.Name = "AddressLine1";
            this.AddressLine1.ReadOnly = true;
            this.AddressLine1.Size = new System.Drawing.Size(156, 13);
            this.AddressLine1.TabIndex = 1;
            this.AddressLine1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.AddressLine1.LostFocus += new System.EventHandler(this.Lost_Focus);
            // 
            // OrderID
            // 
            this.OrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderID.Location = new System.Drawing.Point(480, 52);
            this.OrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Size = new System.Drawing.Size(156, 13);
            this.OrderID.TabIndex = 9;
            this.OrderID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // ProductDesc
            // 
            this.ProductDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDesc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDesc.Location = new System.Drawing.Point(480, 110);
            this.ProductDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductDesc.Name = "ProductDesc";
            this.ProductDesc.ReadOnly = true;
            this.ProductDesc.Size = new System.Drawing.Size(156, 13);
            this.ProductDesc.TabIndex = 10;
            this.ProductDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // GemCode
            // 
            this.GemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GemCode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GemCode.Location = new System.Drawing.Point(480, 138);
            this.GemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GemCode.Name = "GemCode";
            this.GemCode.ReadOnly = true;
            this.GemCode.Size = new System.Drawing.Size(156, 13);
            this.GemCode.TabIndex = 11;
            this.GemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // Weight
            // 
            this.Weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Weight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(480, 229);
            this.Weight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Size = new System.Drawing.Size(156, 13);
            this.Weight.TabIndex = 13;
            this.Weight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // ServiceLevel
            // 
            this.ServiceLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceLevel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLevel.Location = new System.Drawing.Point(480, 255);
            this.ServiceLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceLevel.Name = "ServiceLevel";
            this.ServiceLevel.ReadOnly = true;
            this.ServiceLevel.Size = new System.Drawing.Size(156, 13);
            this.ServiceLevel.TabIndex = 14;
            this.ServiceLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // Price
            // 
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(480, 281);
            this.Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(156, 13);
            this.Price.TabIndex = 15;
            this.Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // QtShip
            // 
            this.QtShip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QtShip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtShip.Location = new System.Drawing.Point(480, 164);
            this.QtShip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QtShip.Name = "QtShip";
            this.QtShip.ReadOnly = true;
            this.QtShip.Size = new System.Drawing.Size(28, 13);
            this.QtShip.TabIndex = 12;
            this.QtShip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // City
            // 
            this.City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.City.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(113, 195);
            this.City.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Size = new System.Drawing.Size(156, 13);
            this.City.TabIndex = 4;
            this.City.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.City.LostFocus += new System.EventHandler(this.Lost_Focus);
            // 
            // StateCounty
            // 
            this.StateCounty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StateCounty.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateCounty.Location = new System.Drawing.Point(113, 221);
            this.StateCounty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StateCounty.Name = "StateCounty";
            this.StateCounty.ReadOnly = true;
            this.StateCounty.Size = new System.Drawing.Size(156, 13);
            this.StateCounty.TabIndex = 5;
            this.StateCounty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.StateCounty.LostFocus += new System.EventHandler(this.Lost_Focus);
            // 
            // Country
            // 
            this.Country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Country.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.Location = new System.Drawing.Point(113, 247);
            this.Country.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Size = new System.Drawing.Size(156, 13);
            this.Country.TabIndex = 6;
            this.Country.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.Country.LostFocus += new System.EventHandler(this.Lost_Focus);
            // 
            // NextPanel
            // 
            this.NextPanel.BackColor = System.Drawing.Color.Transparent;
            this.NextPanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Right_Arrow;
            this.NextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextPanel.Location = new System.Drawing.Point(561, 301);
            this.NextPanel.Name = "NextPanel";
            this.NextPanel.Size = new System.Drawing.Size(66, 22);
            this.NextPanel.TabIndex = 17;
            this.NextPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Next_Click);
            this.NextPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Next_Click);
            this.NextPanel.MouseEnter += new System.EventHandler(this.Next_Hover);
            this.NextPanel.MouseLeave += new System.EventHandler(this.Next_Leave);
            // 
            // PrevPanel
            // 
            this.PrevPanel.BackColor = System.Drawing.Color.Transparent;
            this.PrevPanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Left_Arrow;
            this.PrevPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrevPanel.Location = new System.Drawing.Point(485, 301);
            this.PrevPanel.Name = "PrevPanel";
            this.PrevPanel.Size = new System.Drawing.Size(66, 22);
            this.PrevPanel.TabIndex = 16;
            this.PrevPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Prev_Click);
            this.PrevPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Prev_Click);
            this.PrevPanel.MouseEnter += new System.EventHandler(this.Prev_Hover);
            this.PrevPanel.MouseLeave += new System.EventHandler(this.Prev_Leave);
            // 
            // ClosePanel
            // 
            this.ClosePanel.BackColor = System.Drawing.Color.Transparent;
            this.ClosePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Close_Button;
            this.ClosePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClosePanel.Location = new System.Drawing.Point(622, -1);
            this.ClosePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(27, 27);
            this.ClosePanel.TabIndex = 0;
            this.ClosePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_Click);
            this.ClosePanel.MouseLeave += new System.EventHandler(this.Close_Leave);
            this.ClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_Hover);
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Minimize_Button;
            this.MinimizePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePanel.Location = new System.Drawing.Point(570, -1);
            this.MinimizePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizePanel.Name = "MinimizePanel";
            this.MinimizePanel.Size = new System.Drawing.Size(27, 27);
            this.MinimizePanel.TabIndex = 0;
            this.MinimizePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_Click);
            this.MinimizePanel.MouseLeave += new System.EventHandler(this.Minimize_Leave);
            this.MinimizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Minimize_Hover);
            // 
            // MaximizePanel
            // 
            this.MaximizePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Maximize_Button;
            this.MaximizePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaximizePanel.Location = new System.Drawing.Point(596, -1);
            this.MaximizePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizePanel.Name = "MaximizePanel";
            this.MaximizePanel.Size = new System.Drawing.Size(27, 27);
            this.MaximizePanel.TabIndex = 0;
            this.MaximizePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Maximize_Click);
            this.MaximizePanel.MouseLeave += new System.EventHandler(this.Maximize_Leave);
            this.MaximizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Maximize_Hover);
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.Transparent;
            this.EditPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditPanel.Controls.Add(this.EditLabel);
            this.EditPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPanel.Location = new System.Drawing.Point(204, 295);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(66, 22);
            this.EditPanel.TabIndex = 8;
            this.EditPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Edit_Click);
            this.EditPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Edit_Click);
            this.EditPanel.MouseEnter += new System.EventHandler(this.Edit_Hover);
            this.EditPanel.MouseLeave += new System.EventHandler(this.Edit_Leave);
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditLabel.Location = new System.Drawing.Point(18, 4);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(31, 16);
            this.EditLabel.TabIndex = 0;
            this.EditLabel.Text = "Edit";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // PrintPanel
            // 
            this.PrintPanel.BackColor = System.Drawing.Color.Transparent;
            this.PrintPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintPanel.Controls.Add(this.PrintLabel);
            this.PrintPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPanel.Location = new System.Drawing.Point(470, 454);
            this.PrintPanel.Name = "PrintPanel";
            this.PrintPanel.Size = new System.Drawing.Size(80, 22);
            this.PrintPanel.TabIndex = 18;
            this.PrintPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Print_Click);
            this.PrintPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Print_Click);
            this.PrintPanel.MouseEnter += new System.EventHandler(this.Print_Hover);
            this.PrintPanel.MouseLeave += new System.EventHandler(this.Print_Leave);
            // 
            // PrintLabel
            // 
            this.PrintLabel.AutoSize = true;
            this.PrintLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PrintLabel.Location = new System.Drawing.Point(-1, 4);
            this.PrintLabel.Name = "PrintLabel";
            this.PrintLabel.Size = new System.Drawing.Size(82, 16);
            this.PrintLabel.TabIndex = 0;
            this.PrintLabel.Text = "Export Order";
            // 
            // PrintAllPanel
            // 
            this.PrintAllPanel.BackColor = System.Drawing.Color.Transparent;
            this.PrintAllPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintAllPanel.Controls.Add(this.PrintAllLabel);
            this.PrintAllPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintAllPanel.Location = new System.Drawing.Point(560, 454);
            this.PrintAllPanel.Name = "PrintAllPanel";
            this.PrintAllPanel.Size = new System.Drawing.Size(66, 22);
            this.PrintAllPanel.TabIndex = 19;
            this.PrintAllPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrintAll_Click);
            this.PrintAllPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PrintAll_Click);
            this.PrintAllPanel.MouseEnter += new System.EventHandler(this.PrintAll_Hover);
            this.PrintAllPanel.MouseLeave += new System.EventHandler(this.PrintAll_Leave);
            // 
            // PrintAllLabel
            // 
            this.PrintAllLabel.AutoSize = true;
            this.PrintAllLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintAllLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PrintAllLabel.Location = new System.Drawing.Point(1, 4);
            this.PrintAllLabel.Name = "PrintAllLabel";
            this.PrintAllLabel.Size = new System.Drawing.Size(64, 16);
            this.PrintAllLabel.TabIndex = 0;
            this.PrintAllLabel.Text = "Export All";
            // 
            // CustomerPLabel
            // 
            this.CustomerPLabel.AutoSize = true;
            this.CustomerPLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomerPLabel.Location = new System.Drawing.Point(9, 28);
            this.CustomerPLabel.Name = "CustomerPLabel";
            this.CustomerPLabel.Size = new System.Drawing.Size(82, 13);
            this.CustomerPLabel.TabIndex = 27;
            this.CustomerPLabel.Text = "Customer Name";
            // 
            // AddressLine1PLabel
            // 
            this.AddressLine1PLabel.AutoSize = true;
            this.AddressLine1PLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLine1PLabel.Location = new System.Drawing.Point(9, 44);
            this.AddressLine1PLabel.Name = "AddressLine1PLabel";
            this.AddressLine1PLabel.Size = new System.Drawing.Size(32, 13);
            this.AddressLine1PLabel.TabIndex = 27;
            this.AddressLine1PLabel.Text = "Add1";
            // 
            // AddressLine2PLabel
            // 
            this.AddressLine2PLabel.AutoSize = true;
            this.AddressLine2PLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLine2PLabel.Location = new System.Drawing.Point(9, 60);
            this.AddressLine2PLabel.Name = "AddressLine2PLabel";
            this.AddressLine2PLabel.Size = new System.Drawing.Size(20, 13);
            this.AddressLine2PLabel.TabIndex = 27;
            this.AddressLine2PLabel.Text = "A2";
            // 
            // AddressLine3PLabel
            // 
            this.AddressLine3PLabel.AutoSize = true;
            this.AddressLine3PLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLine3PLabel.Location = new System.Drawing.Point(9, 76);
            this.AddressLine3PLabel.Name = "AddressLine3PLabel";
            this.AddressLine3PLabel.Size = new System.Drawing.Size(20, 13);
            this.AddressLine3PLabel.TabIndex = 27;
            this.AddressLine3PLabel.Text = "A3";
            // 
            // CityPLabel
            // 
            this.CityPLabel.AutoSize = true;
            this.CityPLabel.BackColor = System.Drawing.Color.Transparent;
            this.CityPLabel.Location = new System.Drawing.Point(9, 92);
            this.CityPLabel.Name = "CityPLabel";
            this.CityPLabel.Size = new System.Drawing.Size(24, 13);
            this.CityPLabel.TabIndex = 27;
            this.CityPLabel.Text = "City";
            // 
            // PostcodePLabel
            // 
            this.PostcodePLabel.AutoSize = true;
            this.PostcodePLabel.BackColor = System.Drawing.Color.Transparent;
            this.PostcodePLabel.Location = new System.Drawing.Point(9, 108);
            this.PostcodePLabel.Name = "PostcodePLabel";
            this.PostcodePLabel.Size = new System.Drawing.Size(39, 13);
            this.PostcodePLabel.TabIndex = 27;
            this.PostcodePLabel.Text = "PCode";
            // 
            // OrderIDPLabel
            // 
            this.OrderIDPLabel.AutoSize = true;
            this.OrderIDPLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderIDPLabel.Location = new System.Drawing.Point(166, 4);
            this.OrderIDPLabel.Name = "OrderIDPLabel";
            this.OrderIDPLabel.Size = new System.Drawing.Size(44, 13);
            this.OrderIDPLabel.TabIndex = 27;
            this.OrderIDPLabel.Text = "OrderID";
            // 
            // LabelPreviewPanel
            // 
            this.LabelPreviewPanel.BackColor = System.Drawing.Color.White;
            this.LabelPreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPreviewPanel.Controls.Add(this.DeliveredByImage);
            this.LabelPreviewPanel.Controls.Add(this.PostcodePLabel);
            this.LabelPreviewPanel.Controls.Add(this.CustomerPLabel);
            this.LabelPreviewPanel.Controls.Add(this.CityPLabel);
            this.LabelPreviewPanel.Controls.Add(this.OrderIDPLabel);
            this.LabelPreviewPanel.Controls.Add(this.AddressLine3PLabel);
            this.LabelPreviewPanel.Controls.Add(this.AddressLine1PLabel);
            this.LabelPreviewPanel.Controls.Add(this.AddressLine2PLabel);
            this.LabelPreviewPanel.Location = new System.Drawing.Point(4, 3);
            this.LabelPreviewPanel.Name = "LabelPreviewPanel";
            this.LabelPreviewPanel.Size = new System.Drawing.Size(285, 147);
            this.LabelPreviewPanel.TabIndex = 28;
            // 
            // DeliveredByImage
            // 
            this.DeliveredByImage.BackgroundImage = global::GEM_Label_Database.Properties.Resources.RM_delivered_by_165x165_0;
            this.DeliveredByImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeliveredByImage.Location = new System.Drawing.Point(230, 92);
            this.DeliveredByImage.Name = "DeliveredByImage";
            this.DeliveredByImage.Size = new System.Drawing.Size(50, 50);
            this.DeliveredByImage.TabIndex = 28;
            // 
            // BlackBorderPanel
            // 
            this.BlackBorderPanel.BackColor = System.Drawing.Color.White;
            this.BlackBorderPanel.Controls.Add(this.LabelPreviewPanel);
            this.BlackBorderPanel.Location = new System.Drawing.Point(12, 323);
            this.BlackBorderPanel.Name = "BlackBorderPanel";
            this.BlackBorderPanel.Size = new System.Drawing.Size(292, 153);
            this.BlackBorderPanel.TabIndex = 29;
            // 
            // SearchCategory
            // 
            this.SearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchCategory.FormattingEnabled = true;
            this.SearchCategory.Items.AddRange(new object[] {
            "Customer Name",
            "Order ID"});
            this.SearchCategory.Location = new System.Drawing.Point(310, 352);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.SearchCategory.TabIndex = 30;
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search.Location = new System.Drawing.Point(437, 352);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 20);
            this.Search.TabIndex = 31;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchPanel.Controls.Add(this.SearchLabel);
            this.SearchPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPanel.Location = new System.Drawing.Point(564, 351);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(66, 22);
            this.SearchPanel.TabIndex = 19;
            this.SearchPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Search_Click);
            this.SearchPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Search_Click);
            this.SearchPanel.MouseEnter += new System.EventHandler(this.Search_Hover);
            this.SearchPanel.MouseLeave += new System.EventHandler(this.Search_Leave);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchLabel.Location = new System.Drawing.Point(9, 4);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(49, 16);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search";
            // 
            // HSplitter
            // 
            this.HSplitter.BackgroundImage = global::GEM_Label_Database.Properties.Resources.HSplitter;
            this.HSplitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HSplitter.Location = new System.Drawing.Point(-1, 26);
            this.HSplitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HSplitter.Name = "HSplitter";
            this.HSplitter.Size = new System.Drawing.Size(653, 5);
            this.HSplitter.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(4, 4);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(24, 22);
            this.Logo.TabIndex = 0;
            // 
            // WTitleLabel
            // 
            this.WTitleLabel.AutoSize = true;
            this.WTitleLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTitleLabel.Location = new System.Drawing.Point(26, -1);
            this.WTitleLabel.Name = "WTitleLabel";
            this.WTitleLabel.Size = new System.Drawing.Size(173, 32);
            this.WTitleLabel.TabIndex = 0;
            this.WTitleLabel.Text = "Print Labels";
            // 
            // Records
            // 
            this.Records.AutoSize = true;
            this.Records.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Records.Location = new System.Drawing.Point(336, 465);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(54, 11);
            this.Records.TabIndex = 0;
            this.Records.Text = "Records";
            // 
            // Record
            // 
            this.Record.AutoSize = true;
            this.Record.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record.Location = new System.Drawing.Point(308, 465);
            this.Record.Name = "Record";
            this.Record.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Record.Size = new System.Drawing.Size(47, 11);
            this.Record.TabIndex = 0;
            this.Record.Text = "Record";
            // 
            // LabelPreview
            // 
            this.LabelPreview.AutoSize = true;
            this.LabelPreview.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPreview.Location = new System.Drawing.Point(25, 295);
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Size = new System.Drawing.Size(116, 23);
            this.LabelPreview.TabIndex = 0;
            this.LabelPreview.Text = "Label Preview";
            // 
            // mouseTransparentLabel1
            // 
            this.mouseTransparentLabel1.AutoSize = true;
            this.mouseTransparentLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseTransparentLabel1.Location = new System.Drawing.Point(310, 326);
            this.mouseTransparentLabel1.Name = "mouseTransparentLabel1";
            this.mouseTransparentLabel1.Size = new System.Drawing.Size(62, 23);
            this.mouseTransparentLabel1.TabIndex = 0;
            this.mouseTransparentLabel1.Text = "Search";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(444, 281);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // ServiceLevelLabel
            // 
            this.ServiceLevelLabel.AutoSize = true;
            this.ServiceLevelLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLevelLabel.Location = new System.Drawing.Point(407, 255);
            this.ServiceLevelLabel.Name = "ServiceLevelLabel";
            this.ServiceLevelLabel.Size = new System.Drawing.Size(68, 13);
            this.ServiceLevelLabel.TabIndex = 0;
            this.ServiceLevelLabel.Text = "Service Level";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(395, 229);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(80, 13);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "Weight (Grams)";
            // 
            // DeliveryLabel
            // 
            this.DeliveryLabel.AutoSize = true;
            this.DeliveryLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryLabel.Location = new System.Drawing.Point(428, 195);
            this.DeliveryLabel.Name = "DeliveryLabel";
            this.DeliveryLabel.Size = new System.Drawing.Size(73, 23);
            this.DeliveryLabel.TabIndex = 0;
            this.DeliveryLabel.Text = "Delivery";
            // 
            // QtToShipLabel
            // 
            this.QtToShipLabel.AutoSize = true;
            this.QtToShipLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtToShipLabel.Location = new System.Drawing.Point(420, 164);
            this.QtToShipLabel.Name = "QtToShipLabel";
            this.QtToShipLabel.Size = new System.Drawing.Size(55, 13);
            this.QtToShipLabel.TabIndex = 0;
            this.QtToShipLabel.Text = "Qt. To Ship";
            // 
            // GemCodeLabel
            // 
            this.GemCodeLabel.AutoSize = true;
            this.GemCodeLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GemCodeLabel.Location = new System.Drawing.Point(420, 139);
            this.GemCodeLabel.Name = "GemCodeLabel";
            this.GemCodeLabel.Size = new System.Drawing.Size(55, 13);
            this.GemCodeLabel.TabIndex = 0;
            this.GemCodeLabel.Text = "Gem Code";
            // 
            // ProductDescriptionLabel
            // 
            this.ProductDescriptionLabel.AutoSize = true;
            this.ProductDescriptionLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDescriptionLabel.Location = new System.Drawing.Point(375, 110);
            this.ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            this.ProductDescriptionLabel.Size = new System.Drawing.Size(100, 13);
            this.ProductDescriptionLabel.TabIndex = 0;
            this.ProductDescriptionLabel.Text = "Product Description";
            // 
            // ProductDetailsLabel
            // 
            this.ProductDetailsLabel.AutoSize = true;
            this.ProductDetailsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDetailsLabel.Location = new System.Drawing.Point(374, 79);
            this.ProductDetailsLabel.Name = "ProductDetailsLabel";
            this.ProductDetailsLabel.Size = new System.Drawing.Size(127, 23);
            this.ProductDetailsLabel.TabIndex = 0;
            this.ProductDetailsLabel.Text = "Product Details";
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDLabel.Location = new System.Drawing.Point(429, 52);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(46, 13);
            this.OrderIDLabel.TabIndex = 0;
            this.OrderIDLabel.Text = "Order ID";
            // 
            // CustomerDetailsLabel
            // 
            this.CustomerDetailsLabel.AutoSize = true;
            this.CustomerDetailsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetailsLabel.Location = new System.Drawing.Point(26, 52);
            this.CustomerDetailsLabel.Name = "CustomerDetailsLabel";
            this.CustomerDetailsLabel.Size = new System.Drawing.Size(141, 23);
            this.CustomerDetailsLabel.TabIndex = 0;
            this.CustomerDetailsLabel.Text = "Customer Details";
            // 
            // PostcodeLabel
            // 
            this.PostcodeLabel.AutoSize = true;
            this.PostcodeLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostcodeLabel.Location = new System.Drawing.Point(57, 273);
            this.PostcodeLabel.Name = "PostcodeLabel";
            this.PostcodeLabel.Size = new System.Drawing.Size(51, 13);
            this.PostcodeLabel.TabIndex = 0;
            this.PostcodeLabel.Text = "Postcode";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLabel.Location = new System.Drawing.Point(64, 247);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(44, 13);
            this.CountryLabel.TabIndex = 0;
            this.CountryLabel.Text = "Country";
            // 
            // StateCountyLabel
            // 
            this.StateCountyLabel.AutoSize = true;
            this.StateCountyLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateCountyLabel.Location = new System.Drawing.Point(39, 221);
            this.StateCountyLabel.Name = "StateCountyLabel";
            this.StateCountyLabel.Size = new System.Drawing.Size(69, 13);
            this.StateCountyLabel.TabIndex = 0;
            this.StateCountyLabel.Text = "State/County";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(83, 195);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(25, 13);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "City";
            // 
            // AddressLine3Label
            // 
            this.AddressLine3Label.AutoSize = true;
            this.AddressLine3Label.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine3Label.Location = new System.Drawing.Point(32, 169);
            this.AddressLine3Label.Name = "AddressLine3Label";
            this.AddressLine3Label.Size = new System.Drawing.Size(75, 13);
            this.AddressLine3Label.TabIndex = 0;
            this.AddressLine3Label.Text = "Address Line 3";
            // 
            // AddressLine2Label
            // 
            this.AddressLine2Label.AutoSize = true;
            this.AddressLine2Label.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine2Label.Location = new System.Drawing.Point(33, 143);
            this.AddressLine2Label.Name = "AddressLine2Label";
            this.AddressLine2Label.Size = new System.Drawing.Size(75, 13);
            this.AddressLine2Label.TabIndex = 0;
            this.AddressLine2Label.Text = "Address Line 2";
            // 
            // AddressLine1Label
            // 
            this.AddressLine1Label.AutoSize = true;
            this.AddressLine1Label.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine1Label.Location = new System.Drawing.Point(32, 117);
            this.AddressLine1Label.Name = "AddressLine1Label";
            this.AddressLine1Label.Size = new System.Drawing.Size(75, 13);
            this.AddressLine1Label.TabIndex = 0;
            this.AddressLine1Label.Text = "Address Line 1";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(25, 91);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(83, 13);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // PrintWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(648, 494);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchCategory);
            this.Controls.Add(this.BlackBorderPanel);
            this.Controls.Add(this.NextPanel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.PrintAllPanel);
            this.Controls.Add(this.PrintPanel);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.PrevPanel);
            this.Controls.Add(this.ClosePanel);
            this.Controls.Add(this.HSplitter);
            this.Controls.Add(this.MinimizePanel);
            this.Controls.Add(this.MaximizePanel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.WTitleLabel);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.LabelPreview);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ServiceLevel);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.mouseTransparentLabel1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ServiceLevelLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.DeliveryLabel);
            this.Controls.Add(this.QtShip);
            this.Controls.Add(this.GemCode);
            this.Controls.Add(this.QtToShipLabel);
            this.Controls.Add(this.GemCodeLabel);
            this.Controls.Add(this.ProductDescriptionLabel);
            this.Controls.Add(this.ProductDesc);
            this.Controls.Add(this.ProductDetailsLabel);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.OrderID);
            this.Controls.Add(this.CustomerDetailsLabel);
            this.Controls.Add(this.PostcodeLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.StateCountyLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.AddressLine3Label);
            this.Controls.Add(this.AddressLine2Label);
            this.Controls.Add(this.AddressLine1Label);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.AddressLine1);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.StateCounty);
            this.Controls.Add(this.AddressLine2);
            this.Controls.Add(this.City);
            this.Controls.Add(this.AddressLine3);
            this.Controls.Add(this.Postcode);
            this.Controls.Add(this.CustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrintWindow";
            this.Text = "Label Printing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Scroll_Wheel);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.PrintPanel.ResumeLayout(false);
            this.PrintPanel.PerformLayout();
            this.PrintAllPanel.ResumeLayout(false);
            this.PrintAllPanel.PerformLayout();
            this.LabelPreviewPanel.ResumeLayout(false);
            this.LabelPreviewPanel.PerformLayout();
            this.BlackBorderPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox Postcode;
        private System.Windows.Forms.TextBox AddressLine3;
        private System.Windows.Forms.TextBox AddressLine2;
        private System.Windows.Forms.TextBox AddressLine1;
        private MouseTransparentLabel CustomerNameLabel;
        private MouseTransparentLabel AddressLine1Label;
        private MouseTransparentLabel AddressLine2Label;
        private MouseTransparentLabel AddressLine3Label;
        private MouseTransparentLabel PostcodeLabel;
        private MouseTransparentLabel CustomerDetailsLabel;
        private System.Windows.Forms.TextBox OrderID;
        private MouseTransparentLabel OrderIDLabel;
        private MouseTransparentLabel ProductDetailsLabel;
        private System.Windows.Forms.TextBox ProductDesc;
        private MouseTransparentLabel ProductDescriptionLabel;
        private MouseTransparentLabel GemCodeLabel;
        private System.Windows.Forms.TextBox GemCode;
        private MouseTransparentLabel DeliveryLabel;
        private MouseTransparentLabel WeightLabel;
        private MouseTransparentLabel ServiceLevelLabel;
        private MouseTransparentLabel PriceLabel;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox ServiceLevel;
        private System.Windows.Forms.TextBox Price;
        private MouseTransparentLabel LabelPreview;
        private System.Windows.Forms.TextBox QtShip;
        private MouseTransparentLabel QtToShipLabel;
        private System.Windows.Forms.TextBox City;
        private MouseTransparentLabel CityLabel;
        private System.Windows.Forms.TextBox StateCounty;
        private MouseTransparentLabel StateCountyLabel;
        private System.Windows.Forms.TextBox Country;
        private MouseTransparentLabel CountryLabel;
        private MouseTransparentLabel Record;
        private MouseTransparentLabel Records;
        private MouseTransparentLabel WTitleLabel;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.Panel MaximizePanel;
        private System.Windows.Forms.Panel MinimizePanel;
        private MouseTransparentPanel Logo;
        private MouseTransparentPanel HSplitter;
        private System.Windows.Forms.Panel PrevPanel;
        private System.Windows.Forms.Panel NextPanel;
        private System.Windows.Forms.Panel EditPanel;
        private MouseTransparentLabel EditLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PrintPanel;
        private MouseTransparentLabel PrintLabel;
        private System.Windows.Forms.Panel PrintAllPanel;
        private MouseTransparentLabel PrintAllLabel;
        private System.Windows.Forms.Label CustomerPLabel;
        private System.Windows.Forms.Label AddressLine1PLabel;
        private System.Windows.Forms.Label AddressLine2PLabel;
        private System.Windows.Forms.Label AddressLine3PLabel;
        private System.Windows.Forms.Label CityPLabel;
        private System.Windows.Forms.Label PostcodePLabel;
        private System.Windows.Forms.Label OrderIDPLabel;
        private System.Windows.Forms.Panel LabelPreviewPanel;
        private System.Windows.Forms.Panel BlackBorderPanel;
        private System.Windows.Forms.Panel DeliveredByImage;
        private System.Windows.Forms.ComboBox SearchCategory;
        private MouseTransparentLabel mouseTransparentLabel1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Panel SearchPanel;
        private MouseTransparentLabel SearchLabel;

    }
}

