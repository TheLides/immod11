using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public List<double> stat;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            stat = new List<double>() { 0, 0, 0, 0, 0};
            chart1.Series[0].Points.Clear();
            List<double> probs = new List<double>() {
                (double) prob1.Value,
                (double) prob2.Value,
                (double) prob3.Value,
                (double) prob4.Value,
                (double) prob5.Value
            };
            int days = (int)daysNumeric.Value;
            if (probs[0] + probs[1] + probs[2] + probs[3] + probs[4] > 1)
            {
                MessageBox.Show("Probabilities summ should be less than 1");
            }
            else
            {
                double e0 = 0, d0 = 0;
                for (int i = 0; i < probs.Count; i++)
                {
                    e0 += (i + 1) * probs[i];
                    d0 += (i + 1) * (i + 1) * probs[i];
                }
                d0 -= e0 * e0;

                var ans = Count(days, probs);
                var mat = average(ans);
                var disp = variance(ans, mat);
                var xiRes = xi(probs, days);
                var matError = countError(mat, e0);
                var dispError = countError(disp, d0);

                Show(probs, ans, mat, disp, xiRes, matError, dispError);
            }
            
        }

        private void Show (List<double> probs, List<double> ans, double mat, double disp, double xiRes, double matError, double dispError)
        {
            for (var i = 0; i < probs.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, ans[i]);
            }
            averageLabel.Text = mat.ToString();
            varietyLabel.Text = disp.ToString();
            xiLabel.Text = xiRes.ToString();
            averageError.Text = matError.ToString();
            varienceError.Text = dispError.ToString();
            chart1.Series[0].IsValueShownAsLabel = true;
        }

        private List<double> Count(int d, List<double> pr)
        {
            List<double> result = new List<double>() { 0, 0, 0, 0, 0};
            for (var i = 0; i < d; i++)
            {
                var current = rnd.NextDouble();
                for (int j = 0; j < pr.Count; j++)
                {
                    current -= pr[j];
                    if (current < 0)
                    {
                        stat[j]++;
                        break;
                    }
                }
            } 
            
            for (var i = 0; i < result.Count; i++)
            {
                result[i] = (double) stat[i] / d;
            }
            return result;
        }
        private double average (List<double> freq)
        {
            double ans = 0;
            for (int i = 0; i < freq.Count; i++)
            {
                ans += (i + 1) * freq[i];
            }
            return ans;
        }

        private double variance (List<double> freq, double e)
        {
            double ans = 0;
            for (int i = 0; i < freq.Count; i++)
                ans += (i + 1) * (i + 1) * freq[i];
            ans -= e * e;

            return ans;
        }

        private double xi (List<double> probs, int days)
        {
            double ans = 0;
            for (int i = 0; i < probs.Count; i++) { 
                ans += Math.Pow(stat[i], 2) / (days * probs[i]);
            }
            ans -= days;

            return ans;
        }

        private double countError (double i, double i0)
        {
            return Math.Abs(i - i0) * 100 / Math.Abs(i0);
        }
    }
}
