using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Shtarut.Configuration.Configuration;

namespace Shtarut.Service
{
    internal static class ShtarotService
    {
        public static void CreateIfNotExist()
        {
            if (!File.Exists(ShtarotPath))
            {
                XDocument document = new();

                XElement Shtarot = new("queries");

                document.Add(Shtarot);

                document.Save(ShtarotPath);
            }
        }

        public static void InsertDay(string dayStr)
        {
            try
            {
                XDocument document = XDocument.Load(ShtarotPath);

                XElement? queries = document.Descendants("queries").FirstOrDefault();

                if (queries == null)
                {
                    throw new InvalidOperationException("The 'queries' element was not found.");
                }

                XElement day = new ("Day",(dayStr));

                queries.Add(day);

                document.Save(ShtarotPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while inserting: {ex.Message}");
            }
        }

        public static void InsertDayMonth(string dayNumber)
        {
            try
            {
                XDocument document = XDocument.Load(ShtarotPath);

                XElement? queries = document.Descendants("queries").FirstOrDefault();

                if (queries == null)
                {
                    throw new InvalidOperationException("The 'queries' element was not found.");
                }

                XElement? daystr = document.Descendants("Day").FirstOrDefault();

                if (daystr == null)
                {
                    throw new InvalidOperationException("The 'Day' element was not found.");
                }

                XElement dayMonth = new("DayMonth", (dayNumber));

                queries.Add(dayMonth);

                document.Save(ShtarotPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while inserting: {ex.Message}");
            }
        }

        public static void InsertMonth(string month)
        {
            try
            {
                XDocument document = XDocument.Load(ShtarotPath);

                XElement? queries = document.Descendants("queries").FirstOrDefault();

                if (queries == null)
                {
                    throw new InvalidOperationException("The 'queries' element was not found.");
                }

                XElement? daystr = document.Descendants("Day").FirstOrDefault();

                if (daystr == null)
                {
                    throw new InvalidOperationException("The 'Day' element was not found.");
                }

                XElement? dayNumber = document.Descendants("DayMonth").FirstOrDefault();

                if (dayNumber == null)
                {
                    throw new InvalidOperationException("The 'DayNumber' element was not found.");
                }

                XElement Month = new("Month", (month));

                queries.Add(Month);

                document.Save(ShtarotPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while inserting: {ex.Message}");
            }
        }

        public static void InsertYear(string year)
        {
            try
            {
                XDocument document = XDocument.Load(ShtarotPath);

                XElement? queries = document.Descendants("queries").FirstOrDefault();

                if (queries == null)
                {
                    throw new InvalidOperationException("The 'queries' element was not found.");
                }

                XElement? daystr = document.Descendants("Day").FirstOrDefault();

                if (daystr == null)
                {
                    throw new InvalidOperationException("The 'Day' element was not found.");
                }

                XElement? month = document.Descendants("Month").FirstOrDefault();

                if (month == null)
                {
                    throw new InvalidOperationException("The 'Month' element was not found.");
                }

                XElement year1 = new("Year", (year));

                queries.Add(year1);

                document.Save(ShtarotPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while inserting: {ex.Message}");
            }
        }

        public static void InsertResult(string result)
        {
            try
            {
                XDocument document = XDocument.Load(ShtarotPath);

                XElement? queries = document.Descendants("queries").FirstOrDefault();

                if (queries == null)
                {
                    throw new InvalidOperationException("The 'queries' element was not found.");
                }

                XElement? daystr = document.Descendants("Day").FirstOrDefault();

                if (daystr == null)
                {
                    throw new InvalidOperationException("The 'Day' element was not found.");
                }

                XElement? month = document.Descendants("Month").FirstOrDefault();

                if (month == null)
                {
                    throw new InvalidOperationException("The 'Month' element was not found.");
                }

                XElement? year = document.Descendants("Year").FirstOrDefault();

                if (year == null)
                {
                    throw new InvalidOperationException("The 'Year' element was not found.");
                }

                XElement res = new("Result", (result));

                queries.Add(res);

                document.Save(ShtarotPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while inserting: {ex.Message}");
            }
        }
    }
}
