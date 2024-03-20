namespace Flights_Agency_App
{
    partial class Log_In
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
            label2 = new Label();
            label1 = new Label();
            username = new TextBox();
            password = new TextBox();
            log_in_btn = new Button();
            register_btn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(131, 26);
            label2.Name = "label2";
            label2.Size = new Size(270, 50);
            label2.TabIndex = 12;
            label2.Text = "Welcome Back!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(56, 86);
            label1.Name = "label1";
            label1.Size = new Size(437, 30);
            label1.TabIndex = 13;
            label1.Text = "Log in to your account in order to book a flight.";
            // 
            // username
            // 
            username.BackColor = Color.LightSteelBlue;
            username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = SystemColors.ControlLightLight;
            username.Location = new Point(114, 177);
            username.Name = "username";
            username.PlaceholderText = "Enter Username:";
            username.Size = new Size(287, 35);
            username.TabIndex = 14;
            // 
            // password
            // 
            password.BackColor = Color.LightSteelBlue;
            password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = SystemColors.ControlLightLight;
            password.Location = new Point(114, 240);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Enter Password:";
            password.Size = new Size(287, 35);
            password.TabIndex = 15;
            // 
            // log_in_btn
            // 
            log_in_btn.BackColor = Color.Transparent;
            log_in_btn.FlatAppearance.BorderColor = Color.White;
            log_in_btn.FlatStyle = FlatStyle.Flat;
            log_in_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            log_in_btn.ForeColor = SystemColors.ControlLightLight;
            log_in_btn.Location = new Point(155, 298);
            log_in_btn.Name = "log_in_btn";
            log_in_btn.Size = new Size(191, 54);
            log_in_btn.TabIndex = 16;
            log_in_btn.Text = "Log In";
            log_in_btn.UseVisualStyleBackColor = false;
            log_in_btn.Click += log_in_btn_Click;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.Transparent;
            register_btn.FlatAppearance.BorderColor = Color.White;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            register_btn.ForeColor = SystemColors.ControlLightLight;
            register_btn.Location = new Point(155, 423);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(191, 54);
            register_btn.TabIndex = 17;
            register_btn.Text = "Create Account";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(144, 376);
            label3.Name = "label3";
            label3.Size = new Size(216, 21);
            label3.TabIndex = 18;
            label3.Text = "No account? Create one now!";
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_170958625_612x612;
            ClientSize = new Size(507, 569);
            Controls.Add(label3);
            Controls.Add(register_btn);
            Controls.Add(log_in_btn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Log_In";
            Text = "Log_In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox username;
        private TextBox password;
        private Button log_in_btn;
        private Button register_btn;
        private Label label3;
    }
}