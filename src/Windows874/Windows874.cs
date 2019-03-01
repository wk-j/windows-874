using System;
using System.Text;
using System.Linq;

// http://ascii-table.com/windows-codepage.php?874

namespace Windows874 {
    public class Windows874 {

        [Obsolete("Dot not use this function")]
        private static string ToUtf8(string input) {
            var diff = 3585 - 161;
            var bytes = Encoding.Unicode.GetBytes(input);
            var codes = bytes.Select(x => {
                if (x >= 161 && x <= 251) {
                    var c = x + diff;
                    return Convert.ToChar(c);
                }
                return Convert.ToChar(x);
            }).Where(x => x != 0).ToArray();
            return new string(codes);
        }

        public static void Register() {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }
    }
}
