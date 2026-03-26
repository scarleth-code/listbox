using System.Dynamic;

namespace lisbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbcontinente.SelectedIndex == -1)
            {
                MessageBox.Show("debe seleccionar un continente",
                "Uso de listbox");
            }

            lstpais.Items.Clear();
            switch (cmbcontinente.SelectedItem.ToString())
            {


                case "America":
                    lstpais.Items.Add("Honduras");
                    lstpais.Items.Add("Brasil");
                    lstpais.Items.Add("Canada");
                    break;

                case "Europa":
                    lstpais.Items.Add("España");
                    lstpais.Items.Add("Italia");
                    lstpais.Items.Add("Suiza");
                    break;

                case "Asia":
                    lstpais.Items.Add("Japon");
                    lstpais.Items.Add("China");
                    lstpais.Items.Add("India");
                    break;
            }
        }
           

            
            






        private void Form1_Load(object sender, EventArgs e)
        {
            cmbcontinente.Items.Add("America");
            cmbcontinente.Items.Add("Europa");
            cmbcontinente.Items.Add("Asia");
        }

        private void btcopiar_Click(object sender, EventArgs e)
        {

            if (lstpais.SelectedIndex == -1)
            {
                MessageBox.Show("debe seleccionar un pais",
                    "uso de listbox");
                return;

            }
            string pais = lstpais.SelectedItem.ToString();
            lstlista.Items.Add(pais);
            lstpais.Items.Remove(pais);
        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            if (lstlista.SelectedIndex == -1)
            {
                MessageBox.Show("debe seleccionar un pais",
                    "uso de listbox");
                return;

            }
            string pais = lstlista.SelectedItem.ToString();
            lstlista.Items.Remove(pais);
            
        }
    }
}
