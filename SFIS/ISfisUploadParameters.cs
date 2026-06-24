using System.Configuration;

namespace SDK_Log_Capture_Tool.SFIS
{
    public interface ISfisUploadParameters
    {
        string ProgramId { get; }
        string ProgramPassword { get; }
        string Device { get; }
        string UserID { get; }
        string UserPassword { get; }
        string TSP { get; }
        int Status { get; }
        string CPKFlag { get; }
        string Error { get; }
    }

    public class DefaultSfisUploadParameters: ISfisUploadParameters
    {
        private string GetLiveSetting(string key)
        {
            ConfigurationManager.RefreshSection("appSettings");
            return ConfigurationManager.AppSettings[key];
        }
        public virtual string ProgramId => GetLiveSetting("SFISProgramId");
        public virtual string ProgramPassword => GetLiveSetting("SFISProgramPassword");
        public virtual string Device => GetLiveSetting("SFISDevice");
        public virtual string UserID => GetLiveSetting("UserID");
        public virtual string UserPassword => GetLiveSetting("UserPassword");
        public virtual string TSP => GetLiveSetting("SFISTSP");
        public virtual int Status
        {
            get
            {
                int.TryParse(GetLiveSetting("SFISStatus"), out int statusVal);
                return statusVal == 0 ? 1 : statusVal;
            }
        }
        public virtual string CPKFlag => GetLiveSetting("SFISCPKFlag");
        public virtual string Error => GetLiveSetting("SFISError");
    }

    public class F620_Sfis_Upload_Para: DefaultSfisUploadParameters
    {
        public override string ProgramId => "TSP_DTAUTO";
        public override string ProgramPassword => ":e5T.?H3?n";
        public override string Device => "980530";
        public override string UserID => "LA0800494";
        public override string UserPassword => "LA0800494";
        public override string TSP => "F620";
        public override int Status => 1;
        public override string CPKFlag => "N";
        public override string Error => "";
    }

    public class Water_Sfis_Upload_Para : DefaultSfisUploadParameters
    {
        public override string ProgramId => "TSP_DTAUTO";
        public override string ProgramPassword => ":e5T.?H3?n";
        public override string Device => "980532";
        public override string UserID => "LA0800494";
        public override string UserPassword => "LA0800494";
        public override string TSP => "TimBaking";
        public override int Status => 1;
        public override string CPKFlag => "N";
        public override string Error => "";
    }

    public class N2_Sfis_Upload_Para : DefaultSfisUploadParameters
    {
        public override string ProgramId => "TSP_DTAUTO";
        public override string ProgramPassword => ":e5T.?H3?n";
        public override string Device => "980535";
        public override string UserID => "LA0800494";
        public override string UserPassword => "LA0800494";
        public override string TSP => "CoolerMaster";
        public override int Status => 1;
        public override string CPKFlag => "N";
        public override string Error => "";
    }
}
