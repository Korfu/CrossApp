using CoreFinanceApp.Domain;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace CoreFinanceApp.Ui.Mappers
{
    public class PersonMapper
    {
        public Person MapPerson(Worksheet worksheet, int i, Dictionary<string,int> columnNamesWithIndex, int addressId)
        {
            var nameIndex = columnNamesWithIndex["imie"];
            var name = worksheet.Cells[nameIndex][i].Value?.ToString();

            var surNameIndex = columnNamesWithIndex["nazwisko"];
            var surName = worksheet.Cells[surNameIndex][i].Value?.ToString();

            var peselIndex = columnNamesWithIndex["PESEL"];
            var pesel = worksheet.Cells[peselIndex][i].Value?.ToString();

            var phoneIndex = columnNamesWithIndex["PESEL"];
            var phone = worksheet.Cells[phoneIndex][i].Value?.ToString();

            var phone2Index = columnNamesWithIndex["PESEL"];
            var phone2 = worksheet.Cells[phone2Index][i].Value?.ToString();

            Person newPerson = new Person
            {
                AddressId = addressId,
                FirstName = name,
                SecondName = null,
                Surname = surName,
                NationalIdentificationNumber = pesel,

            };
            return newPerson;
        }
    }
}