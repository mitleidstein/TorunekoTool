namespace TorunekoTool
{
    public class DtoType
    {
        public int TypeNumber { get; set; }
        public string TypeName { get; set; }
        public int RColor { get; set; }
        public int GColor { get; set; }
        public int BColor { get; set; }

        public DtoType()
        {
        }

        public DtoType(int typeNum, string typeName, int rColor, int gColor, int bColor)
        {
            TypeNumber = typeNum;
            TypeName = typeName;
            RColor = rColor;
            GColor = gColor;
            BColor = bColor;
        }
    }
}