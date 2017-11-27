using Laut.Services.Interfaces;
using Laut.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

[assembly: Dependency(typeof(Laut.Services.Implementations.LautData))]
namespace Laut.Services.Implementations
{
    public class LautData : ILautData
    {
        public ObservableCollection<Menu> GetMenuItens()
        {
            var result = new ObservableCollection<Menu>
            {
                new Menu
                {
                    ID = 1,
                    Name = "Serviços",
                    ImageURL = "service.png"
                },
                new Menu
                {
                    ID = 2,
                    Name = "Projetos",
                    ImageURL = "project.png"
                },
                new Menu
                {
                    ID = 3,
                    Name = "Produtos",
                    ImageURL = "product.png"
                },
            };
            return result;
        }

        public ObservableCollection<Product> GetProducts()
        {
            var result = new ObservableCollection<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "SISAL - SISTEMA DE SUPERVISÃO PARA ELEVAÇÃO ARTIFICIAL",
                    FullDescription = "Software supervisório desenvolvido no projeto 'Automação de Poços' em execução desde 2001. Atualmente supervisiona mais de 7.000 poços produtores de petróleo da Petrobras em terra no Rio Grande do Norte, Ceará, Alagoas, Sergipe e Espírito Santo. Substitui com vantagens um software americano anteriormente utilizado pela Petrobras. Trata-se de um sistema concebido para ser multi-métodos e multi-controladores. Em decorrência deste software foi incubada e criada uma empresa, a RN Tecnologia, www.rntecnologia.com.br , que dá suporte ao sistema supervisório em campo. É reconhecidamente um dos produtos de maior impacto de mercado dentre os desenvolvidos pela UFRN e em 2011 ganhou o prêmio do Santander 'Destaques do Ano / Guia do Estudante', na categoria 'Parceria com o Setor Privado'",
                    Description = "Software supervisório desenvolvido no projeto 'Automação de Poços' em execução desde 2001. Atualmente supervisiona mais de 7.000 poços ..."
                },

                new Product
                {
                    Id = 2,
                    Name = "PERSA",
                    FullDescription = "O bom desempenho de malhas de controle é funcamentalmente para a qualidade dos produtos de um determinado processo. Porém grande parte das malhas de controle presentes em uma indústria estão mal sintonizadas e/ou operam em malha aberta devido às dificuldades encontradas na sintonia manual dessas malhas. O Persa é uma ferramenta para monitoramento, avaliação e sintonia de malhas de controle de processos instustriais que permite a avaliação do desempenho das malhas de controle utilizando índices de desempenho previamente definidos e, em caso de necessidade, a realização de froma automática da sintonia das malhas.",
                    Description = "O bom desempenho de malhas de controle é funcamentalmente para a qualidade dos produtos de um determinado processo. Porém grande parte ..."
                },

                new Product
                {
                    Id = 3,
                    Name = "ASTECA",
                    FullDescription = "O Asteca é um pacote de aplicativos, cujo objetvo é a aplicação de controle preditivo multivariável com restrições(controle avançado) em plantas industriais. A implantação de um sistema de controle avançado, adequada em plantas com elevado número de malhas de controle com forte acoplamento, aumento a estabilidade das variáveis de processos, permitindo operar a planta em pontos de operção mais próximos das restrições, o que pode resultar em significativos ganhos econômicos.",
                    Description = "O Asteca é um pacote de aplicativos, cujo objetvo é a aplicação de controle preditivo multivariável com restrições(controle avançado) em ..."
                },

                new Product
                {
                    Id = 4,
                    Name = "SIMULA_BCP",
                    FullDescription = "Software desenvolvido no âmbito do projeto de pesquisa 'Automação de Poços' executado em parceria com a Petrobras desde 2001. É utilizado em treinamentos e pesquisas relacionadas à elevação de petróleo em poços equipados pelo método BCP (Bombeio por Cavidades Progressivas). O simulador possui uma interface com controladores industriais, podendo assim operar como 'poço virtual' para a avaliação prévia de controladores.",
                    Description = "Software desenvolvido no âmbito do projeto de pesquisa 'Automação de Poços' executado em parceria com a Petrobras desde 2001. É utilizado ..."
                },

