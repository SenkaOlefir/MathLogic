using LogicUnit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicPresentation
{
    public partial class Form1 : Form
    {
        private readonly Class1 _cl;
        public Form1()
        {
            InitializeComponent();
            _cl = new Class1();
        }

        private void AddExpressionButton_Click(object sender, EventArgs e)
        {
            this.AddExpressionToList();
        }

        private void CalculateExpressionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Int32? index = null;
                
                if (ExpressionList.SelectedIndex >= 0)
                {
                    index =  ExpressionList.SelectedIndex;
                }

                Boolean calculateResult = _cl.CalculateExpressions(index);

                String []variables = _cl.GetVariables().Select(v => String.Format("{0} = {1}", v.Key, v.Value)).ToArray();

                /*show variable list into form control*/
                VariableList.Items.Clear();
                VariableList.Items.AddRange(variables);

                /*show common resunt of calculation into label*/
                ResultLabel.Text = String.Format("Result = {0}", calculateResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String deletedExpression = ExpressionList.GetItemText(ExpressionList.SelectedItem);

            ExpressionList.Items.Remove(deletedExpression);
            _cl.DeleteExpression(deletedExpression);
        }

        private void ExpressionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*check if Enter button was pressed*/
            if (e.KeyChar == 13)
            {
                this.AddExpressionToList();
            }
        }

        private void AddExpressionToList()
        {
            String addedEexpression = ExpressionTextBox.Text;

            if (String.IsNullOrEmpty(addedEexpression) || String.IsNullOrWhiteSpace(addedEexpression))
            {
                MessageBox.Show("Expression cannot be null or empty");
                return;
            }

            try
            {
                _cl.AddExpression(addedEexpression);
                ExpressionList.Items.Add(addedEexpression);
                ExpressionTextBox.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Some exception thrown during parce entered expression. Expression can't added to list. Please check it");
            }
        }

        private void ForceCalculateExpressionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<String, Boolean> calculatedExpressions = _cl.ForceCalculateExpressions();

                String[] variables = _cl.GetVariables().Select(v => String.Format("{0} = {1}", v.Key, v.Value)).ToArray();

                String[] notCalculatedExpressions = ExpressionList.Items.OfType<String>()
                    .Where(ex => !calculatedExpressions.ContainsKey(ex)).ToArray();

                NotCalculatedExpressions.Items.Clear();
                NotCalculatedExpressions.Items.AddRange(notCalculatedExpressions);

                /*show variable list into form control*/
                VariableList.Items.Clear();
                VariableList.Items.AddRange(variables);

                Int32 selectedIndex = ExpressionList.SelectedIndex;

                if (selectedIndex >= 0)
                {
                    String markedExpression = ExpressionList.GetItemText(ExpressionList.Items[selectedIndex]);
                    ResultLabel.Text = (calculatedExpressions.ContainsKey(markedExpression))
                        ? String.Format("Result = {0}", calculatedExpressions[markedExpression])
                        : String.Format("Expression is not calculated");
                }
                else
                {
                    ResultLabel.Text = (calculatedExpressions.Count > 0)
                        ? String.Format("Result = {0}", calculatedExpressions.Last().Value)
                        : String.Format("Not exist calculated expressions");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
