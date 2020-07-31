using ZiPatchLib.Helpers;

namespace ZiPatchLib.Chunk
{
    public class EndOfFileChunk : ZiPatchChunk
    {
        public new static string Type = "EOF_";

        protected override void ReadChunk()
        {
            var start = reader.BaseStream.Position;

            reader.ReadBytes(Size - (int)(reader.BaseStream.Position - start));
        }


        public EndOfFileChunk(ChecksumBinaryReader reader, int size) : base(reader, size)
        {}

        public override string ToString()
        {
            return Type;
        }
    }
}
