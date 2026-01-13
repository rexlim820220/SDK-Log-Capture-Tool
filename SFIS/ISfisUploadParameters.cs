using System.Configuration;

namespace SDK_Log_Capture_Tool.SFIS
{
    public interface ISfisUploadParameters
    {
        string ProgramId { get; }
        string ProgramPassword { get; }
        string Device { get; }
        string TSP { get; }
        int Status { get; }
        string CPKFlag { get; }
        string Error { get; }
    }

    public class DefaultSfisUploadParameters: ISfisUploadParameters
    {
        public virtual string ProgramId => ConfigurationManager.AppSettings["SFISProgramId"];
        public virtual string ProgramPassword => ConfigurationManager.AppSettings["SFISProgramPassword"];
        public virtual string Device => ConfigurationManager.AppSettings["SFISDevice"];
        public virtual string TSP => ConfigurationManager.AppSettings["SFISTSP"];
        public virtual int Status => int.Parse(ConfigurationManager.AppSettings["SFISStatus"]);
        public virtual string CPKFlag => ConfigurationManager.AppSettings["SFISCPKFlag"];
        public virtual string Error => ConfigurationManager.AppSettings["SFISError"];
    }

    public class F620_Sfis_Upload_Para: DefaultSfisUploadParameters
    {
        public override string ProgramId => "TSP_DTAUTO";
        public override string ProgramPassword => ":e5T.?H3?n";
        public override string Device => "980532";
        public override string TSP => "TimBaking";
        public override int Status => 0;
        public override string CPKFlag => "N";
        public override string Error => "";
    }

    public class Water_Sfis_Upload_Para : DefaultSfisUploadParameters
    {
        public override string ProgramId => "TSP_DTAUTO";
        public override string ProgramPassword => ":e5T.?H3?n";
        public override string Device => "980532";
        public override string TSP => "TimBaking";
        public override int Status => 0;
        public override string CPKFlag => "N";
        public override string Error => "";
    }
}
