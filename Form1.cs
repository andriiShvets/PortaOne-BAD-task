namespace BAD_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            UniqueChars uniqueChars = new UniqueChars(TextBox.Text);
            label1.Visible = true;
            ResultLbl.Visible = true;
            ResultLbl.Text = uniqueChars.result.ToString();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            ResultLbl.Visible = false;
            ResultLbl.Text = "";
            TextBox.Text = String.Empty;
        }


    }
}