                new Product
                {
                    Id = 5,
                    Name = "SIGALI",
                    FullDescription = "Software também desenvolvido no âmbito do projeto de pesquisa 'Automação de Poços' executado em parceria com a Petrobras desde 2001. É utilizado em treinamentos e pesquisas relacionadas à elevação de petróleo em poços equipados pelo método Gas Lift Contínuo. O simulador possui uma interface com controladores industriais, podendo assim operar como 'poço virtual' para a avaliação prévia de controladores.",
                    Description = "Software também desenvolvido no âmbito do projeto de pesquisa 'Automação de Poços' executado em parceria com a Petrobras desde 2001 ..."
                },

                new Product
                {
                    Id = 6,
                    Name = "SISCONTAVAN",
                    FullDescription = "O Sistema de Controle Avançado (SISCONTAVAN) é um software desenvolvido na IDE (Integrated Development Environment) Borland C++ Builder®, sob o paradigma de orientação a objetos. O sistema incorpora dois controladores: o Controlador Preditivo Generalizado Linear (GPC Linear) e o Controlador Preditivo Generalizado Bilinear (GPC Bilinear). Escolheram-se como modelos não-lineares os modelos bilineares porque estes representam de forma adequada a dinâmica do processo em questão e por ser a bilinearidade uma não linearidade mais fácil de tratar. Ambos controladores estão programados para atuar em plantas reais por meio do protocolo OPC (OLE for Process Control).",
                    Description = "O Sistema de Controle Avançado (SISCONTAVAN) é um software desenvolvido na IDE (Integrated Development Environment) Borland C++ Builder® ..."
                },

                new Product
                {
                    Id = 7,
                    Name = "SIMULA_BM",
                    FullDescription = "Software desenvolvido no âmbito do projeto de pesquisa 'Automação de Poços' executado em parceria com a Petrobras desde 2001. É utilizado em treinamentos e pesquisas relacionadas à elevação de petróleo em poços equipados com o método Bombeio Mecânico. O simulador possui uma interface com controladores industriais, podendo assim operar como 'poço virtual' para a avaliação prévia de controladores.",
                    Description = "Software desenvolvido no âmbito do projeto de pesquisa 'Automação de Poços' executado em parceria com a Petrobras desde 2001. É utilizado ..."
                },

                new Product
                {
                    Id = 8,
                    Name = "SIMULA_BCS",
                    FullDescription = "Software desenvolvido no âmbito do projeto de pesquisa 'Automação de Poços' executado em parceria com a Petrobras desde 2001. É utilizado em treinamentos e pesquisas relacionadas à elevação de petróleo em poços equipados com o método BCS (Bombeio Centrífugo Submerso). O simulador possui uma interface com controladores industriais, podendo assim operar como 'poço virtual' para a avaliação prévia de controladores.",
                    Description = "Software desenvolvido no âmbito do projeto de pesquisa 'Automação de Poços' executado em parceria com a Petrobras desde 2001. É utilizado ..."
                },

                new Product
                {
                    Id = 9,
                    Name = "DTVZ",
                    FullDescription = "Sistema desenvolvido no projeto 'Detecção de Vazamentos' executado desde 2003, com o propósito de detectar vazamentos em dutos com escoamento multifásico. Composto de sensores de pressão, controlador lógico programável e programa desenvolvido em Labview. Foi testado e aprovado em um duto real da Petrobras em 2006.",
                    Description = "Sistema desenvolvido no projeto 'Detecção de Vazamentos' executado desde 2003, com o propósito de detectar vazamentos em dutos com ..."
                },

                new Product
                {
                    Id = 10,
                    Name = "BR-CONTROLE",
                    FullDescription = "O objetivo principal deste programa é criar uma biblioteca de controladores avançados de forma que seja possível sintonizá-los e utilizá-los em uma determinada malha de controle industrial. Para isso o software utiliza o protocolo OPC para se comunicar com os equipamentos que possuem informações a respeito da malha. O BR-Controle foi desenvolvido no sistema operacional Microsoft Windows®, a partir da linguagem de programação C++, sendo sua interface gráfica construída através da IDE CODEGEAR® 2009. Uma planta didática de nível em conjunto com um Controlador Lógico Programável (CLP) permitiram os testes dos controladores implementados no BR-CONTROLE. A utilização do BR-CONTROLE é feita sempre em conjunto com um CLP, o qual deve ser programado para receber e enviar os dados para o processo, bem como operar em um modo de segurança e caso de falha de comunicação entre o software e o equipamento, tendo para isso programado um modo de segurança (PI) no próprio CLP.",
                    Description = "O objetivo principal deste programa é criar uma biblioteca de controladores avançados de forma que seja possível sintonizá-los e ..."
                },

