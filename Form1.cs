using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //khai bao bien toan cuc
        Process cmdProcess; // Tiến trình của cmd

        // Dùng để di chuyển form vì mặc định form không di chuyển được 
        int _togMove; // Cho biết pnlTitle có được click chuột vào hay không (1 là có, 0 là không có)
        int _mValX; // Khoảng cách chuột di chuyển theo phương x
        int _mValY; // Khoảng cách chuột di chuyển theo phương y
        public Form1()
        {
            InitializeComponent();
            // Khởi tạo combobox.
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 30; i <= 180; i += 30)
            {
                string temp = i.ToString();
                dict.Add(temp, temp);
            }
            cboTime.DataSource = new BindingSource(dict, null);
            cboTime.DisplayMember = "Value";
            cboTime.ValueMember = "Key";

            // Khởi tạo process.
            cmdProcess = new Process();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
