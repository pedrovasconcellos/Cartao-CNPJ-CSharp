using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using CartaoCNPJ.Validacoes;

namespace CartaoCNPJ
{
    public partial class U_CARTAOCNPJ : Form
    {
        private static readonly ClassCNPJ iCNPJ = new ClassCNPJ();
        private string cnpj;
        private string tipoArquivo;
        private string folder
        {
            get
            {
                return @"C:\www.vasconcellos.site\Cartao-CNPJ\";
            }
        }
        private string username;
        private string password;

        private void SetCNPJ(string cnpj){ this.cnpj = iCNPJ.SemFormatacao(cnpj); }
        private void SetTipoDoArquivo(string tipoArquivo){ this.tipoArquivo = tipoArquivo; }
        private void SetUsername(string username){ this.username = username; }
        private void SetPassword(string password){ this.password = password; }

        public U_CARTAOCNPJ()
        {
            InitializeComponent();
            cbxTipoArquivo.SelectedIndex = 0;
            DateTime thisDay = DateTime.Today;
            lblCopyRight.Text = String.Concat("Copyright © ",thisDay.Year," Vasconcellos IT Solutions");
        }

        private void btnCNPJ_Click(object sender, EventArgs e)
        {// ------------btn

            string textoCNPJ = "";
            txtMensagens.Text = "";
            SetCNPJ(txtCNPJNum.Text);

            while (!iCNPJ.IsCnpj(cnpj))
            {
                MessageBox.Show("Por favor escreva um número de CNPJ válido!");
                return;
            }

            //São apenas 70% dos CNPJs existentes que estão disponíveis sem a utilização do Token da ReceitaWS
            //Para acessar todos os CNPJs existentes, é necessário obter um token no link (www.receitaws.com.br).
            string webserviceURL = String.Concat("https://www.receitaws.com.br/v1/cnpj/",cnpj);
            // Criar uma nova solicitação para o URL mencionada.				
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(webserviceURL);

            // Obter o 'proxy' do navegador padrão.  
            IWebProxy proxy = myWebRequest.Proxy;

            WebProxy myProxy = new WebProxy();

            string proxyAddress = "";
            proxyAddress = Convert.ToString(proxy.GetProxy(myWebRequest.RequestUri));

            string strA = proxyAddress; //Pode ser apagado. Apenas está obtendo o PROXY automaticamente
            string strB = webserviceURL;

            if (String.Compare(strA, strB) == 0)
            {
                txtMensagens.Text = String.Concat(txtMensagens.Text, 
                    "Obs.: Este usuário não está usando Proxy.", Environment.NewLine, Environment.NewLine);
            }
            else
            {//-------else-pegando proxy
                MessageBox.Show(String.Concat(
                    "Por favor insira o Username e o Password do seu Proxy: ",
                    Convert.ToString(proxy.GetProxy(myWebRequest.RequestUri)) )
                    );
                proxyAddress = Convert.ToString(proxy.GetProxy(myWebRequest.RequestUri)); //RECEBENDO O PROXY SEM PRECISAR DIGITAR
                //Exemplo:http://myproxy.example.com:port

                try
                {
                    if (proxyAddress.Length > 0)
                    {
                        if (txtUsernameProxy.Text =="")
                        {
                            txtMensagens.Text = String.Concat(txtMensagens.Text, 
                                " É necessário colocar o nome do usuário proxy.", Environment.NewLine, Environment.NewLine);
                            return;
                        }
                        if (txtPasswordProxy.Text =="")
                        {
                            txtMensagens.Text = String.Concat(txtMensagens.Text, 
                                " É necessário colocar a senha do usuário proxy.", Environment.NewLine, Environment.NewLine);
                            return;
                        }
                        SetUsername(txtUsernameProxy.Text);
                        SetPassword(txtPasswordProxy.Text);
                        // Criar um novo objeto Uri.
                        Uri newUri = new Uri(proxyAddress);
                        // Associar o novo objeto Uri para objeto 'myProxy' para que as novas configurações myproxy possa ser definida.
                        myProxy.Address = newUri;
                        // Criar um objeto NetworkCredential e associá-lo com o 
                        // Propriedade Proxy de pedido de objeto.
                        myProxy.Credentials = new NetworkCredential(username, password);
                        myWebRequest.Proxy = myProxy;
                    }
                    txtMensagens.Text = String.Concat(txtMensagens.Text, 
                        " PROXY ", Convert.ToString(myProxy.Address), Environment.NewLine + Environment.NewLine);
                }
                catch 
                {
                    MessageBox.Show("\nERRO. Problema ao tentar autenticar PROXY!");
                    return;
                }
            }//-------else-pegando proxy


            //--------------------------------------SERVIDOR - Início
            try
            {
                // Obter a resposta.
                HttpWebResponse response = (HttpWebResponse)myWebRequest.GetResponse();
                // Apresentar o estado.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Obter o conteúdo devolvido pelo servidor.
                Stream dataStream = response.GetResponseStream();
                // Abre o fluxo usando um StreamReader para facilitar o acesso.
                StreamReader reader = new StreamReader(dataStream);
                // Leia o conteudo.
                string responseFromServer = reader.ReadToEnd();
                // Exibir o conteúdo.
                MessageBox.Show(responseFromServer);
                textoCNPJ = Convert.ToString(responseFromServer);
                // Limpar os streams e as respostas.
                reader.Close();
                response.Close();

                GerarArquivo(textoCNPJ,cnpj);
            }
            catch 
            {
                txtMensagens.Text = String.Concat(txtMensagens.Text,
                    "O CNPJ não foi encontrado, verifique as informações desse CNPJ no Site http://www.receita.fazenda.gov.br/");
                txtMensagens.Text = String.Concat(txtMensagens.Text,Environment.NewLine,Environment.NewLine);
                return;
            }
            //-----------------------------------------------SERVIDOR - Fim

        }// ----------btn--Gerar--Cartão--CNPJ

