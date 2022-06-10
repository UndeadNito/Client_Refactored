namespace Client_Refactored
{
    partial class EmployeeForm
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
            this.IDSubscribeLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PositionInfoLabel = new System.Windows.Forms.Label();
            this.OtherInfoLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.PositionInfoTextBox = new System.Windows.Forms.TextBox();
            this.OtherInfoTextBox = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RedactButton = new System.Windows.Forms.Button();
            this.AcceptButtonn = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDSubscribeLabel
            // 
            this.IDSubscribeLabel.AutoSize = true;
            this.IDSubscribeLabel.Location = new System.Drawing.Point(12, 41);
            this.IDSubscribeLabel.Name = "IDSubscribeLabel";
            this.IDSubscribeLabel.Size = new System.Drawing.Size(24, 20);
            this.IDSubscribeLabel.TabIndex = 0;
            this.IDSubscribeLabel.Text = "ID";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(522, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Position info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Other info";
            // 
            // PositionInfoLabel
            // 
            this.PositionInfoLabel.AutoSize = true;
            this.PositionInfoLabel.Location = new System.Drawing.Point(150, 239);
            this.PositionInfoLabel.Name = "PositionInfoLabel";
            this.PositionInfoLabel.Size = new System.Drawing.Size(33, 20);
            this.PositionInfoLabel.TabIndex = 8;
            this.PositionInfoLabel.Text = "null";
            // 
            // OtherInfoLabel
            // 
            this.OtherInfoLabel.AutoSize = true;
            this.OtherInfoLabel.Location = new System.Drawing.Point(150, 283);
            this.OtherInfoLabel.Name = "OtherInfoLabel";
            this.OtherInfoLabel.Size = new System.Drawing.Size(33, 20);
            this.OtherInfoLabel.TabIndex = 9;
            this.OtherInfoLabel.Text = "null";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(150, 198);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(33, 20);
            this.PositionLabel.TabIndex = 10;
            this.PositionLabel.Text = "null";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(150, 158);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(33, 20);
            this.GenderLabel.TabIndex = 11;
            this.GenderLabel.Text = "null";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(150, 119);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(33, 20);
            this.DOBLabel.TabIndex = 12;
            this.DOBLabel.Text = "null";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(150, 78);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 20);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "null";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(150, 41);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(33, 20);
            this.IdLabel.TabIndex = 14;
            this.IdLabel.Text = "null";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(150, 75);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(279, 27);
            this.NameTextBox.TabIndex = 16;
            this.NameTextBox.Visible = false;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Enabled = false;
            this.PositionTextBox.Location = new System.Drawing.Point(150, 195);
            this.PositionTextBox.MaxLength = 20;
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(179, 27);
            this.PositionTextBox.TabIndex = 19;
            this.PositionTextBox.Visible = false;
            // 
            // PositionInfoTextBox
            // 
            this.PositionInfoTextBox.Enabled = false;
            this.PositionInfoTextBox.Location = new System.Drawing.Point(150, 236);
            this.PositionInfoTextBox.MaxLength = 100;
            this.PositionInfoTextBox.Name = "PositionInfoTextBox";
            this.PositionInfoTextBox.Size = new System.Drawing.Size(279, 27);
            this.PositionInfoTextBox.TabIndex = 20;
            this.PositionInfoTextBox.Visible = false;
            // 
            // OtherInfoTextBox
            // 
            this.OtherInfoTextBox.Enabled = false;
            this.OtherInfoTextBox.Location = new System.Drawing.Point(150, 280);
            this.OtherInfoTextBox.MaxLength = 200;
            this.OtherInfoTextBox.Multiline = true;
            this.OtherInfoTextBox.Name = "OtherInfoTextBox";
            this.OtherInfoTextBox.Size = new System.Drawing.Size(279, 27);
            this.OtherInfoTextBox.TabIndex = 21;
            this.OtherInfoTextBox.Visible = false;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.Enabled = false;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "M",
            "W"});
            this.GenderComboBox.Location = new System.Drawing.Point(150, 155);
            this.GenderComboBox.MaxDropDownItems = 2;
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(53, 28);
            this.GenderComboBox.TabIndex = 22;
            this.GenderComboBox.Visible = false;
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.Enabled = false;
            this.DOBDateTimePicker.Location = new System.Drawing.Point(150, 114);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(179, 27);
            this.DOBDateTimePicker.TabIndex = 23;
            this.DOBDateTimePicker.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(455, 307);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RedactButton
            // 
            this.RedactButton.Enabled = false;
            this.RedactButton.Location = new System.Drawing.Point(455, 271);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(94, 29);
            this.RedactButton.TabIndex = 25;
            this.RedactButton.Text = "Redact";
            this.RedactButton.UseVisualStyleBackColor = true;
            this.RedactButton.Visible = false;
            this.RedactButton.Click += new System.EventHandler(this.RedactButton_Click);
            // 
            // AcceptButtonn
            // 
            this.AcceptButtonn.Enabled = false;
            this.AcceptButtonn.Location = new System.Drawing.Point(455, 271);
            this.AcceptButtonn.Name = "AcceptButtonn";
            this.AcceptButtonn.Size = new System.Drawing.Size(94, 29);
            this.AcceptButtonn.TabIndex = 26;
            this.AcceptButtonn.Text = "Accept";
            this.AcceptButtonn.UseVisualStyleBackColor = true;
            this.AcceptButtonn.Visible = false;
            this.AcceptButtonn.Click += new System.EventHandler(this.AcceptButtonn_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Location = new System.Drawing.Point(12, 314);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(437, 25);
            this.ErrorLabel.TabIndex = 27;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Enabled = false;
            this.LoginTextBox.Location = new System.Drawing.Point(150, 38);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(179, 27);
            this.LoginTextBox.TabIndex = 28;
            this.LoginTextBox.Visible = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 348);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.AcceptButtonn);
            this.Controls.Add(this.RedactButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DOBDateTimePicker);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.OtherInfoTextBox);
            this.Controls.Add(this.PositionInfoTextBox);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.OtherInfoLabel);
            this.Controls.Add(this.PositionInfoLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.IDSubscribeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button closeButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label PositionInfoLabel;
        private Label OtherInfoLabel;
        private Label PositionLabel;
        private Label GenderLabel;
        private Label DOBLabel;
        private Label NameLabel;
        private Label IdLabel;
        private Button DeleteButton;
        private Button RedactButton;
        private Button AcceptButtonn;
        internal Label IDSubscribeLabel;
        internal TextBox NameTextBox;
        internal TextBox PositionTextBox;
        internal TextBox PositionInfoTextBox;
        internal TextBox OtherInfoTextBox;
        internal ComboBox GenderComboBox;
        internal DateTimePicker DOBDateTimePicker;
        internal TextBox LoginTextBox;
        internal Label ErrorLabel;
    }
}