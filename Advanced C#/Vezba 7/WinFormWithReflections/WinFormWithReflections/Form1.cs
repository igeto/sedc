using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWithReflections
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnGetMethodName_Click(object sender, EventArgs e)
        {
            var typeName = txtMethodName.Text;
            var methods = listOfMethods;
            var properties = listOfProperties;
            var constructors = listOfConstructors;

            Type type = Type.GetType(typeName);

            foreach (var method in type.GetMethods())
            {
                methods.Items.Add(method.ToString());
            }
            foreach (var property in type.GetProperties())
            {
                properties.Items.Add(property.Name);
            }
            foreach (var constructor in type.GetConstructors())
            {
                constructors.Items.Add(constructor.ToString());
            }
        }
    }
}
