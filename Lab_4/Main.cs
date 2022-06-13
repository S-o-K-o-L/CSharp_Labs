using Lav_4_Lights;
using System.Reflection;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            assembly = Assembly.Load("Lav_4_Lights");
            types = assembly.GetTypes().Where(type => !type.IsAbstract && type.GetInterface("ILightSource") != null);
            ÑlassComboBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }

        Assembly assembly;
        IEnumerable<Type> types;
        Type currentType;
        object currentObject;
        MethodInfo currentMethod;
        object[] methodParameters;

        private void ÑlassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputParametrs.Enabled = false;
            ExecuteMethod.Enabled = false;
            Methods.Items.Clear();
            Info.Items.Clear();
            Parametrs.Items.Clear();

            currentType = types.First(type => type.Name == ÑlassComboBox.SelectedItem.ToString());
            currentObject = null;

            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);

            Methods.Items.AddRange(currentType.GetMethods().Where(method => !objectMethods.Contains(method.Name)
                && !method.Name.Contains("get_") && !method.Name.Contains("set_")).Select(method => method.Name).ToArray());

            Methods.Enabled = false;
            Add.Enabled = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Info.Items.Clear();
            Methods.Enabled = true;
            ExecuteMethod.Enabled = false;
            Parametrs.Enabled = false;

            Form addInfo = new Form();
            addInfo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            addInfo.MaximizeBox = false;
            addInfo.MinimizeBox = false;
            addInfo.ClientSize = new Size(400, 280);
            object newObject = Activator.CreateInstance(currentType);
            int position = 5;
            foreach (PropertyInfo info in newObject.GetType().GetProperties())
            {
                Label label = new Label { Top = position, Left = 0, Width = addInfo.ClientSize.Width / 2, Height = 20 };
                label.Text = info.Name;
                TextBox textBox = new TextBox { Top = position, Left = label.Width, Width = label.Width, Height = 20 };
                textBox.Text = "0";
                addInfo.Controls.Add(label);
                addInfo.Controls.Add(textBox);
                position += label.Height + 10;
            }
            addInfo.Controls.Add(new Button() { Top = 220, Left = 130, Width = 100, Height = 50, Text = "Îê" });
            addInfo.Controls[addInfo.Controls.Count - 1].Click += new EventHandler((object sender2, EventArgs e2) => { addInfo.DialogResult = DialogResult.OK; addInfo.Close(); });
            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                PropertyInfo[] infoProperty = newObject.GetType().GetProperties();
                for (int i = 1, j = 0; i < addInfo.Controls.Count; i += 2, j++)
                {
                    string value = addInfo.Controls[i].Text;
                    try
                    {
                        if (value.Length != 0)
                        {
                            if (infoProperty[j].PropertyType.Name == "Int32")
                                infoProperty[j].SetValue(newObject, int.Parse(value));
                            else
                                infoProperty[j].SetValue(newObject, value);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Íåêîððåêòíûé ââîä!");
                    }
                }
            }
            currentObject = newObject;
            foreach (PropertyInfo info in currentType.GetProperties())
            {
                Info.Items.Add(info.Name + ": " + info.GetValue(currentObject));
            }
        }

        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMethod = currentType.GetMethods().First(method => method.Name == Methods.SelectedItem.ToString());
            methodParameters = null;
            ExecuteMethod.Enabled = false;
            if (currentMethod.GetParameters().Length == 0)
            {
                InputParametrs.Enabled = false;
                ExecuteMethod.Enabled = currentObject != null;
            }
            else
            {               
                ExecuteMethod.Enabled = false;
                Parametrs.Enabled = true;
            }
            Parametrs.Items.Clear();
            foreach (ParameterInfo info in currentMethod.GetParameters())
            {
                Parametrs.Items.Add(info.Name);
            }
        }

        private void InputParametrs_Click(object sender, EventArgs e)
        {
            if (Parametrs.SelectedIndex != -1)
            {
                Parametrs.Items.Clear();
                Form addParams = new Form();
                addParams.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                addParams.MaximizeBox = false;
                addParams.MinimizeBox = false;
                addParams.ClientSize = new Size(300, 100);
                int position = 0;
                foreach (ParameterInfo info in currentMethod.GetParameters())
                {
                    Label label = new Label { Top = position, Left = 0, Width = addParams.ClientSize.Width / 2, Height = 20 };
                    label.Text = info.ToString();
                    TextBox textBox = new TextBox { Top = position, Left = label.Width, Width = label.Width, Height = 20 };
                    textBox.Text = "0";
                    addParams.Controls.Add(label);
                    addParams.Controls.Add(textBox);
                    position += label.Height + 5;
                }
                addParams.Controls.Add(new Button() { Top = 50, Left = 100, Width = 100, Height = 50, Text = "Îê" });
                addParams.Controls[addParams.Controls.Count - 1].Click += new EventHandler((object sender1, EventArgs e1) => { addParams.DialogResult = DialogResult.OK; addParams.Hide(); });
                if (addParams.ShowDialog() == DialogResult.OK)
                {
                    List<object> parameters = new List<object>();
                    for (int i = 1; i < addParams.Controls.Count - 1; i += 2)
                    {
                        try
                        {
                            string value = addParams.Controls[i].Text;
                            parameters.Add(int.Parse(value));
                            Parametrs.Items.Add(addParams.Controls[i - 1].Text + ": " + value);
                            ExecuteMethod.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Íåêîððåêòíûå äàííûå!");
                            Parametrs.Items.Add(addParams.Controls[i - 1].Text);
                            ExecuteMethod.Enabled = false;
                        }
                    }
                    methodParameters = parameters.ToArray();
                }
            }
        }

        private void ExecuteMethod_Click(object sender, EventArgs e)
        {
            InputParametrs.Enabled = false;
            if (currentMethod.ReturnType == typeof(void))
            {
                currentMethod.Invoke(currentObject, methodParameters);
                MessageBox.Show("Ìåòîä âûïîëíåí óñïåøíî!");
            }
            else
            {
                MessageBox.Show(currentMethod.Invoke(currentObject, methodParameters).ToString());
            }
        }

        private void Parametrs_MouseClick(object sender, MouseEventArgs e)
        {
            InputParametrs.Enabled = true;
        }
    }
}