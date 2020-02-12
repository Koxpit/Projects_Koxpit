using System.Collections.Generic;

namespace Note
{
    public static class SearchRecords
    {
        public static List<Record> SearchFName(string FName, List<Record> ListRecords)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Name == FName)
                    list.Add(rec);

            return list;
        }

        public static List<Record> SearchLName(string LName, List<Record> ListRecords)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Surname == LName)
                    list.Add(rec);

            return list;
        }

        public static List<Record> SearchPatronymic(string Patronymic, List<Record> ListRecords)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Patronymic == Patronymic)
                    list.Add(rec);

            return list;
        }

        public static List<Record> SearchBirthday(string Birthday, List<Record> ListRecords)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Birthday == Birthday)
                    list.Add(rec);

            return list;
        }

        public static List<Record> SearchPhoneNumber(string PhoneNumber, List<Record> ListRecords)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.PhoneNumber == PhoneNumber)
                    list.Add(rec);

            return list;
        }

        public static List<Record> SearchRecord(Record search, List<Record> ListRecords)
        {
            List<Record> list = new List<Record>();
            foreach (Record rec in ListRecords)
                if (rec.Name == search.Name
                    && rec.Surname == search.Surname
                    && rec.Patronymic == search.Patronymic
                    && rec.Birthday == search.Birthday
                    && rec.PhoneNumber == search.PhoneNumber)
                    list.Add(rec);

            return list;
        }
    }
}
