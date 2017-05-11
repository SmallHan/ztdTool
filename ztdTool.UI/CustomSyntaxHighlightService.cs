using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztdTool.UI
{
    public class CustomSyntaxHighlightService : ISyntaxHighlightService
    {
        #region #parsetokens
        readonly Document document;
        SyntaxHighlightProperties defaultSettings = new SyntaxHighlightProperties() { ForeColor = Color.Black };
        SyntaxHighlightProperties keywordSettings = new SyntaxHighlightProperties() { ForeColor = Color.Green };
        SyntaxHighlightProperties stringSettings = new SyntaxHighlightProperties() { ForeColor = Color.Blue };

        #region MyRegion
        string[] keywords = new string[] {"select"      ,"SELECT"
                                            ,"from"        ,"FROM"
                                            ,"where"       ,"WHERE"
                                            ,"order"       ,"ORDER"
                                            ,"by"          ,"BY"
                                            ,"group"       ,"GROUP"
                                            ,"left"        ,"LEFT"
                                            ,"join"        ,"JOIN"
                                            ,"on"          ,"ON"
                                            ,"inner"       ,"INNER"
                                            ,"set"         ,"SET"
                                            ,"case"        ,"CASE"
                                            ,"when"        ,"WHEN"
                                            ,"then"        ,"THEN"
                                            ,"varchar2"    ,"VARCHAR2"
                                            ,"number"      ,"NUMBER"
                                            ,"date"        ,"DATE"
                                            ,"update"      ,"UPDATE"
                                            ,"delete"      ,"DELETE"
                                            ,"null"        ,"NULL"
                                            ,"exists"      ,"EXISTS"
                                            ,"not"         ,"NOT"
                                            ,"and"         ,"AND"
                                            ,"or"          ,"OR"
                                            ,"in"          ,"IN"
                                            ,"if"          ,"IF"
                                            ,"else"        ,"ELSE"
                                            ,"elseif"      ,"ELSEIF"
                                            ,"end"         ,"END"
                                            ,"insert"      ,"INSERT"
                                            ,"into"        ,"INTO"
                                            ,"values"      ,"VALUES"
                                            ,"sysdate"     ,"SYSDATE"
                                            ,"delete"      ,"DELETE" };
        #endregion

        public CustomSyntaxHighlightService(Document document)
        {
            this.document = document;
        }

        private List<SyntaxHighlightToken> ParseTokens()
        {
            List<SyntaxHighlightToken> tokens = new List<SyntaxHighlightToken>();
            DocumentRange[] ranges = null;
            ranges = document.FindAll("'", SearchOptions.None);
            for (int i = 0; i < ranges.Length / 2; i++)
            {
                tokens.Add(new SyntaxHighlightToken(ranges[i * 2].Start.ToInt(),
                    ranges[i * 2 + 1].Start.ToInt() - ranges[i * 2].Start.ToInt() + 1, stringSettings));
            }

            for (int i = 0; i < keywords.Length; i++)
            {
                ranges = document.FindAll(keywords[i], SearchOptions.CaseSensitive | SearchOptions.WholeWord);

                for (int j = 0; j < ranges.Length; j++)
                {
                    if (!IsRangeInTokens(ranges[j], tokens))
                        tokens.Add(new SyntaxHighlightToken(ranges[j].Start.ToInt(), ranges[j].Length, keywordSettings));
                }
            }
            tokens.Sort(new SyntaxHighlightTokenComparer());
            AddPlainTextTokens(tokens);
            return tokens;
        }

        private void AddPlainTextTokens(List<SyntaxHighlightToken> tokens)
        {
            int count = tokens.Count;
            if (count == 0)
            {
                tokens.Add(new SyntaxHighlightToken(0, document.Range.End.ToInt(), defaultSettings));
                return;
            }
            tokens.Insert(0, new SyntaxHighlightToken(0, tokens[0].Start, defaultSettings));
            for (int i = 1; i < count; i++)
            {
                tokens.Insert(i * 2, new SyntaxHighlightToken(tokens[i * 2 - 1].End,
 tokens[i * 2].Start - tokens[i * 2 - 1].End, defaultSettings));
            }
            tokens.Add(new SyntaxHighlightToken(tokens[count * 2 - 1].End,
 document.Range.End.ToInt() - tokens[count * 2 - 1].End, defaultSettings));
        }

        private bool IsRangeInTokens(DocumentRange range, List<SyntaxHighlightToken> tokens)
        {
            for (int i = 0; i < tokens.Count; i++)
            {
                if (range.Start.ToInt() >= tokens[i].Start && range.End.ToInt() <= tokens[i].End)
                    return true;
            }
            return false;
        }
        #endregion #parsetokens

        #region #ISyntaxHighlightServiceMembers
        public void ForceExecute()
        {
            Execute();
        }
        public void Execute()
        {
            document.ApplySyntaxHighlight(ParseTokens());
        }
        #endregion #ISyntaxHighlightServiceMembers
    }

    public class SyntaxHighlightTokenComparer : IComparer<SyntaxHighlightToken>
    {
        public int Compare(SyntaxHighlightToken x, SyntaxHighlightToken y)
        {
            return x.Start - y.Start;
        }
    }
}
