using System.Collections.Generic;

namespace HTMLParser {
    public class Parser {
        private int dataIndex = 0;
        private int reverseIndex = 0;
        private char delim;
        private string htmlData;
        private string htmlTag;
        private string attrName;
        private string tagAttr;
        private string mainData;
        private string[] emptyTagList = new[] { "area", "base", "basefont", "br", "col", "frame", "hr", "img", "input", "isindex", "link", "meta", "param" };
        private Dictionary<string, string> attrDict = new Dictionary<string, string>();

        public void Reset() {
            dataIndex = 0;
            reverseIndex = 0;
        }
    }
}