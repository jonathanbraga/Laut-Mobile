using Plugin.Messaging;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laut.ViewModels
{
	public class FormPageViewModel : BindableBase
	{
        #region Binding
        #region Automação Predial
        private string _responsavel;
        public string Responsavel
        {
            get { return _responsavel; }
            set { SetProperty(ref _responsavel, value); }
        }

        private bool _pessoaJurídica;
        public bool PessoaJuridica
        {
            get { return _pessoaJurídica; }
            set { SetProperty(ref _pessoaJurídica, value); }
        }

        private bool _pessoaFisica;
        public bool PessoaFisica
        {
            get { return _pessoaFisica; }
            set { SetProperty(ref _pessoaFisica, value); }
        }

        private string _endereco;
        public string Endereco
        {
            get { return _endereco; }
            set { SetProperty(ref _endereco, value); }
        }

        private string _cep;
        public string CEP
        {
            get { return _cep; }
            set { SetProperty(ref _cep, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _telefone;
        public string Telefone
        {
            get { return _telefone; }
            set { SetProperty(ref _telefone, value); }
        }

        private bool _residencial;
        public bool Residencial
        {
            get { return _residencial; }
            set { SetProperty(ref _residencial, value); }
        }

        private bool _comercial;
        public bool Comercial
        {
            get { return _comercial; }
            set { SetProperty(ref _comercial, value); }
        }

        private bool _condominio;
        public bool Condominio
        {
            get { return _condominio; }
            set { SetProperty(ref _condominio, value); }
        }

        private bool _industria;
        public bool Industria
        {
            get { return _industria; }
            set { SetProperty(ref _industria, value); }
        }

        private bool _predial;
        public bool Predial
        {
            get { return _predial; }
            set { SetProperty(ref _predial, value); }
        }

        //Tipo do serviço
        private bool _segurancaEletronica;
        public bool SegurancaEletronica
        {
            get { return _segurancaEletronica; }
            set { SetProperty(ref _segurancaEletronica, value); }
        }

        private bool _circuitoFechado;
        public bool CircuitoFechado
        {
            get { return _circuitoFechado; }
            set { SetProperty(ref _circuitoFechado, value); }
        }

        private bool _reusoAgua;
        public bool ReusoAgua
        {
            get { return _reusoAgua; }
            set { SetProperty(ref _reusoAgua, value); }
        }

        private bool _geracaoEnergia;
        public bool GeracaoEnergia
        {
            get { return _geracaoEnergia; }
            set { SetProperty(ref _geracaoEnergia, value); }
        }

        private string _valorCota;
        public string ValorCota
        {
            get { return _valorCota; }
            set { SetProperty(ref _valorCota, value); }
        }

        private string _consumo;
        public string Consumo
        {
            get { return _consumo; }
            set { SetProperty(ref _consumo, value); }
        }

        private bool _inclinado;
        public bool Inclinado
        {
            get { return _inclinado; }
            set { SetProperty(ref _inclinado, value); }
        }

        private bool _platibanda;
        public bool Platibanda
        {
            get { return _platibanda; }
            set { SetProperty(ref _platibanda, value); }
        }

        private string _area;
        public string Area
        {
            get { return _area; }
            set { SetProperty(ref _area, value); }
        }
        #endregion

        #region Avaliação e Sintonia
        private string _nomeEmpresa;
        public string NomeEmpresa
        {
            get { return _nomeEmpresa; }
            set { SetProperty(ref _nomeEmpresa, value); }
        }

        private string _nomeResponsavel;
        public string NomeResponsavel
        {
            get { return _nomeResponsavel; }
            set { SetProperty(ref _nomeResponsavel, value); }
        }

        private string _enderecoSintonia;
        public string EnderecoSintonia
        {
            get { return _enderecoSintonia; }
            set { SetProperty(ref _enderecoSintonia, value); }
        }

        private string _emailSintonia;
        public string EmailSintonia
        {
            get { return _emailSintonia; }
            set { SetProperty(ref _emailSintonia, value); }
        }

        private string _telefoneSintonia;
        public string TelefoneSintonia
        {
            get { return _telefoneSintonia; }
            set { SetProperty(ref _telefoneSintonia, value); }
        }

        //Tipo Serviço
        private bool _avaliacaoMalha;
        public bool AvaliacaoMalha
        {
            get { return _avaliacaoMalha; }
            set { SetProperty(ref _avaliacaoMalha, value); }
        }

        private bool _sintoniaMalha;
        public bool SintoniaMalha
        {
            get { return _sintoniaMalha; }
            set { SetProperty(ref _sintoniaMalha, value); }
        }

        private bool _avaliacaoSintonia;
        public bool AvaliacaoSintonia
        {
            get { return _avaliacaoSintonia; }
            set { SetProperty(ref _avaliacaoSintonia, value); }
        }

        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { SetProperty(ref _descricao, value); }
        }

        //Numero de Malhas de Controle
        private string _malhaTemperatura;
        public string MalhaTemperatura
        {
            get { return _malhaTemperatura; }
            set { SetProperty(ref _malhaTemperatura, value); }
        }

        private string _malhaNivel;
        public string MalhaNivel
        {
            get { return _malhaNivel; }
            set { SetProperty(ref _malhaNivel, value); }
        }

        private string _malhaPressao;
        public string MalhaPressao
        {
            get { return _malhaPressao; }
            set { SetProperty(ref _malhaPressao, value); }
        }

        private string _malhaVazao;
        public string MalhaVazao
        {
            get { return _malhaVazao; }
            set { SetProperty(ref _malhaVazao, value); }
        }

        private string _outraMalha;
        public string OutraMalha
        {
            get { return _outraMalha; }
            set { SetProperty(ref _outraMalha, value); }
        }
        #endregion
        #endregion

        #region Command
        public DelegateCommand SendEmailAutomacaoPredialCommand { get; set; }
        public DelegateCommand SendEmailSintoniaCommand { get; set; }
        #endregion

        public FormPageViewModel()
        {
            SendEmailAutomacaoPredialCommand = new DelegateCommand(ExecuteSendEmailAutomacaoPredialCommand);
            SendEmailSintoniaCommand = new DelegateCommand(ExecuteSendEmailSintoniaCommand);
        }

        private void ExecuteSendEmailSintoniaCommand()
        {
            var emaillMesseger = CrossMessaging.Current.EmailMessenger;
            if (emaillMesseger.CanSendEmail)
            {   
                var tipoServico = AvaliacaoMalha ? "Avaliação de malhas de controle" : SintoniaMalha ? "Sintonia de malhas de controle" : "Avaliação de sintonia de malhas de controle";

                var message = $"Nome da empresa {NomeEmpresa} \n" +
                    $"Nome do responsável {NomeResponsavel} \n" +
                    $"Endereço: {EnderecoSintonia} \n" +
                    $"{EmailSintonia} - {TelefoneSintonia} \n" +
                    $"Tipo do Serviço: {tipoServico} \n" +
                    $"{Descricao} \n" +
                    $"Quantidade total de malhas de temperatura {MalhaTemperatura} \n" +
                    $"Quantidade total de malhas de nível {MalhaNivel}\n " +
                    $"Quantidade total de malhas de pressão {MalhaPressao} \n" +
                    $"Quantidade total de malhas de vazão {MalhaVazao} \n" +
                    $"Quantidade total de outras malhas {OutraMalha}\n";

                var email = new EmailMessageBuilder()
                    .To("jonathanb2br@gmail.com")
                    .Subject("[Formulário] Avaliação e sintonia de malhas de controle")
                    .Body(message)
                    .Build();

                emaillMesseger.SendEmail(email);
            }
        }

        private void ExecuteSendEmailAutomacaoPredialCommand()
        {
            var emaillMesseger = CrossMessaging.Current.EmailMessenger;
            if(emaillMesseger.CanSendEmail)
            {
                var pessoa = PessoaJuridica ? "Pessoa Jurídica" : "Pessoa Física";
                var tipoImovel = Residencial ? "Residencial" : Comercial ? "Comercial" : Condominio ? "Condomínio" : Industria ? "Industria" : "Pedraria";
                var tipoServico = SegurancaEletronica ? "Segurança eletrônica" : CircuitoFechado ? "Circuito fechado de TV" : ReusoAgua ? "Reuso de águas cinzaz para descargas" : "Geração de energia fotovoltaica";
                var tipoTelhado = Inclinado ? "Inclinado" : "Platibanda";
                var message = $"Nome do responsável {Responsavel} - {pessoa} \n" +
                    $"{Endereco} - {CEP} \n" +
                    $"{Email} - {Telefone} \n" +
                    $"Tipo do imóvel: {tipoImovel} \n" +
                    $"Tipo do serviço: {tipoServico} \n " +
                    $"Valor mensal da conta é de {ValorCota} \n" +
                    $"Consumo mensal de {Consumo} KWh \n" +
                    $"Tipo do telhado: {tipoTelhado} \n" +
                    $"Possui uma área de {Area} m²";
                var email = new EmailMessageBuilder()
                    .To("jonathanb2br@gmail.com")
                    .Subject("[Formulário] Automação predial e residencial")
                    .Body(message)
                    .Build();

                emaillMesseger.SendEmail(email);
            }
        }
    }
}
