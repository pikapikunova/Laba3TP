using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        ClassLibrary.IClass class2;
        ClassLibrary.Person person = new ClassLibrary.Person();

        public Form1(ClassLibrary.IClass classin)
        {
            InitializeComponent();
            class2 = classin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = class2.second(person, comboBox1.Text, Convert.ToInt32(textBox5.Text)).ToString();
                textBox4.Text = Convert.ToInt32(class2.third(person, comboBox1.Text, Convert.ToInt32(textBox5.Text))).ToString();
                textBox2.Text = class2.first(person).ToString();
                class2.sellInBd(person.ID, class2.first(person), class2.second(person, comboBox1.Text, Convert.ToInt32(textBox5.Text)), Convert.ToInt32(class2.third(person, comboBox1.Text, Convert.ToInt32(textBox5.Text))));
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EndpointNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                person = class2.GetPerson(Convert.ToInt32(textBox1.Text));

                textBox6.Text = person.growth.ToString();
                textBox7.Text = person.gender.ToString();
                textBox8.Text = person.age.ToString();
                textBox9.Text = person.weight.ToString();
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EndpointNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }
    }
}
  