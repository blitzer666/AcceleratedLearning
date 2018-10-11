namespace Common.Services
{
    public class StringService
    {
        public string CutString(string s, int cutlength)
        {
            return s.Substring(0, cutlength) + "...";
        }
    }
}
