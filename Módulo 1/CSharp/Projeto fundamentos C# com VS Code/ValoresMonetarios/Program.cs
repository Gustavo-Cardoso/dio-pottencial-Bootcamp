using System.Globalization;

// Alterando a localização do sistema para uma localização específica
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-Us"); // Formatando para dólar

// Formatando valores monetários
// decimal valorMonetario = 1582.40M;

//Console.WriteLine($"{valorMonetario:C}");
/* Quando uso interpolação e uso "dois pontos", isso signica que eu quero 
formatar ele. Nesse caso o "C" ele formata em valor monetário de acordo com a configuração
do sistema */

// Definindo uma cultura mesmo com a localização travada
//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formatando para real mesmo com a cultura travada em "en-Us"

// Criando uma formatação personalizada
// Console.WriteLine(valorMonetario.ToString("C1")); // 1 representa a quantidade de casas decimais
// Console.WriteLine(valorMonetario.ToString("C2")); // 2 representa a quantidade de casas decimais
// Console.WriteLine(valorMonetario.ToString("C8")); // 8 representa a quantidade de casas decimais

// Representado porcentagem
// double CEP = 17350000;
// Console.WriteLine(CEP.ToString("#####-###"));

// Criando uma formatação personalizada
// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// Formatando o tipo DateTime
//DateTime data = DateTime.Parse("10/09/1999 14:00"); // Convertendo string para data e hora

// DateTime data = DateTime.Now;

// Apresentando somente dia/mês/ano hora:minuto:segundo
// Console.WriteLine(data);

// Apresentando somente dia/mês/ano hora:minuto
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

//Formatando data e hora
// Console.WriteLine(data.ToShortDateString()); // Apresenta somente a data

// Console.WriteLine(data.ToShortTimeString()); // Apresenta somente a hora

//dateTime com TryParse
// string dataString = "2022-10-18 18:00";

// DateTime.TryParseExact(dataString, // Variável
//                         "yyyy-MM-dd HH:mm", // Padrão da variável 
//                         CultureInfo.InvariantCulture, // Para qual cultura eu quero converter
//                         DateTimeStyles.None, // Estilo do DateTime
//                         out DateTime data);// Para qual variável vai a saída da conversão

// Console.WriteLine(data);
