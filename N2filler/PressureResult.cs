namespace SDK_Log_Capture_Tool.ModbusTcp
{
    public class PressureResult
    {
        public double Pressure { get; set; }
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;

        public override string ToString()
            => IsValid ? $"{Pressure:F3}" : $"Error: {ErrorMessage}";
    }
}
