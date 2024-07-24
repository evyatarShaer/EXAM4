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
            "4" => "ארבעה ימים בשבת",
            "5" => "חמישה ימים בשבת",
            "6" => "ששה ימים בשבת",
            "7" => "שבעה ימים בשבת",
            "8" => "שמונה ימים בשבת",
            "9" => "תשעה ימים בשבת",
            "10" => "עשרה ימים בשבת",
            "11" => "אחד עשר ימים בשבת לירח",
            "12" => "שניים עשר ימים בשבת לירח",
            "13" => "שלושה עשר ימים בשבת לירח",
            "14" => "ארבעה עשר ימים בשבת לירח",
            "15" => "חמישה עשר ימים בשבת לירח",
            "16" => "שישה עשר ימים בשבת לירח",
            "17" => "שבעה עשר ימים בשבת לירח",
            "18" => "שמונה עשר ימים בשבת לירח",
            "19" => "תשעה עשר ימים בשבת לירח",
            "20" => "עשרים ימים בשבת לירח",
            "21" => "עשרים ואחד ימים בשבת לירח",
            "22" => "עשרים ושתיים ימים בשבת לירח",
            "23" => "עשרים ושלושה ימים בשבת לירח",
            "24" => "עשרים וארבעה ימים בשבת לירח",
            "25" => "עשרים וחמישה ימים בשבת לירח",
            "26" => "עשרים ושישה ימים בשבת לירח",
            "27" => "עשרים ושבעה ימים בשבת לירח",
            "28" => "עשרים ושמונה ימים בשבת לירח",
            "29" => "עשרים ותשעה ימים בשבת לירח",
            "30" => "שלושים ימים בשבת לירח",
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
            "אדר הראשון" => " אדר",
            "אדר השני" => "אדר",
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
            "תשפ''ד" => "חמשת אלפים ושבע מאות וששים ושש לבריאת העולם",
            "תשפ''ה" => "חמשת אלפים ושבע מאות וששים ושבע לבריאת העולם",
            "תשפ''ו" => "חמשת אלפים ושבע מאות וששים ושמונה לבריאת העולם",
            "תשפ''ז" => "חמשת אלפים ושבע מאות וששים ותשע לבריאת העולם",
            "תשפ''ח" => "חמשת אלפים ושבע מאות ושמונים לבריאת העולם",
            "תשפ''ט" => "חמשת אלפים ושבע מאות וששים ושמונים ואחד לבריאת העולם",
            "תש''צ" => "חמשת אלפים ושבע מאות ושמונים ושניים לבריאת העולם",
            "תשצ''א" => "חמשת אלפים ושבע מאות ושמונים ושלושה לבריאת העולם",
            "תשצ''ב" => "חמשת אלפים ושבע מאות ושמונים וארבעה לבריאת העולם",
            "תשצ''ג" => "חמשת אלפים ושבע מאות ושמונים ושלושה לבריאת העולם",
            "תשצ''ד" => "חמשת אלפים ושבע מאות ושמונים וארבעה לבריאת העולם",
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