                new Product
                {
                    Id = 11,
                    Name = "EXPERTUNING",
                    FullDescription = "O Expertuning é um software para a avaliação e sintonia de malhas de controle de processos industriais e apresenta vantagens técnicas e econômicas em comparação com outras ferramentas de mercado, pelo fato de ser customizável de acordo com as necessidades do cliente e apresentar menor custo de instalação e manutenção, pois agrega em um só produto funcionalidades que são oferecidas ao mercado em produtos separados. Além disso, o ExperTuning possibilita um apoio à operação das plantas, por oferecer regras de operação editáveis que podem ser definidas pelo usuário. Os métodos de sintonia implementados são o método de curso de reação e o método do relé. O software já está sendo utilizado em plantas da Petrobras.",
                    Description = "O Expertuning é um software para a avaliação e sintonia de malhas de controle de processos industriais e apresenta vantagens técnicas e ..."
                },

                new Product
                {
                    Id = 12,
                    Name = "DISPOSITIVO DE AJUSTE",
                    FullDescription = "O dispositivo, desenvolvido no projeto 'Balanceamento & Curso Contínuo Inteligente de Unidades de Bombeio' permite o ajuste contínuo do curso das hastes de unidades de bombeio, com a qual a amplitude de acionamento das hastes das bombas de poço de uma unidade pode ser ajustada sem a necessidade de parada de produção ou da desmontagem de qualquer elemento da unidade. O ajuste pode ser realizado a qualquer momento, reduzindo assim os custos e alcançando um aumento acentuado da segurança operacional de da qualidade desta regulagem. (* Foi feito o pedido de depósito da patente deste produto no INPI apenas com o nome de inventores da Petrobras, conforme cláusula contratual do Contrato do projeto de pesquisa e desenvolvimento ao qual o mesmo foi vinculado).",
                    Description = "O dispositivo, desenvolvido no projeto 'Balanceamento & Curso Contínuo Inteligente de Unidades de Bombeio' permite o ajuste contínuo do ..."
                },

                new Product
                {
                    Id = 13,
                    Name = "DISPOSITIVO REGULADOR",
                    FullDescription = "Dispositivo desenvolvido no âmbito do projeto de P&D 'Balanceamento & Curso Contínuo Inteligente de Unidades de Bombeio', que permite regular remotamente o balanceamento das manivelas de unidades de bombeio mecânico, sem a necessidade de uma parada da produção ou da desmontagem de qualquer elemento da unidade. A regulagem pode ser feita a qualquer momento, reduzindo assim os custos e alcançando um aumento acentuado da segurança operacional e da qualidade. (* Foi feito o pedido de depósito da patente deste produto no INPI apenas com o nome de inventores da Petrobras, conforme cláusula contratual do Contrato do projeto de pesquisa e desenvolvimento ao qual o mesmo foi vinculado).",
                    Description = "Dispositivo desenvolvido no âmbito do projeto de P&D 'Balanceamento & Curso Contínuo Inteligente de Unidades de Bombeio', que permite ..."
                },

                new Product
                {
                    Id = 14,
                    Name = "SISTEMA DE SENSORIAMENTO",
                    FullDescription = "Dispositivo desenvolvido no âmbito do projeto 'Conjunto de Sensoriamento para Detecção da Contaminação do Óleo Isolador do Motor do Método BCS -BCSENSOR' e que refere-se à elaboração do projeto de um sistema de sensoriamento eletromagnético composto por dois módulos: o “módulo detector” e o “módulo transmissor”. O sistema é responsável pela detecção da contaminação do óleo isolante pelo fluido de produção, com objetivo de evitar a queima do motor de indução trifásico utilizado no método de elevação artificial do tipo Bombeio Centrífugo Submerso.(*Foi feito o pedido de depósito da patente deste produto no INPI apenas com o nome de inventores da Petrobras, conforme cláusula contratual do Contrato do projeto de pesquisa e desenvolvimento ao qual o mesmo foi vinculado).",
                    Description = "Dispositivo desenvolvido no âmbito do projeto 'Conjunto de Sensoriamento para Detecção da Contaminação do Óleo Isolador do Motor do ..."
                },

