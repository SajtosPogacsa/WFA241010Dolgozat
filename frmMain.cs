namespace WFA241010DolgozatBusaiDániel
{
    public partial class frmMain : Form
    {
        static Random rnd = new Random();
        Label[] labels = new Label[5];
        TextBox[] textBoxes = new TextBox[5];
        public frmMain()
        {
            InitializeComponent();
            btnGen.Click += BtnGenClick;
            btnCheck.Click += BtnCheckClick;
            btnClose.Click += BtnCloseClick;
            Label[] lblArray = { lblFirst, lblSecond, lblThird, lblFourth, lblFifth };
            labels = lblArray;
            TextBox[] tbxArray = { tbxFirst, tbxSecond, tbxThird, tbxFourth, tbxFifth };
            textBoxes = tbxArray;
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCheckClick(object sender, EventArgs e)
        {

            foreach (TextBox textbox in textBoxes)
            {
                bool check = int.TryParse(textbox.Text, out int _);
                if (!check)
                {
                    rtbInstructior.Text = "Nem minden beviteli mező formátuma megfelelő! Ellenőrizd és próbáld újra!";
                    return;
                }
            }

            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                if (int.Parse(textBoxes[i].Text) == (int)labels[i].Tag)
                {
                    labels[i].ForeColor = Color.Green;
                    counter++;
                }
                else
                {
                    labels[i].ForeColor = Color.Red;
                }
            }

            btnCheck.Enabled = false;
            rtbInstructior.Text = $"{counter} darab jó megoldásod van";
        }

        private void BtnGenClick(object sender, EventArgs e)
        {
            foreach (Label label in labels)
            {
                label.ForeColor = Color.Black;
                int num1 = rnd.Next(0, 10);
                char op = (rnd.Next(0, 2) == 0 ? '+' : '-');
                int num2 = rnd.Next(0, 10);
                int result = op switch
                {
                    '+' => num1 + num2,
                    '-' => num1 - num2,
                };
                label.Text = $"{num1} {op} {num2} =";
                label.Tag = (int)result;
            }
            tbxFirst.Enabled = true;
            tbxSecond.Enabled = true;
            tbxThird.Enabled = true;
            tbxFourth.Enabled = true;
            tbxFifth.Enabled = true;
            rtbInstructior.Text = "Töltsd ki a baloldali szövegdobozokat, ha végeztél kattints az Ellenőrzés gombra";
            btnCheck.Enabled = true;
        }
    }
}
