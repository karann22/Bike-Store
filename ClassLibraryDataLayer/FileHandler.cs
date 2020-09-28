using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using ClassLibraryBusinessLayer;

namespace ClassLibraryDataLayer
{
    public class FileHandler
    {
        public static String xmlFilePath = @"../../data/bikes.xml";

        public static void WriteToXmlFile(List<Bikes> listOfBikes)
        {
            XmlWriter xw = XmlWriter.Create(xmlFilePath);
            XmlSerializer xs = new XmlSerializer(typeof(List<Bikes>));

            xs.Serialize(xw, listOfBikes);

            xw.Close();

        }
        public static List<Bikes> ReadFromXmlFile()
        {
            List<Bikes> list = null;

            StreamReader sr = new StreamReader(xmlFilePath);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bikes>));

            list = (List<Bikes>)xmlSerializer.Deserialize(sr);

            sr.Close();

            return list;
        }

        //-----------------------------------------------------------------------------------------------------

        //public static string filePath = @"../../data/bikes.txt";

        //public static void WriteToTextFile(List<IMovable> listOfBikes)
        //{
        //    //listEmployee.Count = number of items in arraylist
        //    String[] lines = new String[listOfBikes.Count];

        //    for (int i = 0; i < listOfBikes.Count; i++)
        //    {
        //        lines[i] = listOfBikes[i].Id + "|" + listOfBikes[i].Fn + "|" + listOfBikes[i].Ln + "|"
        //        + listOfBikes[i].Category + "|"
        //        + listOfEmployees[i].HiredDate.Day + "|"
        //        + listOfEmployees[i].HiredDate.Month + "|"
        //        + listOfEmployees[i].HiredDate.Year;

        //    }
        //    //using System.IO
        //    File.WriteAllLines(filePath, lines);
        //}

        //public static List<Employee> ReadFromTextFile()
        //{
        //    List<Employee> listOfEmployees = new List<Employee>();

        //    string[] lines = File.ReadAllLines(filePath);
        //    Employee employee;
        //    for (int i = 0; i < lines.Length; i++)
        //    {
        //        String[] line = lines[i].Split('|');
        //        /***************************
        //        * Create a new employee (a reference) on each iteration in the loop.
        //        *  If an employee is not created on each iteration
        //        *  the result will be the last result.
        //        ****************************************/
        //        employee = new Employee();
        //        employee.Id = Convert.ToInt32(line[0]);
        //        employee.Fn = line[1];
        //        employee.Ln = line[2];
        //        //convert string to enum
        //        employee.Category = (EnumType)Enum.Parse(typeof(EnumType), line[3]);
        //        Date date = new Date();
        //        date.Day = Convert.ToInt32(line[4]);
        //        date.Month = Convert.ToInt32(line[5]);
        //        date.Year = Convert.ToInt32(line[6]);
        //        employee.HiredDate = date;
        //        listOfEmployees.Add(employee);
        //    }
        //    return listOfEmployees;
        //}
    }
}