                new Product
                {
                    Id = 15,
                    Name = "MÉTODO E SISTEMA DE CONTROLE",
                    FullDescription = "O Método e sistema de controle automático do bombeio centrífugo submerso de petróleo, via ajuste de freqüência de alimentação do motor elétrico, de modo a otimizar a vazão produzida e proteger o sistema quanto a condições operacionais que venham a comprometer a sua vida útil. Estas condições operacionais são vazão dentro da faixa recomendável, a temperatura do motor elétrico abaixo do limite, evitando-se a interferência de gás no bombeamento que causa oscilações na corrente de alimentação do motor. (* Foi feito o pedido de depósito da patente deste produto no INPI no BR 10 2012 006900 8 A8. Inventores: André Laurindo Maitelli e Rutácio de Oliveira Costa).",
                    Description = "O Método e sistema de controle automático do bombeio centrífugo submerso de petróleo, via ajuste de freqüência de alimentação do motor ..."
                },

                new Product
                {
                    Id = 16,
                    Name = "SISTEMA DE COMUNICAÇÃO DE DADOS",
                    FullDescription = "A presente invenção refere-se à elaboração do projeto de um sistema de comunicação de dados via rede elétrica para um motor de indução trifásico utilizado no método de elevação artificial do tipo bombeio centrífugo submerso composto por dois módulos: o módulo de subsuperfície – transmissor do sinal – e o módulo de superfície – aquisição de sinal. O sistema será responsável pela aquisição dos dados de: pressão de entrada, temperatura do motor, temperatura do fundo do poço, corrente de fuga, pressão de descarga, sinais de vibração e sinal de contaminação do óleo isolante, com objetivo de evitar a queima do motor de indução trifásico, utilizado no método de elevação artificial do tipo Bombeio Centrífugo Submerso.",
                    Description = "A presente invenção refere-se à elaboração do projeto de um sistema de comunicação de dados via rede elétrica para um motor de indução ..."
                },

                new Product
                {
                    Id = 17,
                    Name = "VÁLVULA DE ESCAPE RÁPIDO",
                    FullDescription = "A presente invenção refere-se à proposta de um Módulo de uma Válvula de Escape Rápido de Fluxo limitadora da velocidade máxima do PIG instrumentado para realizar a medição de parâmetros e detecção de não conformidades ou predição de falhas. Esta invenção compreende a Válvula de Escape Rápido e demais componentes instalados em um módulo independente, localizado na frente do PIG, tem como finalidade principal evitar o disparo do PIG dentro do gasoduto em operação, controlando a velocidade instantânea do mesmo durante a operação, garantindo a medição correta dos sensores e a integridade da instrumentação a bordo do mesmo. Desta forma, evita danos, desperdício de tempo e grandes prejuízos econômicos. A Válvula de Escape Rápido acionada por atuador pneumático é controlada através de uma eletroválvula de comando direcional de 3 vias e 2 posições e acionamento por simples solenoide. A energia pneumática para acionar o atuador da Válvula de Escape Rápido é oriunda da energia de pressão propulsora do PIG, alimentada à montante do mesmo. A energia elétrica para alimentar a eletroválvula é suprida por baterias alojadas no compartimento do módulo limitador de velocidade, localizado na parte dianteira do PIG. O gerenciamento eletrônico de controle com microprocessador recebe a informação do transdutor de velocidade do PIG e a partir da estratégia adequada envia sinal modulador para a eletroválvula de comando atuar a Válvula de Escape Rápido, limitando e controlando a velocidade instantânea do PIG. (* Foi feito o pedido de depósito da patente deste produto no INPI no BR 10 2014 013623 1 B1. Inventores: Francisco Assis de Oliveira Fontes, Andrés Ortiz Salazar, André Laurindo Maitelli e Ralyson Rayala Gonçalves de Oliveira).",
                    Description = "A presente invenção refere-se à proposta de um Módulo de uma Válvula de Escape Rápido de Fluxo limitadora da velocidade máxima do PIG ..."
                }
            };



