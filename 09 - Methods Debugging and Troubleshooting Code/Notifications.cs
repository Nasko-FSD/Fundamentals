var n = int.Parse(Console.ReadLine());
for (int messages = 1; messages <= n; messages++)
{
    ReadAndProcessMessage();
    Console.WriteLine();
}
static void ReadAndProcessMessage()
{
    string Messages = Console.ReadLine();
    if (Messages == "error")
    {
        string OperationError = Console.ReadLine();
        string ErrorMessage = Console.ReadLine();
        int ErrorCode = int.Parse(Console.ReadLine());
        string ErrorLength = "Error: Failed to execute " + OperationError + ".";
        ShowErrorMessage(OperationError, ErrorMessage, ErrorCode, ErrorLength);
    }
    if (Messages == "warning")
    {
        string WarningMessage = Console.ReadLine();
        string WarningLength = "Warning: " + WarningMessage + ".";
        ShowWarningMessage(WarningMessage, WarningLength);
    }
    if (Messages == "success")
    {
        string OperationSuccess = Console.ReadLine();
        string SuccessMessage = Console.ReadLine();
        string SuccessLength = "Successfully executed " + OperationSuccess + ".";
        ShowSuccessMessage(OperationSuccess, SuccessMessage, SuccessLength);
    }
}
static void ShowErrorMessage(string OperationError, string ErrorMessage, int ErrorCode, string ErrorLength)
{
    Console.WriteLine($"{ErrorLength}");
    for (int i = 1; i <= ErrorLength.Length; i++)
    {
        Console.Write("=");
    }
    Console.WriteLine();
    Console.WriteLine($"Reason: {ErrorMessage}.");
    Console.WriteLine($"Error code: {ErrorCode}.");
}

static void ShowWarningMessage(string WarningMessage, string WarningLength)
{
    Console.WriteLine($"Warning: {WarningMessage}.");
    for (int i = 1; i <= WarningLength.Length; i++)
    {
        Console.Write("=");
    }
    Console.WriteLine();
}
static void ShowSuccessMessage(string OperationSuccess, string SuccessMessage, string SuccessLength)
{
    Console.WriteLine($"Successfully executed {OperationSuccess}.");
    for (int j = 1; j <= SuccessLength.Length; j++)
    {
        Console.Write("=");
    }
    Console.WriteLine();
    Console.WriteLine($"{SuccessMessage}.");
}