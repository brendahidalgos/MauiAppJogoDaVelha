namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X"; /*variável para controlar a vez de quem joga*/

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender; /*pega o botão que foi clicado*/

            btn.IsEnabled = false; /*desabilita o botão após ser clicado*/

            if (vez == "X") /*vez do X*/
            {
                btn.Text = "X"; /*o botão apertado vai receber o valor de X*/
                vez = "O"; /*o próximo a jogar*/
            }
            else /*senao é a vez de o*/
            {
                btn.Text = "O"; /*o botão apertado vai receber o valor de o*/
                vez = "X"; /*o próximo a jogar*/
            }

            /* horizontal */
            /*1 linha*/
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            /*2 linha*/
            if (btn13.Text == "X" && btn14.Text == "X" && btn15.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            if (btn13.Text == "O" && btn14.Text == "O" && btn15.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            /*3 linha*/
            if (btn16.Text == "X" && btn17.Text == "X" && btn18.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            if (btn16.Text == "O" && btn17.Text == "O" && btn18.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            /*diagonais*/
            /*esuqerda superior até direita inferior*/
            if (btn10.Text == "X" && btn14.Text == "X" && btn18.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            if (btn10.Text == "O" && btn14.Text == "O" && btn18.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            /*direita superior até esquerda inferior*/
            if (btn12.Text == "X" && btn14.Text == "X" && btn16.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            if (btn12.Text == "O" && btn14.Text == "O" && btn16.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            /*vertical*/
            /*1 coluna*/
            if (btn10.Text == "X" && btn13.Text == "X" && btn16.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            if (btn10.Text == "O" && btn13.Text == "O" && btn16.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            /*2 coluna*/
            if (btn11.Text == "X" && btn14.Text == "X" && btn17.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            if (btn11.Text == "O" && btn14.Text == "O" && btn17.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            /*3 coluna*/
            if (btn12.Text == "X" && btn15.Text == "X" && btn18.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            if (btn12.Text == "O" && btn15.Text == "O" && btn18.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }

        } // fecha método

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";
            btn15.Text = "";
            btn16.Text = "";
            btn17.Text = "";
            btn18.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn13.IsEnabled = true;
            btn14.IsEnabled = true;
            btn15.IsEnabled = true;
            btn16.IsEnabled = true;
            btn17.IsEnabled = true;
            btn18.IsEnabled = true;
        }

    } // fecha classe
} // fecha namespace

