# avaliador de crédito (arquitetura/design, hipóteses assumidas, frameworks utilizados e por quê.)

Para o desenvolvimento da API Avaliador de Crédito usei a linguagem C# e .NET6 e para a utilização da API no Frontend utilizei o Swagger. Com o .NET6 obtive a possibilidade de criar uma MIINIMAL API e também entender um pouco mais sobre ela (optei pela MINMAL API por se tratar de uma api simples e assim obtendo um código mais limpo e legível para o entendimento). Para o banco de dados, SQL Server. IDE utilizada foi o Visual Studio 2022 com o gerenciador de banco Microsoft SQL Server Management Studio 19.

# execução da api

A execução da API é de simples funcionamento. Em Program.cs expecificamente na linha 13 ("Data Source=LAPTOP-TATUSV7C;Initial Catalog=AVALIADOR_CREDITO;Integrated Security=True"), altere o nome para a sua Server name (Source="..."). Quando a api for iniciada no swagger entrará em ação um método que verificará se existe uma estrura de banco já criada ou não. Se caso não existir a mesma será criada automaticamente. 

# funcionamento da api

O funcionamento da api se dá pela seguinte forma: na classe ClienteEndPoints temos as requisições https AdicionarCliente, ListarCliente, ProcurarCliente(por cpf), ExcluirCliente(por cpf) e AvaliarCredito(por cpf). Para adicionar um cliente devemos definir um nome, cpf, data de nascimento, cidade, estado e salário. Para listar todos os clientes cadastrados executamos a função ListarCliente. Para procurar cliente por cpf inserimos o cpf e a api retornará o cadastro do cliente com o mesmo cpf inserido. Para excluir um cadastro inserimos o cpf e o cadastro será excluído. Para avaliar o crédito do cliente inserimos o cpf e a api executará testes para ver se o cliente será aprovado ou não na avaliação. Primeiro verificará a idade do cliente se tem 18 anos ou mais, segundo se a cidade onde mora for diferente de "Santo Cristo". Assim retornando no campo situacao "Cliente Aprovado" ou "Cliente Reprovado". Se o campo situacao retornar "Cliente Aprovado" passará ao próximo passo para verificar o total de limite que será liberado para o cliente, pegando o valor total do salário, vezes(*) a porcentagem(ex: 40/100 = 0,4) estabelicida na tabela.

# considerações finais

Como havia comentado na minha primeira entrevista com a Tech Recruiter Mayara e também na segunda entrevista com o Gestor e membros da equipe, atualmente trabalho mais com Angular e um pouco de Spring Boot e Vraptor, o qual acabei adquirindo mais experiência, pois trabalho no meu dia a dia e com isso acabei aprendendo com as dificuldades que vão surgindo e assim me aperfeiçoando. 
Gostaria de manifestar o meu sentimento de agradecimento pela oportunidade de ter chegado até essa etapa e pelo desafio que me foi lançado com esse teste, não havia trabalhado ainda com a linguagem de C# e .NET6, tinha só as noções básicas da parte teórica que vi durante o curso superior. Aproveitei o prazo que foi dado para estudar e pesquisar bastante sobre o mesmo, e dei o meu melhor pra tentar atender o que foi solicitado. Tive dificuldade para fazer o último item do teste e por isso não consegui concluir a api como o desejado. Foi muito boa essa experiência de trabalhar com esse tipo de linguagem, e sei que tenho muito a estudar e aprender ainda, mas é na prática e nas dificuldades do dia a dia que irei adquirir experiência.
