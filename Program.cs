﻿namespace HTMLParser {
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
    }
}