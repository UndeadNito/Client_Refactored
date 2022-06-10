using System.Data;

namespace Client_Refactored
{
    public partial class WorkForm : Form
    {
        private readonly MessageProvider _provider;

        private Point _lastLocation;
        private bool _moveForm = false;
        private const byte _dragFieldHeightPercentage = 8;
        private int _dragFieldHeight;

        public WorkForm(MessageProvider provider, string login)
        {
            _provider = provider;

            InitializeComponent();
            CalculateDragField();

            closeButton.Size = new Size(_dragFieldHeight - 4, _dragFieldHeight - 4);
            closeButton.Location = new Point(Width - _dragFieldHeight, 2);

            loginLable.Text = login;
            loginLable.Location = new Point(Width - closeButton.Width - loginLable.Width - 30, (_dragFieldHeight - loginLable.Height) / 2);

            _provider.SendMessage(new Dictionary<string, string>() { { "action", "getEmployees" } });
            FillDataGridView(_provider.WaitMessage());
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            _provider.SendMessage(new Dictionary<string, string>() { 
                { "action", "getEmployees" } ,
                { "filter_criterion", comboBox1.Text },
                { "filter_value", textBox1.Text }
            });

            FillDataGridView(_provider.WaitMessage());
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeForm employeeForm = new(_provider, Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
            employeeForm.Show();
        }

        public void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FillDataGridView(Dictionary<string, string> message)
        {
            var data = message.ToList();
            DataTable table = new();
            table.Columns.AddRange(new DataColumn[3] { new DataColumn("ID", typeof(string)),
                                new DataColumn("Name", typeof(string)),
                                new DataColumn("Position",typeof(string)) });

            for (int i = 0; i < data.Count; i++)
                table.Rows.Add(data[i].Key, data[i].Value.Split("  ")[0], data[i].Value.Split("  ")[1]);
            
            dataGridView1.DataSource = table;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            new AddForm(_provider).Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _provider.SendMessage(new Dictionary<string, string>() { { "action", "getEmployees" } });
            FillDataGridView(_provider.WaitMessage());
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