        public void GerarArquivo(string textoCNPJ, string cnpj)
        {
            //---Gerando Cartão-CNPJ.TXT
            SetTipoDoArquivo(cbxTipoArquivo.Text);
            if (!Directory.Exists(folder))
            {

                Directory.CreateDirectory(folder);

            }
            DateTime data = DateTime.Now;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(String.Concat(folder,"Cartão-CNPJ-",cnpj,tipoArquivo)) )
            {
                file.Write(textoCNPJ);
                txtMensagens.Text = txtMensagens.Text + String.Concat(
                    "O ", tipoArquivo, " do Cartão CNPJ foi gerado com sucesso! O seu arquivo foi salvo no diretório ",
                    folder, Environment.NewLine, Environment.NewLine);
            }
            //---Gerando Cartão-CNPJ.TXT
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            txtMensagens.Text = "";
            Close();
        }

        private void btnAbrirCNPJ_Click(object sender, EventArgs e)
        {//---btn--Abrir

            txtMensagens.Text = "";
            SetCNPJ(txtCNPJNum.Text);
            SetTipoDoArquivo(cbxTipoArquivo.Text);
            if (Directory.Exists(folder))
            {//----Abrir--Arquivo
                try
                {
                    System.Diagnostics.Process.Start(String.Concat(folder,"Cartão-CNPJ-",cnpj,tipoArquivo));
                }
                catch
                {
                    MessageBox.Show(String.Concat("O Cartão CNPJ não foi encontrada !",Environment.NewLine, 
                        "Por favor informe a numeração do CNPJ no campo Número do CNPJ."));
                }
            }//----Abrir--Arquivo
            else { MessageBox.Show(String.Concat("Diretório ",folder," não existe")); }
        }//---btn--Abrir

        private void btnAbrirDiretorio_Click(object sender, EventArgs e)
        {//--btn--Abri--Diretório

            txtMensagens.Text = "";
            try
            {
                System.Diagnostics.Process.Start(folder);
            }
            catch
            {
                MessageBox.Show("O diretório não foi encontrado.");
            }

        }//--btn--Abri--Diretório

        private void btnHelp_Click(object sender, EventArgs e)
        {
            StringBuilder stringHelper = new StringBuilder();

            stringHelper.Append("O Cartão CNPJ será gerado no diretório ");
            stringHelper.AppendLine(folder);
            stringHelper.AppendLine();
            stringHelper.AppendLine("O Programa possuí o objetivo de gerar o cartão CNPJ em formato .JSON ou .TXT.");
            stringHelper.AppendLine();
            stringHelper.AppendLine("Após preencher os dados CNPJ e Tipo De Arquivo, o usuário deverá clicar em Solicitar Cartão CNPJ.");
            stringHelper.AppendLine();
            stringHelper.AppendLine(
                String.Concat("Se caso o usuário possuir Proxy em sua rede de conexão, ",
                "ele deverá autenticar com Username e Password através dos campos abaixo para que a aplicação funcione corretamente."));
            stringHelper.AppendLine();
            stringHelper.AppendLine(
                String.Concat("Para usar o botão Abrir Cartão CNPJ, é necessário o Usuário já tenha gerado o Cartão CNPJ ",
                "préviamente, e tenha preenchido somente os números do CNPJ no campo Número do CNPJ."));
            MessageBox.Show(stringHelper.ToString());
            txtMensagens.Text = stringHelper.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vasconcellossolutions.com");
        }

        private void txtCNPJNum_KeyPress(object sender, KeyPressEventArgs e)
        {//-------KeyPressSomenteDIGITO
            if ( (!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)8) && (e.KeyChar < 45 || e.KeyChar > 47) )
            {
                MessageBox.Show("Dentro do campo Número do CNPJ serão aceito apenas números.");
                e.Handled = true;
            }
        }//-------KeyPressSomenteDIGITO

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMensagens.Text = "";
            txtCNPJNum.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vasconcellossolutions.com");
        }

        private void btnControlV_Click(object sender, EventArgs e)
        {
            SetCNPJ(Clipboard.GetText());
            if (iCNPJ.IsCnpj(cnpj))
            {
                txtCNPJNum.Text = cnpj;
            }
            else
            {
                MessageBox.Show("A área de transferência não possui um CNPJ Válido!\nPor favor tente novamente");
            }
        }

    }//--U_CARTAOCNPJ

}//===NAMESPACE
