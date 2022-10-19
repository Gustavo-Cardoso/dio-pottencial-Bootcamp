using System.Globalization;

// Alterando a localização do sistema para uma localização específica
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-Us"); // Formatando para dólar

// Formatando valores monetários
decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}");
/* Quando uso interpolação e uso "dois pontos", isso signica que eu quero 
formatar ele. Nesse caso o "C" ele formata em valor monetário de acordo com a configuração
do sistema */
