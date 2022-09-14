using QuantityOfUnitsOfGrainOnBarge;

Console.OutputEncoding = System.Text.Encoding.Unicode;

int QuantityOfUnitsOfGrain = 0;
int i = 0;
int HigherLevelValue = 0;
int HigherLevelIndex = 0;
int LowerLevelValue = 0;

Console.WriteLine("Уведіть кількість рівнів баржі");
int QuantityLevels = AdditionalClass.ReadIntOnly();
int[] LevelsOfHeight = new int[QuantityLevels];

if (QuantityLevels == 0)
{
    Console.WriteLine($"Кількість одиниць зерна дорівнюе {QuantityOfUnitsOfGrain}");
    return;
}

Console.WriteLine("Уведіть розміры высот рівнів баржі");

for (i = 0; i < QuantityLevels; i++)
{
    LevelsOfHeight[i] = AdditionalClass.ReadIntOnly();
    if (HigherLevelValue < LevelsOfHeight[i])
    {
        HigherLevelValue = LevelsOfHeight[i];
        HigherLevelIndex = i;
    }
}


if (LevelsOfHeight.Length <= 2)
{
    Console.WriteLine($"Кількість одиниць зерна дорівнюе {QuantityOfUnitsOfGrain}");
}
else
{
    LowerLevelValue = LevelsOfHeight[0];

    for (i = 0; i < HigherLevelIndex; i++)
    {
        QuantityOfUnitsOfGrain += AdditionalClass.CalculateTheQuantityOfUnitsOfGrain(ref LowerLevelValue, LevelsOfHeight[i]);
    }

    LowerLevelValue = LevelsOfHeight[QuantityLevels - 1];
    for (i = QuantityLevels - 1; i > HigherLevelIndex; i--)
    {
        QuantityOfUnitsOfGrain += AdditionalClass.CalculateTheQuantityOfUnitsOfGrain(ref LowerLevelValue, LevelsOfHeight[i]);
    }

    Console.WriteLine($"Кількість одиниць зерна дорівнюе {QuantityOfUnitsOfGrain}");
}

