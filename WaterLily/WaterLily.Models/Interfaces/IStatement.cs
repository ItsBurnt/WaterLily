using System.Collections.Generic;
using WaterLily.Models.Entities;
using WaterLily.Models.Enums;

namespace WaterLily.Models.Interfaces;

public interface IStatement
{
    void RenameParsedFile();

    void Archive();

    Organization ParseOrganization();

    List<Transaction> ParseTransactions();
}