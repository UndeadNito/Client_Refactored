namespace Client_Refactored
{
    public partial class EmployeeForm : Form
    {
        private readonly MessageProvider _provider;

        private Point _lastLocation;
        private bool _moveForm = false;
        private const byte _dragFieldHeightPercentage = 10;
        private int _dragFieldHeight;

        public EmployeeForm(MessageProvider provider, int id)
        {
            _provider = provider;

            InitializeComponent();
            CalculateDragField();

            closeButton.Size = new Size(_dragFieldHeight - 4, _dragFieldHeight - 4);
            closeButton.Location = new Point(Width - _dragFieldHeight, 2);

            GetDataFromServer(id);
        }

        internal virtual void GetDataFromServer(int id)
        {
            _provider.SendMessage(new Dictionary<string, string>() {
                { "action", "getEmployee" } ,
                { "id", id.ToString() }
            });

            var message = _provider.WaitMessage();

            if (message.ContainsKey("can_redact") && message["can_redact"] == "true")
            {
                RedactButton.Enabled = true; RedactButton.Visible = true;
                DeleteButton.Enabled = true; DeleteButton.Visible = true;
            }

            if (message.ContainsKey("error") && message["error"] != "")
            {
                ErrorLabel.Text = message["error"];
                return;
            }

            IdLabel.Text = message["id"];
            NameLabel.Text = message["name"];
            DOBLabel.Text = message["dob"];
            GenderLabel.Text = message["gender"];
            PositionLabel.Text = message["position"];
            PositionInfoLabel.Text = message["position_info"];
            OtherInfoLabel.Text = message["other_info"];
        }

        private void RedactButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = NameLabel.Text;
            DOBDateTimePicker.Value = DateTime.Parse(DOBLabel.Text);
            GenderComboBox.Text = GenderLabel.Text;
            PositionTextBox.Text = PositionLabel.Text;
            PositionInfoTextBox.Text = PositionInfoLabel.Text;
            OtherInfoTextBox.Text = OtherInfoLabel.Text;

            RedactControlsVisibility(true);
        }

        internal virtual void AcceptButtonn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> message = new();

            message["action"] = "redactEmployee";
            message["id"] = IdLabel.Text;

            ErrorLabel.Text = "";

            if (NameTextBox.Text != NameLabel.Text) message["name"] = NameTextBox.Text;
            if (DOBDateTimePicker.Value.ToString("yyyy-MM-dd") != DOBLabel.Text) message["dob"] = DOBDateTimePicker.Value.ToString("yyyy-MM-dd");
            if (GenderComboBox.Text != GenderLabel.Text) message["gender"] = GenderComboBox.Text;
            if (PositionTextBox.Text != PositionLabel.Text) message["position"] = PositionTextBox.Text;
            if (PositionInfoTextBox.Text != PositionInfoLabel.Text) message["position_info"] = PositionInfoTextBox.Text;
            if (OtherInfoTextBox.Text != OtherInfoLabel.Text) message["other_info"] = OtherInfoTextBox.Text;

            _provider.SendMessage(message);
            var answer = _provider.WaitMessage();

            if (answer["confirmed"] == "true")
            {
                NameLabel.Text = NameTextBox.Text;
                DOBLabel.Text =  DOBDateTimePicker.Value.ToString("yyyy-MM-dd");
                GenderLabel.Text = GenderComboBox.Text;
                PositionLabel.Text = PositionTextBox.Text;
                PositionInfoLabel.Text = PositionInfoTextBox.Text;
                OtherInfoLabel.Text = OtherInfoTextBox.Text;

                RedactControlsVisibility(false);
                return;
            }

            if (!answer.ContainsKey("error"))
            {
                ErrorLabel.Text = "Unknown error";
                return;
            }
            ErrorLabel.Text = answer["error"];
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> message = new();

            message["action"] = "deleteEmployee";
            message["id"] = IdLabel.Text;

            ErrorLabel.Text = "";

            _provider.SendMessage(message);
            var answer = _provider.WaitMessage();

            if (answer["confirmed"] == "true") this.Close();

            if (!answer.ContainsKey("error"))
            {
                ErrorLabel.Text = "Unknown error";
                return;
            }
            ErrorLabel.Text = answer["error"];
        }

        public void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RedactControlsVisibility(bool state)
        {
            NameTextBox.Enabled = state; NameTextBox.Visible = state;
            DOBDateTimePicker.Enabled = state; DOBDateTimePicker.Visible = state;
            GenderComboBox.Enabled = state; GenderComboBox.Visible = state;
            PositionTextBox.Enabled = state; PositionTextBox.Visible = state;
            PositionInfoTextBox.Enabled = state; PositionInfoTextBox.Visible = state;
            OtherInfoTextBox.Enabled = state; OtherInfoTextBox.Visible = state;

            AcceptButtonn.Enabled = state; AcceptButtonn.Visible = state;
        }



        public void Form_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(
                new Pen(Color.Black, 1),
                new Point(0, _dragFieldHeight),
                new Point(Width, _dragFieldHeight));
        }

        public void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseAtTop(e)) _moveForm = true;
            _lastLocation = e.Location;

            bool MouseAtTop(MouseEventArgs mouse)
            {
                if (mouse.Y < _dragFieldHeight) return true;

                return false;
            }
        }

        public void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (_moveForm)
            {
                Location = new Point(
                (Location.X - _lastLocation.X) + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        public void Form_MouseUp(object sender, MouseEventArgs e)
        {
            _moveForm = false;
        }

        public void CalculateDragField()
        {
            _dragFieldHeight = (int)Math.Ceiling((decimal)(ClientSize.Height * _dragFieldHeightPercentage) / 100);
        }
    }
}

