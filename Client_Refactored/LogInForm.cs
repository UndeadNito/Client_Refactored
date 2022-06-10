namespace Client_Refactored
{
    public partial class LogInForm : Form
    {
        private readonly MessageProvider _provider;

        private Point _lastLocation;
        private bool _moveForm = false;
        private const byte _dragFieldHeightPercentage = 10;
        private int _dragFieldHeight;


        public LogInForm(MessageProvider provider)
        {
            _provider = provider;

            InitializeComponent();
            CalculateDragField();

            closeButton.Size = new Size(_dragFieldHeight - 4, _dragFieldHeight - 4);
            closeButton.Location = new Point(Width - _dragFieldHeight, 2);
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> message = new()
            {
                { "action", "login" },
                { "login", loginTextBox.Text },
                { "password", passwordTextBox.Text }
            };

            _provider.SendMessage(message);

            var answer = _provider.WaitMessage();

            if (answer["confirmed"] == "true")
            {
                new WorkForm(_provider, loginTextBox.Text).Show();
                Close();
            }

            logInErrorLable.Text = answer["error"];
        }

        private void registerButton_click(object sender, EventArgs e)
        {
            Dictionary<string, string> message = new()
            {
                { "action", "register" },
                { "login", registerLoginTextBox.Text },
                { "password", registerPasswordTextBox.Text }
            };

            _provider.SendMessage(message);

            Dictionary<string, string> answer;
            while (true)
            {
                if (!_provider.NewMessage())
                {
                    Thread.Sleep(10);
                    continue;
                }


                answer = _provider.GetMessage()!;
                break;
            }

            if (answer["confirmed"] == "true")
            {
                new WorkForm(_provider, registerLoginTextBox.Text).Show();
                Close();
            }

            registerErrorLable.Text = answer["error"];
        }

        public void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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