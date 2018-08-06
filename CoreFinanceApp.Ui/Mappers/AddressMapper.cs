using CoreFinanceApp.Domain;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreFinanceApp.Ui.Mappers
{
    public class AddressMapper
    {
        public Address MapAdress(Worksheet worksheet, int i, Dictionary<string, int> columnNamesWithIndex)
        {
            var streetNameIndex = columnNamesWithIndex["MAIN_STREET_NAME"];
            var streetName = worksheet.Cells[streetNameIndex][i].Value?.ToString();

            var streetNumberIndex = columnNamesWithIndex["MAIN_STREET_NUMBER"];
            var streetNumber = worksheet.Cells[streetNumberIndex][i].Value?.ToString();

            var streetFlatNumberIndex = columnNamesWithIndex["MAIN_STREET_FLAT_NUMBER"];
            var streetFlatNumber = worksheet.Cells[streetFlatNumberIndex][i].Value?.ToString();

            var postCodeIndex = columnNamesWithIndex["MAIN_POST_CODE"];
            var postCode = worksheet.Cells[postCodeIndex][i].Value?.ToString();

            var postOfficeCityIndex = columnNamesWithIndex["MAIN_POST_OFFICE_CITY"];
            var postOfficeCity = worksheet.Cells[postOfficeCityIndex][i].Value?.ToString();

            var correspondenceStreetNameIndex = columnNamesWithIndex["CORRESPONDENCE_STREET_NAME"];
            var correspondenceStreetName = worksheet.Cells[correspondenceStreetNameIndex][i].Value?.ToString();

            var correspondenceStreetNumberIndex = columnNamesWithIndex["CORRESPONDENCE_STREET_NUMBER"];
            var correspondenceStreetNumber = worksheet.Cells[correspondenceStreetNumberIndex][i].Value?.ToString();

            var correspondenceStreetFlatNumberIndex = columnNamesWithIndex["CORRESPONDENCE_STREET_FLAT_NUMBER"];
            var correspondenceStreetFlatNumber = worksheet.Cells[correspondenceStreetFlatNumberIndex][i].Value?.ToString();

            var correspondencePostCodeIndex = columnNamesWithIndex["CORRESPONDENCE_POST_CODE"];
            var correspondencePostCode = worksheet.Cells[correspondencePostCodeIndex][i].Value?.ToString();

            var correspondencePostOfficeCityIndex = columnNamesWithIndex["CORRESPONDENCE_POST_OFFICE_CITY"];
            var correspondencePostOfficeCity = worksheet.Cells[correspondencePostOfficeCityIndex][i].Value?.ToString();


            Address newAddress = new Address
            {
                StreetName = streetName,
                StreetNumber = streetNumber,
                FlatNumber = streetFlatNumber,
                PostCode = postCode,
                PostOfficeCity = postOfficeCity,
                CorrespondenceStreetName = correspondenceStreetName,
                CorrespondenceStreetNumber = correspondenceStreetNumber,
                CorrespondenceFlatNumber = correspondenceStreetFlatNumber,
                CorrespondencePostCode = correspondencePostCode,
                CorrespondencePostOfficeCity = correspondencePostOfficeCity
            };
            return newAddress;
        }
    }
}