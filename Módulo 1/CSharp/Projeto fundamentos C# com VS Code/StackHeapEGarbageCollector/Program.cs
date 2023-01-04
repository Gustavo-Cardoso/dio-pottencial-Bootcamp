/*-------------------------------------------------------------------*/
/*---------------------Alocação de memória---------------------------*/
/*-------------------------------------------------------------------*/

/*---------------------Stack e Heap---------------------------*/
// Exemplo - Stack

// int a = 5;

// int b = 10;

/*------------------------------------------------*/

// Exemplo - Stack e Heap

// Quando for objeto o valor vai ser criado e armazenado  no stack e uma referência (link) com a memória Heap

// Pessoa p1 = new Pessoa();

/*------------------Garbage Collector (GC)------------------------------*/

// Todo objeto que está na heap e perdeu a referência com a stack (por que o método foi finalizado a excução) o GC mata o objeto, para limpar a memória

/*---------------------------------------------------------------------------*/
/*------------------Tipos de Valor e referência------------------------------*/
/*---------------------------------------------------------------------------*/

/*------------------Tipos de Valor------------------------------*/

// É uma variável que contém uma instância do tipo, ou seja ela armazena na memória stack e dentro dela ela contém o próprio valor também.

/*------------------Tipos de referência------------------------------*/

// É uma variável que contém referênci a uma instância do tipo, ou seja ele vai apontar um determinado endereço da memória heap.