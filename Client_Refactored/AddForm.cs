namespace Client_Refactored
{
    public partial class AddForm : EmployeeForm
    {
        private readonly MessageProvider _provider;

        public AddForm(MessageProvider provider): base(provider, 0)
        {
            _provider = provider;

            InitializeComponent();
            this.Size = new System.Drawing.Size(561, 348);

            RedactControlsVisibility(true);
            IDSubscribeLabel.Text = "Login";
            LoginTextBox.Enabled = true; LoginTextBox.Visible = true;
        }

        internal override void GetDataFromServer(int id) { }

        internal override void AcceptButtonn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> message = new();
            message["action"] = "addEmployee";

            message["login"] = LoginTextBox.Text;
            message["name"] = NameTextBox.Text;
            message["dob"] = DOBDateTimePicker.Value.ToString("yyyy-MM-dd");
            message["gender"] = GenderComboBox.Text;
            message["position"] = PositionTextBox.Text;
            message["position_info"] = PositionInfoTextBox.Text;
            message["other_info"] = OtherInfoTextBox.Text;

            _provider.SendMessage(message);

            var _answer = _provider.WaitMessage();

            if (_answer.ContainsKey("confirmed") && _answer["confirmed"] == "true") this.Close();

            if (_answer.ContainsKey("error"))
            {
                ErrorLabel.Text = _answer["error"];
                return;
            }
        }
    }
}
