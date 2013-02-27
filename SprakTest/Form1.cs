using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SprakTest
{
    public partial class Form1 : Form
    {
        private TabControl itemsTab;
        private Dictionary<string, Test> tests;
        private Logger logger;

        private int screenWidth;
        private int screenHeight;

        public Form1()
        {
            InitializeComponent();

            tests = new Dictionary<string, Test>();
            logger = new Logger();
            screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            LoadTests();
        }

        private void LoadTests()
        {
            // Fetch tests from Tests-folder
            string[] filePaths = Directory.GetFiles(@"Tests\");

            // Create one tab per test
            foreach (string fileName in filePaths)
            {
                TabPage newTab = AddTab(fileName);
                AddTest(fileName);
                
                AddContentToTab(newTab, fileName);
            }
        }

        private void AddTest(string fileName)
        {
            string fileExtension = fileName.Split('.')[1];

            switch (fileExtension)
            {
                case "ag":
                    tests.Add(fileName, new Anagram(fileName));
                    break;

                case "ls":
                    tests.Add(fileName, new Levenshtein(fileName));
                    break;
            }
        }

        private TabPage AddTab(string name)
        {
            // Add tab
            TabPage newTab = new TabPage();
            newTab.Name = name;

            newTab.Text = name.Split('\\')[1].Split('.')[0];
            this.TestTabs.Controls.Add(newTab);
            return newTab;
        }

        private void AddContentToTab(TabPage newTab, string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            string[] controls = lines[0].Split(':');

            string fileExtension = fileName.Split('.')[1];

            System.Windows.Forms.Button b;
            System.Windows.Forms.TrackBar tb;

            Size buttonSize = new Size(175, 40);

            switch (fileExtension)
            {
                case "ls":
                    string[] values = controls[0].Split('-');
                    values[1] = values[1].Remove(0, 1);
                
                    // Trackbar
                    tb = new TrackBar();
                    tb.Location = new System.Drawing.Point(screenWidth / 2 - 250, 350);
                    tb.Name = newTab.Name + "Trackbar";
                    tb.Width = 500;
                    tb.Minimum = int.Parse(values[0]);
                    tb.Maximum = int.Parse(values[1]);
                    tb.LargeChange = 0;
                    tb.ValueChanged += new System.EventHandler(ChangeTrackLabel);
                    newTab.Controls.Add(tb);

                    // Label
                    Label trackValueLabel = new Label();
                    trackValueLabel.Name = newTab.Name + "TrackbarLabel";
                    trackValueLabel.Text = tb.Value.ToString();
                    trackValueLabel.Font = new Font(trackValueLabel.Font.FontFamily, 14f);
                    trackValueLabel.Location = new System.Drawing.Point(tb.Location.X - 30, tb.Location.Y);
                    newTab.Controls.Add(trackValueLabel);

                    // Button
                    b = new Button();
                    b.Location = new System.Drawing.Point(tb.Location.X - (buttonSize.Width/2) + (tb.Width / 2), tb.Location.Y + 60);
                    b.Name = "button1";
                    b.Size = buttonSize;
                    b.Text = "Nästa";
                    b.UseVisualStyleBackColor = true;

                    b.Click += new System.EventHandler(EvalLeven);
                    newTab.Controls.Add(b);
                    break;

                case "ag":
                    int i = 0;
                    int numButtons = controls.Length;
                    int totalButtonWidth = (numButtons * buttonSize.Width) + (((numButtons - 1) * 10));
                    int leftStartPos = (screenWidth - totalButtonWidth)/2;

                    foreach (string buttonText in controls)
                    {
                        b = new Button();
                        b.Location = new System.Drawing.Point(leftStartPos + i, 350);
                        i += buttonSize.Width + 10;

                        b.Name = "button1";
                        b.Size = buttonSize;
                        b.Text = buttonText;
                        b.UseVisualStyleBackColor = true;

                        b.Click += new System.EventHandler(EvalAnagram);
                        newTab.Controls.Add(b);
                    }
                    break;
            }


            // Texts
            Label text1 = new Label();
            text1.BorderStyle = BorderStyle.FixedSingle;
            text1.Name = newTab.Name + "text1";
            text1.Location = new System.Drawing.Point(screenWidth / 2 - 350, 50);
            text1.Size = new Size(700, 70);
            text1.TextAlign = ContentAlignment.MiddleCenter;
            text1.Font = new Font(text1.Font.FontFamily, 30f);
            newTab.Controls.Add(text1);

            Label text2 = new Label();
            text2.BorderStyle = BorderStyle.FixedSingle;
            text2.Name = newTab.Name + "text2";
            text2.Location = new System.Drawing.Point(screenWidth / 2 - 350, 150);
            text2.Size = new Size(700, 70);
            text2.TextAlign = ContentAlignment.MiddleCenter;
            text2.Font = new Font(text2.Font.FontFamily, 30f);
            newTab.Controls.Add(text2);

            text1.Text = "Klicka på en knapp";
            text2.Text = "för att starta testet";

            KeyValuePair<string, string> nextPair = tests[newTab.Name].GetNextPair();
            ShowNewPair(newTab, nextPair);
        }

        private void EvalAnagram(object sender, EventArgs e)
        {
            // Parent Tab
            TabPage tab = ((TabPage)((Button)sender).Parent);

            // Evaluate answer, see if correct. Save stats
            string word1 = ((Label)tab.Controls.Find(tab.Name + "text1", false)[0]).Text;
            string word2 = ((Label)tab.Controls.Find(tab.Name + "text2", false)[0]).Text;
            
            int answer = ((Button)sender).Text.Equals("Ja") ? 1 : 0;

            bool CorrectAnswer = tests[tab.Name].Evaluate(word1, word2, answer);
            if (CorrectAnswer)
                Console.WriteLine("Rätt svar woho");

            // Fetch next word-pair and show it
            KeyValuePair<string, string> nextPair = tests[tab.Name].GetNextPair();
            ShowNewPair(tab, nextPair);

            if (nextPair.Key.Equals("") && nextPair.Value.Equals(""))
            {
                // test over, do something
                Label text1 = (Label)tab.Controls.Find(tab.Name + "text1", false)[0];
                text1.Text = "Test complete!";
                List<Button> buttons = new List<Button>();
                foreach (Control c in tab.Controls)
                {
                   if (c is Button)
                      buttons.Add((Button) c);
                }
                foreach (Button b in buttons)
                {
                   tab.Controls.Remove(b);
                }
                //tab.Controls.Remove((Button)sender);
                logger.save(tab.Name, (int)age_box.Value, man_radiobutton.Checked, tests[tab.Name]);
            }
        }

        private void EvalLeven(object sender, EventArgs e)
        {
            TabPage tab = ((TabPage)((Button)sender).Parent);
            TrackBar l = (TrackBar)tab.Controls.Find(tab.Name + "Trackbar", false)[0];

            // Evaluate answer, see if correct. Save stats
            string word1 = ((Label)tab.Controls.Find(tab.Name + "text1", false)[0]).Text;
            string word2 = ((Label)tab.Controls.Find(tab.Name + "text2", false)[0]).Text;

            bool CorrectAnswer = tests[tab.Name].Evaluate(word1, word2, l.Value);
            if (CorrectAnswer)
                Console.WriteLine("Rätt svar woho");

            KeyValuePair<string, string> nextPair = tests[tab.Name].GetNextPair();
            ShowNewPair(tab, nextPair);

            if (nextPair.Key.Equals("") && nextPair.Value.Equals(""))
            {
                // test over, do something
               Label text1 = (Label)tab.Controls.Find(tab.Name + "text1", false)[0];
               text1.Text = "Test complete!";
               foreach (Control c in tab.Controls)
               {
                  if (c is TrackBar)
                     tab.Controls.Remove((TrackBar) c);
               }
               tab.Controls.Remove((Button)sender);
               logger.save(tab.Name, (int)age_box.Value, man_radiobutton.Checked, tests[tab.Name]);
            }

        }

        void ShowNewPair(TabPage tab, KeyValuePair<string, string> kvp)
        {
            Label text1 = (Label)tab.Controls.Find(tab.Name + "text1", false)[0];
            text1.Text = kvp.Key;

            Label text2 = (Label)tab.Controls.Find(tab.Name + "text2", false)[0];
            text2.Text = kvp.Value;
        }

        private void ChangeTrackLabel(object sender, EventArgs e)
        {
            TabPage tab = ((TabPage)((TrackBar)sender).Parent);
            Label l = (Label)tab.Controls.Find(tab.Name + "TrackbarLabel", false)[0];
            l.Text = ((TrackBar)sender).Value.ToString();
        }

        private void age_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
