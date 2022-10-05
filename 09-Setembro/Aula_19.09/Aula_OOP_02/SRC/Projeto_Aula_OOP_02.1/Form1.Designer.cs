namespace Projeto_Aula_OOP_02._1
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
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Phone_number = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Labe_PostCode = new System.Windows.Forms.Label();
            this.Label_adress = new System.Windows.Forms.Label();
            this.Label_distric = new System.Windows.Forms.Label();
            this.Label_City = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.Label_country = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_district = new System.Windows.Forms.TextBox();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.textBox_postcode = new System.Windows.Forms.TextBox();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.textBox_state = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Button_Clean = new System.Windows.Forms.Button();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.Label_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(19, 15);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(56, 20);
            this.Label_Name.TabIndex = 3;
            this.Label_Name.Text = "Name: ";
            // 
            // Label_Phone_number
            // 
            this.Label_Phone_number.AutoSize = true;
            this.Label_Phone_number.Location = new System.Drawing.Point(19, 48);
            this.Label_Phone_number.Name = "Label_Phone_number";
            this.Label_Phone_number.Size = new System.Drawing.Size(108, 20);
            this.Label_Phone_number.TabIndex = 4;
            this.Label_Phone_number.Text = "Phone number:";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Location = new System.Drawing.Point(19, 81);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(59, 20);
            this.Label_Email.TabIndex = 5;
            this.Label_Email.Text = "E-mail: ";
            // 
            // Labe_PostCode
            // 
            this.Labe_PostCode.AutoSize = true;
            this.Labe_PostCode.Location = new System.Drawing.Point(16, 155);
            this.Labe_PostCode.Name = "Labe_PostCode";
            this.Labe_PostCode.Size = new System.Drawing.Size(74, 20);
            this.Labe_PostCode.TabIndex = 6;
            this.Labe_PostCode.Text = "PostCode:";
            // 
            // Label_adress
            // 
            this.Label_adress.AutoSize = true;
            this.Label_adress.Location = new System.Drawing.Point(16, 188);
            this.Label_adress.Name = "Label_adress";
            this.Label_adress.Size = new System.Drawing.Size(56, 20);
            this.Label_adress.TabIndex = 7;
            this.Label_adress.Text = "Adress:";
            // 
            // Label_distric
            // 
            this.Label_distric.AutoSize = true;
            this.Label_distric.Location = new System.Drawing.Point(16, 221);
            this.Label_distric.Name = "Label_distric";
            this.Label_distric.Size = new System.Drawing.Size(59, 20);
            this.Label_distric.TabIndex = 8;
            this.Label_distric.Text = "District:";
            // 
            // Label_City
            // 
            this.Label_City.AutoSize = true;
            this.Label_City.Location = new System.Drawing.Point(16, 255);
            this.Label_City.Name = "Label_City";
            this.Label_City.Size = new System.Drawing.Size(37, 20);
            this.Label_City.TabIndex = 9;
            this.Label_City.Text = "City:";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(16, 288);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(46, 20);
            this.label_State.TabIndex = 10;
            this.label_State.Text = "State:";
            // 
            // Label_country
            // 
            this.Label_country.AutoSize = true;
            this.Label_country.Location = new System.Drawing.Point(16, 321);
            this.Label_country.Name = "Label_country";
            this.Label_country.Size = new System.Drawing.Size(63, 20);
            this.Label_country.TabIndex = 11;
            this.Label_country.Text = "Country:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(168, 12);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(125, 27);
            this.textBox_Name.TabIndex = 12;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(168, 45);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(125, 27);
            this.textBox_Phone.TabIndex = 13;
            this.textBox_Phone.TextChanged += new System.EventHandler(this.textBox_Phone_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(168, 78);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(125, 27);
            this.textBox_email.TabIndex = 14;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // textBox_district
            // 
            this.textBox_district.Location = new System.Drawing.Point(168, 218);
            this.textBox_district.Name = "textBox_district";
            this.textBox_district.Size = new System.Drawing.Size(125, 27);
            this.textBox_district.TabIndex = 17;
            this.textBox_district.TextChanged += new System.EventHandler(this.textBox_district_TextChanged);
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(168, 185);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(125, 27);
            this.textBox_adress.TabIndex = 16;
            this.textBox_adress.TextChanged += new System.EventHandler(this.textBox_adress_TextChanged);
            // 
            // textBox_postcode
            // 
            this.textBox_postcode.Location = new System.Drawing.Point(168, 152);
            this.textBox_postcode.Name = "textBox_postcode";
            this.textBox_postcode.Size = new System.Drawing.Size(125, 27);
            this.textBox_postcode.TabIndex = 15;
            this.textBox_postcode.TextChanged += new System.EventHandler(this.textBox_postcode_TextChanged);
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(168, 318);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(125, 27);
            this.textBox_Country.TabIndex = 20;
            this.textBox_Country.TextChanged += new System.EventHandler(this.textBox_Country_TextChanged);
            // 
            // textBox_state
            // 
            this.textBox_state.Location = new System.Drawing.Point(168, 285);
            this.textBox_state.Name = "textBox_state";
            this.textBox_state.Size = new System.Drawing.Size(125, 27);
            this.textBox_state.TabIndex = 19;
            this.textBox_state.TextChanged += new System.EventHandler(this.textBox_state_TextChanged);
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(168, 252);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(125, 27);
            this.textBox_City.TabIndex = 18;
            this.textBox_City.TextChanged += new System.EventHandler(this.textBox_City_TextChanged);
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(19, 380);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(94, 29);
            this.Button_Send.TabIndex = 21;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Button_Clean
            // 
            this.Button_Clean.Location = new System.Drawing.Point(119, 380);
            this.Button_Clean.Name = "Button_Clean";
            this.Button_Clean.Size = new System.Drawing.Size(94, 29);
            this.Button_Clean.TabIndex = 22;
            this.Button_Clean.Text = "Clean";
            this.Button_Clean.UseVisualStyleBackColor = true;
            this.Button_Clean.Click += new System.EventHandler(this.Button_Clean_Click);
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(365, 12);
            this.textBox_text.Multiline = true;
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(423, 333);
            this.textBox_text.TabIndex = 23;
            this.textBox_text.TextChanged += new System.EventHandler(this.textBox_text_TextChanged);
            // 
            // Label_text
            // 
            this.Label_text.AutoSize = true;
            this.Label_text.Location = new System.Drawing.Point(323, 12);
            this.Label_text.Name = "Label_text";
            this.Label_text.Size = new System.Drawing.Size(39, 20);
            this.Label_text.TabIndex = 24;
            this.Label_text.Text = "Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_text);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.Button_Clean);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.textBox_state);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.textBox_district);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.textBox_postcode);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.Label_country);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.Label_City);
            this.Controls.Add(this.Label_distric);
            this.Controls.Add(this.Label_adress);
            this.Controls.Add(this.Labe_PostCode);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Label_Phone_number);
            this.Controls.Add(this.Label_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Label_Name;
        private Label Label_Phone_number;
        private Label Label_Email;
        private Label Labe_PostCode;
        private Label Label_adress;
        private Label Label_distric;
        private Label Label_City;
        private Label label_State;
        private Label Label_country;
        private TextBox textBox_Name;
        private TextBox textBox_Phone;
        private TextBox textBox_email;
        private TextBox textBox_district;
        private TextBox textBox_adress;
        private TextBox textBox_postcode;
        private TextBox textBox_Country;
        private TextBox textBox_state;
        private TextBox textBox_City;
        private Button Button_Send;
        private Button Button_Clean;
        private TextBox textBox_text;
        private Label Label_text;
    }
}