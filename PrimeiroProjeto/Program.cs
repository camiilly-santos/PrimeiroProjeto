namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            string cidade;


            Console.WriteLine("Digite seu nome:");
            nome =  Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da sua cidade: ");
            cidade = Console.ReadLine();
         


            
            Console.WriteLine("Nome:{0} ", nome);
            Console.WriteLine("Idade:{0} ", idade);
            Console.WriteLine("Cidade: {0}",cidade);
            Console.WriteLine("Nome: {0} \n Idade: {1}\n Cidade: {2}", nome, idade, cidade);
            
           
       
        }
    }
}
