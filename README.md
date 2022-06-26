# avaliador de credito (arquitetura/design, hipóteses assumidas, frameworks utilizados e por quê.)

Para o desenvolvimento da API Avaliador de Crédito usei a linguagem C# e .NET6 e para a utilização da API no Frontend usei o Swagger. Com o .NET6 obtive a possibilidade de criar uma MIINIMAL API e também entender um pouco mais sobre ela (optei pela MINMAL API por se tratar de uma api simples e assim o código ficando mais limpo e legível). Para o banco de dados, SQL Server. IDE utilizada foi o Visual Studio 2022 com o gerenciador de banco Microsoft SQL Server Management Studio 19.

# execução da api

A execução da API é de simples funcionamento. Em Program.cs expecificamente na linha 13 ("Data Source=LAPTOP-TATUSV7C;Initial Catalog=AVALIADOR_CREDITO;Integrated Security=True"), altere o nome da sua base de dados (Source="..."). Quando a api for iniciada no swagger entrará em ação um método que verificará se existe uma estrura de banco já criada ou não. Se caso não existir a mesma será criada automaticamente. 

# considerações finais

