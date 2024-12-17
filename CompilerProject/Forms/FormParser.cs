//using Guna.UI2.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CompilerProject.Forms.FormScanner;

namespace CompilerProject.Forms
{
    public partial class FormParser : Form
    {
        public class Parser
        {
            private int currentIndex=0;
            private List<Token> tokens;
            private StringBuilder grammers;
            private Token currentToken => currentIndex < tokens.Count ? tokens[currentIndex] : null;

           // private Token currentToken => tokens[currentIndex];
            public Parser( List<Token> tokens)
            {
                 this.tokens = tokens;
                this.grammers=new StringBuilder();
                
            }
            public string parse()
            {
                grammers.Clear();
                parseProgram();
                return grammers.ToString();
            }
            //private void advanced()
            //{
            //    if(currentIndex < tokens.Count-1)
            //    {
            //        currentIndex++;
            //    }
            //    //else
            //    //{
            //    //    currentIndex =tokens.Count;
            //    //}

            //}
            public void parseProgram()
            {
                grammers.AppendLine("<program> → <statement_list>");
                statementList();
            }

            void statementList()
            {
                if (currentToken != null)
                {
                    grammers.AppendLine("<statement_list> → <statement> <statement_list>");
                    statement();
                    statementList();
                }
                else
                {
                    grammers.AppendLine("<statement_list> → ε");
                }
            }
            void statement()
            {
                if (currentToken.Type == TokenType.Keyword && currentToken.Value == "اذا")
                {
                    grammers.AppendLine("<statement> →  <if_statement>");
                    // if_statement();
                }
                else if(currentToken.Type == TokenType.Keyword && currentToken.Value== "متغير")
                {
                    grammers.AppendLine("<statement> → <declaration>");
                    declaration();
                }
                else if(currentToken.Type == TokenType.Keyword && currentToken.Value== "طالما")
                {
                    grammers.AppendLine("<statement> → <while_statement>");
                    //while_statement();
                }
                else if (currentToken.Type == TokenType.Identifier)
                {
                    grammers.AppendLine("<statement> →  <assignment> ");
                    assignment();
                }
                else
                {
                    Error($"Unexpected token {currentToken.Value}");
                }
            }

            private void Error(string v)
            {
                throw new Exception($"Error at token '{currentToken.Value}', Type: {currentToken.Type}. Message: {v}");
            }
            void declaration()
            {
                grammers.AppendLine("<declaration> → متغير IDENT = <expression> ;");
                Match(TokenType.Keyword);
                Match(TokenType.Identifier);
                Match(TokenType.Assign);
                Expression();
                Match(TokenType.Semicolon);
            }
            void Expression()
            {
                grammers.AppendLine("<expression> → <term>");
                term();
                if (currentToken.Type == TokenType.Operator && currentToken!=null)
                {
                    grammers.AppendLine("<expression> → <term> <operator> <expression>");
                    Match(TokenType.Operator);
                    Expression();
                }

            }
            void term()
            {
                if (currentToken.Type == TokenType.Number )
                {
                    grammers.AppendLine("<term> → NUM");
                    Match(TokenType.Number);
                }
                else if (currentToken.Type == TokenType.Identifier)
                {
                    grammers.AppendLine("<term> → IDENT");
                    Match(TokenType.Identifier);
                }
                else
                {
                    Error($"Unexpected token{currentToken.Value}");
                }
 
            }
            void assignment()
            {
                grammers.AppendLine("<assignment> → IDENT = <expression> ;");
                Match(TokenType.Identifier);
                Match(TokenType.Assign);
                Expression();
                Match(TokenType.Semicolon);
            }

            void Match(TokenType expectedType)
            {
                if (currentToken != null && currentToken.Type == expectedType)
                {
                    grammers.AppendLine($"Matched:{currentToken.Value} his type id{currentToken.Type}");
                    //advanced();
                    currentIndex++;
                    
                }
                else
                {
                    Error($"SyntaxError: unexpexted type {currentToken.Type} ,{currentToken.Value}");
                }
            }
        }
        public FormParser()
        {
            InitializeComponent();
          //  LoadTheme();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
                string code = guna2TextBox1.Text;
                Scanner Scanner = new Scanner();
                List<Token> tokens = Scanner.Scan(code);
                Parser parse = new Parser(tokens);
            try
            {
                string parseser = parse.parse();
                MessageBox.Show(parseser,"Parsing successfully");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
 
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
