using System.IO;

namespace ZiPatchLib.Util
{
    public class SqpackIndexFile : SqpackFile
    {
        public SqpackIndexFile(BinaryReader reader) : base(reader) {}


        protected override string GetFileName(ZiPatchConfig.PlatformId platform) =>
            $"{base.GetFileName(platform)}.index{(FileId == 0 ? string.Empty : FileId.ToString())}";
    }
}
