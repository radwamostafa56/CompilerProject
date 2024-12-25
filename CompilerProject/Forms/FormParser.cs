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
            private int currentIndex = 0;
            private List<Token> tokens;
            private StringBuilder grammers;
            private Token currentToken => currentIndex < tokens.Count ? tokens[currentIndex] : null;

            // private Token currentToken => tokens[currentIndex];
            public Parser(List<Token> tokens)
            {
                this.tokens = tokens;
                this.grammers = new StringBuilder();

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
                if (currentToken != null && currentToken.Type != TokenType.RightBrace)
                {
                    grammers.AppendLine("<statement_list> → <statement> <statement_list>");
                    statement();

                    if (currentToken != null && currentToken.Type != TokenType.RightBrace)
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
                    IfStatement();
                }
                else if (currentToken.Type == TokenType.Keyword && currentToken.Value == "متغير")
                {
                    grammers.AppendLine("<statement> → <declaration>");
                    declaration();
                }
                else if (currentToken.Type == TokenType.Keyword && currentToken.Value == "طالما")
                {
                    grammers.AppendLine("<statement> → <while_statement>");
                    WhileStatement();
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
                //if (currentToken == null || currentToken.Type != TokenType.Semicolon)
                //{
                //    grammers.AppendLine("Error: Missing semicolon at the end of the declaration. Assuming semicolon is present.");
                //}
                //else
                //{
                //    Match(TokenType.Semicolon);
                //}
            }
            void Expression()
            {
                grammers.AppendLine("<expression> → <term>");
                term();

                // Handle arithmetic operators
                while (currentToken != null && currentToken.Type == TokenType.Operator &&
                       (currentToken.Value == "+" || currentToken.Value == "-" ||
                        currentToken.Value == "*" || currentToken.Value == "/"))
                {
                    grammers.AppendLine($"<expression> → <term> {currentToken.Value} <expression>");
                    Match(TokenType.Operator); // Match the arithmetic operator
                    term(); // Parse the next term
                }
            }


            void term()
            {
                if (currentToken.Type == TokenType.Number)
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
                    string tokenValue = currentToken?.Value ?? "null";
                    Error($"Unexpected token: {tokenValue}");
                    //Error($"Unexpected token{currentToken.Value}");
                }

            }
            void assignment()
            {
                grammers.AppendLine("<assignment> → IDENT = <expression> ;");
                Match(TokenType.Identifier);
                Match(TokenType.Assign);
                Expression();
                 Match(TokenType.Semicolon);
                //if (currentToken == null || currentToken.Type != TokenType.Semicolon)
                //{
                //    grammers.AppendLine("Error: Missing semicolon at the end of the assignment. Assuming semicolon is present.");
                //}
                //else
                //{
                //    Match(TokenType.Semicolon);
                //}
            }

            void IfStatement()
            {
                grammers.AppendLine("<if_statement> → اذا (<expression>) {<statement_list>}");
                Match(TokenType.Keyword);
                Match(TokenType.LeftParenthesis);
                RelationalExpression();
                Match(TokenType.RightParenthesis);
                Match(TokenType.LeftBrace);
                statementList();
                Match(TokenType.RightBrace);

            }

            void WhileStatement()
            {
                grammers.AppendLine("<while_statement → طالما (<condition>) {<statement_list> }");
                Match(TokenType.Keyword);
                Match(TokenType.LeftParenthesis);
                RelationalExpression();
                Match(TokenType.RightParenthesis);
                Match(TokenType.LeftBrace);
                statementList();
                Match(TokenType.RightBrace);

            }

            void RelationalExpression()
            {
                grammers.AppendLine("<condition> → <<relational_expression>");
                grammers.AppendLine("<relational_expression> → <term> [<relational_operator> <term>]");


                Expression();

                if (currentToken != null && currentToken.Type == TokenType.Operator)
                {
                    grammers.AppendLine($"<operator> → {currentToken.Value}");
                    Match(TokenType.Operator);
                    term();
                }
                if (currentToken != null && currentToken.Type == TokenType.RelationalOperator)
                {
                    grammers.AppendLine($"<relational_operator> → {currentToken.Value}");
                    Match(TokenType.RelationalOperator);
                    Expression();
                }

                else
                {
                    grammers.AppendLine("<expression> → <term>");
                }
            }
            public void ErrorEnd(string v)
            {
                throw new Exception(message: $" {v} ");
            }

            void Match(TokenType expectedType)
            {
                if (currentToken != null && currentToken.Type == expectedType)
                {
                    grammers.AppendLine($"Matched: {currentToken.Value}, Type: {currentToken.Type}");
                    currentIndex++;
                }
                else
                {
                    string tokenValue = currentToken?.Value ?? "null";
                    string errorMessage = $"SyntaxError: Expected '{expectedType}', but got '{currentToken?.Type}' ({tokenValue}).";

                    if (expectedType == TokenType.Semicolon)
                    {
                        //grammers.AppendLine($"Error: {errorMessage}. Assuming semicolon is present.");
                        //ErrorEnd($"missed token {expectedType}");
                        throw new Exception(message :"Missing semicolon");
                        //return;
                    }

                    else if (expectedType == TokenType.RightBrace)
                    {
                        //grammers.AppendLine($"Error: {errorMessage}. Assuming RightBrace is present.");
                        //Error($"Unexpected token {currentToken.Value}");
                        throw new Exception(message: "Missing RightBrace");
                        //return;
                    }
                    Error(errorMessage);
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
                MessageBox.Show(parseser, "Parsing successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormParser_Load(object sender, EventArgs e)
        {

        }
    }
}
