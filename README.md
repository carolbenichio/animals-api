## Animals API

Nesse projeto, trabalhamos os conceitos de orientação a objetos, reutilização de código, clean code e o entendimento sobre a arquitetura de um projeto .net. 

Essa solução contém dois projetos:

-> Api -> Carol.Api

-> Commons -> Carol.Commons

Para esse desafio vamos criar um controller que tem a finalidade de retornar uma lista de 20 animais diferentes, cada uma com suas características.
Vamos retornar os seguintes animais e suas particularidades:

--------------------------------
Animal *Dog*

Propriedades:
- Name
- Color
- Age
- Size (small, medium, big)
- Breed

--------------------------------
Animal *Cat*

Propriedades
- Name
- Color
- Age
- Size (small, medium, big)
- HairType

--------------------------------
Animal *Horse*

Propriedades:
- Name
- Color
- Age
- Size (small, medium, big)

--------------------------------
Animal *Bird*

Propriedades:
- Color
- Size (small, medium, big)
- WingSize (small, medium, big)
- FlightSpeed
--------------------------------

1. Como o projeto é feito em net6, fez sentindo enteder as nuanças do mesmo e adequar o projeto para esses padrões adotados nessa versão. Um exemplo seria o encapsulamento do namespace que não é mais obrigatorio. 

2. O primeiro desafio solicitava a criação de animais de forma randomica, na sua solução vc utilizou o construtor da classe para essa construção. Como ponto de refatoração acredito que implementar um padrão de projeto do tipo criacional seria o ideal para criar as instancias desses animais.

3. Hoje a solução contem apenas um método GET que é responsavel por criar e retornar os animais, acredito que possamos melhorar essa dinamica, para isso proponho a criação de um POST com as seguintes caracteristicas:

- O endpoint recebe como entrada 1 ou N tipos de animais e a quantidade que deverá ser gerada.
- Ele deve gerar a quantidade de animais solicitados e armazenar na memória em um mapa utilizando como chave um UUID.
- A cada nova solicitação no endpoint para geração da lista de animais ele incrementa o mapa, incluindo uma nova lista de animal.

Exemplo:

```
{

   "ID1": [animal1, animal2],
   "ID2": [animal1, animal2, animal3]
   ...
}
```

- "Get all" retorna uma lista contendo cada lista de animal armazenado anteriomente:

```
{
 [
   {
      id: "abc",
      animals: [animal1, animal2],
   },
   {
      id: "xyz",
      animals: [animal1, animal2, animal3],
   }
   {...}
 ]
}
```

- "Get by Id" retorna uma lista de animais filtrada pelo ID gerado no POST.
