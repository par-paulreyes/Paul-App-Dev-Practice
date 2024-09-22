using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DartPracticeApp
{
    public class SyntaxHighlighter
    {
        public void ApplySyntaxHighlighting(RichTextBox richTextBox)
        {
            // Define regex patterns for different elements, expanded for Dart-specific syntax and more variation
            string keywordsPattern = @"\b(abstract|else|import|super|as|enum|in|sync|await|extension|late|break|external|library|this|case|factory|mixin|throw|catch|class|final|try|const|finally|on|typedef|continue|for|operator|covariant|Function|part|void|default|get|required|while|deferred|hide|rethrow|with|do|if|return|yield|dynamic|implements|set|assert|bool|new|var|await|async|static|final|const)\b";
            string flowControlPattern = @"\b(if|else|for|while|switch|case|break|continue|return|yield|try|catch|finally|throw)\b";
            string typesPattern = @"\b(int|double|String|bool|List|Map|Set|void|var|dynamic)\b";
            string annotationsPattern = @"@\w+";  // Annotations like @override, @Deprecated
            string classPattern = @"\b[A-Z][a-zA-Z0-9_]*\b";  // Class names (start with uppercase)
            string constructorPattern = @"\b[A-Z][a-zA-Z0-9_]*\s*\(";  // Constructor pattern, e.g., MyClass()
            string staticMethodPattern = @"\bstatic\s+\w+\s*(?=\()";  // Static method pattern
            string functionPattern = @"\b\w+\s*(?=\()";  // Function names followed by ()
            string constantsPattern = @"\b(true|false|null|this|new)\b";  // Constants like true, false, null, this, new
            string enumValuesPattern = @"\b[A-Z_]+\b";  // Enum values (usually uppercase)
            string operatorsPattern = @"[+\-*/%=!<>&|^~]+";  // Operators
            string numbersPattern = @"\b\d+(\.\d+)?\b";  // Numbers (integers and decimals)
            string multilineStringsPattern = @"""([^""]|\r|\n)*""";  // Multiline strings in quotes
            string singleLineStringsPattern = "\".*?\"";  // Single-line strings
            string commentsPattern = @"(\/\/.*?$|\/\*[\s\S]*?\*\/)";  // Comments (single-line and multi-line)

            // Store the original selection and color
            int originalSelectionStart = richTextBox.SelectionStart;
            int originalSelectionLength = richTextBox.SelectionLength;
            Color originalColor = richTextBox.SelectionColor;

            // Clear all formatting
            richTextBox.SelectAll();
            richTextBox.SelectionColor = Color.Black;  // Default text color

            // Apply syntax coloring with even more colors and patterns
            ApplyColorToPattern(richTextBox, keywordsPattern, Color.Purple);            // Keywords in Purple
            ApplyColorToPattern(richTextBox, flowControlPattern, Color.Blue);           // Flow control keywords in Blue
            ApplyColorToPattern(richTextBox, typesPattern, Color.DarkOrange);           // Types in Dark Orange
            ApplyColorToPattern(richTextBox, annotationsPattern, Color.Green);          // Annotations in Green
            ApplyColorToPattern(richTextBox, classPattern, Color.DarkCyan);             // Class names in Dark Cyan
            ApplyColorToPattern(richTextBox, constructorPattern, Color.DarkCyan);       // Constructor methods in Dark Cyan
            ApplyColorToPattern(richTextBox, staticMethodPattern, Color.Teal);          // Static methods in Teal
            ApplyColorToPattern(richTextBox, functionPattern, Color.Teal);              // Function names in Teal
            ApplyColorToPattern(richTextBox, constantsPattern, Color.CornflowerBlue);   // Constants in Cornflower Blue
            ApplyColorToPattern(richTextBox, enumValuesPattern, Color.DarkMagenta);     // Enum values in Dark Magenta
            ApplyColorToPattern(richTextBox, operatorsPattern, Color.DarkRed);          // Operators in Dark Red
            ApplyColorToPattern(richTextBox, numbersPattern, Color.Magenta);            // Numbers in Magenta
            ApplyColorToPattern(richTextBox, multilineStringsPattern, Color.DarkRed);   // Multiline strings in Dark Red
            ApplyColorToPattern(richTextBox, singleLineStringsPattern, Color.Red);      // Single-line strings in Red
            ApplyColorToPattern(richTextBox, commentsPattern, Color.Gray);              // Comments in Gray

            // Restore the original selection and color
            richTextBox.SelectionStart = originalSelectionStart;
            richTextBox.SelectionLength = originalSelectionLength;
            richTextBox.SelectionColor = originalColor;
        }

        // Helper method to apply color to text matching a regex pattern
        private void ApplyColorToPattern(RichTextBox richTextBox, string pattern, Color color)
        {
            MatchCollection matches = Regex.Matches(richTextBox.Text, pattern, RegexOptions.Multiline);

            foreach (Match match in matches)
            {
                richTextBox.Select(match.Index, match.Length);
                richTextBox.SelectionColor = color;
            }
        }
    }
}
