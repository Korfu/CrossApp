using CoreFinanceApp.Domain;
using CoreFinanceApp.Data;
using CoreFinanceApp.Ui.Mappers;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CoreFinanceApp.Ui.Logic
{
    public class ExcelOperations
    {
        public void GetExcel(string path)
        {
            var application = new Application();
            var workbook = application.Workbooks.Open(path);
            var worksheet = (Worksheet)workbook.Worksheets.get_Item(1);


            //These two lines do the magic.
            worksheet.Columns.ClearFormats();
            worksheet.Rows.ClearFormats();

            var TotalColumns = worksheet.UsedRange.Columns.Count;
            var TotalRows = worksheet.UsedRange.Rows.Count;

            PushtoDatabase(TotalColumns, TotalRows, worksheet);

            workbook.Close();
            application.Quit();

        }

        public void PushtoDatabase (int columns, int rows, Worksheet worksheet)
        {
            Dictionary<string, int> columnNamesWithIndex = new Dictionary<string, int>();
            for (int i = 1; i <= columns; i++)
            {
                columnNamesWithIndex.Add(worksheet.Cells[i][1].Value.ToString(), i);
            }

            var addressMapper = new AddressMapper();
            var addressRepository = new AddressRepository();
            var personMapper = new PersonMapper();
            var personRepository = new PersonRepository();
            var financialStateMapper = new FinancialStateMapper();
            var financialStateRepository = new FinancialStateRepository();
            var agrementMapper = new AgreementMapper();
            var agreementRepository = new AgreementRepository();

            for (int i = 2; i <= rows; i++)
            {

                var addressObject = addressMapper.MapAdress(worksheet, i, columnNamesWithIndex);
                var addressId = addressRepository.PushAddressesToDb(addressObject);

                var personObject = personMapper.MapPerson(worksheet, i, columnNamesWithIndex, addressId);
                var personId = personRepository.PushPeopleToDb(personObject);

                var financialStateObject = financialStateMapper.MapFinancialState(worksheet, i, columnNamesWithIndex);
                var financialStateId = financialStateRepository.PushFinancialStatesToDb(financialStateObject);

                var agreementObject = agrementMapper.MapAgreement(worksheet, i, columnNamesWithIndex, personId, financialStateId);
                agreementRepository.PushAgreementsToDb(agreementObject);
            }
        }


    }
}