            return result;

        }

        public ObservableCollection<Project> GetProjects()
        {
            var result = new ObservableCollection<Project>
            {
                new Project
                {
                    Id = 1,
                    Name = "AUTOPOC",
                    FullDescription = "Projeto relacionado à automação da elevação artificial, executado desde 2001 e que trata da pesquisa e do desenvolvimento de equipamentos e sistemas computacionais para supervisão, simulação, otimização e controle dos métodos de elevação artificial de petróleo. Já foram desenvolvidos vários produtos no âmbito deste projeto, sendo o sistema supervisório SISAL o de maior aplicação.",
                    Description = "Projeto relacionado à automação da elevação artificial, executado desde 2001 e que trata da pesquisa e do desenvolvimento de equipamentos ..."
                },
                new Project
                {
                    Id = 2,
                    Name = "DTVZ/SONIC",
                    FullDescription = "Este projeto está sendo desenvolvido pela mesma equipe desde fevereiro de 2003. Em uma primeira fase foram instalados no duto entre ETB e Upanema, da UN-RNCE da Petrobras, três pontos de coleta de dados de pressão. Cada ponto é constituído basicamente de um transmissor de pressão, um PLC e um rádio modem, instalados em painéis apropriados. Os pontos de coleta transmitem os seus dados, via rádio, para as estações mais próximas, nas quais os softwares de processamento de sinais e de supervisão estão rodando e sinalizarão os possíveis vazamentos no duto em questão. Neste primeiro projeto, os métodos implementados são baseados no ruído de pressão e no uso de redes neurais e Wavelets. Atualmente, estamos estudando e implementando métodos de detecção de vazamentos baseados em dispositivos acústicos em um outro duto da Petrobras. O sistema tem pontos de coleta de dados de pressão nas duas extremidades do duto e um sistema de processamento de sinais, com o uso de DSPs e sistemas supervisórios.",
                    Description = "Este projeto está sendo desenvolvido pela mesma equipe desde fevereiro de 2003. Em uma primeira fase foram instalados no duto entre ETB ..."
                },
                new Project
                {
                    Id = 3,
                    Name = "CONPETRO",
                    FullDescription = "O objetivo do projeto foi desenvolver e aplicar técnicas de controle avançado, em particular Controle Preditivo, na Torre Desbutanizadora da UPGN-II do Pólo de Guamaré para otimizar a produção de GLP. Quatro principais atividades foram desenvolvidas em paralelo para obterem-se os seguintes produtos: Programa de controle avançado em linguagem C++; Simulação das Torres; Preditor Neural e Proposta de uma Nova Malha de Controle.",
                    Description = "O objetivo do projeto foi desenvolver e aplicar técnicas de controle avançado, em particular Controle Preditivo, na Torre Desbutanizadora ..."
                },
                new Project
                {
                    Id = 4,
                    Name = "REDICONT",
                    FullDescription = "Objetiva a aplicação de técnicas de controle ditas não convencionais, como as preditivas (incluindo o PID preditivo), adaptativas (incluindo o PID adaptativo) e inteligentes, que são reconhecidamente eficientes no controle de plantas não-lineares. Porém, apesar deste fato, a implementação das mesmas em processos reais ainda é bastante restrita, principalmente devido à dificuldades de programação destas técnicas na instrumentação industrial atual (controladores multi e single-loop e CLPs). A idéia deste projeto é estudar e implementar estas técnicas em processos utilizados na indústria do petróleo. As técnicas de controle serão implementadas em software comunicando-se com CLPs.",
                    Description = "Objetiva a aplicação de técnicas de controle ditas não convencionais, como as preditivas (incluindo o PID preditivo), adaptativas ..."
                },
                new Project
                {
                    Id = 5,
                    Name = "REDIC-ADAP",
                    FullDescription = "A Rede Cooperativa de Pesquisa em Instrumentação e Controle (REDIC), aprovada pela FINEP em 2001, é formada por 12 instituições das regiões Norte-Nordeste, incluindo universidades, centros federais de educação tecnológica e institutos de pesquisa. São elas: UFPA, UFRN, UFBA, UFPE, UFCG, UFC, CEFET-RN, CEFET-SE, CEFET-BA, CEPED-BA, UNIFOR e ITEP-PE. A REDIC atualmente desenvolve pesquisas para o setor de petróleo e gás em 9 projetos, ligados aos temas medição de petróleo, controle de processos e automação da elevação artificial de petróleo. Os projetos desenvolvidos compartilham interesses mútuos, com auxílio recíproco, e visam atender as necessidades das indústrias. O trabalho em rede pretende somar esforços, agregando competências de várias instituições das regiões norte-nordeste, de modo a atender às necessidades do setor de petróleo e gás e de outros setores. Dentre estas competências podemos destacar: redes industriais, metrologia aplicada, controle avançado, inteligência artificial, microeletrônica/nanoeletrônica e instrumentação industrial.",
                    Description = "A Rede Cooperativa de Pesquisa em Instrumentação e Controle (REDIC), aprovada pela FINEP em 2001, é formada por 12 instituições das regiões ..."
                },
                new Project
                {
                    Id = 6,
                    Name = "AIPETRO",
                    FullDescription = "Neste projeto são desenvolvidos sistemas computacionais para o suporte à operação do processo, para o diagnóstico de falhas e para o controle avançado, os quais serão integrados à rede Petrobras e comunicar-se-ão com sistemas de automação e controle já utilizados pela Petrobras/CENPES, tais como BR-PerfeX, BR-Tuning e BR-AlarmExpert. Os sistemas serão implantados na Planta de Processamento Primário de Petróleo (5P) que está sendo construída no Núcleo Experimental Engenheiro Baruzzi (NuEx), localizado junto à Estação de Processamento de Atalaia, em Aracaju-SE, visando uma simulação prática, mas serão elaborados com o foco na aplicação à plataformas do Pré-Sal, permitindo a operação remota destas plataformas com inteligência e confiabilidade.",
                    Description = "Neste projeto são desenvolvidos sistemas computacionais para o suporte à operação do processo, para o diagnóstico de falhas ..."
                },
                new Project
                {
                    Id = 7,
                    Name = "AVANSAL",
                    FullDescription = "O objetivo principal deste projeto é a produção de um software para aplicação de controle avançado, implementando técnicas de controle preditivo multivariável, identificação/re-identificação de modelos e avaliação do desempenho de malhas de controle. Outro objetivo a ser atingido é a capacitação de uma equipe para dar suporte e manutenção ao sistema desenvolvido, visando a sua aplicação prática.",
                    Description = "O objetivo principal deste projeto é a produção de um software para aplicação de controle avançado, implementando técnicas de controle ..."
                },
                new Project
                {
                    Id = 8,
                    Name = "AUTODOC",
                    FullDescription = "O projeto tem como objetivo o desenvolvimento de um software que gere um documento de Projeto de Engenharia a partir de uma interface de entrada. A interface proposta é uma planilha eletrônica padrão para a entrada de dados. Este projeto será desenvolvido em parceria com a empresa Altus, sediada em São Leopoldo-RS e que desenvolve, fabrica e fornece equipamentos de automação industrial e serviços associados. Como se trata de um software de complexidade média pretende-se empregar uma metodologia ágil em seu desenvolvimento. Este tipo de metodologia baseia o foco do desenvolvimento nos requisitos levantados pelo cliente através da descrição de cenários. O cronograma de desenvolvimento irá prever a entrega de versões de teste ao cliente e, ao final, uma versão validada e testada.",
                    Description = "O projeto tem como objetivo o desenvolvimento de um software que gere um documento de Projeto de Engenharia a partir de uma interface de ..."
                },
                new Project
                {
                    Id = 9,
                    Name = "GERINE",
                    FullDescription = "Neste projeto pretende-se desenvolver metodologias e processos que permitam as seguintes funcionalidades no nível gerencial da automação industrial: Definição de dados relevantes para gerência de informação; Tratamento de dados em tempo real, com propriedades de compressão, bufferização e filtragem; Integração do sistema desenvolvido com o atual sistema de informações da produção da Petrobras (SIP); Geração de relatórios para análise gerencial estratégica, incluindo gráficos e informações sintetizadas.",
                    Description = "Neste projeto pretende-se desenvolver metodologias e processos que permitam as seguintes funcionalidades no nível gerencial da automação ..."
                }
            };

            return result;
        }

        public ObservableCollection<Service> GetServices()
        {
            var result = new ObservableCollection<Service>
            {
                new Service
                {
                    Id = 1,
                    Name = "Sintoniia e Avalização de malhas de controle insdustriais",
                    FullDescription = "Temos uma ferramenta para o monitoramento, avaliação e sintonia de malhas de controle de processos industriais, que permite a avaliação do desempenho de malhas de controle através de índices de desempenho previamente definidos e, em caso de necessidade, a realização de forma automática da sintonia das malhas. O uso dessa ferramenta implica em benefícios econômicos ao processo decorrente de menor desgaste dos atuadores e de uma maior estabilidade das variáveis do processo.",
                    Description = "Temos uma ferramenta para o monitoramento, avaliação e sintonia de malhas de controle de processos industriais, que permite a avaliação ..."
                },
                new Service
                {
                    Id = 2,
                    Name = "Programação de sistemas supervisionados",
                    FullDescription = "Desenvolvemos telas de sistemas supervisórios, incluindo o planejamento do sistema, a elaboração das telas e subtelas de supervisão e a comunicação com CLPs de diversos fabricantes.",
                    Description = "Desenvolvemos telas de sistemas supervisórios, incluindo o planejamento do sistema, a elaboração das telas e subtelas de supervisão ..."
                },
                new Service
                {
                    Id = 3,
                    Name = "Programação de controladores lógicos programáveis",
                    FullDescription = "Elaboramos programas de automação para CLPs em diversas linguagens, incluindo Ladder, Grafcet e Blocos de Função e para equipamentos de diversos fabricantes.",
                    Description = "Elaboramos programas de automação para CLPs em diversas linguagens, incluindo Ladder, Grafcet e Blocos de Função e para equipamentos ..."
                },
                new Service
                {
                    Id = 4,
                    Name = "Treinamento em controle de processos industriais",
                    FullDescription = "Realizamos treinamento em controle de processos industriais, usando plantas didáticas industriais disponíveis no laboratório. Esse treinamento permite a apresentação e demonstração de conceitos básicos de ações de controle, sintonia de malhas de controle, controle em cascata, entre outros, usando plantas equipadas com instrumentação industrial.",
                    Description = "Realizamos treinamento em controle de processos industriais, usando plantas didáticas industriais disponíveis no laboratório. Esse ..."
                },
                new Service
                {
                    Id = 5,
                    Name = "Projeto de sistemas de automação predial e residencial",
                    FullDescription = "Elaboramos projetos de automação predial, incluindo segurança eletrônica, reuso de água cinza, controle de temperatura e micro geração de energia elétrica usando painéis fotovoltaicos. Um projeto dessa natureza possibilita o uso racional da água e energia elétrica em uma edificação, resultado em economia e um retorno do investimento em curto prazo.",
                    Description = "Elaboramos projetos de automação predial, incluindo segurança eletrônica, reuso de água cinza, controle de temperatura e micro geração ..."
                },
                new Service
                {
                    Id = 6,
                    Name = "Manutenção em equipamentos eletrônicoos voltados para a automação insdustrial e predial",
                    FullDescription = "Realizamos manutenção em Controladores Lógicos Programáveis (CLPs), computadores e outros equipamentos eletrônicos utilizados em automação, com diagnóstico dos defeitos e a troca de componentes, em caso de necessidade.",
                    Description = "Realizamos manutenção em Controladores Lógicos Programáveis (CLPs), computadores e outros equipamentos eletrônicos utilizados em ..."
                },
                new Service
                {
                    Id = 7,
                    Name = "Treinamento em sotfwares voltados à elevação artificial de petróleo",
                    FullDescription = "Realizamos treinamentos em softwares voltados à automação de poços de petróleo, incluindo os métodos de elevação artificial por Bombeio Mecânico, Gás Lift, Bombeio Centrífugo Submerso (BCS) e Bombeio por Cavidades Progressivas (BCP).",
                    Description = "Realizamos treinamentos em softwares voltados à automação de poços de petróleo, incluindo os métodos de elevação artificial por Bombeio ..."
                }
            };

            return result;
        }
    }
}
