class Program
{
    internal static readonly string[] separator = ["\r\n", "\r", "\n"];

    static void Main()
    {
        string obj = "id\tint\r\nABSSubAssy_SubAssy_DATE_NUMERICID\tint\r\nABSSubAssy_SubAssy_DATE_VALUE\tchar\r\nABSSubAssy_SubAssy_DATE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_DATE_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MODULATOR_FRONT_MASTER_BANJO_TORQUE_NUMERICID\tint\r\nABSSubAssy_SubAssy_MODULATOR_FRONT_MASTER_BANJO_TORQUE_VALUE\tchar\r\nABSSubAssy_SubAssy_MODULATOR_FRONT_MASTER_BANJO_TORQUE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MODULATOR_FRONT_MASTER_BANJO_TORQUE_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MODULATOR_PRESSURE_SWITCH_TORQUE_CONFORMATION_NUMERICID\tint\r\nABSSubAssy_SubAssy_MODULATOR_PRESSURE_SWITCH_TORQUE_CONFORMATION_VALUE\tchar\r\nABSSubAssy_SubAssy_MODULATOR_PRESSURE_SWITCH_TORQUE_CONFORMATION_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MODULATOR_PRESSURE_SWITCH_TORQUE_CONFORMATION_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MODULATOR_REAR_MASTER_TORQUE_NUMERICID\tint\r\nABSSubAssy_SubAssy_MODULATOR_REAR_MASTER_TORQUE_VALUE\tchar\r\nABSSubAssy_SubAssy_MODULATOR_REAR_MASTER_TORQUE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MODULATOR_REAR_MASTER_TORQUE_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MODULATOR_TO_FRONT_CALIBER_BANJO_WASHER_PICKUP_NUMERICID\tint\r\nABSSubAssy_SubAssy_MODULATOR_TO_FRONT_CALIBER_BANJO_WASHER_PICKUP_VALUE\tchar\r\nABSSubAssy_SubAssy_MODULATOR_TO_FRONT_CALIBER_BANJO_WASHER_PICKUP_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MODULATOR_TO_FRONT_CALIBER_BANJO_WASHER_PICKUP_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MODULATOR_TO_FRONT_MASTER_BANJO_WASHER_PICKUP_NUMERICID\tint\r\nABSSubAssy_SubAssy_MODULATOR_TO_FRONT_MASTER_BANJO_WASHER_PICKUP_VALUE\tchar\r\nABSSubAssy_SubAssy_MODULATOR_TO_FRONT_MASTER_BANJO_WASHER_PICKUP_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MODULATOR_TO_FRONT_MASTER_BANJO_WASHER_PICKUP_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MODULATOR_TO_REAR_CALIBER_BANJO_WASHER_PICKUP_NUMERICID\tint\r\nABSSubAssy_SubAssy_MODULATOR_TO_REAR_CALIBER_BANJO_WASHER_PICKUP_VALUE\tchar\r\nABSSubAssy_SubAssy_MODULATOR_TO_REAR_CALIBER_BANJO_WASHER_PICKUP_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MODULATOR_TO_REAR_CALIBER_BANJO_WASHER_PICKUP_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MODULATOR_TO_REAR_MASTER_CYLINDER_BANGO_WASHER_PICKUP_NUMERICID\tint\r\nABSSubAssy_SubAssy_MODULATOR_TO_REAR_MASTER_CYLINDER_BANGO_WASHER_PICKUP_VALUE\tchar\r\nABSSubAssy_SubAssy_MODULATOR_TO_REAR_MASTER_CYLINDER_BANGO_WASHER_PICKUP_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MODULATOR_TO_REAR_MASTER_CYLINDER_BANGO_WASHER_PICKUP_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MONTH_NUMERICID\tint\r\nABSSubAssy_SubAssy_MONTH_VALUE\tchar\r\nABSSubAssy_SubAssy_MONTH_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MONTH_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_PartStatus_NUMERICID\tint\r\nABSSubAssy_SubAssy_PartStatus_VALUE\tchar\r\nABSSubAssy_SubAssy_PartStatus_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_PartStatus_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_REAR_CALIBER_BANJO_WASHER_PICKUP_NUMERICID\tint\r\nABSSubAssy_SubAssy_REAR_CALIBER_BANJO_WASHER_PICKUP_VALUE\tchar\r\nABSSubAssy_SubAssy_REAR_CALIBER_BANJO_WASHER_PICKUP_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_REAR_CALIBER_BANJO_WASHER_PICKUP_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_FRONT_CALIPER_BANJO_WASHER_PICKUP_NUMERICID\tint\r\nABSSubAssy_SubAssy_FRONT_CALIPER_BANJO_WASHER_PICKUP_VALUE\tchar\r\nABSSubAssy_SubAssy_FRONT_CALIPER_BANJO_WASHER_PICKUP_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_FRONT_CALIPER_BANJO_WASHER_PICKUP_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_REAR_CALIBER_TORQUE_NUMERICID\tint\r\nABSSubAssy_SubAssy_REAR_CALIBER_TORQUE_VALUE\tchar\r\nABSSubAssy_SubAssy_REAR_CALIBER_TORQUE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_REAR_CALIBER_TORQUE_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_REAR_MASTER_CYLINDER_BANGO_WASHER_PICKUP_NUMERICID\tint\r\nABSSubAssy_SubAssy_REAR_MASTER_CYLINDER_BANGO_WASHER_PICKUP_VALUE\tchar\r\nABSSubAssy_SubAssy_REAR_MASTER_CYLINDER_BANGO_WASHER_PICKUP_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_REAR_MASTER_CYLINDER_BANGO_WASHER_PICKUP_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_REAR_MASTER_CYLINDER_TORQUE_NUMERICID\tint\r\nABSSubAssy_SubAssy_REAR_MASTER_CYLINDER_TORQUE_VALUE\tchar\r\nABSSubAssy_SubAssy_REAR_MASTER_CYLINDER_TORQUE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_REAR_MASTER_CYLINDER_TORQUE_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_SECONDS_NUMERICID\tint\r\nABSSubAssy_SubAssy_SECONDS_VALUE\tchar\r\nABSSubAssy_SubAssy_SECONDS_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_SECONDS_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_YEAR_NUMERICID\tint\r\nABSSubAssy_SubAssy_YEAR_VALUE\tchar\r\nABSSubAssy_SubAssy_YEAR_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_YEAR_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_FRONT_CALIPER_TORQUE_NUMERICID\tint\r\nABSSubAssy_SubAssy_FRONT_CALIPER_TORQUE_VALUE\tchar\r\nABSSubAssy_SubAssy_FRONT_CALIPER_TORQUE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_FRONT_CALIPER_TORQUE_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_FRONT_MASTER_BANJO_WASHER_PICKUP_NUMERICID\tint\r\nABSSubAssy_SubAssy_FRONT_MASTER_BANJO_WASHER_PICKUP_VALUE\tchar\r\nABSSubAssy_SubAssy_FRONT_MASTER_BANJO_WASHER_PICKUP_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_FRONT_MASTER_BANJO_WASHER_PICKUP_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_FRONT_MASTER_CYLINDER_TORQUE_NUMERICID\tint\r\nABSSubAssy_SubAssy_FRONT_MASTER_CYLINDER_TORQUE_VALUE\tchar\r\nABSSubAssy_SubAssy_FRONT_MASTER_CYLINDER_TORQUE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_FRONT_MASTER_CYLINDER_TORQUE_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_HOUR_NUMERICID\tint\r\nABSSubAssy_SubAssy_HOUR_VALUE\tchar\r\nABSSubAssy_SubAssy_HOUR_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_HOUR_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MINUITE_NUMERICID\tint\r\nABSSubAssy_SubAssy_MINUITE_VALUE\tchar\r\nABSSubAssy_SubAssy_MINUITE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MINUITE_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MODULATOR_BARCODE_NUMERICID\tint\r\nABSSubAssy_SubAssy_MODULATOR_BARCODE_VALUE\tchar\r\nABSSubAssy_SubAssy_MODULATOR_BARCODE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MODULATOR_BARCODE_QUALITY\tsmallint\r\nABSSubAssy_SubAssy_MODULATOR_FRONT_CALIBER_TORQUE_NUMERICID\tint\r\nABSSubAssy_SubAssy_MODULATOR_FRONT_CALIBER_TORQUE_VALUE\tchar\r\nABSSubAssy_SubAssy_MODULATOR_FRONT_CALIBER_TORQUE_TIMESTAMP\tdatetime\r\nABSSubAssy_SubAssy_MODULATOR_FRONT_CALIBER_TORQUE_QUALITY\tsmallint";

        string[] lines = obj.Split(separator, StringSplitOptions.None);

        foreach (string line in lines)
        {
            string[] columns = line.Split('\t');

            if (columns.Length < 2)
                continue;

            string columnName = columns[0];
            string columnType = columns[1];

            string propertyName = string.Join("", columnName.Split('_')
                .Select(word => char.ToUpper(word[0]) + word[1..].ToLower()));

            Console.WriteLine($"[Column(\"{columnName}\")]");
            Console.WriteLine($"public {GetCSharpType(columnType)} {propertyName} {{ get; set; }}\n");
        }
        Console.ReadLine();
    }

    static string GetCSharpType(string columnType)
    {
        return columnType.ToLower() switch
        {
            "int" => "int",
            "char" => "string?",
            "datetime" => "DateTime",
            "smallint" => "int",
            "varchar" => "string?",
            // Add more mappings as needed
            _ => "object",
        };
    }
}
