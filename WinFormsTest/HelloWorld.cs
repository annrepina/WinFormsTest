namespace WinFormsTest
{
    class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public partial class HelloWorld : Form
    {
        private List<string> _list = new List<string>() { "����", "���", "���" };

        public HelloWorld()
        {
            InitializeComponent();

            MainList.Items.AddRange(_list.ToArray());
        }

        private void OnBestButtonClick(object sender, EventArgs e)
        {
            //// �� ������� ��������� ������� ����. � ����� � ������� �������� ����� � ����������� �� ���������� ������ � ����������
            //MessageBox.Show("You taped me", "My first WinForms MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //TitleLabel.Text = MainInput.Text;

            //// �� ������� ����������� ����� �����, ������� ��������� ������ � ������ �������� (������������ ������)
            SlaveForm slaveForm = new SlaveForm();
            var res = slaveForm.ShowDialog();

            switch (res)
            {
                case DialogResult.Cancel:
                    BackColor = Color.Black;
                    break;
                case DialogResult.Yes:
                    BackColor = Color.Yellow;
                    break;
                case DialogResult.No:
                    BackColor = Color.Red;
                    break;
                default:
                    break;
            }

        }

        private void OnMainTextChanged(object sender, EventArgs e)
        {
            TitleLabel.Text = MainInput.Text;
        }

        private void OnMainButtonMouseEnter(object sender, EventArgs e)
        {
            var oldLocation = this.BestButton.Location;

            this.BestButton.Location = new Point(oldLocation.X + 5, oldLocation.Y + 5);
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            var isTrue = checkBox.Checked;

            BestButton.Enabled = isTrue;

            UpdateCheckBoxText();
        }

        private void HelloWorld_Shown(object sender, EventArgs e)
        {
            BestButton.Enabled = checkBox.Checked;

            UpdateCheckBoxText();
        }

        private void UpdateCheckBoxText()
        {
            var isTrue = checkBox.Checked;

            if (isTrue)
                checkBox.Text = "������ �������";

            else
                checkBox.Text = "������ �� �������";
        }

        private void MainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkedItems = MainList.CheckedItems;
        }
    }
}