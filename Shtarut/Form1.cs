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

            
        }


        string result1(string Day) => Day switch
        {
            "ראשון" => "באחד לשבת",
            "שני" => "בשני לשבת",
            "שלישי" => "בשלישי לשבת",
            "רביעי" => "ברביעי לשבת",
            "חמישי" => "בחמישי לשבת",
            "ששי" => "בששי לשבת",
            _ => string.Empty
        };

        string result2(string DayNum) => DayNum switch
        {
            "1" => "יום אחד לירח",
            "2" => "שני ימים לירח",
            "3" => "שלושה ימים לירח",
            "4" => "ארבעה ימים לירח",
            "5" => "חמישה ימים לירח",
            "6" => "ששה ימים לירח",
            "7" => "שבעה ימים לירח",
            "8" => "שמונה ימים לירח",
            "9" => "תשעה ימים לירח",
            "10" => "עשרה ימים לירח",
            "11" => "אחד עשר ימים לירח",
            "12" => "שניים עשר ימים לירח",
            "13" => "שלושה עשר ימים לירח",
            "14" => "ארבעה עשר ימים לירח",
            "15" => "חמישה עשר ימים לירח",
            "16" => "שישה עשר ימים לירח",
            "17" => "שבעה עשר ימים לירח",
            "18" => "שמונה עשר ימים לירח",
            "19" => "תשעה עשר ימים לירח",
            "20" => "עשרים ימים לירח",
            "21" => "עשרים ואחד ימים לירח",
            "22" => "עשרים ושתיים ימים לירח",
            "23" => "עשרים ושלושה ימים לירח",
            "24" => "עשרים וארבעה ימים לירח",
            "25" => "עשרים וחמישה ימים לירח",
            "26" => "עשרים ושישה ימים לירח",
            "27" => "עשרים ושבעה ימים לירח",
            "28" => "עשרים ושמונה ימים לירח",
            "29" => "עשרים ותשעה ימים לירח",
            "30" => "שלושים ימים לירח",
            _ => string.Empty
        };

        string result3(string month) => month switch
        {
            "תשרי" => "תשרי",
            "חשוון" => "חשוון",
            "כסלו" => "כסלו",
            "טבת" => "טבת",
            "שבט" => "שבט",
            "אדר" => "אדר",
            "אדר הראשון" => "אדר הראשון",
            "אדר השני" => "אדר השני",
            "ניסן" => "ניסן",
            "אייר" => "אייר",
            "סיון" => "סיון",
            "תמוז" => "תמוז",
            "אב" => "אב",
            "אלול" => "אלול",
            _ => string.Empty
        };


        string result4(string year) => year switch
        {
            "תשפ''ד" => "חמשת אלפים ושבע מאות וששים וארבע לבריאת העולם",
            "תשפ''ה" => "חמשת אלפים ושבע מאות וששים וחמש לבריאת העולם",
            "תשפ''ו" => "חמשת אלפים ושבע מאות וששים ושש לבריאת העולם",
            "תשפ''ז" => "חמשת אלפים ושבע מאות וששים ושבע לבריאת העולם",
            "תשפ''ח" => "חמשת אלפים ושבע מאות וששים ושמונה לבריאת העולם",
            "תשפ''ט" => "חמשת אלפים ושבע מאות וששים ותשע לבריאת העולם",
            "תש''צ" => "חמשת אלפים ושבע מאות ושמונים לבריאת העולם",
            "תשצ''א" => "חמשת אלפים ושבע מאות ושמונים ואחת לבריאת העולם",
            "תשצ''ב" => "חמשת אלפים ושבע מאות ושמונים ושתיים לבריאת העולם",
            "תשצ''ג" => "חמשת אלפים ושבע מאות ושמונים ושלוש לבריאת העולם",
            "תשצ''ד" => "חמשת אלפים ושבע מאות ושמונים וארבע לבריאת העולם",
            _ => string.Empty
        };


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            string data1 = dayWeekcomboBox.Text;
            InsertDay(data1);

            string data2 = monthdayComboBox.Text;
            InsertDayMonth(data2);

            string data3 = monthComboBox.Text;
            InsertMonth(data3);

            string data4 = yearComboBox.Text;
            InsertYear(data4);

            InsertDay(result1(data1));

            InsertDayMonth(result2(data2));

            InsertMonth(result3(data3));

            InsertYear(result4(data4));

            string result = $"{result1(data1)} {result2(data2)} {result3(data3)} {result4(data4)}";
            InsertResult(result);
            MessageBox.Show(result);

        }
    }
}
