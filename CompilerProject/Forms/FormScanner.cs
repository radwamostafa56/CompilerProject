using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerProject.Forms
{
    public partial class FormScanner : Form
    {

		public enum TokenType
		{
			Keyword, Identifier, Number, Operator, Assign, LeftParenthesis, RightParenthesis, LeftBrace, RightBrace, Whitespace, Semicolon
		}

		public class Token
		{
			public TokenType Type { get;  }
			public string Value { get;  } //actual text

			public Token(TokenType type, string value)
			{
				Type = type;
				Value = value;
			}

			public override string ToString() => $"('{Type}', '{Value}')";
			// override change how Token instances are displayed.
			//  ToString() is overridden to display the token in a specific format
		}

		public class Scanner
		{
			//  \b enforces word boundaries, so it matches whole words only
			private static readonly Regex Patterns = new Regex(@"
			(?<Keyword>\b(اذا|طالما|متغير)\b) |
			(?<Identifier>\b[_\u0621-\u064Aa-zA-Z][_\u0621-\u064Aa-zA-Z0-9]*\b) |
			(?<Number>\b\d+(\.\d+)?\b) |
			(?<Assign>[=]) |
			(?<Operator>[+\-/*\<\>!=\==\<=\>=]) |

			(?<LeftParenthesis>[\(]) |
			(?<RightParenthesis>[\)]) |
			(?<LeftBrace>[\{]) |
			(?<RightBrace>[\}]) |
			(?<Whitespace>\s+) |
			(?<Semicolon>[;])",
				RegexOptions.IgnorePatternWhitespace); //allows whitespace in the pattern for readability

			public List<Token> Scan(string code)
			{
				var tokens = new List<Token>();

				foreach (Match match in Patterns.Matches(code))
				{
					if (match.Groups["Keyword"].Success)
						tokens.Add(new Token(TokenType.Keyword, match.Value));

					else if (match.Groups["Identifier"].Success)
						tokens.Add(new Token(TokenType.Identifier, match.Value));

					else if (match.Groups["Number"].Success)
						tokens.Add(new Token(TokenType.Number, match.Value));

					else if (match.Groups["Operator"].Success)
						tokens.Add(new Token(TokenType.Operator, match.Value));

					else if (match.Groups["Assign"].Success)
						tokens.Add(new Token(TokenType.Assign, match.Value));

					else if (match.Groups["LeftParenthesis"].Success)
						tokens.Add(new Token(TokenType.LeftParenthesis, match.Value));

					else if (match.Groups["RightParenthesis"].Success)
						tokens.Add(new Token(TokenType.RightParenthesis, match.Value));

					else if (match.Groups["LeftBrace"].Success)
						tokens.Add(new Token(TokenType.LeftBrace, match.Value));

					else if (match.Groups["RightBrace"].Success)
						tokens.Add(new Token(TokenType.RightBrace, match.Value));

					else if (match.Groups["Whitespace"].Success)
						continue; // Skip whitespace

					else if (match.Groups["Semicolon"].Success)
						tokens.Add(new Token(TokenType.Semicolon, match.Value));
				}

				return tokens;
			}
		}

		public FormScanner()
        {
            InitializeComponent();
           // LoadTheme();
        }
		public FormScanner(string initialText)
		{
			InitializeComponent();
			guna2TextBox1.Text = initialText;
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			string codeText = guna2TextBox1.Text;

			Scanner scanner = new Scanner();

			List<Token> tokens = scanner.Scan(codeText);

			StringBuilder result = new StringBuilder("Scanner Output:\n");

			foreach (var token in tokens)
			{
				result.AppendLine(token.ToString());
			}

			MessageBox.Show(result.ToString(), "Scanner Output");
		}

		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
