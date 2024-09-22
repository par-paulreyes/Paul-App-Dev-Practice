using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DartPracticeApp
{
    public partial class Form1 : Form
    {
        private List<Problem> problems;
        private int score = 0;
        private string selectedDifficulty = "All"; // To track selected difficulty level

        public Form1()
        {
            InitializeComponent();
            InitializeProblems();
            InitializeDifficultyLevels(); // Initialize levels in ComboBox
            txtCodeDisplay.Visible = false;
        }

        private void InitializeProblems()
        {
            problems = ProblemList.GetProblems(); // Fetch problems from ProblemList class
            PopulateProblemComboBox(); // Populate ComboBox with filtered problems based on difficulty
        }

        private void InitializeDifficultyLevels()
        {
            // Add levels to comboBoxLevel
            comboBoxLevel.Items.Add("All");
            comboBoxLevel.Items.Add("Easy");
            comboBoxLevel.Items.Add("Medium");
            comboBoxLevel.Items.Add("Hard");

            comboBoxLevel.SelectedIndex = 0; // Default to 'All' levels
        }

        private void PopulateProblemComboBox()
        {
            comboBoxProblems.Items.Clear(); // Clear before adding filtered problems

            foreach (var problem in problems)
            {
                // Add to ComboBox only if the problem matches the selected difficulty
                if (selectedDifficulty == "All" || problem.DifficultyLevel == selectedDifficulty)
                {
                    comboBoxProblems.Items.Add(problem.GetProblem);
                }
            }

            comboBoxProblems.SelectedIndex = comboBoxProblems.Items.Count > 0 ? 0 : -1; // Select first item if available
        }

        private void comboBoxProblems_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtProblemDescription.Clear();
            txtCodeDisplay.Clear();
            txtOutput.Clear();
            if (comboBoxProblems.SelectedIndex != -1)
            {
                var selectedProblem = problems[comboBoxProblems.SelectedIndex];
                txtProblemDescription.Text = $"{selectedProblem.GetDescription} {Environment.NewLine}Expected Output: {selectedProblem.GetExpectedOutput}";
                txtCodeDisplay.Text = selectedProblem.GetCode; // Update code display dynamically
            }
        }

        private void btnRunCode_Click(object sender, EventArgs e)
        {
            string dartCode = txtCodeInput.Text;
            string tempFilePath = Path.Combine(Path.GetTempPath(), "temp_dart_code.dart");
            File.WriteAllText(tempFilePath, dartCode);
            RunDartCode(tempFilePath);
        }

        private void RunDartCode(string filePath)
        {
            ProcessStartInfo startInfo = CreateProcessStartInfo(filePath);

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    txtOutput.Clear();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    HandleProcessOutput(output, error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private ProcessStartInfo CreateProcessStartInfo(string filePath)
        {
            return new ProcessStartInfo
            {
                FileName = "dart",
                Arguments = $"\"{filePath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
        }

        private void HandleProcessOutput(string output, string error)
        {
            if (!string.IsNullOrEmpty(error))
            {
                txtOutput.Text = $"Error: {error}";
            }
            else
            {
                txtOutput.Text = output;
                CheckOutput(output);
            }
        }

        private void CheckOutput(string output)
        {
            var selectedProblem = problems[comboBoxProblems.SelectedIndex];
            string expectedOutput = selectedProblem.GetExpectedOutput;

            if (output.Trim() == expectedOutput.Trim())
            {
                if (!selectedProblem.IsSolved) // Only increment score if the problem is unsolved
                {
                    score += selectedProblem.ScoreValue; // Add the score based on problem difficulty
                    txtScore.Text = score.ToString();
                    selectedProblem.IsSolved = true; // Mark problem as solved
                    MessageBox.Show($"Correct! You've earned {selectedProblem.ScoreValue} points! Your total score is: {score}");

                }
                else
                {
                    MessageBox.Show($"You've already solved this problem.");
                }
            }
            else
            {
                MessageBox.Show($"Incorrect. Try again!");
            }
        }

        private bool isCodeVisible = true;
        private void btnShowCode_Click(object sender, EventArgs e)
        {
            isCodeVisible = !isCodeVisible; // Toggle the visibility state
            txtCodeDisplay.Visible = isCodeVisible;
            btnShowCode.Text = isCodeVisible ? "Hide Code" : "Show Code";
        }

        // Change problem difficulty level based on selection
        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProblemDescription.Clear();
            txtCodeDisplay.Clear();
            txtOutput.Clear();
            selectedDifficulty = comboBoxLevel.SelectedItem.ToString(); // Get the selected difficulty level
            PopulateProblemComboBox(); // Re-populate the ComboBox with problems of the selected difficulty
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before closing
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
