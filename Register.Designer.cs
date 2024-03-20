namespace Flights_Agency_App
{
    partial class Register
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
            register_btn = new Button();
            password = new TextBox();
            username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            first_name = new TextBox();
            last_name = new TextBox();
            email = new TextBox();
            DOB = new TextBox();
            username_lbl = new Label();
            genderBox = new ComboBox();
            password_lbl = new Label();
            lenght = new Label();
            capital = new Label();
            lower = new Label();
            number = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.Transparent;
            register_btn.FlatAppearance.BorderColor = Color.White;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            register_btn.ForeColor = SystemColors.ControlLightLight;
            register_btn.Location = new Point(213, 446);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(191, 54);
            register_btn.TabIndex = 24;
            register_btn.Text = "Create Account";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // password
            // 
            password.BackColor = Color.LightSteelBlue;
            password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = SystemColors.ActiveCaptionText;
            password.Location = new Point(99, 315);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password:";
            password.Size = new Size(397, 33);
            password.TabIndex = 22;
            password.TextChanged += password_TextChanged;
            password.Validating += password_Validating;
            // 
            // username
            // 
            username.BackColor = Color.LightSteelBlue;
            username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = SystemColors.ActiveCaptionText;
            username.Location = new Point(99, 260);
            username.Name = "username";
            username.PlaceholderText = "Username:";
            username.Size = new Size(397, 33);
            username.TabIndex = 21;
            username.TextChanged += username_TextChanged;
            username.Validating += username_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(137, 68);
            label1.Name = "label1";
            label1.Size = new Size(345, 25);
            label1.TabIndex = 20;
            label1.Text = "Create an account in order to book easily";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(115, 8);
            label2.Name = "label2";
            label2.Size = new Size(392, 50);
            label2.TabIndex = 19;
            label2.Text = "Welcome to AeroPilot!";
            // 
            // first_name
            // 
            first_name.BackColor = Color.LightSteelBlue;
            first_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            first_name.ForeColor = SystemColors.ActiveCaptionText;
            first_name.Location = new Point(99, 143);
            first_name.Name = "first_name";
            first_name.PlaceholderText = "First Name:";
            first_name.Size = new Size(188, 33);
            first_name.TabIndex = 25;
            first_name.Validating += first_name_Validating;
            // 
            // last_name
            // 
            last_name.BackColor = Color.LightSteelBlue;
            last_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            last_name.ForeColor = SystemColors.ActiveCaptionText;
            last_name.Location = new Point(308, 143);
            last_name.Name = "last_name";
            last_name.PlaceholderText = "Last_Name";
            last_name.Size = new Size(188, 33);
            last_name.TabIndex = 26;
            last_name.Validating += last_name_Validating;
            // 
            // email
            // 
            email.BackColor = Color.LightSteelBlue;
            email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.ForeColor = SystemColors.ActiveCaptionText;
            email.Location = new Point(99, 206);
            email.Name = "email";
            email.PlaceholderText = "Email:";
            email.Size = new Size(397, 33);
            email.TabIndex = 27;
            email.Validating += email_Validating;
            // 
            // DOB
            // 
            DOB.BackColor = Color.LightSteelBlue;
            DOB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DOB.ForeColor = SystemColors.ActiveCaptionText;
            DOB.Location = new Point(99, 374);
            DOB.Name = "DOB";
            DOB.PlaceholderText = "Date of Birth:";
            DOB.Size = new Size(188, 33);
            DOB.TabIndex = 28;
            DOB.Validating += DOB_Validating;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.BackColor = Color.Transparent;
            username_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            username_lbl.ForeColor = SystemColors.ControlLightLight;
            username_lbl.Location = new Point(516, 260);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(150, 21);
            username_lbl.TabIndex = 30;
            username_lbl.Text = "At least 8 characters";
            // 
            // genderBox
            // 
            genderBox.BackColor = Color.LightSteelBlue;
            genderBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Gender:", "Male", "Female", "Non-binary", "Other" });
            genderBox.Location = new Point(322, 374);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(174, 33);
            genderBox.TabIndex = 31;
            genderBox.Text = "Gender:";
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.BackColor = Color.Transparent;
            password_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            password_lbl.ForeColor = SystemColors.ControlLightLight;
            password_lbl.Location = new Point(516, 272);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(184, 21);
            password_lbl.TabIndex = 32;
            password_lbl.Text = "The password must have:";
            // 
            // lenght
            // 
            lenght.AutoSize = true;
            lenght.BackColor = Color.Transparent;
            lenght.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lenght.ForeColor = SystemColors.ControlLightLight;
            lenght.Location = new Point(516, 303);
            lenght.Name = "lenght";
            lenght.Size = new Size(139, 20);
            lenght.TabIndex = 33;
            lenght.Text = "At least 8 characters";
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.BackColor = Color.Transparent;
            capital.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            capital.ForeColor = SystemColors.ControlLightLight;
            capital.Location = new Point(516, 328);
            capital.Name = "capital";
            capital.Size = new Size(154, 20);
            capital.TabIndex = 34;
            capital.Text = "At least 1 capital letter";
            // 
            // lower
            // 
            lower.AutoSize = true;
            lower.BackColor = Color.Transparent;
            lower.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lower.ForeColor = SystemColors.ControlLightLight;
            lower.Location = new Point(516, 357);
            lower.Name = "lower";
            lower.Size = new Size(173, 20);
            lower.TabIndex = 35;
            lower.Text = "At least 1 lowercase letter";
            // 
            // number
            // 
            number.AutoSize = true;
            number.BackColor = Color.Transparent;
            number.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            number.ForeColor = SystemColors.ControlLightLight;
            number.Location = new Point(516, 387);
            number.Name = "number";
            number.Size = new Size(122, 20);
            number.TabIndex = 36;
            number.Text = "At least 1 number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(99, 420);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 37;
            label3.Text = "dd/mm/yyyy";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.unnamed;
            ClientSize = new Size(732, 534);
            Controls.Add(label3);
            Controls.Add(number);
            Controls.Add(lower);
            Controls.Add(capital);
            Controls.Add(lenght);
            Controls.Add(password_lbl);
            Controls.Add(genderBox);
            Controls.Add(username_lbl);
            Controls.Add(DOB);
            Controls.Add(email);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(register_btn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button register_btn;
        private TextBox password;
        private TextBox username;
        private Label label1;
        private Label label2;
        private TextBox first_name;
        private TextBox last_name;
        private TextBox email;
        private TextBox DOB;
        private Label username_lbl;
        private ComboBox genderBox;
        private Label password_lbl;
        private Label lenght;
        private Label capital;
        private Label lower;
        private Label number;
        private Label label3;
    }
}