using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Ticket
    {
        public string Name { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Price { get; set; }
        public Ticket(string name, string from, string to, string price)
        {
            Name = name;
            From = from;
            To = to;
            Price = price;
        }

        public override string ToString()
        {
            return Name + " | " + From + " | " + To + " | " + Price;
        }
    }

    internal class TicketManager
    {
        public void SaveTicket(Ticket ticket)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("tickets.txt", true))
                {
                    sw.WriteLine("Name: " + ticket.Name);
                    sw.WriteLine("From: " + ticket.From);
                    sw.WriteLine("To: " + ticket.To);
                    sw.WriteLine("Price: " + ticket.Price);
                    sw.WriteLine("-------------------");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في حفظ التذكرة: " + ex.Message);
            }
        }

        public List<Ticket> LoadTickets()
        {
            List<Ticket> list = new List<Ticket>();

            if (!File.Exists("tickets.txt"))
                return list;

            try
            {
                StreamReader sr = new StreamReader("tickets.txt");
                string name = "", from = "", to = "", price = "";

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if (line.StartsWith("Name:"))
                        name = line.Replace("Name:", "").Trim();
                    else if (line.StartsWith("From:"))
                        from = line.Replace("From:", "").Trim();
                    else if (line.StartsWith("To:"))
                        to = line.Replace("To:", "").Trim();
                    else if (line.StartsWith("Price:"))
                        price = line.Replace("Price:", "").Trim();
                    else if (line == "-------------------")
                        list.Add(new Ticket(name, from, to, price));
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل التذاكر: " + ex.Message);
            }

            return list;
        }

        /// بتحسب السعر الإجمالي بناءً على الدرجة والإضافات وعدد التذاكر
        public int CalculatePrice(string grade, bool hasMeal, bool hasWifi, int count)
        {
            int price = 0;

            if (grade == "normal") price = 50;
            else if (grade == "first") price = 100;
            else price = 150;

            if (hasMeal) price += 20;
            if (hasWifi) price += 10;

            return price * count;
        }
    }
}
