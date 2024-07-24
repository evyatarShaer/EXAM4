using static Shtarut.Service.ShtarotService;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Shtarut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CreateIfNotExist();

            string data = dayWeekcomboBox.Text;
            InsertDay(result1(data));

            string data2 = monthdayComboBox.Text;
            InsertDayMonth(result2(data2));

            string data3 = monthComboBox.Text;
            InsertMonth(result3(data3));

            string data4 = yearComboBox.Text;
            InsertYear(result4(data4));

            string result = $"{result1} {result2} {result3} {result4}";
            InsertResult(result);
        
        }


        string result1(string Day) => Day switch
        {
            "�����" => "���� ����",
            "���" => "���� ����",
            "�����" => "������ ����",
            "�����" => "������ ����",
            "�����" => "������ ����",
            "���" => "���� ����",
            _ => string.Empty
        };

        string result2(string DayNum) => DayNum switch
        {
            "1" => "��� ��� ����",
            "2" => "��� ���� ����",
            "3" => "����� ���� ����",
            "4" => "����� ���� ����",
            "5" => "����� ���� ����",
            "6" => "��� ���� ����",
            "7" => "���� ���� ����",
            "8" => "����� ���� ����",
            "9" => "���� ���� ����",
            "10" => "���� ���� ����",
            "11" => "��� ��� ���� ���� ����",
            "12" => "����� ��� ���� ���� ����",
            "13" => "����� ��� ���� ���� ����",
            "14" => "����� ��� ���� ���� ����",
            "15" => "����� ��� ���� ���� ����",
            "16" => "���� ��� ���� ���� ����",
            "17" => "���� ��� ���� ���� ����",
            "18" => "����� ��� ���� ���� ����",
            "19" => "���� ��� ���� ���� ����",
            "20" => "����� ���� ���� ����",
            "21" => "����� ���� ���� ���� ����",
            "22" => "����� ������ ���� ���� ����",
            "23" => "����� ������ ���� ���� ����",
            "24" => "����� ������ ���� ���� ����",
            "25" => "����� ������ ���� ���� ����",
            "26" => "����� ����� ���� ���� ����",
            "27" => "����� ����� ���� ���� ����",
            "28" => "����� ������ ���� ���� ����",
            "29" => "����� ����� ���� ���� ����",
            "30" => "������ ���� ���� ����",
            _ => string.Empty
        };

        string result3(string month) => month switch
        {
            "����" => "����",
            "�����" => "�����",
            "����" => "����",
            "���" => "���",
            "���" => "���",
            "���" => "���",
            "��� ������" => " ���",
            "��� ����" => "���",
            "����" => "����",
            "����" => "����",
            "����" => "����",
            "����" => "����",
            "��" => "��",
            "����" => "����",
            _ => string.Empty
        };


        string result4(string year) => year switch
        {
            "���''�" => "���� ����� ���� ���� ����� ��� ������ �����",
            "���''�" => "���� ����� ���� ���� ����� ���� ������ �����",
            "���''�" => "���� ����� ���� ���� ����� ������ ������ �����",
            "���''�" => "���� ����� ���� ���� ����� ���� ������ �����",
            "���''�" => "���� ����� ���� ���� ������� ������ �����",
            "���''�" => "���� ����� ���� ���� ����� ������� ���� ������ �����",
            "��''�" => "���� ����� ���� ���� ������� ������ ������ �����",
            "���''�" => "���� ����� ���� ���� ������� ������ ������ �����",
            "���''�" => "���� ����� ���� ���� ������� ������ ������ �����",
            "���''�" => "���� ����� ���� ���� ������� ������ ������ �����",
            "���''�" => "���� ����� ���� ���� ������� ������ ������ �����",
            _ => string.Empty
        };


        //string result = $"{result1()}"
        private void label1_Click(object sender, EventArgs e)
        {

        }


        
        private void resultButton_Click(object sender, EventArgs e)
        {
            string data = dayWeekcomboBox.Text;
            InsertDay(data);

            string data2 = monthdayComboBox.Text;
            InsertDayMonth(data2);

            string data3 = monthComboBox.Text;
            InsertMonth(data3);

            string data4 = yearComboBox.Text;
            InsertYear(data4);

            //MessageBox.Show(result);
        }
    }
}
