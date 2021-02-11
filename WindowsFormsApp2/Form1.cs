using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string VT;
        private string NT;
        private string S;
        private string P;

        private List<List<string>> rules;
        private List<char> index;
        private ArrayList sequence;
        private bool leftHand = true;

        private bool empty = false;

        public Form1()
        {
            InitializeComponent();

            LoadGrammar();
        }

        void LoadGrammar()
        {
                VT = "";
                NT = "";
                S = "";
                P = "";

                termT.Focus();
            
        }

        void RulesToList()
        {
            string[] temp = P.Split(new char[] { '\n' });
            index = new List<char>();

            for (int i = 0; i < temp.Length; i++)
            {
                index.Add(temp[i].ElementAt(0));
                temp[i] = temp[i].Substring(5).Replace(" ", String.Empty);
                string[] rule = temp[i].Split(new char[] { '|' });

                List<string> str = new List<string>();

                for (int j = 0; j < rule.Length; j++)
                {
                    str.Add(rule[j]);

                    if (rule[j] == "lam")
                    {
                        empty = true;
                    }
                }

                rules.Add(str);
            }
        }
        void Generate(string chain, int numTerminals)
        {
            if (empty)
            {
                if (numTerminals > numericUpDown2.Value)
                {
                    return;
                }
            }
            else
            {
                if (chain.Length > numericUpDown2.Value)
                {
                    return;
                }
            }

            bool terminal = true;

            if (leftHand)
            {
                for (int c = 0; c < chain.Length; c++)
                {
                    if (NT.Contains(chain[c]))
                    {
                        terminal = false;

                        for (int i = 0; i < rules[index.IndexOf(chain[c])].Count; i++)
                        {
                            string s;

                            if (rules[index.IndexOf(chain[c])][i] == "lam")
                            {
                                s = chain.Remove(c, 1);
                            }
                            else
                            {
                                s = chain.Remove(c, 1).Insert(c, rules[index.IndexOf(chain[c])][i]);
                            }
                            numTerminals = 0;

                            if (empty)
                            {
                                for (int j = 0; j < s.Length; j++)
                                {
                                    if (VT.Contains(s[j]))
                                    {
                                        numTerminals++;
                                    }
                                }
                            }

                            Generate(s, numTerminals);
                        }

                        break;
                    }
                }
            }
            else
            {
                for (int c = chain.Length - 1; c >= 0; c--)
                {
                    if (NT.Contains(chain[c]))
                    {
                        terminal = false;

                        for (int i = rules[index.IndexOf(chain[c])].Count - 1; i >= 0; i--)
                        {
                            string s = "";

                            if (rules[index.IndexOf(chain[c])][i] == "lam")
                            {
                                s = chain.Remove(c, 1);
                            }
                            else
                            {
                                s = chain.Remove(c, 1).Insert(c, rules[index.IndexOf(chain[c])][i]);
                            }

                            numTerminals = 0;

                            if (empty)
                            {
                                for (int j = 0; j < s.Length; j++)
                                {
                                    if (VT.Contains(s[j]))
                                    {
                                        numTerminals++;
                                    }
                                }
                            }

                            Generate(s, numTerminals);
                        }

                        break;
                    }
                }
            }

            if (terminal)
            {
                if (!sequence.Contains(chain) && chain.Length >= numericUpDown1.Value)
                {
                    sequence.Add(chain);
                }
            }
        }


        private void StorLev_CheckedChanged(object sender, EventArgs e)
        {
            if (StorLev.Checked)
            {
                leftHand = true;
            }
            else
            {
                leftHand = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            rules = new List<List<string>>();
            RulesToList();
            textResult.Clear();
            textResult.Enabled = false;
            sequence = new ArrayList();

            textResult.Text = "...";
            button11.Enabled = false;
            panel7.Enabled = false;
            panel8.Enabled = false;

            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 50;

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                numericUpDown1.Value = numericUpDown2.Value;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < numericUpDown1.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Generate(S, 0);
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = progressBar1.Minimum;

            progressBar1.Visible = false;
            button11.Enabled = true;
            panel7.Enabled = true;
            panel8.Enabled = true;
            textResult.Enabled = true;
            textResult.Clear();

            // show results
            string result = "";

            for (int i = 0; i < sequence.Count; i++)
            {
                result = result + sequence[i] + Environment.NewLine;
            }

            if (result.Length > 0)
            {
                textResult.Text = result.Remove(result.Length - 1, 1);
            }
        }

        private void addTerm_Click(object sender, EventArgs e)
        {
            if (termT.Text != "" && !VT.Contains(termT.Text) && !"| ".Contains(termT.Text))
            {
                if (VT.Length == 0)
                {
                    VT = termT.Text;
                }
                else
                {
                    VT = VT + ", " + termT.Text;
                }
            }

            labelTerm.Text = VT;
            termT.Text = "";
            neTermT.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (VT.Length > 0)
            {
                if (VT.Length == 1)
                {
                    VT = "";
                }
                else
                {
                    VT = VT.Remove(VT.Length - 3);
                }
            }

            labelTerm.Text = VT;
            termT.Text = "";
            termT.Focus();
        }

        private void addNeTerm_Click(object sender, EventArgs e)
        {
                if (NT.Length == 0)
                {
                    NT = neTermT.Text;
                }
                else
                {
                    NT = NT + ", " + neTermT.Text;
                }
            

            labelNeTerm.Text = NT;
            neTermT.Text = "";
            CelT.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NT.Length > 0)
            {
                if (NT.Length == 1)
                {
                    NT = "";
                }
                else
                {
                    NT = NT.Remove(NT.Length - 3);
                }
            }

            labelNeTerm.Text = NT;
            neTermT.Text = "";
            neTermT.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CelT.Text != "" && NT.Contains(CelT.Text))
            {
                if (S.Length == 0)
                {
                    S = CelT.Text;
                }
            }

            labelCel.Text = S;
            CelT.Text = "";
            CelPrav.Text = S;
            CelPrav.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (S.Length > 0)
            {
                S = "";
            }

            labelCel.Text = S;
            CelT.Text = "";
            CelPrav.Text = "";
            CelT.Focus();
        }

        private void CelPrav_TextChanged(object sender, EventArgs e)
        {
            if (!NT.Contains(CelPrav.Text.ToUpper()) || CelPrav.Text.Contains(','))
            {
                CelPrav.Text = "";
                CelPrav.Focus();
            }
            else
            {
                CelPrav.Text = CelPrav.Text.ToUpper();
                PravilaT.Focus();
            }

        }

        private void PravilaT_TextChanged(object sender, EventArgs e)
        {
            if (PravilaT.Text == "lam")
            {
                return;
            }
        }

        private void addPravila_Click(object sender, EventArgs e)
        {
            P = P + CelPrav.Text + " -> " + PravilaT.Text + '\n'.ToString();

            labelPrav.Text = P;

            PravilaT.Text = "";
            PravilaT.Focus();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (P.Length > 0)
            {
                int i = P.LastIndexOf(" -> ");

                P = P.Remove(i - 1);

                labelPrav.Text = P;
                PravilaT.Text = "";
                PravilaT.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (VT.Length > 0 && NT.Length > 0 && S.Length > 0 && P.Length > 0)
            {
                bool check = true;
                string temp = NT.Replace(" ", String.Empty);
                string[] nt = temp.Split(new char[] { ',' });

                for (int i = 0; i < nt.Length; i++)
                {
                    if (P.IndexOf(nt[i] + " -> ") == -1)
                    {
                        MessageBox.Show("Пожалуйста, введите данные для '" + nt[i].ToString() + "' !");
                        CelPrav.Text = nt[i];
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    CelPrav.Text = "";
                    P = P.Remove(P.Length - 1);
                    button11.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите все данные!");
            }
        }

        private void addEmpty_Click(object sender, EventArgs e)
        {
            PravilaT.Text = "lam";
        }

    }
}
