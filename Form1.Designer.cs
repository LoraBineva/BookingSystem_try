namespace Flights_Agency_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Departure = new ComboBox();
            Destination = new ComboBox();
            From_Date = new ComboBox();
            To_Date = new ComboBox();
            Flight_Data = new DataGridView();
            search_btn = new Button();
            departure_lbl = new Label();
            destination_lbl = new Label();
            from_date_lbl = new Label();
            to_date_lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Flight_Data).BeginInit();
            SuspendLayout();
            // 
            // Departure
            // 
            Departure.BackColor = Color.LightSteelBlue;
            Departure.FormattingEnabled = true;
            Departure.Location = new Point(57, 137);
            Departure.Name = "Departure";
            Departure.Size = new Size(121, 23);
            Departure.TabIndex = 0;
            Departure.SelectedIndexChanged += Departure_SelectedIndexChanged;
            // 
            // Destination
            // 
            Destination.BackColor = Color.LightSteelBlue;
            Destination.FormattingEnabled = true;
            Destination.Location = new Point(204, 137);
            Destination.Name = "Destination";
            Destination.Size = new Size(121, 23);
            Destination.TabIndex = 1;
            Destination.SelectedIndexChanged += Destination_SelectedIndexChanged;
            // 
            // From_Date
            // 
            From_Date.BackColor = Color.LightSteelBlue;
            From_Date.FormattingEnabled = true;
            From_Date.Location = new Point(350, 137);
            From_Date.Name = "From_Date";
            From_Date.Size = new Size(121, 23);
            From_Date.TabIndex = 2;
            // 
            // To_Date
            // 
            To_Date.BackColor = Color.LightSteelBlue;
            To_Date.FormattingEnabled = true;
            To_Date.Location = new Point(499, 137);
            To_Date.Name = "To_Date";
            To_Date.Size = new Size(121, 23);
            To_Date.TabIndex = 3;
            // 
            // Flight_Data
            // 
            Flight_Data.BackgroundColor = Color.LightSteelBlue;
            Flight_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Flight_Data.Location = new Point(57, 191);
            Flight_Data.Name = "Flight_Data";
            Flight_Data.RowTemplate.Height = 25;
            Flight_Data.Size = new Size(676, 235);
            Flight_Data.TabIndex = 4;
            Flight_Data.RowHeaderMouseDoubleClick += Flight_Data_RowHeaderMouseDoubleClick_1;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.LightSteelBlue;
            search_btn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            search_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            search_btn.Location = new Point(662, 137);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(85, 34);
            search_btn.TabIndex = 5;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += button1_Click;
            // 
            // departure_lbl
            // 
            departure_lbl.AutoSize = true;
            departure_lbl.BackColor = Color.Transparent;
            departure_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            departure_lbl.ForeColor = Color.LightSteelBlue;
            departure_lbl.Location = new Point(57, 91);
            departure_lbl.Name = "departure_lbl";
            departure_lbl.Size = new Size(74, 32);
            departure_lbl.TabIndex = 6;
            departure_lbl.Text = "From:";
            // 
            // destination_lbl
            // 
            destination_lbl.AutoSize = true;
            destination_lbl.BackColor = Color.Transparent;
            destination_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            destination_lbl.ForeColor = Color.LightSteelBlue;
            destination_lbl.Location = new Point(204, 91);
            destination_lbl.Name = "destination_lbl";
            destination_lbl.Size = new Size(44, 32);
            destination_lbl.TabIndex = 7;
            destination_lbl.Text = "To:";
            // 
            // from_date_lbl
            // 
            from_date_lbl.AutoSize = true;
            from_date_lbl.BackColor = Color.Transparent;
            from_date_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            from_date_lbl.ForeColor = Color.LightSteelBlue;
            from_date_lbl.Location = new Point(350, 91);
            from_date_lbl.Name = "from_date_lbl";
            from_date_lbl.Size = new Size(121, 32);
            from_date_lbl.TabIndex = 8;
            from_date_lbl.Text = "Start date:";
            // 
            // to_date_lbl
            // 
            to_date_lbl.AutoSize = true;
            to_date_lbl.BackColor = Color.Transparent;
            to_date_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            to_date_lbl.ForeColor = Color.LightSteelBlue;
            to_date_lbl.Location = new Point(499, 91);
            to_date_lbl.Name = "to_date_lbl";
            to_date_lbl.Size = new Size(113, 32);
            to_date_lbl.TabIndex = 9;
            to_date_lbl.Text = "End date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 45);
            label1.TabIndex = 10;
            label1.Text = "AeroPilot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(213, 19);
            label2.Name = "label2";
            label2.Size = new Size(384, 50);
            label2.TabIndex = 11;
            label2.Text = "Book Your Flight Now!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_170958625_612x612;
            ClientSize = new Size(786, 451);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(to_date_lbl);
            Controls.Add(from_date_lbl);
            Controls.Add(destination_lbl);
            Controls.Add(departure_lbl);
            Controls.Add(search_btn);
            Controls.Add(Flight_Data);
            Controls.Add(To_Date);
            Controls.Add(From_Date);
            Controls.Add(Destination);
            Controls.Add(Departure);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Flight_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Departure;
        private ComboBox Destination;
        private ComboBox From_Date;
        private ComboBox To_Date;
        private DataGridView Flight_Data;
        private Button search_btn;
        private Label departure_lbl;
        private Label destination_lbl;
        private Label from_date_lbl;
        private Label to_date_lbl;
        private Label label1;
        private Label label2;
    }
}